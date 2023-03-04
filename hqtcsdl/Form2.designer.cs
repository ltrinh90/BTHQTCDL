namespace Lab123Form
{
    partial class Form2
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
            this.btTraSach = new System.Windows.Forms.Button();
            this.TraCuu = new System.Windows.Forms.Button();
            this.txtMaCS = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.ISBN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MaCuonSach = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayGioMuon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NgayGioTra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "MƯỢN TRẢ SÁCH";
            // 
            // btTraSach
            // 
            this.btTraSach.BackColor = System.Drawing.Color.Honeydew;
            this.btTraSach.Location = new System.Drawing.Point(352, 357);
            this.btTraSach.Margin = new System.Windows.Forms.Padding(4);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(100, 41);
            this.btTraSach.TabIndex = 1;
            this.btTraSach.Text = "Trả sách";
            this.btTraSach.UseVisualStyleBackColor = false;
            this.btTraSach.Click += new System.EventHandler(this.btTraSach_Click);
            // 
            // TraCuu
            // 
            this.TraCuu.BackColor = System.Drawing.Color.Honeydew;
            this.TraCuu.Location = new System.Drawing.Point(571, 68);
            this.TraCuu.Margin = new System.Windows.Forms.Padding(4);
            this.TraCuu.Name = "TraCuu";
            this.TraCuu.Size = new System.Drawing.Size(100, 39);
            this.TraCuu.TabIndex = 2;
            this.TraCuu.Text = "Tra cứu";
            this.TraCuu.UseVisualStyleBackColor = false;
            this.TraCuu.Click += new System.EventHandler(this.TraCuu_Click);
            // 
            // txtMaCS
            // 
            this.txtMaCS.Location = new System.Drawing.Point(605, 295);
            this.txtMaCS.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaCS.Name = "txtMaCS";
            this.txtMaCS.Size = new System.Drawing.Size(158, 22);
            this.txtMaCS.TabIndex = 3;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(132, 293);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(4);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(189, 22);
            this.txt_isbn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(454, 298);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Mã cuốn sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISBN";
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.Location = new System.Drawing.Point(300, 76);
            this.txtMaDocGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(234, 22);
            this.txtMaDocGia.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập vào mã đọc giả";
            // 
            // listView2
            // 
            this.listView2.AllowColumnReorder = true;
            this.listView2.BackColor = System.Drawing.Color.Cornsilk;
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STT,
            this.MaCuonSach,
            this.ISBN,
            this.NgayGioMuon,
            this.NgayGioTra});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(35, 130);
            this.listView2.Margin = new System.Windows.Forms.Padding(4);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(768, 155);
            this.listView2.TabIndex = 9;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // ISBN
            // 
            this.ISBN.DisplayIndex = 0;
            this.ISBN.Text = "ISBN";
            // 
            // MaCuonSach
            // 
            this.MaCuonSach.Text = "Mã cuốn sách";
            // 
            // NgayGioMuon
            // 
            this.NgayGioMuon.DisplayIndex = 2;
            this.NgayGioMuon.Text = "Ngày giờ mượn";
            // 
            // NgayGioTra
            // 
            this.NgayGioTra.DisplayIndex = 3;
            this.NgayGioTra.Text = "Ngày giờ trả";
            // 
            // STT
            // 
            this.STT.DisplayIndex = 4;
            this.STT.Text = "STT";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(926, 457);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMaDocGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.txtMaCS);
            this.Controls.Add(this.TraCuu);
            this.Controls.Add(this.btTraSach);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btTraSach;
        private System.Windows.Forms.Button TraCuu;
        private System.Windows.Forms.TextBox txtMaCS;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader ISBN;
        private System.Windows.Forms.ColumnHeader MaCuonSach;
        private System.Windows.Forms.ColumnHeader NgayGioMuon;
        private System.Windows.Forms.ColumnHeader NgayGioTra;
        private System.Windows.Forms.ColumnHeader STT;
    }
}