﻿namespace Programming3Home
{
    partial class RemoveConfirmation
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
            this.label1 = new System.Windows.Forms.Label();
            this.removeyes = new System.Windows.Forms.Button();
            this.removeno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to Remove this Client from the Database?";
            // 
            // removeyes
            // 
            this.removeyes.Location = new System.Drawing.Point(98, 84);
            this.removeyes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeyes.Name = "removeyes";
            this.removeyes.Size = new System.Drawing.Size(56, 19);
            this.removeyes.TabIndex = 1;
            this.removeyes.Text = "Yes";
            this.removeyes.UseVisualStyleBackColor = true;
            this.removeyes.Click += new System.EventHandler(this.removeyes_Click);
            // 
            // removeno
            // 
            this.removeno.Location = new System.Drawing.Point(225, 84);
            this.removeno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.removeno.Name = "removeno";
            this.removeno.Size = new System.Drawing.Size(56, 19);
            this.removeno.TabIndex = 2;
            this.removeno.Text = "No";
            this.removeno.UseVisualStyleBackColor = true;
            this.removeno.Click += new System.EventHandler(this.removeno_Click_1);
            // 
            // RemoveConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(393, 175);
            this.Controls.Add(this.removeno);
            this.Controls.Add(this.removeyes);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RemoveConfirmation";
            this.Text = "RemoveConfirmation";
            this.Load += new System.EventHandler(this.RemoveConfirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button removeyes;
        private System.Windows.Forms.Button removeno;
    }
}