namespace NguyenVanTan_Buoi2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_n = new TextBox();
            txt_kq = new TextBox();
            txt_SNTn = new TextBox();
            btnthoat = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(199, 54);
            label1.Name = "label1";
            label1.Size = new Size(366, 32);
            label1.TabIndex = 0;
            label1.Text = "Kiểm Tra Và Tìm Số Nguyên Tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(112, 153);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 1;
            label2.Text = "Nhập n :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 188);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 2;
            label3.Text = "Kiểm tra SNT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(112, 223);
            label4.Name = "label4";
            label4.Size = new Size(115, 15);
            label4.TabIndex = 3;
            label4.Text = "Tìm SNT nhỏ hơn n :";
            // 
            // txt_n
            // 
            txt_n.Location = new Point(246, 152);
            txt_n.Name = "txt_n";
            txt_n.Size = new Size(100, 23);
            txt_n.TabIndex = 4;
            txt_n.TextChanged += txt_n_TextChanged;
            // 
            // txt_kq
            // 
            txt_kq.Location = new Point(244, 184);
            txt_kq.Name = "txt_kq";
            txt_kq.Size = new Size(100, 23);
            txt_kq.TabIndex = 5;
            txt_kq.TextChanged += txt_kq_TextChanged;
            // 
            // txt_SNTn
            // 
            txt_SNTn.Location = new Point(247, 222);
            txt_SNTn.Name = "txt_SNTn";
            txt_SNTn.Size = new Size(100, 23);
            txt_SNTn.TabIndex = 6;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(466, 149);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(75, 23);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnthoat);
            Controls.Add(txt_SNTn);
            Controls.Add(txt_kq);
            Controls.Add(txt_n);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_n;
        private TextBox txt_kq;
        private TextBox txt_SNTn;
        private Button btnthoat;
    }
}
