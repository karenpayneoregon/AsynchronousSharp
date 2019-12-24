using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenSqlServerExample.Classes;
using SqlServerDiagnosticsLibrary;

namespace OpenSqlServerExample
{
    public partial class Form1 : Form
    {
        private readonly SqlServerOperaions _serverOperaions = new SqlServerOperaions();
        public Form1()
        {
            InitializeComponent();
            ServerNameTextBox.TextChanged += ServerNameTextBox_TextChanged;
        }
        /// <summary>
        /// Validate there is a server name and the name is longer than four characters,
        /// the fours characters is assuming server names are longer than four characters.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ServerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            ServerAvailableButton.Enabled = !string.IsNullOrWhiteSpace(ServerNameTextBox.Text) && ServerNameTextBox.Text.Length > 4;
        }
        /// <summary>
        /// Conventional open, server does not exists, app will lock up until the
        /// attempt to open a connection with a non-existing server completes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SynchronousNoneExistingServerButton_Click(object sender, EventArgs e)
        {
            ButtonsSetup(false);

            _serverOperaions.TryConnectNoServerSync();
            if (_serverOperaions.HasException)
            {
                MessageBox.Show(_serverOperaions.LastExceptionMessage);
            }

            ButtonsSetup();
        }
        /// <summary>
        /// Improvement on the above, app is responsive
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void AsynchronousNoneExistingServerButton_Click(object sender, EventArgs e)
        {
            ButtonsSetup(false);

            await _serverOperaions.TryConnectNoServerAsync();
            if (_serverOperaions.HasException)
            {
                MessageBox.Show(_serverOperaions.LastExceptionMessage);
            }

            ButtonsSetup();

        }
        /// <summary>
        /// Intended to be used with or without an existing server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ServerAvailableButton_Click(object sender, EventArgs e)
        {
            ButtonsSetup(false);

            var operation = new Detectors();
            var results = await operation.SqlServerIsAvailable(ServerNameTextBox.Text);
            if (results)
            {
                MessageBox.Show($"Server {ServerNameTextBox.Text} found, press okay to connect");
                await _serverOperaions.ConnectServerAsync(ServerNameTextBox.Text);
                if (_serverOperaions.IsSuccessFul)
                {
                    MessageBox.Show("Connected successfully");
                }
                else
                {
                    MessageBox.Show($"Connection failed with\n{_serverOperaions.LastExceptionMessage}");
                }
            }
            else
            {
                MessageBox.Show($"Server {ServerNameTextBox.Text} not found");
            }

            ButtonsSetup();

        }
        /// <summary>
        /// Intended to be used with an existing server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ServerConnectionWithKnownServerButton_Click(object sender, EventArgs e)
        {

            await _serverOperaions.ConnectServerAsync(ServerNameTextBox.Text);

            if (_serverOperaions.IsSuccessFul)
            {
                MessageBox.Show("Connected successfully");
            }
            else
            {
                MessageBox.Show($"Connection failed with\n{_serverOperaions.LastExceptionMessage}");
            }
        }

        private void ButtonsSetup(bool enable = true)
        {
            foreach (var button in Controls.OfType<Button>())
            {
                button.Enabled = enable;
            }

            if (enable)
            {
                ServerNameTextBox.TextChanged += ServerNameTextBox_TextChanged;
            }
            else
            {
                ServerNameTextBox.TextChanged -= ServerNameTextBox_TextChanged;
            }
        }


    }
}
