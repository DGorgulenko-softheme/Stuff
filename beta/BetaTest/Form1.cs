using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Replay.Core.Contracts.Agents;
using Replay.Logging;
using Replay.ServiceHost.Contracts;
using System.Net;
using Replay.Core.Client;
using WCFClientBase;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Security.Permissions;
using System.IO;

namespace BetaTest
{
    public partial class Form1 : Form
    {
        private ICoreClient coreClient;

        public Form1()
        {
            InitializeComponent();
        }
        private void ConnectButton_Click(object sender, EventArgs e)
        {
            AgentList.Items.Clear();
            if (String.IsNullOrEmpty(UserNameBox.Text) || String.IsNullOrEmpty(PasswordBox.Text))
            {
            coreClient = GetDefaultCoreClient(ServerBox.Text, 8006);
            }
            else
            {
            coreClient = GetFullCoreClient(ServerBox.Text, 8006, UserNameBox.Text, PasswordBox.Text);
            }
           var protectedAgents = coreClient.AgentsManagement.GetProtectedAgents();

            foreach (var Agent in protectedAgents)
            {
                var agentDetails = coreClient.AgentsManagement.GetAgentDetails(Agent.Id.ToString());
                var HostName = agentDetails.Metadata.HostName;
                AgentList.Items.Add(HostName);
                
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

        private void UpdateButton_Click(object sender, EventArgs e)
        {
     
          
                string filePath = @"C:\Parameters.csv";  
	            string delimiter = ",";
                string[][] output = new string[][]{  
	                new string[]{"Size", "Compression", "Path", "Time"},  
	                new string[]{SizeBox.Text, Convert.ToString(CompressionNum.Value) , LocationBox.Text, Convert.ToString(IntervalNum.Value)}  
	            };  
	            int length = output.GetLength(0);  
	            StringBuilder sb = new StringBuilder();  
	            for (int index = 0; index < length; index++)  
	                sb.AppendLine(string.Join(delimiter, output[index]));  
	            File.WriteAllText(filePath, sb.ToString());


                for (int i = 0; i < AgentList.Items.Count; i++)
                {
                    if (AgentList.GetItemChecked(i))
                    {
                        string Dest = @"\\" + (string)AgentList.Items[i] + @"\\datagen\Parameters.csv";

                        File.Copy(filePath, Dest, true);
                    }
                }

            MessageBox.Show("Done");




        }
    }
}
