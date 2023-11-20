
namespace Programming3Home
{
    partial class Order
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
            this.orderByOptions = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.orderBy = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // orderByOptions
            // 
            this.orderByOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderByOptions.FormattingEnabled = true;
            this.orderByOptions.ItemHeight = 25;
            this.orderByOptions.Items.AddRange(new object[] {
            "Client ID",
            "First Name",
            "Last Name",
            "Address",
            "Phone",
            "Email",
            "Services ID",
            "Software Services",
            "Laptop & PC Services",
            "Game Services",
            "Office & Tool Services",
            "Accessories Services"});
            this.orderByOptions.Location = new System.Drawing.Point(12, 67);
            this.orderByOptions.Name = "orderByOptions";
            this.orderByOptions.Size = new System.Drawing.Size(325, 304);
            this.orderByOptions.TabIndex = 0;
            this.orderByOptions.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(325, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "Order";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // orderBy
            // 
            this.orderBy.AutoSize = true;
            this.orderBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderBy.ForeColor = System.Drawing.Color.White;
            this.orderBy.Location = new System.Drawing.Point(60, 22);
            this.orderBy.Name = "orderBy";
            this.orderBy.Size = new System.Drawing.Size(232, 29);
            this.orderBy.TabIndex = 2;
            this.orderBy.Text = "Order Results By...";
            this.orderBy.Click += new System.EventHandler(this.orderBy_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(349, 460);
            this.Controls.Add(this.orderBy);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.orderByOptions);
            this.Name = "Order";
            this.Text = "Order Results By...";
            this.Load += new System.EventHandler(this.Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox orderByOptions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label orderBy;
    }
}