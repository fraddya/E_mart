
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
            this.dataGridView1.Location = new System.Drawing.Point(447, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(999, 651);
            this.dataGridView1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.iconButton1.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(839, 673);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(241, 48);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "View Bill History";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(415, 736);
            this.panel1.TabIndex = 2;
            // 
            // dtp_H
            // 
            this.dtp_H.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_H.Location = new System.Drawing.Point(81, 271);
            this.dtp_H.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtp_H.Name = "dtp_H";
            this.dtp_H.Size = new System.Drawing.Size(239, 29);
            this.dtp_H.TabIndex = 3;
            // 
            // txt_invoiceidH
            // 
            this.txt_invoiceidH.BackColor = System.Drawing.Color.Silver;
            this.txt_invoiceidH.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_invoiceidH.Location = new System.Drawing.Point(81, 346);
            this.txt_invoiceidH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_invoiceidH.Name = "txt_invoiceidH";
            this.txt_invoiceidH.Size = new System.Drawing.Size(239, 39);
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
            this.combox_H.Location = new System.Drawing.Point(81, 183);
            this.combox_H.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combox_H.Name = "combox_H";
            this.combox_H.Size = new System.Drawing.Size(239, 36);
            this.combox_H.TabIndex = 1;
            // 
            // btn_viewH
            // 
            this.btn_viewH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(214)))), ((int)(((byte)(0)))));
            this.btn_viewH.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewH.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btn_viewH.IconColor = System.Drawing.Color.Black;
            this.btn_viewH.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_viewH.Location = new System.Drawing.Point(81, 438);
            this.btn_viewH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_viewH.Name = "btn_viewH";
            this.btn_viewH.Size = new System.Drawing.Size(240, 46);
            this.btn_viewH.TabIndex = 0;
            this.btn_viewH.Text = "View History";
            this.btn_viewH.UseVisualStyleBackColor = false;
            this.btn_viewH.Click += new System.EventHandler(this.btn_viewH_Click);
            // 
            // History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1461, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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