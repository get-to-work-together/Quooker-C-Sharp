namespace CharCounter
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
            this.btnRead = new System.Windows.Forms.Button();
            this.lvChars = new System.Windows.Forms.ListView();
            this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCount = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(583, 40);
            this.btnRead.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(195, 44);
            this.btnRead.TabIndex = 7;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // lvChars
            // 
            this.lvChars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.columnHeader3});
            this.lvChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvChars.HideSelection = false;
            this.lvChars.Location = new System.Drawing.Point(822, 21);
            this.lvChars.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lvChars.Name = "lvChars";
            this.lvChars.Size = new System.Drawing.Size(404, 569);
            this.lvChars.TabIndex = 6;
            this.lvChars.UseCompatibleStateImageBehavior = false;
            this.lvChars.View = System.Windows.Forms.View.Details;
            // 
            // ColumnHeader1
            // 
            this.ColumnHeader1.Text = "Character";
            // 
            // ColumnHeader2
            // 
            this.ColumnHeader2.Text = "Upper";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lower";
            // 
            // btnCount
            // 
            this.btnCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCount.Location = new System.Drawing.Point(26, 40);
            this.btnCount.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(150, 44);
            this.btnCount.TabIndex = 5;
            this.btnCount.Text = "Count Now";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // txtText
            // 
            this.txtText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtText.Location = new System.Drawing.Point(26, 113);
            this.txtText.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtText.Size = new System.Drawing.Size(748, 477);
            this.txtText.TabIndex = 4;
            this.txtText.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 613);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.lvChars);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.txtText);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Character Counter";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Button btnRead;
    internal System.Windows.Forms.ListView lvChars;
    internal System.Windows.Forms.ColumnHeader ColumnHeader1;
    internal System.Windows.Forms.ColumnHeader ColumnHeader2;
    internal System.Windows.Forms.Button btnCount;
    internal System.Windows.Forms.TextBox txtText;
    private System.Windows.Forms.ColumnHeader columnHeader3;
  }
}

