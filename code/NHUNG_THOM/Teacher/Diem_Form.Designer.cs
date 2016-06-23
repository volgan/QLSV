namespace NHUNG_THOM
{
    partial class Diem_Form
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
            this.label_MALOP = new System.Windows.Forms.Label();
            this.label_MAMH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_LOP = new System.Windows.Forms.ComboBox();
            this.label_TENLOP = new System.Windows.Forms.Label();
            this.combox_MONHOC = new System.Windows.Forms.ComboBox();
            this.txt_TENLOP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_HKY = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MASV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_SAVE = new System.Windows.Forms.Button();
            this.comboBox_LAN = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(203, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(572, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP ĐIỂM MÔN HỌC";
            // 
            // label_MALOP
            // 
            this.label_MALOP.AutoSize = true;
            this.label_MALOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MALOP.Location = new System.Drawing.Point(56, 116);
            this.label_MALOP.Name = "label_MALOP";
            this.label_MALOP.Size = new System.Drawing.Size(88, 25);
            this.label_MALOP.TabIndex = 1;
            this.label_MALOP.Text = "MÃ LỚP";
            // 
            // label_MAMH
            // 
            this.label_MAMH.AutoSize = true;
            this.label_MAMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MAMH.Location = new System.Drawing.Point(55, 174);
            this.label_MAMH.Name = "label_MAMH";
            this.label_MAMH.Size = new System.Drawing.Size(109, 25);
            this.label_MAMH.TabIndex = 1;
            this.label_MAMH.Text = "MÔN HỌC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(56, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "HỌC KỲ";
            // 
            // combo_LOP
            // 
            this.combo_LOP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_LOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_LOP.FormattingEnabled = true;
            this.combo_LOP.Location = new System.Drawing.Point(189, 105);
            this.combo_LOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combo_LOP.Name = "combo_LOP";
            this.combo_LOP.Size = new System.Drawing.Size(225, 33);
            this.combo_LOP.TabIndex = 2;
            this.combo_LOP.SelectedIndexChanged += new System.EventHandler(this.combo_LOP_SelectedIndexChanged);
            // 
            // label_TENLOP
            // 
            this.label_TENLOP.AutoSize = true;
            this.label_TENLOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TENLOP.Location = new System.Drawing.Point(560, 116);
            this.label_TENLOP.Name = "label_TENLOP";
            this.label_TENLOP.Size = new System.Drawing.Size(97, 25);
            this.label_TENLOP.TabIndex = 1;
            this.label_TENLOP.Text = "TÊN LỚP";
            // 
            // combox_MONHOC
            // 
            this.combox_MONHOC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combox_MONHOC.Enabled = false;
            this.combox_MONHOC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combox_MONHOC.FormattingEnabled = true;
            this.combox_MONHOC.Location = new System.Drawing.Point(189, 166);
            this.combox_MONHOC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.combox_MONHOC.Name = "combox_MONHOC";
            this.combox_MONHOC.Size = new System.Drawing.Size(225, 33);
            this.combox_MONHOC.TabIndex = 3;
            this.combox_MONHOC.SelectedIndexChanged += new System.EventHandler(this.combox_MONHOC_SelectedIndexChanged);
            // 
            // txt_TENLOP
            // 
            this.txt_TENLOP.Enabled = false;
            this.txt_TENLOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TENLOP.Location = new System.Drawing.Point(716, 105);
            this.txt_TENLOP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_TENLOP.Name = "txt_TENLOP";
            this.txt_TENLOP.Size = new System.Drawing.Size(307, 30);
            this.txt_TENLOP.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(560, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "LẦN";
            // 
            // txt_HKY
            // 
            this.txt_HKY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HKY.Location = new System.Drawing.Point(189, 220);
            this.txt_HKY.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_HKY.MaxLength = 2;
            this.txt_HKY.Name = "txt_HKY";
            this.txt_HKY.Size = new System.Drawing.Size(225, 30);
            this.txt_HKY.TabIndex = 5;
            this.txt_HKY.TextChanged += new System.EventHandler(this.txt_HKY_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MASV,
            this.HO,
            this.TEN,
            this.DIEM});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1237, 282);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MASV
            // 
            this.MASV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MASV.DataPropertyName = "MASV";
            this.MASV.HeaderText = "MÃ SV";
            this.MASV.Name = "MASV";
            this.MASV.ReadOnly = true;
            // 
            // HO
            // 
            this.HO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HO.DataPropertyName = "HO";
            this.HO.HeaderText = "HỌ";
            this.HO.Name = "HO";
            this.HO.ReadOnly = true;
            // 
            // TEN
            // 
            this.TEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TEN.DataPropertyName = "TEN";
            this.TEN.HeaderText = "TÊN";
            this.TEN.Name = "TEN";
            this.TEN.ReadOnly = true;
            // 
            // DIEM
            // 
            this.DIEM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DIEM.DataPropertyName = "DIEM";
            this.DIEM.HeaderText = "ĐIỂM";
            this.DIEM.MaxInputLength = 3;
            this.DIEM.Name = "DIEM";
            // 
            // btn_Start
            // 
            this.btn_Start.Enabled = false;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(565, 218);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(125, 37);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "BẮT ĐẦU";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_SAVE
            // 
            this.btn_SAVE.Enabled = false;
            this.btn_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SAVE.Location = new System.Drawing.Point(899, 220);
            this.btn_SAVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SAVE.Name = "btn_SAVE";
            this.btn_SAVE.Size = new System.Drawing.Size(125, 37);
            this.btn_SAVE.TabIndex = 7;
            this.btn_SAVE.Text = "LƯU";
            this.btn_SAVE.UseVisualStyleBackColor = true;
            this.btn_SAVE.Click += new System.EventHandler(this.btn_SAVE_Click);
            // 
            // comboBox_LAN
            // 
            this.comboBox_LAN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_LAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_LAN.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox_LAN.Location = new System.Drawing.Point(716, 166);
            this.comboBox_LAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_LAN.Name = "comboBox_LAN";
            this.comboBox_LAN.Size = new System.Drawing.Size(181, 33);
            this.comboBox_LAN.TabIndex = 2;
            this.comboBox_LAN.SelectedIndexChanged += new System.EventHandler(this.comboBox_LAN_SelectedIndexChanged);
            // 
            // Diem_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 588);
            this.Controls.Add(this.btn_SAVE);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_HKY);
            this.Controls.Add(this.txt_TENLOP);
            this.Controls.Add(this.combox_MONHOC);
            this.Controls.Add(this.comboBox_LAN);
            this.Controls.Add(this.combo_LOP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_MAMH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_TENLOP);
            this.Controls.Add(this.label_MALOP);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Diem_Form";
            this.Text = "Diem_Form";
            this.Load += new System.EventHandler(this.Diem_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_MALOP;
        private System.Windows.Forms.Label label_MAMH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_LOP;
        private System.Windows.Forms.Label label_TENLOP;
        private System.Windows.Forms.ComboBox combox_MONHOC;
        private System.Windows.Forms.TextBox txt_TENLOP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_HKY;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_SAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASV;
        private System.Windows.Forms.DataGridViewTextBoxColumn HO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIEM;
        private System.Windows.Forms.ComboBox comboBox_LAN;
    }
}