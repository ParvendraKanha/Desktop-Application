namespace KMPS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnlmenu = new System.Windows.Forms.Panel();
            this.BtnMenu4 = new FontAwesome.Sharp.IconButton();
            this.BtnMenu3 = new FontAwesome.Sharp.IconButton();
            this.BtnError = new FontAwesome.Sharp.IconButton();
            this.BtnDashBoard = new FontAwesome.Sharp.IconButton();
            this.pnllogo = new System.Windows.Forms.Panel();
            this.BtnHome = new System.Windows.Forms.PictureBox();
            this.pnltopmenu = new System.Windows.Forms.Panel();
            this.button15 = new System.Windows.Forms.Button();
            this.lblchildformname = new System.Windows.Forms.Label();
            this.iconcurrentchildform = new FontAwesome.Sharp.IconPictureBox();
            this.pnlshadow = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pnlmenu.SuspendLayout();
            this.pnllogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).BeginInit();
            this.pnltopmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentchildform)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlmenu
            // 
            this.pnlmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.pnlmenu.Controls.Add(this.iconButton1);
            this.pnlmenu.Controls.Add(this.BtnMenu4);
            this.pnlmenu.Controls.Add(this.BtnMenu3);
            this.pnlmenu.Controls.Add(this.BtnError);
            this.pnlmenu.Controls.Add(this.BtnDashBoard);
            this.pnlmenu.Controls.Add(this.pnllogo);
            this.pnlmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlmenu.Location = new System.Drawing.Point(0, 0);
            this.pnlmenu.Name = "pnlmenu";
            this.pnlmenu.Size = new System.Drawing.Size(220, 561);
            this.pnlmenu.TabIndex = 0;
            // 
            // BtnMenu4
            // 
            this.BtnMenu4.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenu4.FlatAppearance.BorderSize = 0;
            this.BtnMenu4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu4.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnMenu4.IconChar = FontAwesome.Sharp.IconChar.Male;
            this.BtnMenu4.IconColor = System.Drawing.Color.GhostWhite;
            this.BtnMenu4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMenu4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu4.Location = new System.Drawing.Point(0, 320);
            this.BtnMenu4.Name = "BtnMenu4";
            this.BtnMenu4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnMenu4.Size = new System.Drawing.Size(220, 60);
            this.BtnMenu4.TabIndex = 4;
            this.BtnMenu4.Text = "Export Member";
            this.BtnMenu4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenu4.UseVisualStyleBackColor = true;
            this.BtnMenu4.Click += new System.EventHandler(this.BtnMenu4_Click);
            // 
            // BtnMenu3
            // 
            this.BtnMenu3.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMenu3.FlatAppearance.BorderSize = 0;
            this.BtnMenu3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenu3.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnMenu3.IconChar = FontAwesome.Sharp.IconChar.CloudDownloadAlt;
            this.BtnMenu3.IconColor = System.Drawing.Color.GhostWhite;
            this.BtnMenu3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMenu3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu3.Location = new System.Drawing.Point(0, 260);
            this.BtnMenu3.Name = "BtnMenu3";
            this.BtnMenu3.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnMenu3.Size = new System.Drawing.Size(220, 60);
            this.BtnMenu3.TabIndex = 3;
            this.BtnMenu3.Text = "Export Rate Chart";
            this.BtnMenu3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMenu3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnMenu3.UseVisualStyleBackColor = true;
            this.BtnMenu3.Click += new System.EventHandler(this.BtnMenu3_Click);
            // 
            // BtnError
            // 
            this.BtnError.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnError.FlatAppearance.BorderSize = 0;
            this.BtnError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnError.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnError.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.BtnError.IconColor = System.Drawing.Color.GhostWhite;
            this.BtnError.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnError.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnError.Location = new System.Drawing.Point(0, 200);
            this.BtnError.Name = "BtnError";
            this.BtnError.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnError.Size = new System.Drawing.Size(220, 60);
            this.BtnError.TabIndex = 2;
            this.BtnError.Text = "Import Pen Drive";
            this.BtnError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnError.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnError.UseVisualStyleBackColor = true;
            this.BtnError.Click += new System.EventHandler(this.BtnError_Click);
            // 
            // BtnDashBoard
            // 
            this.BtnDashBoard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashBoard.FlatAppearance.BorderSize = 0;
            this.BtnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDashBoard.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BtnDashBoard.IconChar = FontAwesome.Sharp.IconChar.Burn;
            this.BtnDashBoard.IconColor = System.Drawing.Color.GhostWhite;
            this.BtnDashBoard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashBoard.Location = new System.Drawing.Point(0, 140);
            this.BtnDashBoard.Name = "BtnDashBoard";
            this.BtnDashBoard.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.BtnDashBoard.Size = new System.Drawing.Size(220, 60);
            this.BtnDashBoard.TabIndex = 1;
            this.BtnDashBoard.Text = "RMRD Collection";
            this.BtnDashBoard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDashBoard.UseVisualStyleBackColor = true;
            this.BtnDashBoard.Click += new System.EventHandler(this.BtnDashBoard_Click);
            // 
            // pnllogo
            // 
            this.pnllogo.Controls.Add(this.BtnHome);
            this.pnllogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnllogo.Location = new System.Drawing.Point(0, 0);
            this.pnllogo.Name = "pnllogo";
            this.pnllogo.Size = new System.Drawing.Size(220, 140);
            this.pnllogo.TabIndex = 0;
            // 
            // BtnHome
            // 
            this.BtnHome.Image = global::KMPS.Properties.Resources.KANHA_Transparent;
            this.BtnHome.Location = new System.Drawing.Point(3, 3);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(214, 131);
            this.BtnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnHome.TabIndex = 0;
            this.BtnHome.TabStop = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // pnltopmenu
            // 
            this.pnltopmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.pnltopmenu.Controls.Add(this.button15);
            this.pnltopmenu.Controls.Add(this.lblchildformname);
            this.pnltopmenu.Controls.Add(this.iconcurrentchildform);
            this.pnltopmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltopmenu.Location = new System.Drawing.Point(220, 0);
            this.pnltopmenu.Name = "pnltopmenu";
            this.pnltopmenu.Size = new System.Drawing.Size(664, 75);
            this.pnltopmenu.TabIndex = 1;
            this.pnltopmenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnltopmenu_MouseDown);
            // 
            // button15
            // 
            this.button15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button15.BackColor = System.Drawing.Color.Red;
            this.button15.FlatAppearance.BorderSize = 0;
            this.button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button15.ForeColor = System.Drawing.Color.White;
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.Location = new System.Drawing.Point(633, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(28, 27);
            this.button15.TabIndex = 4;
            this.button15.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // lblchildformname
            // 
            this.lblchildformname.AutoSize = true;
            this.lblchildformname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchildformname.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblchildformname.Location = new System.Drawing.Point(54, 27);
            this.lblchildformname.Name = "lblchildformname";
            this.lblchildformname.Size = new System.Drawing.Size(45, 17);
            this.lblchildformname.TabIndex = 1;
            this.lblchildformname.Text = "Home";
            this.lblchildformname.Click += new System.EventHandler(this.lblchildformname_Click);
            // 
            // iconcurrentchildform
            // 
            this.iconcurrentchildform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.iconcurrentchildform.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconcurrentchildform.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconcurrentchildform.IconColor = System.Drawing.SystemColors.ButtonHighlight;
            this.iconcurrentchildform.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconcurrentchildform.Location = new System.Drawing.Point(16, 27);
            this.iconcurrentchildform.Name = "iconcurrentchildform";
            this.iconcurrentchildform.Size = new System.Drawing.Size(32, 32);
            this.iconcurrentchildform.TabIndex = 0;
            this.iconcurrentchildform.TabStop = false;
            this.iconcurrentchildform.Click += new System.EventHandler(this.iconcurrentchildform_Click);
            // 
            // pnlshadow
            // 
            this.pnlshadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.pnlshadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlshadow.Location = new System.Drawing.Point(220, 75);
            this.pnlshadow.Name = "pnlshadow";
            this.pnlshadow.Size = new System.Drawing.Size(664, 9);
            this.pnlshadow.TabIndex = 2;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(220, 84);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(664, 477);
            this.pnlDesktop.TabIndex = 3;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.TextHeight;
            this.iconButton1.IconColor = System.Drawing.Color.GhostWhite;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 380);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(220, 60);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Sync Master Transaction";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlshadow);
            this.Controls.Add(this.pnltopmenu);
            this.Controls.Add(this.pnlmenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlmenu.ResumeLayout(false);
            this.pnllogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnHome)).EndInit();
            this.pnltopmenu.ResumeLayout(false);
            this.pnltopmenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconcurrentchildform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlmenu;
        private FontAwesome.Sharp.IconButton BtnDashBoard;
        private FontAwesome.Sharp.IconButton BtnMenu4;
        private FontAwesome.Sharp.IconButton BtnMenu3;
        private FontAwesome.Sharp.IconButton BtnError;
        private System.Windows.Forms.Panel pnllogo;
        private System.Windows.Forms.PictureBox BtnHome;
        private System.Windows.Forms.Panel pnltopmenu;
        private FontAwesome.Sharp.IconPictureBox iconcurrentchildform;
        private System.Windows.Forms.Label lblchildformname;
        private System.Windows.Forms.Panel pnlshadow;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Button button15;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}

