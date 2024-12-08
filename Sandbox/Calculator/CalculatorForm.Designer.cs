using System.Xml.Linq;

namespace Calculator
{
    partial class CalculatorForm
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
            key1 = new Button();
            key2 = new Button();
            key3 = new Button();
            keyAdd = new Button();
            key4 = new Button();
            key5 = new Button();
            key6 = new Button();
            keySubtract = new Button();
            key7 = new Button();
            key8 = new Button();
            key9 = new Button();
            keyMultiply = new Button();
            keyClear = new Button();
            key0 = new Button();
            keyIs = new Button();
            keyDivide = new Button();
            display = new Label();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.BackColor = Color.FromArgb(0, 192, 192);
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(key1, 0, 1);
            tableLayoutPanel1.Controls.Add(key2, 1, 1);
            tableLayoutPanel1.Controls.Add(key3, 2, 1);
            tableLayoutPanel1.Controls.Add(keyAdd, 3, 1);
            tableLayoutPanel1.Controls.Add(key4, 0, 2);
            tableLayoutPanel1.Controls.Add(key5, 1, 2);
            tableLayoutPanel1.Controls.Add(key6, 2, 2);
            tableLayoutPanel1.Controls.Add(keySubtract, 3, 2);
            tableLayoutPanel1.Controls.Add(key7, 0, 3);
            tableLayoutPanel1.Controls.Add(key8, 1, 3);
            tableLayoutPanel1.Controls.Add(key9, 2, 3);
            tableLayoutPanel1.Controls.Add(keyMultiply, 3, 3);
            tableLayoutPanel1.Controls.Add(keyClear, 0, 4);
            tableLayoutPanel1.Controls.Add(key0, 1, 4);
            tableLayoutPanel1.Controls.Add(keyIs, 2, 4);
            tableLayoutPanel1.Controls.Add(keyDivide, 3, 4);
            tableLayoutPanel1.Controls.Add(display, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI", 19.875F);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(5);
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(563, 752);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // key1
            // 
            key1.AutoSize = true;
            key1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key1.BackColor = Color.FromArgb(0, 192, 192);
            key1.Dock = DockStyle.Fill;
            key1.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key1.Location = new Point(8, 156);
            key1.Name = "key1";
            key1.Size = new Size(132, 142);
            key1.TabIndex = 5;
            key1.Text = "1";
            key1.UseVisualStyleBackColor = false;
            key1.Click += HandleButtonClick;
            // 
            // key2
            // 
            key2.AutoSize = true;
            key2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key2.BackColor = Color.FromArgb(0, 192, 192);
            key2.Dock = DockStyle.Fill;
            key2.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key2.Location = new Point(146, 156);
            key2.Name = "key2";
            key2.Size = new Size(132, 142);
            key2.TabIndex = 6;
            key2.Text = "2";
            key2.UseVisualStyleBackColor = false;
            key2.Click += HandleButtonClick;
            // 
            // key3
            // 
            key3.AutoSize = true;
            key3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key3.BackColor = Color.FromArgb(0, 192, 192);
            key3.Dock = DockStyle.Fill;
            key3.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key3.Location = new Point(284, 156);
            key3.Name = "key3";
            key3.Size = new Size(132, 142);
            key3.TabIndex = 7;
            key3.Text = "3";
            key3.UseVisualStyleBackColor = false;
            key3.Click += HandleButtonClick;
            // 
            // keyAdd
            // 
            keyAdd.AutoSize = true;
            keyAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            keyAdd.BackColor = Color.FromArgb(0, 192, 192);
            keyAdd.Dock = DockStyle.Fill;
            keyAdd.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            keyAdd.Location = new Point(422, 156);
            keyAdd.Name = "keyAdd";
            keyAdd.Size = new Size(133, 142);
            keyAdd.TabIndex = 8;
            keyAdd.Text = "+";
            keyAdd.UseVisualStyleBackColor = false;
            keyAdd.Click += HandleButtonClick;
            // 
            // key4
            // 
            key4.AutoSize = true;
            key4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key4.BackColor = Color.FromArgb(0, 192, 192);
            key4.Dock = DockStyle.Fill;
            key4.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key4.Location = new Point(8, 304);
            key4.Name = "key4";
            key4.Size = new Size(132, 142);
            key4.TabIndex = 9;
            key4.Text = "4";
            key4.UseVisualStyleBackColor = false;
            key4.Click += HandleButtonClick;
            // 
            // key5
            // 
            key5.AutoSize = true;
            key5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key5.BackColor = Color.FromArgb(0, 192, 192);
            key5.Dock = DockStyle.Fill;
            key5.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key5.Location = new Point(146, 304);
            key5.Name = "key5";
            key5.Size = new Size(132, 142);
            key5.TabIndex = 10;
            key5.Text = "5";
            key5.UseVisualStyleBackColor = false;
            key5.Click += HandleButtonClick;
            // 
            // key6
            // 
            key6.AutoSize = true;
            key6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key6.BackColor = Color.FromArgb(0, 192, 192);
            key6.Dock = DockStyle.Fill;
            key6.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key6.Location = new Point(284, 304);
            key6.Name = "key6";
            key6.Size = new Size(132, 142);
            key6.TabIndex = 11;
            key6.Text = "6";
            key6.UseVisualStyleBackColor = false;
            key6.Click += HandleButtonClick;
            // 
            // keySubtract
            // 
            keySubtract.AutoSize = true;
            keySubtract.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            keySubtract.BackColor = Color.FromArgb(0, 192, 192);
            keySubtract.Dock = DockStyle.Fill;
            keySubtract.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            keySubtract.Location = new Point(422, 304);
            keySubtract.Name = "keySubtract";
            keySubtract.Size = new Size(133, 142);
            keySubtract.TabIndex = 12;
            keySubtract.Text = "-";
            keySubtract.UseVisualStyleBackColor = false;
            keySubtract.Click += HandleButtonClick;
            // 
            // key7
            // 
            key7.AutoSize = true;
            key7.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key7.BackColor = Color.FromArgb(0, 192, 192);
            key7.Dock = DockStyle.Fill;
            key7.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key7.Location = new Point(8, 452);
            key7.Name = "key7";
            key7.Size = new Size(132, 142);
            key7.TabIndex = 13;
            key7.Text = "7";
            key7.UseVisualStyleBackColor = false;
            key7.Click += HandleButtonClick;
            // 
            // key8
            // 
            key8.AutoSize = true;
            key8.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key8.BackColor = Color.FromArgb(0, 192, 192);
            key8.Dock = DockStyle.Fill;
            key8.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key8.Location = new Point(146, 452);
            key8.Name = "key8";
            key8.Size = new Size(132, 142);
            key8.TabIndex = 14;
            key8.Text = "8";
            key8.UseVisualStyleBackColor = false;
            key8.Click += HandleButtonClick;
            // 
            // key9
            // 
            key9.AutoSize = true;
            key9.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key9.BackColor = Color.FromArgb(0, 192, 192);
            key9.Dock = DockStyle.Fill;
            key9.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key9.Location = new Point(284, 452);
            key9.Name = "key9";
            key9.Size = new Size(132, 142);
            key9.TabIndex = 15;
            key9.Text = "9";
            key9.UseVisualStyleBackColor = false;
            key9.Click += HandleButtonClick;
            // 
            // keyMultiply
            // 
            keyMultiply.AutoSize = true;
            keyMultiply.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            keyMultiply.BackColor = Color.FromArgb(0, 192, 192);
            keyMultiply.Dock = DockStyle.Fill;
            keyMultiply.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            keyMultiply.Location = new Point(422, 452);
            keyMultiply.Name = "keyMultiply";
            keyMultiply.Size = new Size(133, 142);
            keyMultiply.TabIndex = 16;
            keyMultiply.Text = "*";
            keyMultiply.UseVisualStyleBackColor = false;
            keyMultiply.Click += HandleButtonClick;
            // 
            // keyClear
            // 
            keyClear.AutoSize = true;
            keyClear.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            keyClear.BackColor = Color.FromArgb(0, 192, 192);
            keyClear.Dock = DockStyle.Fill;
            keyClear.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            keyClear.Location = new Point(8, 600);
            keyClear.Name = "keyClear";
            keyClear.Size = new Size(132, 144);
            keyClear.TabIndex = 17;
            keyClear.Text = "C";
            keyClear.UseVisualStyleBackColor = false;
            keyClear.Click += HandleButtonClick;
            // 
            // key0
            // 
            key0.AutoSize = true;
            key0.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            key0.BackColor = Color.FromArgb(0, 192, 192);
            key0.Dock = DockStyle.Fill;
            key0.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            key0.Location = new Point(146, 600);
            key0.Name = "key0";
            key0.Size = new Size(132, 144);
            key0.TabIndex = 18;
            key0.Text = "0";
            key0.UseVisualStyleBackColor = false;
            key0.Click += HandleButtonClick;
            // 
            // keyIs
            // 
            keyIs.AutoSize = true;
            keyIs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            keyIs.BackColor = Color.FromArgb(0, 192, 192);
            keyIs.Dock = DockStyle.Fill;
            keyIs.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            keyIs.Location = new Point(284, 600);
            keyIs.Name = "keyIs";
            keyIs.Size = new Size(132, 144);
            keyIs.TabIndex = 19;
            keyIs.Text = "=";
            keyIs.UseVisualStyleBackColor = false;
            keyIs.Click += HandleButtonClick;
            // 
            // keyDivide
            // 
            keyDivide.AutoSize = true;
            keyDivide.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            keyDivide.BackColor = Color.FromArgb(0, 192, 192);
            keyDivide.Dock = DockStyle.Fill;
            keyDivide.Font = new Font("Segoe UI", 19.875F);
            keyDivide.Location = new Point(422, 600);
            keyDivide.Name = "keyDivide";
            keyDivide.Size = new Size(133, 144);
            keyDivide.TabIndex = 20;
            keyDivide.Text = "/";
            keyDivide.UseVisualStyleBackColor = false;
            keyDivide.Click += HandleButtonClick;
            // 
            // display
            // 
            display.AutoSize = true;
            display.BackColor = Color.Black;
            tableLayoutPanel1.SetColumnSpan(display, 4);
            display.Dock = DockStyle.Fill;
            display.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            display.ForeColor = Color.Lime;
            display.Location = new Point(15, 15);
            display.Margin = new Padding(10);
            display.Name = "display";
            display.Size = new Size(533, 128);
            display.TabIndex = 21;
            display.TextAlign = ContentAlignment.MiddleRight;
            // 
            // CalculatorForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 752);
            Controls.Add(tableLayoutPanel1);
            Name = "CalculatorForm";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label display;
        private Button key1;
        private Button key2;
        private Button key3;
        private Button key4;
        private Button key5;
        private Button key6;
        private Button key7;
        private Button key8;
        private Button key9;
        private Button key0;
        private Button keyAdd;
        private Button keySubtract;
        private Button keyMultiply;
        private Button keyDivide;
        private Button keyClear;
        private Button keyIs;

        private void HandleButtonClick(object sender, EventArgs e)
        {
            string text = ((Button)sender).Text;
            processor.keyPressed(text);
            display.Text = processor.getDisplay();
        }
    }
}
