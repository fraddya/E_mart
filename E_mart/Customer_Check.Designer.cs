
namespace E_mart
{
    partial class Customer_Check
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
            this.btn_enterc = new System.Windows.Forms.Button();
            this.txt_cidc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_valid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_enterc
            // 
            this.btn_enterc.BackColor = System.Drawing.Color.Gold;
            this.btn_enterc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enterc.Location = new System.Drawing.Point(309, 159);
            this.btn_enterc.Name = "btn_enterc";
            this.btn_enterc.Size = new System.Drawing.Size(99, 34);
            this.btn_enterc.TabIndex = 0;
            this.btn_enterc.Text = "Enter";
            this.btn_enterc.UseVisualStyleBackColor = false;
            this.btn_enterc.Click += new System.EventHandler(this.btn_enterc_Click);
            // 
            // txt_cidc
            // 
            this.txt_cidc.BackColor = System.Drawing.Color.Silver;
            this.txt_cidc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cidc.Location = new System.Drawing.Point(273, 90);
            this.txt_cidc.Name = "txt_cidc";
            this.txt_cidc.Size = new System.Drawing.Size(197, 28);
            this.txt_cidc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer ID";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.BackColor = System.Drawing.Color.White;
            this.lbl_1.ForeColor = System.Drawing.Color.Black;
            this.lbl_1.Location = new System.Drawing.Point(80, 187);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(0, 17);
            this.lbl_1.TabIndex = 3;
            // 
            // lbl_valid
            // 
            this.lbl_valid.AutoSize = true;
            this.lbl_valid.ForeColor = System.Drawing.Color.Red;
            this.lbl_valid.Location = new System.Drawing.Point(257, 120);
            this.lbl_valid.Name = "lbl_valid";
            this.lbl_valid.Size = new System.Drawing.Size(0, 17);
            this.lbl_valid.TabIndex = 4;
            // 
            // Customer_Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(645, 267);
            this.Controls.Add(this.lbl_valid);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cidc);
            this.Controls.Add(this.btn_enterc);
            this.Name = "Customer_Check";
            this.Text = "Customer_Check";
            this.Load += new System.EventHandler(this.Customer_Check_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_enterc;
        private System.Windows.Forms.TextBox txt_cidc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_valid;
    }
}