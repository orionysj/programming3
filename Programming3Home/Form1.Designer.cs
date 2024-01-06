namespace Programming3Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.ClientDataTablehome = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.RemoveClientButton = new System.Windows.Forms.Button();
            this.PrintClientButton = new System.Windows.Forms.Button();
            this.OrderClientButton = new System.Windows.Forms.Button();
            this.SaveClientButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataTablehome)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Registration System";
            // 
            // ClientDataTablehome
            // 
            this.ClientDataTablehome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataTablehome.Location = new System.Drawing.Point(16, 100);
            this.ClientDataTablehome.Name = "ClientDataTablehome";
            this.ClientDataTablehome.RowHeadersWidth = 57;
            this.ClientDataTablehome.RowTemplate.Height = 24;
            this.ClientDataTablehome.Size = new System.Drawing.Size(654, 432);
            this.ClientDataTablehome.TabIndex = 1;
            this.ClientDataTablehome.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientDataTablehome_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(529, 22);
            this.textBox1.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchButton.Location = new System.Drawing.Point(557, 70);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(113, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(684, 119);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(237, 86);
            this.AddClientButton.TabIndex = 4;
            this.AddClientButton.Text = "Add New Client Details/Record";
            this.AddClientButton.UseVisualStyleBackColor = true;
            // 
            // RemoveClientButton
            // 
            this.RemoveClientButton.Location = new System.Drawing.Point(684, 218);
            this.RemoveClientButton.Name = "RemoveClientButton";
            this.RemoveClientButton.Size = new System.Drawing.Size(237, 90);
            this.RemoveClientButton.TabIndex = 5;
            this.RemoveClientButton.Text = "Remove Selected Client Details/Record ";
            this.RemoveClientButton.UseVisualStyleBackColor = true;
            this.RemoveClientButton.Click += new System.EventHandler(this.RemoveClientButton_Click);
            // 
            // PrintClientButton
            // 
            this.PrintClientButton.Location = new System.Drawing.Point(684, 324);
            this.PrintClientButton.Name = "PrintClientButton";
            this.PrintClientButton.Size = new System.Drawing.Size(237, 91);
            this.PrintClientButton.TabIndex = 6;
            this.PrintClientButton.Text = "Print Client Details/Record";
            this.PrintClientButton.UseVisualStyleBackColor = true;
            this.PrintClientButton.Click += new System.EventHandler(this.PrintClientButton_Click);
            // 
            // OrderClientButton
            // 
            this.OrderClientButton.Location = new System.Drawing.Point(684, 62);
            this.OrderClientButton.Name = "OrderClientButton";
            this.OrderClientButton.Size = new System.Drawing.Size(237, 40);
            this.OrderClientButton.TabIndex = 7;
            this.OrderClientButton.Text = "Order Clients by Detail";
            this.OrderClientButton.UseVisualStyleBackColor = true;
            // 
            // SaveClientButton
            // 
            this.SaveClientButton.Location = new System.Drawing.Point(742, 430);
            this.SaveClientButton.Name = "SaveClientButton";
            this.SaveClientButton.Size = new System.Drawing.Size(121, 54);
            this.SaveClientButton.TabIndex = 8;
            this.SaveClientButton.Text = "Save Client Details";
            this.SaveClientButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Search Clients:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(943, 550);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveClientButton);
            this.Controls.Add(this.OrderClientButton);
            this.Controls.Add(this.PrintClientButton);
            this.Controls.Add(this.RemoveClientButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClientDataTablehome);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Name = "Form1";
            this.Text = "Home - Client Registration System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataTablehome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ClientDataTablehome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button RemoveClientButton;
        private System.Windows.Forms.Button PrintClientButton;
        private System.Windows.Forms.Button OrderClientButton;
        private System.Windows.Forms.Button SaveClientButton;
        private System.Windows.Forms.Label label2;
    }
}

