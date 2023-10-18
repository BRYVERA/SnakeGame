namespace SnakeGame
{
    partial class FrmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGame));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            this.StatusPlayer1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusPlayer2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.pbSnake2 = new System.Windows.Forms.PictureBox();
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.pbSnake1 = new System.Windows.Forms.PictureBox();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Russo One", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(832, 27);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // NewGame
            // 
            this.NewGame.Font = new System.Drawing.Font("Russo One", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGame.MergeIndex = 0;
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(136, 23);
            this.NewGame.Text = "Multijugador";
            this.NewGame.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.BackColor = System.Drawing.Color.Transparent;
            this.lblOutput.Location = new System.Drawing.Point(726, 0);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(106, 25);
            this.lblOutput.TabIndex = 12;
            this.lblOutput.Visible = false;
            this.lblOutput.TextChanged += new System.EventHandler(this.LblOutput_TextChanged);
            // 
            // lblInput
            // 
            this.lblInput.BackColor = System.Drawing.Color.YellowGreen;
            this.lblInput.Location = new System.Drawing.Point(624, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(100, 25);
            this.lblInput.TabIndex = 13;
            this.lblInput.Visible = false;
            // 
            // StatusPlayer1
            // 
            this.StatusPlayer1.Name = "StatusPlayer1";
            this.StatusPlayer1.Size = new System.Drawing.Size(0, 17);
            // 
            // StatusPlayer2
            // 
            this.StatusPlayer2.Name = "StatusPlayer2";
            this.StatusPlayer2.Size = new System.Drawing.Size(0, 17);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusPlayer1,
            this.StatusPlayer2});
            this.statusStrip.Location = new System.Drawing.Point(0, 566);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(832, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // pbSnake2
            // 
            this.pbSnake2.BackColor = System.Drawing.Color.Transparent;
            this.pbSnake2.ErrorImage = null;
            this.pbSnake2.Image = ((System.Drawing.Image)(resources.GetObject("pbSnake2.Image")));
            this.pbSnake2.InitialImage = null;
            this.pbSnake2.Location = new System.Drawing.Point(794, 40);
            this.pbSnake2.Name = "pbSnake2";
            this.pbSnake2.Size = new System.Drawing.Size(26, 26);
            this.pbSnake2.TabIndex = 0;
            this.pbSnake2.TabStop = false;
            this.pbSnake2.Visible = false;
            this.pbSnake2.Click += new System.EventHandler(this.pbSnake2_Click);
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.Color.Transparent;
            this.pbBall.ErrorImage = null;
            this.pbBall.Image = ((System.Drawing.Image)(resources.GetObject("pbBall.Image")));
            this.pbBall.InitialImage = null;
            this.pbBall.Location = new System.Drawing.Point(451, 331);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(26, 26);
            this.pbBall.TabIndex = 1;
            this.pbBall.TabStop = false;
            this.pbBall.Click += new System.EventHandler(this.pbBall_Click);
            // 
            // pbSnake1
            // 
            this.pbSnake1.BackColor = System.Drawing.Color.Transparent;
            this.pbSnake1.ErrorImage = null;
            this.pbSnake1.Image = ((System.Drawing.Image)(resources.GetObject("pbSnake1.Image")));
            this.pbSnake1.InitialImage = null;
            this.pbSnake1.Location = new System.Drawing.Point(12, 512);
            this.pbSnake1.Name = "pbSnake1";
            this.pbSnake1.Size = new System.Drawing.Size(26, 26);
            this.pbSnake1.TabIndex = 2;
            this.pbSnake1.TabStop = false;
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(832, 588);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbSnake1);
            this.Controls.Add(this.pbBall);
            this.Controls.Add(this.pbSnake2);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(848, 627);
            this.Name = "FrmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGame_FormClosing);
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGame_KeyDown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnake1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        public System.Windows.Forms.Label lblOutput;
        public System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.ToolStripStatusLabel StatusPlayer1;
        private System.Windows.Forms.ToolStripStatusLabel StatusPlayer2;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.PictureBox pbSnake2;
        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.PictureBox pbSnake1;
    }
}

