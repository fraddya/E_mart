﻿
namespace E_mart
{
    partial class Product
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
            this.btn_add = new FontAwesome.Sharp.IconButton();
            this.btn_remove = new FontAwesome.Sharp.IconButton();
            this.btn_refil = new FontAwesome.Sharp.IconButton();
            this.btn_productsubmit = new FontAwesome.Sharp.IconButton();
            this.txt_quentity = new System.Windows.Forms.TextBox();
            this.txt_queantity = new System.Windows.Forms.TextBox();
            this.txt_Pname = new System.Windows.Forms.TextBox();
            this.txt_refil = new System.Windows.Forms.TextBox();
            this.txt_Pid = new System.Windows.Forms.TextBox();
            this.rdo_product_name = new System.Windows.Forms.RadioButton();
            this.rdo_pid = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_view = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btn_add);
            this.panel1.Controls.Add(this.btn_remove);
            this.panel1.Controls.Add(this.btn_refil);
            this.panel1.Controls.Add(this.btn_productsubmit);
            this.panel1.Controls.Add(this.txt_quentity);
            this.panel1.Controls.Add(this.txt_queantity);
            this.panel1.Controls.Add(this.txt_Pname);
            this.panel1.Controls.Add(this.txt_refil);
            this.panel1.Controls.Add(this.txt_Pid);
            this.panel1.Controls.Add(this.rdo_product_name);
            this.panel1.Controls.Add(this.rdo_pid);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 920);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_add
            // 
            this.btn_add.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_add.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btn_add.IconColor = System.Drawing.Color.Black;
            this.btn_add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_add.IconSize = 35;
            this.btn_add.Location = new System.Drawing.Point(358, 715);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 57);
            this.btn_add.TabIndex = 20;
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_remove
            // 
            this.btn_remove.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.btn_remove.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_remove.IconColor = System.Drawing.Color.Black;
            this.btn_remove.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_remove.IconSize = 35;
            this.btn_remove.Location = new System.Drawing.Point(104, 715);
            this.btn_remove.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(56, 57);
            this.btn_remove.TabIndex = 19;
            this.btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_refil
            // 
            this.btn_refil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_refil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refil.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refil.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_refil.IconColor = System.Drawing.Color.Black;
            this.btn_refil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_refil.Location = new System.Drawing.Point(184, 826);
            this.btn_refil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_refil.Name = "btn_refil";
            this.btn_refil.Size = new System.Drawing.Size(135, 48);
            this.btn_refil.TabIndex = 18;
            this.btn_refil.Text = "Submit";
            this.btn_refil.UseVisualStyleBackColor = false;
            this.btn_refil.Click += new System.EventHandler(this.btn_refil_Click);
            // 
            // btn_productsubmit
            // 
            this.btn_productsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_productsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_productsubmit.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_productsubmit.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_productsubmit.IconColor = System.Drawing.Color.Black;
            this.btn_productsubmit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_productsubmit.Location = new System.Drawing.Point(184, 405);
            this.btn_productsubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_productsubmit.Name = "btn_productsubmit";
            this.btn_productsubmit.Size = new System.Drawing.Size(135, 48);
            this.btn_productsubmit.TabIndex = 17;
            this.btn_productsubmit.Text = "Submit";
            this.btn_productsubmit.UseVisualStyleBackColor = false;
            this.btn_productsubmit.Click += new System.EventHandler(this.btn_productsubmit_Click);
            // 
            // txt_quentity
            // 
            this.txt_quentity.BackColor = System.Drawing.Color.Silver;
            this.txt_quentity.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quentity.Location = new System.Drawing.Point(168, 715);
            this.txt_quentity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_quentity.Name = "txt_quentity";
            this.txt_quentity.Size = new System.Drawing.Size(180, 52);
            this.txt_quentity.TabIndex = 15;
            // 
            // txt_queantity
            // 
            this.txt_queantity.BackColor = System.Drawing.Color.Silver;
            this.txt_queantity.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_queantity.Location = new System.Drawing.Point(120, 322);
            this.txt_queantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_queantity.Name = "txt_queantity";
            this.txt_queantity.Size = new System.Drawing.Size(292, 52);
            this.txt_queantity.TabIndex = 14;
            this.txt_queantity.TextChanged += new System.EventHandler(this.txt_queantity_TextChanged);
            // 
            // txt_Pname
            // 
            this.txt_Pname.BackColor = System.Drawing.Color.Silver;
            this.txt_Pname.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pname.Location = new System.Drawing.Point(120, 211);
            this.txt_Pname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pname.Name = "txt_Pname";
            this.txt_Pname.Size = new System.Drawing.Size(292, 52);
            this.txt_Pname.TabIndex = 13;
            // 
            // txt_refil
            // 
            this.txt_refil.BackColor = System.Drawing.Color.Silver;
            this.txt_refil.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_refil.Location = new System.Drawing.Point(120, 577);
            this.txt_refil.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_refil.Name = "txt_refil";
            this.txt_refil.Size = new System.Drawing.Size(292, 52);
            this.txt_refil.TabIndex = 12;
            // 
            // txt_Pid
            // 
            this.txt_Pid.BackColor = System.Drawing.Color.Silver;
            this.txt_Pid.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pid.Location = new System.Drawing.Point(120, 98);
            this.txt_Pid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Pid.Name = "txt_Pid";
            this.txt_Pid.Size = new System.Drawing.Size(292, 52);
            this.txt_Pid.TabIndex = 11;
            // 
            // rdo_product_name
            // 
            this.rdo_product_name.AutoSize = true;
            this.rdo_product_name.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_product_name.ForeColor = System.Drawing.SystemColors.Control;
            this.rdo_product_name.Location = new System.Drawing.Point(231, 531);
            this.rdo_product_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdo_product_name.Name = "rdo_product_name";
            this.rdo_product_name.Size = new System.Drawing.Size(216, 35);
            this.rdo_product_name.TabIndex = 10;
            this.rdo_product_name.TabStop = true;
            this.rdo_product_name.Text = "By Product Name";
            this.rdo_product_name.UseVisualStyleBackColor = true;
            // 
            // rdo_pid
            // 
            this.rdo_pid.AutoSize = true;
            this.rdo_pid.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_pid.ForeColor = System.Drawing.SystemColors.Control;
            this.rdo_pid.Location = new System.Drawing.Point(56, 531);
            this.rdo_pid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdo_pid.Name = "rdo_pid";
            this.rdo_pid.Size = new System.Drawing.Size(175, 35);
            this.rdo_pid.TabIndex = 9;
            this.rdo_pid.TabStop = true;
            this.rdo_pid.Text = "By Product Id";
            this.rdo_pid.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(50, 657);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "Queantity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(177, 471);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 40);
            this.label5.TabIndex = 4;
            this.label5.Text = "Refill Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(50, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 31);
            this.label4.TabIndex = 3;
            this.label4.Text = "Queantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(50, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(50, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(177, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // btn_view
            // 
            this.btn_view.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_view.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_view.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_view.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_view.IconColor = System.Drawing.Color.Black;
            this.btn_view.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_view.Location = new System.Drawing.Point(1012, 818);
            this.btn_view.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(232, 55);
            this.btn_view.TabIndex = 11;
            this.btn_view.Text = "View All Product";
            this.btn_view.UseVisualStyleBackColor = false;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(622, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(1032, 709);
            this.dataGridView1.TabIndex = 12;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1644, 920);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_view);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Product";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdo_product_name;
        private System.Windows.Forms.RadioButton rdo_pid;
        private FontAwesome.Sharp.IconButton btn_view;
        private FontAwesome.Sharp.IconButton btn_refil;
        private FontAwesome.Sharp.IconButton btn_productsubmit;
        private System.Windows.Forms.TextBox txt_quentity;
        private System.Windows.Forms.TextBox txt_queantity;
        private System.Windows.Forms.TextBox txt_Pname;
        private System.Windows.Forms.TextBox txt_refil;
        private System.Windows.Forms.TextBox txt_Pid;
        private FontAwesome.Sharp.IconButton btn_add;
        private FontAwesome.Sharp.IconButton btn_remove;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}