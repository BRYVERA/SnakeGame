using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class FrmPlayers : Form
    {
        public int numberPlayers = 0;
        public string userName   = "";
        public string ipAddress  = "";

        public FrmPlayers()
        {
            InitializeComponent();

            cboPlayers.SelectedIndex = 0;
        }

        private void CboPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            LocationCtrl(false);

            if (cboPlayers.SelectedIndex == 1)
            {
                LocationCtrl(true);
            }
        }

        private void LocationCtrl(bool value)
        {
            lblUserName.Visible = value;
            lblIP.Visible       = value;
            txtUsername.Visible = value;
            txtIP.Visible       = value;

            if (value)
            {
                this.Size = new Size(320, 270);
                panel1.Size = new Size(296, 246);
                btnStart.Location = new Point(111, 180);
            }
            else
            {
                this.Size = new Size(320, 170);
                panel1.Size = new Size(296, 146);
                btnStart.Location = new Point(110, 88);
            }

            this.CenterToScreen();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            numberPlayers = int.Parse(cboPlayers.Text);

            if (numberPlayers == 2)
            {
                if (txtUsername.Text.Trim() != "" && txtIP.Text.Trim() != "")
                {
                    userName  = txtUsername.Text.Trim();
                    ipAddress = txtIP.Text.Trim();
                }
                else
                {
                    MessageBox.Show("Ingrese el Nickname y la IP", "Intente de nuevo",
                               MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1);

                    txtIP.Text = "";
                    txtUsername.Text = "";

                    return;
                }
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
