namespace LedDriver
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
            trbRed = new TrackBar();
            trbBlue = new TrackBar();
            trbGreen = new TrackBar();
            trbSpeed = new TrackBar();
            lblLed = new Label();
            ((System.ComponentModel.ISupportInitialize)trbRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbBlue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trbSpeed).BeginInit();
            SuspendLayout();
            // 
            // trbRed
            // 
            trbRed.BackColor = Color.White;
            trbRed.Location = new Point(99, 62);
            trbRed.Maximum = 255;
            trbRed.Name = "trbRed";
            trbRed.Orientation = Orientation.Vertical;
            trbRed.Size = new Size(90, 512);
            trbRed.TabIndex = 0;
            trbRed.MouseCaptureChanged += handleColorChange;
            // 
            // trbBlue
            // 
            trbBlue.BackColor = Color.White;
            trbBlue.Location = new Point(363, 62);
            trbBlue.Maximum = 255;
            trbBlue.Name = "trbBlue";
            trbBlue.Orientation = Orientation.Vertical;
            trbBlue.Size = new Size(90, 512);
            trbBlue.TabIndex = 1;
            trbBlue.MouseCaptureChanged += handleColorChange;
            // 
            // trbGreen
            // 
            trbGreen.BackColor = Color.White;
            trbGreen.Location = new Point(233, 62);
            trbGreen.Maximum = 255;
            trbGreen.Name = "trbGreen";
            trbGreen.Orientation = Orientation.Vertical;
            trbGreen.Size = new Size(90, 512);
            trbGreen.TabIndex = 2;
            trbGreen.Scroll += trbGreen_Scroll;
            trbGreen.MouseCaptureChanged += handleColorChange;
            // 
            // trbSpeed
            // 
            trbSpeed.BackColor = Color.White;
            trbSpeed.Location = new Point(623, 62);
            trbSpeed.Maximum = 255;
            trbSpeed.Name = "trbSpeed";
            trbSpeed.Orientation = Orientation.Vertical;
            trbSpeed.Size = new Size(90, 512);
            trbSpeed.TabIndex = 3;
            // 
            // lblLed
            // 
            lblLed.BackColor = Color.Black;
            lblLed.Location = new Point(1447, 62);
            lblLed.Name = "lblLed";
            lblLed.Size = new Size(241, 215);
            lblLed.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1765, 739);
            Controls.Add(lblLed);
            Controls.Add(trbSpeed);
            Controls.Add(trbGreen);
            Controls.Add(trbBlue);
            Controls.Add(trbRed);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)trbRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbBlue).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)trbSpeed).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar trbRed;
        private TrackBar trbBlue;
        private TrackBar trbGreen;
        private TrackBar trbSpeed;
        private Label lblLed;
    }
}
