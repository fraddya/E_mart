
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
            this.txt_emp = new System.Windows.Forms.TextBox();
            this.combox_emp = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_addemp = new FontAwesome.Sharp.IconButton();
            this.btn_viewE = new FontAwesome.Sharp.IconButton();
            this.btn_stock = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_emp);
            this.panel1.Controls.Add(this.combox_emp);
            this.panel1.Controls.Add(this.btn_viewE);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 598);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_addemp);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 303);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 295);
            this.panel2.TabIndex = 7;
            // 
            // txt_emp
            // 
            this.txt_emp.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emp.Location = new System.Drawing.Point(43, 121);
            this.txt_emp.Name = "txt_emp";
            this.txt_emp.Size = new System.Drawing.Size(180, 33);
            this.txt_emp.TabIndex = 6;
            // 
            // combox_emp
            // 
            this.combox_emp.FormattingEnabled = true;
            this.combox_emp.Items.AddRange(new object[] {
            "View Employer by ID",
            "Vive Employer by Name"});
            this.combox_emp.Location = new System.Drawing.Point(43, 54);
            this.combox_emp.Name = "combox_emp";
            this.combox_emp.Size = new System.Drawing.Size(180, 21);
            this.combox_emp.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(284, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(721, 487);
            this.dataGridView1.TabIndex = 3;
            // 
            // btn_addemp
            // 
            this.btn_addemp.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addemp.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_addemp.IconColor = System.Drawing.Color.Black;
            this.btn_addemp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_addemp.Location = new System.Drawing.Point(43, 106);
            this.btn_addemp.Name = "btn_addemp";
            this.btn_addemp.Size = new System.Drawing.Size(180, 83);
            this.btn_addemp.TabIndex = 5;
            this.btn_addemp.Text = "Employer Registration";
            this.btn_addemp.UseVisualStyleBackColor = true;
            this.btn_addemp.Click += new System.EventHandler(this.btn_addemp_Click);
            // 
            // btn_viewE
            // 
            this.btn_viewE.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewE.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_viewE.IconColor = System.Drawing.Color.Black;
            this.btn_viewE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_viewE.Location = new System.Drawing.Point(43, 211);
            this.btn_viewE.Name = "btn_viewE";
            this.btn_viewE.Size = new System.Drawing.Size(180, 37);
            this.btn_viewE.TabIndex = 4;
            this.btn_viewE.Text = "View Employer";
            this.btn_viewE.UseVisualStyleBackColor = true;
            this.btn_viewE.Click += new System.EventHandler(this.btn_viewE_Click);
            // 
            // btn_stock
            // 
            this.btn_stock.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stock.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_stock.IconColor = System.Drawing.Color.Black;
            this.btn_stock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_stock.Location = new System.Drawing.Point(555, 528);
            this.btn_stock.Name = "btn_stock";
            this.btn_stock.Size = new System.Drawing.Size(189, 47);
            this.btn_stock.TabIndex = 4;
            this.btn_stock.Text = "View All Employer";
            this.btn_stock.UseVisualStyleBackColor = true;
            this.btn_stock.Click += new System.EventHandler(this.btn_stock_Click);
            // 
            // Manage_emp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_stock);
            this.Controls.Add(this.dataGridView1);
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
    }
}