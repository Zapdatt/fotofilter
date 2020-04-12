namespace fotofilter
{
    partial class Amount
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
            this.buttonNotOk = new System.Windows.Forms.Button();
            this.buttonOkay = new System.Windows.Forms.Button();
            this.trackBarAmount = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNotOk
            // 
            this.buttonNotOk.Location = new System.Drawing.Point(113, 56);
            this.buttonNotOk.Name = "buttonNotOk";
            this.buttonNotOk.Size = new System.Drawing.Size(85, 34);
            this.buttonNotOk.TabIndex = 9;
            this.buttonNotOk.Text = "Cancel";
            this.buttonNotOk.UseVisualStyleBackColor = true;
            this.buttonNotOk.Click += new System.EventHandler(this.buttonNotOk_Click);
            // 
            // buttonOkay
            // 
            this.buttonOkay.Location = new System.Drawing.Point(20, 56);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(87, 34);
            this.buttonOkay.TabIndex = 8;
            this.buttonOkay.Text = "Confirm";
            this.buttonOkay.UseVisualStyleBackColor = true;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
            // 
            // trackBarAmount
            // 
            this.trackBarAmount.Location = new System.Drawing.Point(20, 12);
            this.trackBarAmount.Maximum = 100;
            this.trackBarAmount.Name = "trackBarAmount";
            this.trackBarAmount.Size = new System.Drawing.Size(178, 56);
            this.trackBarAmount.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "100";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "0";
            // 
            // Amount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 101);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNotOk);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.trackBarAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Amount";
            this.Text = "Amount";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button buttonNotOk;
        public System.Windows.Forms.Button buttonOkay;
        public System.Windows.Forms.TrackBar trackBarAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}