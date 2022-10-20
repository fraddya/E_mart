
namespace E_mart
{
    partial class Stock
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_stock = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_stock = new System.Windows.Forms.TextBox();
            this.combox_stocktype = new System.Windows.Forms.ComboBox();
            this.btn_viewS = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(342, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 487);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_stock.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_stock.IconColor = System.Drawing.Color.Black;
            this.btn_stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_stock.Location = new System.Drawing.Point(601, 539);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(189, 47);
            this.btn_stock.TabIndex = 1;
            this.btn_stock.Text = "View All Stock";
            this.btn_stock.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.txt_stock);
            this.panel1.Controls.Add(this.combox_stocktype);
            this.panel1.Controls.Add(this.btn_viewS);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 598);
            this.panel1.TabIndex = 2;
            // 
            // txt_stock
            // 
            this.txt_stock.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_stock.Location = new System.Drawing.Point(56, 262);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(180, 33);
            this.txt_stock.TabIndex = 6;
            // 
            // combox_stocktype
            // 
            this.combox_stocktype.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_stocktype.FormattingEnabled = true;
            this.combox_stocktype.Items.AddRange(new object[] {
            "By Product ID",
            "By Product Name"});
            this.combox_stocktype.Location = new System.Drawing.Point(56, 186);
            this.combox_stocktype.Name = "combox_stocktype";
            this.combox_stocktype.Size = new System.Drawing.Size(180, 29);
            this.combox_stocktype.TabIndex = 5;
            // 
            // btn_viewS
            // 
            this.btn_viewS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_viewS.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewS.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_viewS.IconColor = System.Drawing.Color.Black;
            this.btn_viewS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_viewS.Location = new System.Drawing.Point(56, 353);
            this.btn_viewS.Name = "btn_viewS";
            this.btn_viewS.Size = new System.Drawing.Size(180, 37);
            this.btn_viewS.TabIndex = 4;
            this.btn_viewS.Text = "View Stock";
            this.btn_viewS.UseVisualStyleBackColor = false;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1096, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stock";
            this.Text = "Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton btn_stock;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_stock;
        private System.Windows.Forms.ComboBox combox_stocktype;
        private FontAwesome.Sharp.IconButton btn_viewS;
    }
}