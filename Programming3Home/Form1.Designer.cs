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
            this.ClientDataTable = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddClientButton = new System.Windows.Forms.Button();
            this.RemoveClientButton = new System.Windows.Forms.Button();
            this.PrintClientButton = new System.Windows.Forms.Button();
            this.OrderClientButton = new System.Windows.Forms.Button();
            this.SaveClientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Client Registration System";
            // 
            // ClientDataTable
            // 
            this.ClientDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataTable.Location = new System.Drawing.Point(40, 167);
            this.ClientDataTable.Margin = new System.Windows.Forms.Padding(2);
            this.ClientDataTable.Name = "ClientDataTable";
            this.ClientDataTable.RowHeadersWidth = 57;
            this.ClientDataTable.RowTemplate.Height = 24;
            this.ClientDataTable.Size = new System.Drawing.Size(399, 240);
            this.ClientDataTable.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 118);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 20);
            this.textBox1.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SearchButton.Location = new System.Drawing.Point(337, 116);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(56, 19);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(486, 167);
            this.AddClientButton.Margin = new System.Windows.Forms.Padding(2);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(178, 40);
            this.AddClientButton.TabIndex = 4;
            this.AddClientButton.Text = "Add New Client Details/Record";
            this.AddClientButton.UseVisualStyleBackColor = true;
            // 
            // RemoveClientButton
            // 
            this.RemoveClientButton.Location = new System.Drawing.Point(486, 228);
            this.RemoveClientButton.Margin = new System.Windows.Forms.Padding(2);
            this.RemoveClientButton.Name = "RemoveClientButton";
            this.RemoveClientButton.Size = new System.Drawing.Size(178, 39);
            this.RemoveClientButton.TabIndex = 5;
            this.RemoveClientButton.Text = "Remove Selected Client Details/Record ";
            this.RemoveClientButton.UseVisualStyleBackColor = true;
            // 
            // PrintClientButton
            // 
            this.PrintClientButton.Location = new System.Drawing.Point(486, 290);
            this.PrintClientButton.Margin = new System.Windows.Forms.Padding(2);
            this.PrintClientButton.Name = "PrintClientButton";
            this.PrintClientButton.Size = new System.Drawing.Size(178, 39);
            this.PrintClientButton.TabIndex = 6;
            this.PrintClientButton.Text = "Print Client Details/Record";
            this.PrintClientButton.UseVisualStyleBackColor = true;
            // 
            // OrderClientButton
            // 
            this.OrderClientButton.Location = new System.Drawing.Point(486, 116);
            this.OrderClientButton.Margin = new System.Windows.Forms.Padding(2);
            this.OrderClientButton.Name = "OrderClientButton";
            this.OrderClientButton.Size = new System.Drawing.Size(178, 32);
            this.OrderClientButton.TabIndex = 7;
            this.OrderClientButton.Text = "Order Clients by Detail";
            this.OrderClientButton.UseVisualStyleBackColor = true;
            // 
            // SaveClientButton
            // 
            this.SaveClientButton.Location = new System.Drawing.Point(486, 362);
            this.SaveClientButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveClientButton.Name = "SaveClientButton";
            this.SaveClientButton.Size = new System.Drawing.Size(91, 44);
            this.SaveClientButton.TabIndex = 8;
            this.SaveClientButton.Text = "Save Client Details";
            this.SaveClientButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1230, 606);
            this.Controls.Add(this.SaveClientButton);
            this.Controls.Add(this.OrderClientButton);
            this.Controls.Add(this.PrintClientButton);
            this.Controls.Add(this.RemoveClientButton);
            this.Controls.Add(this.AddClientButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ClientDataTable);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1246, 645);
            this.Name = "Form1";
            this.Text = "Home - Client Registration System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseHover += new System.EventHandler(this.Form1_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ClientDataTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button AddClientButton;
        private System.Windows.Forms.Button RemoveClientButton;
        private System.Windows.Forms.Button PrintClientButton;
        private System.Windows.Forms.Button OrderClientButton;
        private System.Windows.Forms.Button SaveClientButton;
    }
}

