namespace fotofilter
{
    partial class Brightness
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
            this.trackBarBright = new System.Windows.Forms.TrackBar();
            this.buttonNotOk = new System.Windows.Forms.Button();
            this.buttonOkay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBright)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarBright
            // 
            this.trackBarBright.Location = new System.Drawing.Point(12, 12);
            this.trackBarBright.Maximum = 255;
            this.trackBarBright.Minimum = -255;
            this.trackBarBright.Name = "trackBarBright";
            this.trackBarBright.Size = new System.Drawing.Size(178, 56);
            this.trackBarBright.TabIndex = 1;
            // 
            // buttonNotOk
            // 
            this.buttonNotOk.Location = new System.Drawing.Point(105, 56);
            this.buttonNotOk.Name = "buttonNotOk";
            this.buttonNotOk.Size = new System.Drawing.Size(85, 34);
            this.buttonNotOk.TabIndex = 6;
            this.buttonNotOk.Text = "Cancel";
            this.buttonNotOk.UseVisualStyleBackColor = true;
            this.buttonNotOk.Click += new System.EventHandler(this.buttonNotOk_Click_1);
            // 
            // buttonOkay
            // 
            this.buttonOkay.Location = new System.Drawing.Point(12, 56);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(87, 34);
            this.buttonOkay.TabIndex = 5;
            this.buttonOkay.Text = "Confirm";
            this.buttonOkay.UseVisualStyleBackColor = true;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click_1);
            // 
            // Brightness
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 102);
            this.Controls.Add(this.buttonNotOk);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.trackBarBright);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Brightness";
            this.Text = "Brightness";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBright)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar trackBarBright;
        public System.Windows.Forms.Button buttonNotOk;
        public System.Windows.Forms.Button buttonOkay;
    }
}