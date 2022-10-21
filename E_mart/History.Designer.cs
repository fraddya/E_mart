
namespace E_mart
{
    partial class History
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtp_H = new System.Windows.Forms.DateTimePicker();
            this.txt_invoiceidH = new System.Windows.Forms.TextBox();
            this.combox_H = new System.Windows.Forms.ComboBox();
            this.btn_viewH = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(749, 529);
            this.dataGridView1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.iconButton1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(629, 547);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(181, 39);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "View Bill History";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.dtp_H);
            this.panel1.Controls.Add(this.txt_invoiceidH);
            this.panel1.Controls.Add(this.combox_H);
            this.panel1.Controls.Add(this.btn_viewH);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(311, 598);
            this.panel1.TabIndex = 2;
            // 
            // dtp_H
            // 
            this.dtp_H.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_H.Location = new System.Drawing.Point(61, 220);
            this.dtp_H.Name = "dtp_H";
            this.dtp_H.Size = new System.Drawing.Size(180, 25);
            this.dtp_H.TabIndex = 3;
            // 
            // txt_invoiceidH
            // 
            this.txt_invoiceidH.BackColor = System.Drawing.Color.Silver;
            this.txt_invoiceidH.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceidH.Location = new System.Drawing.Point(61, 281);
            this.txt_invoiceidH.Name = "txt_invoiceidH";
            this.txt_invoiceidH.Size = new System.Drawing.Size(180, 33);
            this.txt_invoiceidH.TabIndex = 2;
            // 
            // combox_H
            // 
            this.combox_H.BackColor = System.Drawing.Color.Silver;
            this.combox_H.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_H.FormattingEnabled = true;
            this.combox_H.Items.AddRange(new object[] {
            "By Invoice ID",
            "By Date"});
            this.combox_H.Location = new System.Drawing.Point(61, 149);
            this.combox_H.Name = "combox_H";
            this.combox_H.Size = new System.Drawing.Size(180, 29);
            this.combox_H.TabIndex = 1;
            // 
            // btn_viewH
            // 
            this.btn_viewH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_viewH.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewH.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_viewH.IconColor = System.Drawing.Color.Black;
            this.btn_viewH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_viewH.Location = new System.Drawing.Point(61, 356);
            this.btn_viewH.Name = "btn_viewH";
            this.btn_viewH.Size = new System.Drawing.Size(180, 37);
            this.btn_viewH.TabIndex = 0;
            this.btn_viewH.Text = "View History";
            this.btn_viewH.UseVisualStyleBackColor = false;
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1096, 598);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "History";
            this.Text = "History";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtp_H;
        private System.Windows.Forms.TextBox txt_invoiceidH;
        private System.Windows.Forms.ComboBox combox_H;
        private FontAwesome.Sharp.IconButton btn_viewH;
    }
}