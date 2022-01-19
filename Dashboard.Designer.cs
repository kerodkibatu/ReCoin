namespace ReCoin
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.foreverForm1 = new ReaLTaiizor.Forms.ForeverForm();
            this.WelcomeLbl = new ReaLTaiizor.Controls.ForeverLabel();
            this.NavMenu = new ReaLTaiizor.Controls.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DetailTBox = new ReaLTaiizor.Controls.ForeverTextBox();
            this.foreverLabel6 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel5 = new ReaLTaiizor.Controls.ForeverLabel();
            this.BalanceLbl = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.S = new System.Windows.Forms.TabPage();
            this.TransferBtn = new ReaLTaiizor.Controls.ForeverButton();
            this.foreverLabel4 = new ReaLTaiizor.Controls.ForeverLabel();
            this.AmountTbox = new ReaLTaiizor.Controls.ForeverTextBox();
            this.foreverLabel3 = new ReaLTaiizor.Controls.ForeverLabel();
            this.RecipientTbox = new ReaLTaiizor.Controls.ForeverTextBox();
            this.CloseBtn = new ReaLTaiizor.Controls.ForeverClose();
            this.TransactionLbox = new System.Windows.Forms.ListBox();
            this.foreverForm1.SuspendLayout();
            this.NavMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.S.SuspendLayout();
            this.SuspendLayout();
            // 
            // foreverForm1
            // 
            this.foreverForm1.BackColor = System.Drawing.Color.White;
            this.foreverForm1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.foreverForm1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.foreverForm1.Controls.Add(this.WelcomeLbl);
            this.foreverForm1.Controls.Add(this.NavMenu);
            this.foreverForm1.Controls.Add(this.CloseBtn);
            this.foreverForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foreverForm1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverForm1.ForeverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.foreverForm1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverForm1.HeaderMaximize = false;
            this.foreverForm1.HeaderTextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverForm1.Image = ((System.Drawing.Image)(resources.GetObject("foreverForm1.Image")));
            this.foreverForm1.Location = new System.Drawing.Point(0, 0);
            this.foreverForm1.MinimumSize = new System.Drawing.Size(210, 50);
            this.foreverForm1.Name = "foreverForm1";
            this.foreverForm1.Padding = new System.Windows.Forms.Padding(1, 51, 1, 1);
            this.foreverForm1.Sizable = true;
            this.foreverForm1.Size = new System.Drawing.Size(800, 450);
            this.foreverForm1.TabIndex = 0;
            this.foreverForm1.Text = "Dashboard";
            this.foreverForm1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.foreverForm1.TextLight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.AutoSize = true;
            this.WelcomeLbl.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WelcomeLbl.ForeColor = System.Drawing.Color.Gray;
            this.WelcomeLbl.Location = new System.Drawing.Point(50, 33);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(63, 15);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Welcome :";
            // 
            // NavMenu
            // 
            this.NavMenu.ActiveForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NavMenu.ActiveLineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.NavMenu.ActiveTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.NavMenu.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.NavMenu.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighSpeed;
            this.NavMenu.CompositingType = System.Drawing.Drawing2D.CompositingMode.SourceOver;
            this.NavMenu.ControlBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.NavMenu.Controls.Add(this.tabPage2);
            this.NavMenu.Controls.Add(this.tabPage3);
            this.NavMenu.Controls.Add(this.S);
            this.NavMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavMenu.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.NavMenu.FrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.NavMenu.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.NavMenu.ItemSize = new System.Drawing.Size(44, 135);
            this.NavMenu.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.NavMenu.LineTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.NavMenu.Location = new System.Drawing.Point(1, 51);
            this.NavMenu.Multiline = true;
            this.NavMenu.Name = "NavMenu";
            this.NavMenu.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(162)))), ((int)(((byte)(167)))));
            this.NavMenu.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.NavMenu.SelectedIndex = 0;
            this.NavMenu.Size = new System.Drawing.Size(798, 398);
            this.NavMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.NavMenu.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            this.NavMenu.StringType = System.Drawing.StringAlignment.Near;
            this.NavMenu.TabColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(57)))), ((int)(((byte)(64)))));
            this.NavMenu.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabPage2.Controls.Add(this.TransactionLbox);
            this.tabPage2.Controls.Add(this.DetailTBox);
            this.tabPage2.Controls.Add(this.foreverLabel6);
            this.tabPage2.Controls.Add(this.foreverLabel5);
            this.tabPage2.Controls.Add(this.BalanceLbl);
            this.tabPage2.Controls.Add(this.foreverLabel1);
            this.tabPage2.Location = new System.Drawing.Point(139, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(655, 390);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Wallet";
            // 
            // DetailTBox
            // 
            this.DetailTBox.BackColor = System.Drawing.Color.Transparent;
            this.DetailTBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.DetailTBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.DetailTBox.FocusOnHover = false;
            this.DetailTBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DetailTBox.Location = new System.Drawing.Point(285, 166);
            this.DetailTBox.MaxLength = 32767;
            this.DetailTBox.Multiline = true;
            this.DetailTBox.Name = "DetailTBox";
            this.DetailTBox.ReadOnly = true;
            this.DetailTBox.Size = new System.Drawing.Size(363, 217);
            this.DetailTBox.TabIndex = 6;
            this.DetailTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.DetailTBox.UseSystemPasswordChar = false;
            // 
            // foreverLabel6
            // 
            this.foreverLabel6.AutoSize = true;
            this.foreverLabel6.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel6.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverLabel6.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel6.Location = new System.Drawing.Point(285, 112);
            this.foreverLabel6.Name = "foreverLabel6";
            this.foreverLabel6.Size = new System.Drawing.Size(135, 51);
            this.foreverLabel6.TabIndex = 5;
            this.foreverLabel6.Text = "Details";
            // 
            // foreverLabel5
            // 
            this.foreverLabel5.AutoSize = true;
            this.foreverLabel5.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel5.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverLabel5.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel5.Location = new System.Drawing.Point(0, 112);
            this.foreverLabel5.Name = "foreverLabel5";
            this.foreverLabel5.Size = new System.Drawing.Size(228, 51);
            this.foreverLabel5.TabIndex = 3;
            this.foreverLabel5.Text = "Transactions";
            // 
            // BalanceLbl
            // 
            this.BalanceLbl.AutoSize = true;
            this.BalanceLbl.BackColor = System.Drawing.Color.Transparent;
            this.BalanceLbl.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BalanceLbl.ForeColor = System.Drawing.Color.LightGray;
            this.BalanceLbl.Location = new System.Drawing.Point(166, 17);
            this.BalanceLbl.Name = "BalanceLbl";
            this.BalanceLbl.Size = new System.Drawing.Size(30, 51);
            this.BalanceLbl.TabIndex = 1;
            this.BalanceLbl.Text = ":";
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel1.Location = new System.Drawing.Point(6, 17);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(169, 51);
            this.foreverLabel1.TabIndex = 0;
            this.foreverLabel1.Text = "Balance :";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.foreverLabel2);
            this.tabPage3.Location = new System.Drawing.Point(139, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(655, 390);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Buy/Sell";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ReCoin.Properties.Resources.NicePng_metal_gear_alert_png_589511;
            this.pictureBox1.Location = new System.Drawing.Point(206, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel2.Location = new System.Drawing.Point(164, 107);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(305, 51);
            this.foreverLabel2.TabIndex = 1;
            this.foreverLabel2.Text = "Work in Progress";
            // 
            // S
            // 
            this.S.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.S.Controls.Add(this.TransferBtn);
            this.S.Controls.Add(this.foreverLabel4);
            this.S.Controls.Add(this.AmountTbox);
            this.S.Controls.Add(this.foreverLabel3);
            this.S.Controls.Add(this.RecipientTbox);
            this.S.Location = new System.Drawing.Point(139, 4);
            this.S.Name = "S";
            this.S.Padding = new System.Windows.Forms.Padding(3);
            this.S.Size = new System.Drawing.Size(655, 390);
            this.S.TabIndex = 2;
            this.S.Text = "Trade";
            // 
            // TransferBtn
            // 
            this.TransferBtn.BackColor = System.Drawing.Color.Transparent;
            this.TransferBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.TransferBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TransferBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TransferBtn.Location = new System.Drawing.Point(521, 96);
            this.TransferBtn.Name = "TransferBtn";
            this.TransferBtn.Rounded = false;
            this.TransferBtn.Size = new System.Drawing.Size(115, 42);
            this.TransferBtn.TabIndex = 4;
            this.TransferBtn.Text = "Transfer";
            this.TransferBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.TransferBtn.Click += new System.EventHandler(this.TransferBtnCLicked);
            // 
            // foreverLabel4
            // 
            this.foreverLabel4.AutoSize = true;
            this.foreverLabel4.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel4.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverLabel4.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel4.Location = new System.Drawing.Point(6, 83);
            this.foreverLabel4.Name = "foreverLabel4";
            this.foreverLabel4.Size = new System.Drawing.Size(177, 51);
            this.foreverLabel4.TabIndex = 3;
            this.foreverLabel4.Text = "Amount :";
            // 
            // AmountTbox
            // 
            this.AmountTbox.BackColor = System.Drawing.Color.Transparent;
            this.AmountTbox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.AmountTbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.AmountTbox.FocusOnHover = false;
            this.AmountTbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AmountTbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AmountTbox.Location = new System.Drawing.Point(207, 96);
            this.AmountTbox.MaxLength = 32767;
            this.AmountTbox.Multiline = false;
            this.AmountTbox.Name = "AmountTbox";
            this.AmountTbox.ReadOnly = false;
            this.AmountTbox.Size = new System.Drawing.Size(172, 38);
            this.AmountTbox.TabIndex = 2;
            this.AmountTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AmountTbox.UseSystemPasswordChar = false;
            // 
            // foreverLabel3
            // 
            this.foreverLabel3.AutoSize = true;
            this.foreverLabel3.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel3.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.foreverLabel3.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel3.Location = new System.Drawing.Point(6, 19);
            this.foreverLabel3.Name = "foreverLabel3";
            this.foreverLabel3.Size = new System.Drawing.Size(195, 51);
            this.foreverLabel3.TabIndex = 1;
            this.foreverLabel3.Text = "Recipient :";
            // 
            // RecipientTbox
            // 
            this.RecipientTbox.BackColor = System.Drawing.Color.Transparent;
            this.RecipientTbox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.RecipientTbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.RecipientTbox.FocusOnHover = false;
            this.RecipientTbox.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecipientTbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.RecipientTbox.Location = new System.Drawing.Point(207, 32);
            this.RecipientTbox.MaxLength = 32767;
            this.RecipientTbox.Multiline = false;
            this.RecipientTbox.Name = "RecipientTbox";
            this.RecipientTbox.ReadOnly = false;
            this.RecipientTbox.Size = new System.Drawing.Size(172, 38);
            this.RecipientTbox.TabIndex = 0;
            this.RecipientTbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RecipientTbox.UseSystemPasswordChar = false;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseBtn.DefaultLocation = true;
            this.CloseBtn.DownColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBtn.Font = new System.Drawing.Font("Marlett", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseBtn.Location = new System.Drawing.Point(770, 16);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.OverColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CloseBtn.Size = new System.Drawing.Size(18, 18);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "foreverClose1";
            this.CloseBtn.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // TransactionLbox
            // 
            this.TransactionLbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.TransactionLbox.ForeColor = System.Drawing.Color.White;
            this.TransactionLbox.FormattingEnabled = true;
            this.TransactionLbox.ItemHeight = 21;
            this.TransactionLbox.Location = new System.Drawing.Point(6, 166);
            this.TransactionLbox.Name = "TransactionLbox";
            this.TransactionLbox.Size = new System.Drawing.Size(273, 214);
            this.TransactionLbox.TabIndex = 7;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.foreverForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.foreverForm1.ResumeLayout(false);
            this.foreverForm1.PerformLayout();
            this.NavMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.S.ResumeLayout(false);
            this.S.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm foreverForm1;
        private ReaLTaiizor.Controls.ForeverClose CloseBtn;
        private ReaLTaiizor.Controls.TabPage NavMenu;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ReaLTaiizor.Controls.ForeverLabel WelcomeLbl;
        private ReaLTaiizor.Controls.ForeverLabel BalanceLbl;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private TabPage S;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ForeverTextBox RecipientTbox;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel4;
        private ReaLTaiizor.Controls.ForeverTextBox AmountTbox;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel3;
        private ReaLTaiizor.Controls.ForeverButton TransferBtn;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel6;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel5;
        private ReaLTaiizor.Controls.ForeverTextBox DetailTBox;
        private ListBox TransactionLbox;
    }
}