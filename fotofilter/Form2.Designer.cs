﻿namespace fotofilter
{
    partial class Form2
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
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.trackBarG = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            this.buttonOkay = new System.Windows.Forms.Button();
            this.buttonNotOk = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorPreview = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarR
            // 
            this.trackBarR.Location = new System.Drawing.Point(92, 12);
            this.trackBarR.Maximum = 255;
            this.trackBarR.Minimum = -255;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(178, 56);
            this.trackBarR.TabIndex = 0;
            this.trackBarR.ValueChanged += new System.EventHandler(this.trackBarR_ValueChanged);
            // 
            // trackBarG
            // 
            this.trackBarG.Location = new System.Drawing.Point(92, 74);
            this.trackBarG.Maximum = 255;
            this.trackBarG.Minimum = -255;
            this.trackBarG.Name = "trackBarG";
            this.trackBarG.Size = new System.Drawing.Size(178, 56);
            this.trackBarG.TabIndex = 1;
            this.trackBarG.ValueChanged += new System.EventHandler(this.trackBarG_ValueChanged);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(92, 136);
            this.trackBarB.Maximum = 255;
            this.trackBarB.Minimum = -255;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(178, 56);
            this.trackBarB.TabIndex = 2;
            this.trackBarB.ValueChanged += new System.EventHandler(this.trackBarB_ValueChanged);
            // 
            // buttonOkay
            // 
            this.buttonOkay.Location = new System.Drawing.Point(13, 205);
            this.buttonOkay.Name = "buttonOkay";
            this.buttonOkay.Size = new System.Drawing.Size(75, 23);
            this.buttonOkay.TabIndex = 3;
            this.buttonOkay.Text = "Confirm";
            this.buttonOkay.UseVisualStyleBackColor = true;
            this.buttonOkay.Click += new System.EventHandler(this.buttonOkay_Click);
            // 
            // buttonNotOk
            // 
            this.buttonNotOk.Location = new System.Drawing.Point(94, 205);
            this.buttonNotOk.Name = "buttonNotOk";
            this.buttonNotOk.Size = new System.Drawing.Size(75, 23);
            this.buttonNotOk.TabIndex = 4;
            this.buttonNotOk.Text = "Cancel";
            this.buttonNotOk.UseVisualStyleBackColor = true;
            this.buttonNotOk.Click += new System.EventHandler(this.buttonNotOk_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // colorPreview
            // 
            this.colorPreview.BackColor = System.Drawing.SystemColors.Control;
            this.colorPreview.Location = new System.Drawing.Point(176, 190);
            this.colorPreview.Name = "colorPreview";
            this.colorPreview.Size = new System.Drawing.Size(36, 37);
            this.colorPreview.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.colorPreview);
            this.Controls.Add(this.buttonNotOk);
            this.Controls.Add(this.buttonOkay);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarG);
            this.Controls.Add(this.trackBarR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TrackBar trackBarR;
        public System.Windows.Forms.TrackBar trackBarG;
        public System.Windows.Forms.TrackBar trackBarB;
        private System.Windows.Forms.Button buttonOkay;
        private System.Windows.Forms.Button buttonNotOk;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Panel colorPreview;
    }
}