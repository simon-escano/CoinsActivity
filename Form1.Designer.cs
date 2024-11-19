namespace CoinsActivity
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnBase = new TableLayoutPanel();
            pnImage = new TableLayoutPanel();
            pbImage = new PictureBox();
            pnButtons = new TableLayoutPanel();
            btnChooseImage = new Button();
            btnCount = new Button();
            pnResult = new TableLayoutPanel();
            pnDenominations = new TableLayoutPanel();
            pnC5 = new TableLayoutPanel();
            lblC5 = new Label();
            tbC5 = new TextBox();
            pnC10 = new TableLayoutPanel();
            lblC10 = new Label();
            tbC10 = new TextBox();
            pnC25 = new TableLayoutPanel();
            lblC25 = new Label();
            tbC25 = new TextBox();
            pnP1 = new TableLayoutPanel();
            lblP1 = new Label();
            tbP1 = new TextBox();
            pnP5 = new TableLayoutPanel();
            lblP5 = new Label();
            tbP5 = new TextBox();
            pnP10 = new TableLayoutPanel();
            lblP10 = new Label();
            tbP10 = new TextBox();
            pnTotal = new TableLayoutPanel();
            lblTotal = new Label();
            tbTotal = new TextBox();
            pnBase.SuspendLayout();
            pnImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            pnButtons.SuspendLayout();
            pnResult.SuspendLayout();
            pnDenominations.SuspendLayout();
            pnC5.SuspendLayout();
            pnC10.SuspendLayout();
            pnC25.SuspendLayout();
            pnP1.SuspendLayout();
            pnP5.SuspendLayout();
            pnP10.SuspendLayout();
            pnTotal.SuspendLayout();
            SuspendLayout();
            // 
            // pnBase
            // 
            pnBase.ColumnCount = 1;
            pnBase.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnBase.Controls.Add(pnImage, 0, 0);
            pnBase.Controls.Add(pnResult, 0, 1);
            pnBase.Dock = DockStyle.Fill;
            pnBase.Location = new Point(0, 0);
            pnBase.Margin = new Padding(0);
            pnBase.Name = "pnBase";
            pnBase.Padding = new Padding(16);
            pnBase.RowCount = 2;
            pnBase.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnBase.RowStyles.Add(new RowStyle());
            pnBase.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            pnBase.Size = new Size(432, 513);
            pnBase.TabIndex = 0;
            // 
            // pnImage
            // 
            pnImage.ColumnCount = 1;
            pnImage.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnImage.Controls.Add(pbImage, 0, 0);
            pnImage.Controls.Add(pnButtons, 0, 1);
            pnImage.Dock = DockStyle.Fill;
            pnImage.Location = new Point(16, 16);
            pnImage.Margin = new Padding(0, 0, 0, 16);
            pnImage.Name = "pnImage";
            pnImage.RowCount = 2;
            pnImage.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnImage.RowStyles.Add(new RowStyle());
            pnImage.Size = new Size(400, 411);
            pnImage.TabIndex = 0;
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.Fixed3D;
            pbImage.Dock = DockStyle.Fill;
            pbImage.Location = new Point(0, 0);
            pbImage.Margin = new Padding(0);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(400, 367);
            pbImage.SizeMode = PictureBoxSizeMode.Zoom;
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // pnButtons
            // 
            pnButtons.AutoSize = true;
            pnButtons.ColumnCount = 2;
            pnButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            pnButtons.Controls.Add(btnChooseImage, 0, 0);
            pnButtons.Controls.Add(btnCount, 1, 0);
            pnButtons.Dock = DockStyle.Fill;
            pnButtons.Location = new Point(0, 367);
            pnButtons.Margin = new Padding(0);
            pnButtons.Name = "pnButtons";
            pnButtons.RowCount = 1;
            pnButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnButtons.Size = new Size(400, 44);
            pnButtons.TabIndex = 1;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Dock = DockStyle.Fill;
            btnChooseImage.Location = new Point(0, 0);
            btnChooseImage.Margin = new Padding(0);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(200, 44);
            btnChooseImage.TabIndex = 2;
            btnChooseImage.Text = "Choose image";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnCount
            // 
            btnCount.Dock = DockStyle.Fill;
            btnCount.Location = new Point(200, 0);
            btnCount.Margin = new Padding(0);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(200, 44);
            btnCount.TabIndex = 3;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // pnResult
            // 
            pnResult.AutoSize = true;
            pnResult.ColumnCount = 1;
            pnResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnResult.Controls.Add(pnDenominations, 0, 0);
            pnResult.Controls.Add(pnTotal, 0, 1);
            pnResult.Dock = DockStyle.Fill;
            pnResult.Enabled = false;
            pnResult.Location = new Point(16, 443);
            pnResult.Margin = new Padding(0);
            pnResult.Name = "pnResult";
            pnResult.RowCount = 2;
            pnResult.RowStyles.Add(new RowStyle());
            pnResult.RowStyles.Add(new RowStyle());
            pnResult.Size = new Size(400, 54);
            pnResult.TabIndex = 1;
            // 
            // pnDenominations
            // 
            pnDenominations.AutoSize = true;
            pnDenominations.ColumnCount = 6;
            pnDenominations.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            pnDenominations.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            pnDenominations.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            pnDenominations.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            pnDenominations.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            pnDenominations.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.666666F));
            pnDenominations.Controls.Add(pnC5, 0, 0);
            pnDenominations.Controls.Add(pnC10, 1, 0);
            pnDenominations.Controls.Add(pnC25, 2, 0);
            pnDenominations.Controls.Add(pnP1, 3, 0);
            pnDenominations.Controls.Add(pnP5, 4, 0);
            pnDenominations.Controls.Add(pnP10, 5, 0);
            pnDenominations.Dock = DockStyle.Fill;
            pnDenominations.Location = new Point(0, 0);
            pnDenominations.Margin = new Padding(0, 0, 0, 8);
            pnDenominations.Name = "pnDenominations";
            pnDenominations.RowCount = 1;
            pnDenominations.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnDenominations.Size = new Size(400, 23);
            pnDenominations.TabIndex = 0;
            // 
            // pnC5
            // 
            pnC5.AutoSize = true;
            pnC5.ColumnCount = 2;
            pnC5.ColumnStyles.Add(new ColumnStyle());
            pnC5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnC5.Controls.Add(lblC5, 0, 0);
            pnC5.Controls.Add(tbC5, 1, 0);
            pnC5.Dock = DockStyle.Fill;
            pnC5.Location = new Point(0, 0);
            pnC5.Margin = new Padding(0, 0, 8, 0);
            pnC5.Name = "pnC5";
            pnC5.RowCount = 1;
            pnC5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnC5.Size = new Size(58, 23);
            pnC5.TabIndex = 5;
            // 
            // lblC5
            // 
            lblC5.AutoSize = true;
            lblC5.Dock = DockStyle.Fill;
            lblC5.Location = new Point(0, 0);
            lblC5.Margin = new Padding(0);
            lblC5.Name = "lblC5";
            lblC5.Size = new Size(19, 23);
            lblC5.TabIndex = 0;
            lblC5.Text = "¢5";
            lblC5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbC5
            // 
            tbC5.Dock = DockStyle.Fill;
            tbC5.Location = new Point(19, 0);
            tbC5.Margin = new Padding(0);
            tbC5.Name = "tbC5";
            tbC5.ReadOnly = true;
            tbC5.Size = new Size(39, 23);
            tbC5.TabIndex = 1;
            // 
            // pnC10
            // 
            pnC10.AutoSize = true;
            pnC10.ColumnCount = 2;
            pnC10.ColumnStyles.Add(new ColumnStyle());
            pnC10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnC10.Controls.Add(lblC10, 0, 0);
            pnC10.Controls.Add(tbC10, 1, 0);
            pnC10.Dock = DockStyle.Fill;
            pnC10.Location = new Point(66, 0);
            pnC10.Margin = new Padding(0, 0, 8, 0);
            pnC10.Name = "pnC10";
            pnC10.RowCount = 1;
            pnC10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnC10.Size = new Size(58, 23);
            pnC10.TabIndex = 4;
            // 
            // lblC10
            // 
            lblC10.AutoSize = true;
            lblC10.Dock = DockStyle.Fill;
            lblC10.Location = new Point(0, 0);
            lblC10.Margin = new Padding(0);
            lblC10.Name = "lblC10";
            lblC10.Size = new Size(25, 23);
            lblC10.TabIndex = 0;
            lblC10.Text = "¢10";
            lblC10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbC10
            // 
            tbC10.Dock = DockStyle.Fill;
            tbC10.Location = new Point(25, 0);
            tbC10.Margin = new Padding(0);
            tbC10.Name = "tbC10";
            tbC10.ReadOnly = true;
            tbC10.Size = new Size(33, 23);
            tbC10.TabIndex = 1;
            // 
            // pnC25
            // 
            pnC25.AutoSize = true;
            pnC25.ColumnCount = 2;
            pnC25.ColumnStyles.Add(new ColumnStyle());
            pnC25.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnC25.Controls.Add(lblC25, 0, 0);
            pnC25.Controls.Add(tbC25, 1, 0);
            pnC25.Dock = DockStyle.Fill;
            pnC25.Location = new Point(132, 0);
            pnC25.Margin = new Padding(0, 0, 8, 0);
            pnC25.Name = "pnC25";
            pnC25.RowCount = 1;
            pnC25.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnC25.Size = new Size(58, 23);
            pnC25.TabIndex = 3;
            // 
            // lblC25
            // 
            lblC25.AutoSize = true;
            lblC25.Dock = DockStyle.Fill;
            lblC25.Location = new Point(0, 0);
            lblC25.Margin = new Padding(0);
            lblC25.Name = "lblC25";
            lblC25.Size = new Size(25, 23);
            lblC25.TabIndex = 0;
            lblC25.Text = "¢25";
            lblC25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbC25
            // 
            tbC25.Dock = DockStyle.Fill;
            tbC25.Location = new Point(25, 0);
            tbC25.Margin = new Padding(0);
            tbC25.Name = "tbC25";
            tbC25.ReadOnly = true;
            tbC25.Size = new Size(33, 23);
            tbC25.TabIndex = 1;
            // 
            // pnP1
            // 
            pnP1.AutoSize = true;
            pnP1.ColumnCount = 2;
            pnP1.ColumnStyles.Add(new ColumnStyle());
            pnP1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnP1.Controls.Add(lblP1, 0, 0);
            pnP1.Controls.Add(tbP1, 1, 0);
            pnP1.Dock = DockStyle.Fill;
            pnP1.Location = new Point(198, 0);
            pnP1.Margin = new Padding(0, 0, 8, 0);
            pnP1.Name = "pnP1";
            pnP1.RowCount = 1;
            pnP1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnP1.Size = new Size(58, 23);
            pnP1.TabIndex = 2;
            // 
            // lblP1
            // 
            lblP1.AutoSize = true;
            lblP1.Dock = DockStyle.Fill;
            lblP1.Location = new Point(0, 0);
            lblP1.Margin = new Padding(0);
            lblP1.Name = "lblP1";
            lblP1.Size = new Size(20, 23);
            lblP1.TabIndex = 0;
            lblP1.Text = "₱1";
            lblP1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbP1
            // 
            tbP1.Dock = DockStyle.Fill;
            tbP1.Location = new Point(20, 0);
            tbP1.Margin = new Padding(0);
            tbP1.Name = "tbP1";
            tbP1.ReadOnly = true;
            tbP1.Size = new Size(38, 23);
            tbP1.TabIndex = 1;
            // 
            // pnP5
            // 
            pnP5.AutoSize = true;
            pnP5.ColumnCount = 2;
            pnP5.ColumnStyles.Add(new ColumnStyle());
            pnP5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnP5.Controls.Add(lblP5, 0, 0);
            pnP5.Controls.Add(tbP5, 1, 0);
            pnP5.Dock = DockStyle.Fill;
            pnP5.Location = new Point(264, 0);
            pnP5.Margin = new Padding(0, 0, 8, 0);
            pnP5.Name = "pnP5";
            pnP5.RowCount = 1;
            pnP5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnP5.Size = new Size(58, 23);
            pnP5.TabIndex = 1;
            // 
            // lblP5
            // 
            lblP5.AutoSize = true;
            lblP5.Dock = DockStyle.Fill;
            lblP5.Location = new Point(0, 0);
            lblP5.Margin = new Padding(0);
            lblP5.Name = "lblP5";
            lblP5.Size = new Size(20, 23);
            lblP5.TabIndex = 0;
            lblP5.Text = "₱5";
            lblP5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbP5
            // 
            tbP5.Dock = DockStyle.Fill;
            tbP5.Location = new Point(20, 0);
            tbP5.Margin = new Padding(0);
            tbP5.Name = "tbP5";
            tbP5.ReadOnly = true;
            tbP5.Size = new Size(38, 23);
            tbP5.TabIndex = 1;
            // 
            // pnP10
            // 
            pnP10.AutoSize = true;
            pnP10.ColumnCount = 2;
            pnP10.ColumnStyles.Add(new ColumnStyle());
            pnP10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnP10.Controls.Add(lblP10, 0, 0);
            pnP10.Controls.Add(tbP10, 1, 0);
            pnP10.Dock = DockStyle.Fill;
            pnP10.Location = new Point(330, 0);
            pnP10.Margin = new Padding(0);
            pnP10.Name = "pnP10";
            pnP10.RowCount = 1;
            pnP10.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnP10.Size = new Size(70, 23);
            pnP10.TabIndex = 0;
            // 
            // lblP10
            // 
            lblP10.AutoSize = true;
            lblP10.Dock = DockStyle.Fill;
            lblP10.Location = new Point(0, 0);
            lblP10.Margin = new Padding(0);
            lblP10.Name = "lblP10";
            lblP10.Size = new Size(26, 23);
            lblP10.TabIndex = 0;
            lblP10.Text = "₱10";
            lblP10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbP10
            // 
            tbP10.Dock = DockStyle.Fill;
            tbP10.Location = new Point(26, 0);
            tbP10.Margin = new Padding(0);
            tbP10.Name = "tbP10";
            tbP10.ReadOnly = true;
            tbP10.Size = new Size(44, 23);
            tbP10.TabIndex = 1;
            // 
            // pnTotal
            // 
            pnTotal.AutoSize = true;
            pnTotal.ColumnCount = 2;
            pnTotal.ColumnStyles.Add(new ColumnStyle());
            pnTotal.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            pnTotal.Controls.Add(lblTotal, 0, 0);
            pnTotal.Controls.Add(tbTotal, 1, 0);
            pnTotal.Dock = DockStyle.Fill;
            pnTotal.Location = new Point(0, 31);
            pnTotal.Margin = new Padding(0);
            pnTotal.Name = "pnTotal";
            pnTotal.RowCount = 1;
            pnTotal.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnTotal.Size = new Size(400, 23);
            pnTotal.TabIndex = 1;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Dock = DockStyle.Fill;
            lblTotal.Location = new Point(0, 0);
            lblTotal.Margin = new Padding(0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(32, 23);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "Total";
            lblTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbTotal
            // 
            tbTotal.Dock = DockStyle.Fill;
            tbTotal.Location = new Point(32, 0);
            tbTotal.Margin = new Padding(0);
            tbTotal.Name = "tbTotal";
            tbTotal.ReadOnly = true;
            tbTotal.Size = new Size(368, 23);
            tbTotal.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 513);
            Controls.Add(pnBase);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coins Activity";
            pnBase.ResumeLayout(false);
            pnBase.PerformLayout();
            pnImage.ResumeLayout(false);
            pnImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            pnButtons.ResumeLayout(false);
            pnResult.ResumeLayout(false);
            pnResult.PerformLayout();
            pnDenominations.ResumeLayout(false);
            pnDenominations.PerformLayout();
            pnC5.ResumeLayout(false);
            pnC5.PerformLayout();
            pnC10.ResumeLayout(false);
            pnC10.PerformLayout();
            pnC25.ResumeLayout(false);
            pnC25.PerformLayout();
            pnP1.ResumeLayout(false);
            pnP1.PerformLayout();
            pnP5.ResumeLayout(false);
            pnP5.PerformLayout();
            pnP10.ResumeLayout(false);
            pnP10.PerformLayout();
            pnTotal.ResumeLayout(false);
            pnTotal.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel pnBase;
        private TableLayoutPanel pnImage;
        private PictureBox pbImage;
        private Button btnChooseImage;
        private TableLayoutPanel pnButtons;
        private Button btnCount;
        private TableLayoutPanel pnResult;
        private TableLayoutPanel pnDenominations;
        private TableLayoutPanel pnC5;
        private Label lblC5;
        private TextBox tbC5;
        private TableLayoutPanel pnC10;
        private Label lblC10;
        private TextBox tbC10;
        private TableLayoutPanel pnC25;
        private Label lblC25;
        private TextBox tbC25;
        private TableLayoutPanel pnP1;
        private Label lblP1;
        private TextBox tbP1;
        private TableLayoutPanel pnP5;
        private Label lblP5;
        private TextBox tbP5;
        private TableLayoutPanel pnP10;
        private Label lblP10;
        private TextBox tbP10;
        private TableLayoutPanel pnTotal;
        private Label lblTotal;
        private TextBox tbTotal;
    }
}
