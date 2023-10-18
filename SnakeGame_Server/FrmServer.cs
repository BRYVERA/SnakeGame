using System;
using System.Windows.Forms;

namespace SnakeGame_Server
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {

        }

        #region Server
        private void BtnServerStart_Click(object sender, EventArgs e)
        {
            Server.SetupServer(this);

            tbServerInput.ReadOnly = false;
            btnServerStart.Enabled = false;
            btnStopServer.Enabled = true;
        }

        private void BtnStopServer_Click(object sender, EventArgs e)
        {
            if (Server._serverOnline)
            {
                Server.ShutdownServer();

                tbServerInput.ReadOnly = true;
                btnServerStart.Enabled = true;
                btnStopServer.Enabled = false;
            }
            else
            {
                tbServerOutput.Text += "Servidor apagado\r\n";
            }
        }

        private void BtnServerSend_Click(object sender, EventArgs e)
        {
            if (tbServerInput.Text.Trim() != "")
            {
                Server.SendMessage();

                tbServerInput.Text = "";
            }
        }
        #endregion

        private void tbServerOutput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
