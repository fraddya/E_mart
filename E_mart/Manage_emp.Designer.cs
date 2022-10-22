
namespace E_mart
{
    partial class Manage_emp
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_addemp = new FontAwesome.Sharp.IconButton();
            this.txt_emp = new System.Windows.Forms.TextBox();
            this.combox_emp = new System.Windows.Forms.ComboBox();
            this.btn_viewE = new FontAwesome.Sharp.IconButton();
            this.btn_stock = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.lbl_1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_emp);
            this.panel1.Controls.Add(this.combox_emp);
            this.panel1.Controls.Add(this.btn_viewE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 736);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_addemp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 373);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(371, 363);
            this.panel2.TabIndex = 7;
            // 
            // btn_addemp
            // 
            this.btn_addemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_addemp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addemp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_addemp.IconColor = System.Drawing.Color.Black;
            this.btn_addemp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_addemp.Location = new System.Drawing.Point(57, 130);
            this.btn_addemp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_addemp.Name = "btn_addemp";
            this.btn_addemp.Size = new System.Drawing.Size(240, 102);
            this.btn_addemp.TabIndex = 5;
            this.btn_addemp.Text = "Employer Registration";
            this.btn_addemp.UseVisualStyleBackColor = false;
            this.btn_addemp.Click += new System.EventHandler(this.btn_addemp_Click);
            // 
            // txt_emp
            // 
            this.txt_emp.BackColor = System.Drawing.Color.Silver;
            this.txt_emp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp.Location = new System.Drawing.Point(57, 160);
            this.txt_emp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_emp.Name = "txt_emp";
            this.txt_emp.Size = new System.Drawing.Size(239, 39);
            this.txt_emp.TabIndex = 6;
            // 
            // combox_emp
            // 
            this.combox_emp.BackColor = System.Drawing.Color.Silver;
            this.combox_emp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_emp.FormattingEnabled = true;
            this.combox_emp.Items.AddRange(new object[] {
            "View Employer by ID",
            "Vive Employer by Name",
            "Remove Employer"});
            this.combox_emp.Location = new System.Drawing.Point(57, 66);
            this.combox_emp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combox_emp.Name = "combox_emp";
            this.combox_emp.Size = new System.Drawing.Size(239, 36);
            this.combox_emp.TabIndex = 5;
            // 
            // btn_viewE
            // 
            this.btn_viewE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_viewE.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewE.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_viewE.IconColor = System.Drawing.Color.Black;
            this.btn_viewE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_viewE.Location = new System.Drawing.Point(57, 272);
            this.btn_viewE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_viewE.Name = "btn_viewE";
            this.btn_viewE.Size = new System.Drawing.Size(240, 46);
            this.btn_viewE.TabIndex = 4;
            this.btn_viewE.Text = "Accept";
            this.btn_viewE.UseVisualStyleBackColor = false;
            this.btn_viewE.Click += new System.EventHandler(this.btn_viewE_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_stock.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_stock.IconColor = System.Drawing.Color.Black;
            this.btn_stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_stock.Location = new System.Drawing.Point(824, 663);
            this.btn_stock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(252, 58);
            this.btn_stock.TabIndex = 4;
            this.btn_stock.Text = "View All Employer";
            this.btn_stock.UseVisualStyleBackColor = false;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(399, 43);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1041, 599);
            this.dataGridView1.TabIndex = 3;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.ForeColor = System.Drawing.Color.Red;
            this.lbl_1.Location = new System.Drawing.Point(98, 225);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(0, 18);
            this.lbl_1.TabIndex = 8;
            // 
            // Manage_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1461, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Manage_emp";
            this.Text = "Manage_emp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btn_addemp;
        private System.Windows.Forms.TextBox txt_emp;
        private System.Windows.Forms.ComboBox combox_emp;
        private FontAwesome.Sharp.IconButton btn_viewE;
        private FontAwesome.Sharp.IconButton btn_stock;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_1;
    }
}