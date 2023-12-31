﻿namespace SnakeGame_Server
{
    partial class FrmServer
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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServer));
            this.tlpServerMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpServerChats = new System.Windows.Forms.TableLayoutPanel();
            this.lblServerChats = new System.Windows.Forms.Label();
            this.lvServer = new System.Windows.Forms.ListView();
            this.tlpServerButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnServerStart = new System.Windows.Forms.Button();
            this.tlpServerIO = new System.Windows.Forms.TableLayoutPanel();
            this.tbServerOutput = new System.Windows.Forms.TextBox();
            this.tlpServerInput = new System.Windows.Forms.TableLayoutPanel();
            this.tbServerInput = new System.Windows.Forms.TextBox();
            this.btnServerSend = new System.Windows.Forms.Button();
            this.tlpServerMain.SuspendLayout();
            this.tlpServerChats.SuspendLayout();
            this.tlpServerButtons.SuspendLayout();
            this.tlpServerIO.SuspendLayout();
            this.tlpServerInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpServerMain
            // 
            this.tlpServerMain.ColumnCount = 2;
            this.tlpServerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlpServerMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpServerMain.Controls.Add(this.tlpServerChats, 0, 0);
            this.tlpServerMain.Controls.Add(this.tlpServerIO, 1, 0);
            this.tlpServerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerMain.Location = new System.Drawing.Point(0, 0);
            this.tlpServerMain.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tlpServerMain.Name = "tlpServerMain";
            this.tlpServerMain.RowCount = 1;
            this.tlpServerMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServerMain.Size = new System.Drawing.Size(684, 351);
            this.tlpServerMain.TabIndex = 1;
            // 
            // tlpServerChats
            // 
            this.tlpServerChats.BackColor = System.Drawing.Color.YellowGreen;
            this.tlpServerChats.ColumnCount = 1;
            this.tlpServerChats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServerChats.Controls.Add(this.lblServerChats, 0, 0);
            this.tlpServerChats.Controls.Add(this.lvServer, 0, 1);
            this.tlpServerChats.Controls.Add(this.tlpServerButtons, 0, 2);
            this.tlpServerChats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerChats.Location = new System.Drawing.Point(0, 3);
            this.tlpServerChats.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tlpServerChats.Name = "tlpServerChats";
            this.tlpServerChats.RowCount = 3;
            this.tlpServerChats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tlpServerChats.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpServerChats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tlpServerChats.Size = new System.Drawing.Size(150, 345);
            this.tlpServerChats.TabIndex = 1;
            // 
            // lblServerChats
            // 
            this.lblServerChats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblServerChats.AutoSize = true;
            this.lblServerChats.Location = new System.Drawing.Point(51, 10);
            this.lblServerChats.Name = "lblServerChats";
            this.lblServerChats.Size = new System.Drawing.Size(48, 13);
            this.lblServerChats.TabIndex = 0;
            this.lblServerChats.Text = "Usuarios";
            // 
            // lvServer
            // 
            this.lvServer.BackColor = System.Drawing.SystemColors.Window;
            this.lvServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvServer.ForeColor = System.Drawing.Color.Black;
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = null;
            this.lvServer.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.lvServer.HideSelection = false;
            this.lvServer.Location = new System.Drawing.Point(3, 36);
            this.lvServer.MultiSelect = false;
            this.lvServer.Name = "lvServer";
            this.lvServer.Size = new System.Drawing.Size(144, 248);
            this.lvServer.TabIndex = 1;
            this.lvServer.UseCompatibleStateImageBehavior = false;
            this.lvServer.View = System.Windows.Forms.View.List;
            // 
            // tlpServerButtons
            // 
            this.tlpServerButtons.ColumnCount = 2;
            this.tlpServerButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpServerButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpServerButtons.Controls.Add(this.btnStopServer, 0, 0);
            this.tlpServerButtons.Controls.Add(this.btnServerStart, 1, 0);
            this.tlpServerButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerButtons.Location = new System.Drawing.Point(0, 287);
            this.tlpServerButtons.Margin = new System.Windows.Forms.Padding(0);
            this.tlpServerButtons.Name = "tlpServerButtons";
            this.tlpServerButtons.RowCount = 1;
            this.tlpServerButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServerButtons.Size = new System.Drawing.Size(150, 58);
            this.tlpServerButtons.TabIndex = 2;
            // 
            // btnStopServer
            // 
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Image = ((System.Drawing.Image)(resources.GetObject("btnStopServer.Image")));
            this.btnStopServer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStopServer.Location = new System.Drawing.Point(3, 3);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(69, 52);
            this.btnStopServer.TabIndex = 0;
            this.btnStopServer.Text = "Detener";
            this.btnStopServer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.BtnStopServer_Click);
            // 
            // btnServerStart
            // 
            this.btnServerStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnServerStart.Image = ((System.Drawing.Image)(resources.GetObject("btnServerStart.Image")));
            this.btnServerStart.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnServerStart.Location = new System.Drawing.Point(78, 3);
            this.btnServerStart.Name = "btnServerStart";
            this.btnServerStart.Size = new System.Drawing.Size(69, 52);
            this.btnServerStart.TabIndex = 1;
            this.btnServerStart.Text = "Iniciar";
            this.btnServerStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServerStart.UseVisualStyleBackColor = true;
            this.btnServerStart.Click += new System.EventHandler(this.BtnServerStart_Click);
            // 
            // tlpServerIO
            // 
            this.tlpServerIO.ColumnCount = 1;
            this.tlpServerIO.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServerIO.Controls.Add(this.tbServerOutput, 0, 0);
            this.tlpServerIO.Controls.Add(this.tlpServerInput, 0, 1);
            this.tlpServerIO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerIO.Location = new System.Drawing.Point(150, 3);
            this.tlpServerIO.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tlpServerIO.Name = "tlpServerIO";
            this.tlpServerIO.RowCount = 2;
            this.tlpServerIO.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpServerIO.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpServerIO.Size = new System.Drawing.Size(534, 345);
            this.tlpServerIO.TabIndex = 2;
            // 
            // tbServerOutput
            // 
            this.tbServerOutput.BackColor = System.Drawing.SystemColors.Window;
            this.tbServerOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbServerOutput.ForeColor = System.Drawing.Color.Black;
            this.tbServerOutput.HideSelection = false;
            this.tbServerOutput.Location = new System.Drawing.Point(3, 3);
            this.tbServerOutput.MaxLength = 0;
            this.tbServerOutput.Multiline = true;
            this.tbServerOutput.Name = "tbServerOutput";
            this.tbServerOutput.ReadOnly = true;
            this.tbServerOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbServerOutput.Size = new System.Drawing.Size(528, 281);
            this.tbServerOutput.TabIndex = 2;
            this.tbServerOutput.TextChanged += new System.EventHandler(this.tbServerOutput_TextChanged);
            // 
            // tlpServerInput
            // 
            this.tlpServerInput.ColumnCount = 2;
            this.tlpServerInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpServerInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpServerInput.Controls.Add(this.tbServerInput, 0, 0);
            this.tlpServerInput.Controls.Add(this.btnServerSend, 1, 0);
            this.tlpServerInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpServerInput.Location = new System.Drawing.Point(0, 287);
            this.tlpServerInput.Margin = new System.Windows.Forms.Padding(0);
            this.tlpServerInput.Name = "tlpServerInput";
            this.tlpServerInput.RowCount = 1;
            this.tlpServerInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpServerInput.Size = new System.Drawing.Size(534, 58);
            this.tlpServerInput.TabIndex = 3;
            // 
            // tbServerInput
            // 
            this.tbServerInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbServerInput.Location = new System.Drawing.Point(3, 3);
            this.tbServerInput.Multiline = true;
            this.tbServerInput.Name = "tbServerInput";
            this.tbServerInput.ReadOnly = true;
            this.tbServerInput.Size = new System.Drawing.Size(435, 52);
            this.tbServerInput.TabIndex = 0;
            // 
            // btnServerSend
            // 
            this.btnServerSend.Image = ((System.Drawing.Image)(resources.GetObject("btnServerSend.Image")));
            this.btnServerSend.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnServerSend.Location = new System.Drawing.Point(444, 3);
            this.btnServerSend.Name = "btnServerSend";
            this.btnServerSend.Size = new System.Drawing.Size(84, 52);
            this.btnServerSend.TabIndex = 1;
            this.btnServerSend.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnServerSend.UseVisualStyleBackColor = true;
            this.btnServerSend.Click += new System.EventHandler(this.BtnServerSend_Click);
            // 
            // FrmServer
            // 
            this.AcceptButton = this.btnServerSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(684, 351);
            this.Controls.Add(this.tlpServerMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 390);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snake Game - Server";
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.tlpServerMain.ResumeLayout(false);
            this.tlpServerChats.ResumeLayout(false);
            this.tlpServerChats.PerformLayout();
            this.tlpServerButtons.ResumeLayout(false);
            this.tlpServerIO.ResumeLayout(false);
            this.tlpServerIO.PerformLayout();
            this.tlpServerInput.ResumeLayout(false);
            this.tlpServerInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tlpServerMain;
        public System.Windows.Forms.TableLayoutPanel tlpServerChats;
        public System.Windows.Forms.Label lblServerChats;
        public System.Windows.Forms.ListView lvServer;
        public System.Windows.Forms.TableLayoutPanel tlpServerButtons;
        public System.Windows.Forms.Button btnStopServer;
        public System.Windows.Forms.Button btnServerStart;
        public System.Windows.Forms.TableLayoutPanel tlpServerIO;
        public System.Windows.Forms.TableLayoutPanel tlpServerInput;
        public System.Windows.Forms.TextBox tbServerInput;
        public System.Windows.Forms.Button btnServerSend;
        public System.Windows.Forms.TextBox tbServerOutput;
    }
}