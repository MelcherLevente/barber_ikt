﻿namespace mainForm.Forms
{
    partial class appointment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.homebutton = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homebutton)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.homebutton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 100);
            this.panel1.TabIndex = 3;
            // 
            // homebutton
            // 
            this.homebutton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.homebutton.Image = global::mainForm.Properties.Resources.homebutton;
            this.homebutton.Location = new System.Drawing.Point(38, 25);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(50, 50);
            this.homebutton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homebutton.TabIndex = 2;
            this.homebutton.TabStop = false;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(319, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 100);
            this.label2.TabIndex = 1;
            this.label2.Text = "Foglalás";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 20F);
            this.button1.Location = new System.Drawing.Point(95, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(292, 80);
            this.button1.TabIndex = 4;
            this.button1.Text = "FOGLALÁS MEGKEZDÉSE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 20F);
            this.button2.Location = new System.Drawing.Point(503, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(359, 80);
            this.button2.TabIndex = 5;
            this.button2.Text = "BORBÉLY KERESÉSE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label1.Location = new System.Drawing.Point(72, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 46);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tudom kit válasszak";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 30F);
            this.label3.Location = new System.Drawing.Point(484, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(423, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nem tudom kit válasszak";
            // 
            // appointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appointment";
            this.Text = "appointment";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homebutton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox homebutton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}