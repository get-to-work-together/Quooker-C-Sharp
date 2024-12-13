namespace DemoBlinker
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
            tableLayoutPanel1 = new TableLayoutPanel();
            lblLed5 = new Label();
            lblLed3 = new Label();
            lblLed2 = new Label();
            lblLed1 = new Label();
            btnStart5 = new Button();
            btnStart4 = new Button();
            btnStart3 = new Button();
            btnStart2 = new Button();
            btnStart1 = new Button();
            lblTitle = new Label();
            lblLed4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(lblLed5, 4, 5);
            tableLayoutPanel1.Controls.Add(lblLed3, 4, 2);
            tableLayoutPanel1.Controls.Add(lblLed2, 4, 3);
            tableLayoutPanel1.Controls.Add(lblLed1, 4, 4);
            tableLayoutPanel1.Controls.Add(btnStart5, 0, 5);
            tableLayoutPanel1.Controls.Add(btnStart4, 0, 4);
            tableLayoutPanel1.Controls.Add(btnStart3, 0, 3);
            tableLayoutPanel1.Controls.Add(btnStart2, 0, 2);
            tableLayoutPanel1.Controls.Add(btnStart1, 0, 1);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblLed4, 4, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1425, 1066);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblLed5
            // 
            lblLed5.AutoSize = true;
            lblLed5.Dock = DockStyle.Right;
            lblLed5.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLed5.ForeColor = Color.ForestGreen;
            lblLed5.Location = new Point(1275, 912);
            lblLed5.Margin = new Padding(100, 40, 40, 40);
            lblLed5.Name = "lblLed5";
            lblLed5.Size = new Size(110, 114);
            lblLed5.TabIndex = 15;
            lblLed5.Text = "o";
            lblLed5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLed3
            // 
            lblLed3.AutoSize = true;
            lblLed3.Dock = DockStyle.Right;
            lblLed3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLed3.ForeColor = Color.ForestGreen;
            lblLed3.Location = new Point(1275, 333);
            lblLed3.Margin = new Padding(100, 40, 40, 40);
            lblLed3.Name = "lblLed3";
            lblLed3.Size = new Size(110, 113);
            lblLed3.TabIndex = 14;
            lblLed3.Text = "o";
            lblLed3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLed2
            // 
            lblLed2.AutoSize = true;
            lblLed2.Dock = DockStyle.Right;
            lblLed2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLed2.ForeColor = Color.ForestGreen;
            lblLed2.Location = new Point(1275, 526);
            lblLed2.Margin = new Padding(100, 40, 40, 40);
            lblLed2.Name = "lblLed2";
            lblLed2.Size = new Size(110, 113);
            lblLed2.TabIndex = 13;
            lblLed2.Text = "o";
            lblLed2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLed1
            // 
            lblLed1.AutoSize = true;
            lblLed1.Dock = DockStyle.Right;
            lblLed1.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLed1.ForeColor = Color.ForestGreen;
            lblLed1.Location = new Point(1275, 719);
            lblLed1.Margin = new Padding(100, 40, 40, 40);
            lblLed1.Name = "lblLed1";
            lblLed1.Size = new Size(110, 113);
            lblLed1.TabIndex = 12;
            lblLed1.Text = "o";
            lblLed1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnStart5
            // 
            btnStart5.Dock = DockStyle.Fill;
            btnStart5.Location = new Point(50, 922);
            btnStart5.Margin = new Padding(50);
            btnStart5.Name = "btnStart5";
            btnStart5.Size = new Size(185, 94);
            btnStart5.TabIndex = 4;
            btnStart5.Text = "button5";
            btnStart5.UseVisualStyleBackColor = true;
            // 
            // btnStart4
            // 
            btnStart4.Dock = DockStyle.Fill;
            btnStart4.Location = new Point(50, 729);
            btnStart4.Margin = new Padding(50);
            btnStart4.Name = "btnStart4";
            btnStart4.Size = new Size(185, 93);
            btnStart4.TabIndex = 3;
            btnStart4.Text = "button4";
            btnStart4.UseVisualStyleBackColor = true;
            // 
            // btnStart3
            // 
            btnStart3.Dock = DockStyle.Fill;
            btnStart3.Location = new Point(50, 536);
            btnStart3.Margin = new Padding(50);
            btnStart3.Name = "btnStart3";
            btnStart3.Size = new Size(185, 93);
            btnStart3.TabIndex = 2;
            btnStart3.Text = "button3";
            btnStart3.UseVisualStyleBackColor = true;
            // 
            // btnStart2
            // 
            btnStart2.Dock = DockStyle.Fill;
            btnStart2.Location = new Point(50, 343);
            btnStart2.Margin = new Padding(50);
            btnStart2.Name = "btnStart2";
            btnStart2.Size = new Size(185, 93);
            btnStart2.TabIndex = 1;
            btnStart2.Text = "button2";
            btnStart2.UseVisualStyleBackColor = true;
            // 
            // btnStart1
            // 
            btnStart1.Dock = DockStyle.Fill;
            btnStart1.Location = new Point(50, 150);
            btnStart1.Margin = new Padding(50);
            btnStart1.Name = "btnStart1";
            btnStart1.Size = new Size(185, 93);
            btnStart1.TabIndex = 0;
            btnStart1.Text = "button1";
            btnStart1.UseVisualStyleBackColor = true;
            btnStart1.Click += btnStart1_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(lblTitle, 5);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 19.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(1419, 100);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Blinker";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLed4
            // 
            lblLed4.AutoSize = true;
            lblLed4.Dock = DockStyle.Right;
            lblLed4.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLed4.ForeColor = Color.ForestGreen;
            lblLed4.Location = new Point(1275, 140);
            lblLed4.Margin = new Padding(100, 40, 40, 40);
            lblLed4.Name = "lblLed4";
            lblLed4.Size = new Size(110, 113);
            lblLed4.TabIndex = 11;
            lblLed4.Text = "o";
            lblLed4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1425, 1066);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnStart4;
        private Button btnStart3;
        private Button btnStart2;
        private Button btnStart1;
        private Button btnStart5;
        private Label lblTitle;
        private Label lblLed4;
        private Label lblLed5;
        private Label lblLed3;
        private Label lblLed2;
        private Label lblLed1;
    }
}
