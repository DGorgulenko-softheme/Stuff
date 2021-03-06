﻿using System;
using System.Text;
using System.Windows.Forms;
using Replay.ServiceHost.Contracts;
using System.Net;
using Replay.Core.Client;
using System.IO;
using System.Management;
using  System.Diagnostics;
using System.Security.Principal;
using Replay.Common.Contracts.Utilities.Impersonation;

namespace BetaTest
{
    public partial class Form1 : Form
    {
        private ICoreClient _coreClient;

        public Form1()
        {
            InitializeComponent();
        }
        public void SaveACopyfileToServer(string filePath, string savePath)
        {
            var directory = Path.GetDirectoryName(savePath).Trim();
            var username = UserNameBox.Text;
            var password = PasswordBox.Text;
            var filenameToSave = Path.GetFileName(savePath);

            if (!directory.EndsWith("\\"))
                filenameToSave = "\\" + filenameToSave;

            var command = "NET USE " + directory + " /delete";
            ExecuteCommand(command, 5000);

            command = "NET USE " + directory + " /user:" + username + " " + password;
            ExecuteCommand(command, 5000);

            command = " copy \"" + filePath + "\"  \"" + directory + filenameToSave + "\"";

            ExecuteCommand(command, 5000);


            command = "NET USE " + directory + " /delete";
            ExecuteCommand(command, 5000);
        }
        public static int ExecuteCommand(string command, int timeout)
        {
            var processInfo = new ProcessStartInfo("cmd.exe", "/C " + command)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = "C:\\",
            };

            var process = Process.Start(processInfo);
            process.WaitForExit(timeout);
            var exitCode = process.ExitCode;
            process.Close();
            return exitCode;
        } 
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                StatusBar.Text = "Trying to connect to the Core...";
                AgentList.Items.Clear();
                if (String.IsNullOrEmpty(UserNameBox.Text) || String.IsNullOrEmpty(PasswordBox.Text))
                {
                    _coreClient = GetDefaultCoreClient(ServerBox.Text, 8006);
                }
                else
                {
                    _coreClient = GetFullCoreClient(ServerBox.Text, 8006, UserNameBox.Text, PasswordBox.Text);
                }
                StatusBar.Text = "Getting protected agents";
                var protectedAgents = _coreClient.AgentsManagement.GetProtectedAgents();
                StatusBar.Text = "Updating agents list";
                foreach (var Agent in protectedAgents)
                {
                    var agentInfo = _coreClient.AgentsManagement.GetAgentInfo(Agent.Id.ToString());
                   //var agentDetails = _coreClient.AgentsManagement.GetAgentDetails(Agent.Id.ToString());
                   // var agentDetails = _coreClient.AgentsManagement.GetAgentDetails(Agent.Id.ToString());
                    var hostName = agentInfo.Descriptor.HostUri.Host;
                    AgentList.Items.Add(hostName);
                }
                StatusBar.Text = "Connected to " + ServerBox.Text;
                RestartButton.Enabled = Enabled;
                UpdateButton.Enabled = Enabled;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:\n\n"+ ex);
            }
        }
        private static ICoreClient GetDefaultCoreClient(string host, int port)
        {
            var coreClientFactory = new CoreClientFactory();

            var coreClient = coreClientFactory.Create(CreateApiUri(host, port));
            coreClient.UseDefaultCredentials();

            return coreClient;
        }
        private void AgentList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public static ICoreClient GetFullCoreClient(string host, int port, string username, string password)
        {
            var networdCredentials = new NetworkCredential(username, password);
            var factory = new CoreClientFactory();
            var coreClient = factory.Create(CreateApiUri(host, port));
            coreClient.UseSpecificCredentials(networdCredentials);

            return coreClient;
        }
        private static Uri CreateApiUri(string host, int port)
        {
            var apiUri = string.Format("https://{0}:{1}/{2}/api/core/", host, port,  ServiceHostConstants.RootOfServiceHostAddress);

            return new Uri(apiUri);
        }
        private void UserNameBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void CompressionNum_ValueChanged(object sender, EventArgs e)
        {

        }
        private void UpdateConfig()
        {
            try
            {
                StatusBar.Text = "Creating file with parameters...";
                string filePath = @"C:\Parameters.csv";
                string delimiter = ",";
                string[][] output = new string[][]
                {
                    new string[] {"Size", "Compression", "Path", "Time"},
                    new string[]
                    {
                        SizeBox.Text, Convert.ToString(CompressionNum.Value), LocationBox.Text,
                        Convert.ToString(IntervalNum.Value)
                    }
                };
                int length = output.GetLength(0);
                StringBuilder sb = new StringBuilder();
                for (int index = 0; index < length; index++)
                    sb.AppendLine(string.Join(delimiter, output[index]));
                StatusBar.Text = "Saving file to temp folder...";
                File.WriteAllText(filePath, sb.ToString());

                for (int i = 0; i < AgentList.Items.Count; i++)
                {
                    if (AgentList.GetItemChecked(i))
                    {
                        StatusBar.Text = "Updating configuration for " + (string)AgentList.Items[i];
                        string Dest = @"\\" + (string)AgentList.Items[i] + @"\changegen\Parameters.csv";
                        SaveACopyfileToServer(filePath, Dest);
                        // File.Copy(filePath, Dest, true);
                    }
                }
                StatusBar.Text = "Update complete";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:\n\n" + ex);
            }
        }
        private void RestartJob()
        {
            try
            {
                string IP;
                // next string is HardCoded so we need to fix this
                object[] theProcessToRun = { @"Powershell.exe -noExit -Command C:\ChangeGen\Start.ps1" };
                ConnectionOptions theConnection = new ConnectionOptions();

                if (useCoreCredentialsCheckbox.Checked)
                {
                    theConnection.Username = "\\";
                    theConnection.Password = "";
                }
                else if (String.IsNullOrEmpty(UserNameBox.Text) || String.IsNullOrEmpty(PasswordBox.Text))
                {
                    MessageBox.Show(
                        "Please enter Username or Password. Also you can try to use current user. To do that please set Use Core credentials checkbox.");
                }
                else
                {
                    theConnection.Username = UserNameBox.Text;
                    theConnection.Password = PasswordBox.Text;
                }

                for (int i = 0; i < AgentList.Items.Count; i++)
                {
                    if (AgentList.GetItemChecked(i))
                    {
                        IP = (string)AgentList.Items[i];
                        //Connect to remote WMI
                        StatusBar.Text = "Connecting to WMI on " + IP;
                        ManagementScope theScope = new ManagementScope("\\\\" + IP + "\\root\\cimv2", theConnection);
                       
                        // Find and remove all Powershell processes 
                        StatusBar.Text = "Find and remove all Powershell processes on " + IP;
                        SelectQuery query = new SelectQuery("select * from Win32_Process Where Name='Powershell.exe'");
                        using (ManagementObjectSearcher searcher = new ManagementObjectSearcher(theScope, query))
                        {
                            ManagementObjectCollection collection = searcher.Get();
                            foreach (ManagementObject process in collection)
                            {
                                object[] terminationObject = new object[2];
                                process.InvokeMethod("Terminate", terminationObject);
                            }
                        }
                        //Starting process
                        StatusBar.Text = "Starting process on " + IP;
                        ManagementClass theClass = new ManagementClass(theScope, new ManagementPath("Win32_Process"),
                            new ObjectGetOptions());
                        theClass.InvokeMethod("Create", theProcessToRun);
                        StatusBar.Text = "Done";
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong:\n\n" + ex);
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateConfig();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            UpdateConfig();
            RestartJob();
        }
    }
}
