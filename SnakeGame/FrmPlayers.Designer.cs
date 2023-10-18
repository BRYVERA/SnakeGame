namespace SnakeGame
{
    partial class FrmPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.cboPlayers = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.lblPlayers);
            this.panel1.Controls.Add(this.txtIP);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.lblIP);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Controls.Add(this.cboPlayers);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 246);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Doppio One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(111, 180);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(176, 36);
            this.btnStart.TabIndex = 10;
            this.btnStart.Text = "Iniciar";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Font = new System.Drawing.Font("Doppio One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayers.Location = new System.Drawing.Point(11, 48);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(90, 19);
            this.lblPlayers.TabIndex = 15;
            this.lblPlayers.Text = "Jugadores :";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(110, 125);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(176, 23);
            this.txtIP.TabIndex = 14;
            this.txtIP.Visible = false;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(110, 88);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(176, 23);
            this.txtUsername.TabIndex = 13;
            this.txtUsername.Visible = false;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Font = new System.Drawing.Font("Doppio One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIP.Location = new System.Drawing.Point(11, 127);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(99, 19);
            this.lblIP.TabIndex = 12;
            this.lblIP.Text = "Direccion IP :";
            this.lblIP.Visible = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Doppio One", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(11, 91);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(62, 19);
            this.lblUserName.TabIndex = 11;
            this.lblUserName.Text = "Apodo :";
            this.lblUserName.Visible = false;
            // 
            // cboPlayers
            // 
            this.cboPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPlayers.FormattingEnabled = true;
            this.cboPlayers.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cboPlayers.Location = new System.Drawing.Point(110, 45);
            this.cboPlayers.Name = "cboPlayers";
            this.cboPlayers.Size = new System.Drawing.Size(176, 25);
            this.cboPlayers.TabIndex = 9;
            this.cboPlayers.SelectedIndexChanged += new System.EventHandler(this.CboPlayers_SelectedIndexChanged);
            // 
            // FrmPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(320, 270);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPlayers";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game - Players";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ComboBox cboPlayers;
    }
}