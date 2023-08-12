namespace hoangdhph31492_Csharp3_BT1
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
            txtTen = new TextBox();
            btnThem = new Button();
            groupBox1 = new GroupBox();
            cmbSL = new ComboBox();
            label4 = new Label();
            txtGia = new TextBox();
            label3 = new Label();
            txtMT = new TextBox();
            label2 = new Label();
            groupBox3 = new GroupBox();
            dtgXe = new DataGridView();
            txtTim = new TextBox();
            label5 = new Label();
            groupBox2 = new GroupBox();
            btnClear = new Button();
            btnTim = new Button();
            btnXoa = new Button();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgXe).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 26);
            label1.Name = "label1";
            label1.Size = new Size(44, 16);
            label1.TabIndex = 0;
            label1.Text = "Tên xe:";
            // 
            // txtTen
            // 
            txtTen.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTen.Location = new Point(75, 23);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(148, 24);
            txtTen.TabIndex = 1;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnThem.Location = new Point(0, 11);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(114, 36);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbSL);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtMT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 177);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // cmbSL
            // 
            cmbSL.DropDownHeight = 60;
            cmbSL.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSL.FormattingEnabled = true;
            cmbSL.IntegralHeight = false;
            cmbSL.Location = new Point(75, 142);
            cmbSL.Name = "cmbSL";
            cmbSL.Size = new Size(148, 24);
            cmbSL.TabIndex = 10;
            cmbSL.SelectedIndexChanged += cmbSL_SelectedIndexChanged;
            cmbSL.Click += cmbSL_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 145);
            label4.Name = "label4";
            label4.Size = new Size(60, 16);
            label4.TabIndex = 9;
            label4.Text = "Số Lượng:";
            label4.Click += label4_Click;
            // 
            // txtGia
            // 
            txtGia.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtGia.Location = new Point(75, 102);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(148, 24);
            txtGia.TabIndex = 8;
            txtGia.KeyPress += txtGia_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 105);
            label3.Name = "label3";
            label3.Size = new Size(59, 16);
            label3.TabIndex = 7;
            label3.Text = "Giá Nhập:";
            // 
            // txtMT
            // 
            txtMT.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMT.Location = new Point(75, 62);
            txtMT.Name = "txtMT";
            txtMT.Size = new Size(148, 24);
            txtMT.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 65);
            label2.Name = "label2";
            label2.Size = new Size(41, 16);
            label2.TabIndex = 5;
            label2.Text = "Mô tả:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(dtgXe);
            groupBox3.Controls.Add(txtTim);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(1, 184);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 199);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // dtgXe
            // 
            dtgXe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgXe.Location = new Point(0, 47);
            dtgXe.Name = "dtgXe";
            dtgXe.RowTemplate.Height = 26;
            dtgXe.Size = new Size(409, 150);
            dtgXe.TabIndex = 11;
            dtgXe.CellContentClick += dtgXe_CellContentClick;
            // 
            // txtTim
            // 
            txtTim.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtTim.Location = new Point(75, 17);
            txtTim.Name = "txtTim";
            txtTim.Size = new Size(334, 24);
            txtTim.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(7, 20);
            label5.Name = "label5";
            label5.Size = new Size(57, 16);
            label5.TabIndex = 9;
            label5.Text = "Tìm kiếm:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnClear);
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Font = new Font("Segoe UI", 6F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(296, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(114, 177);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức Năng";
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnClear.Location = new Point(0, 128);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(114, 43);
            btnClear.TabIndex = 5;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnTim
            // 
            btnTim.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnTim.Location = new Point(0, 87);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(114, 39);
            btnTim.TabIndex = 4;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnXoa.Location = new Point(0, 49);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(114, 37);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 398);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgXe).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtTen;
        private Button btnThem;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox txtGia;
        private Label label3;
        private TextBox txtMT;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnClear;
        private Button btnTim;
        private Button btnXoa;
        private GroupBox groupBox3;
        private ComboBox cmbSL;
        private DataGridView dtgXe;
        private TextBox txtTim;
        private Label label5;
    }
}