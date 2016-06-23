namespace NHUNG_THOM
{
    partial class MONHOC
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
            this.label_TenMH = new System.Windows.Forms.Label();
            this.txt_MaMH = new System.Windows.Forms.TextBox();
            this.txt_TenMH = new System.Windows.Forms.TextBox();
            this.btn_Add_Subject = new System.Windows.Forms.Button();
            this.btn_Edit_Subject = new System.Windows.Forms.Button();
            this.btn_Delete_Subject = new System.Windows.Forms.Button();
            this.btn_Search_Subject = new System.Windows.Forms.Button();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÃ MÔN HỌC";
            // 
            // label_TenMH
            // 
            this.label_TenMH.AutoSize = true;
            this.label_TenMH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenMH.Location = new System.Drawing.Point(34, 82);
            this.label_TenMH.Name = "label_TenMH";
            this.label_TenMH.Size = new System.Drawing.Size(117, 17);
            this.label_TenMH.TabIndex = 0;
            this.label_TenMH.Text = "TÊN MÔN HỌC";
            // 
            // txt_MaMH
            // 
            this.txt_MaMH.Location = new System.Drawing.Point(158, 38);
            this.txt_MaMH.MaxLength = 5;
            this.txt_MaMH.Name = "txt_MaMH";
            this.txt_MaMH.Size = new System.Drawing.Size(309, 20);
            this.txt_MaMH.TabIndex = 1;
            this.txt_MaMH.TextChanged += new System.EventHandler(this.txt_MaMH_TextChanged);
            // 
            // txt_TenMH
            // 
            this.txt_TenMH.Location = new System.Drawing.Point(158, 81);
            this.txt_TenMH.MaxLength = 40;
            this.txt_TenMH.Name = "txt_TenMH";
            this.txt_TenMH.Size = new System.Drawing.Size(309, 20);
            this.txt_TenMH.TabIndex = 1;
            this.txt_TenMH.TextChanged += new System.EventHandler(this.txt_TenMH_TextChanged);
            // 
            // btn_Add_Subject
            // 
            this.btn_Add_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Subject.Location = new System.Drawing.Point(37, 161);
            this.btn_Add_Subject.Name = "btn_Add_Subject";
            this.btn_Add_Subject.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_Subject.TabIndex = 3;
            this.btn_Add_Subject.Text = "THÊM";
            this.btn_Add_Subject.UseVisualStyleBackColor = true;
            this.btn_Add_Subject.Click += new System.EventHandler(this.btn_Add_Subject_Click);
            // 
            // btn_Edit_Subject
            // 
            this.btn_Edit_Subject.Enabled = false;
            this.btn_Edit_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Edit_Subject.Location = new System.Drawing.Point(139, 161);
            this.btn_Edit_Subject.Name = "btn_Edit_Subject";
            this.btn_Edit_Subject.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit_Subject.TabIndex = 3;
            this.btn_Edit_Subject.Text = "SỬA";
            this.btn_Edit_Subject.UseVisualStyleBackColor = true;
            this.btn_Edit_Subject.Click += new System.EventHandler(this.btn_Edit_Subject_Click);
            // 
            // btn_Delete_Subject
            // 
            this.btn_Delete_Subject.Enabled = false;
            this.btn_Delete_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete_Subject.Location = new System.Drawing.Point(238, 161);
            this.btn_Delete_Subject.Name = "btn_Delete_Subject";
            this.btn_Delete_Subject.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete_Subject.TabIndex = 3;
            this.btn_Delete_Subject.Text = "XÓA";
            this.btn_Delete_Subject.UseVisualStyleBackColor = true;
            this.btn_Delete_Subject.Click += new System.EventHandler(this.btn_Delete_Subject_Click);
            // 
            // btn_Search_Subject
            // 
            this.btn_Search_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search_Subject.Location = new System.Drawing.Point(340, 161);
            this.btn_Search_Subject.Name = "btn_Search_Subject";
            this.btn_Search_Subject.Size = new System.Drawing.Size(75, 23);
            this.btn_Search_Subject.TabIndex = 3;
            this.btn_Search_Subject.Text = "TÌM KIẾM";
            this.btn_Search_Subject.UseVisualStyleBackColor = true;
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancle.Location = new System.Drawing.Point(438, 161);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancle.TabIndex = 3;
            this.btn_Cancle.Text = "HỦY";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MAMH,
            this.TENMH});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(525, 150);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.STT.DataPropertyName = "STT";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MAMH
            // 
            this.MAMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MAMH.DataPropertyName = "MAMH";
            this.MAMH.HeaderText = "MÃ MÔN HỌC";
            this.MAMH.Name = "MAMH";
            this.MAMH.ReadOnly = true;
            // 
            // TENMH
            // 
            this.TENMH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENMH.DataPropertyName = "TENMH";
            this.TENMH.HeaderText = "TÊN MÔN HỌC";
            this.TENMH.Name = "TENMH";
            this.TENMH.ReadOnly = true;
            // 
            // MONHOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 382);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Cancle);
            this.Controls.Add(this.btn_Search_Subject);
            this.Controls.Add(this.btn_Delete_Subject);
            this.Controls.Add(this.btn_Edit_Subject);
            this.Controls.Add(this.btn_Add_Subject);
            this.Controls.Add(this.txt_TenMH);
            this.Controls.Add(this.txt_MaMH);
            this.Controls.Add(this.label_TenMH);
            this.Controls.Add(this.label1);
            this.Name = "MONHOC";
            this.Text = "MÔN HỌC";
            this.Load += new System.EventHandler(this.MONHOC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_TenMH;
        private System.Windows.Forms.TextBox txt_MaMH;
        private System.Windows.Forms.TextBox txt_TenMH;
        private System.Windows.Forms.Button btn_Add_Subject;
        private System.Windows.Forms.Button btn_Edit_Subject;
        private System.Windows.Forms.Button btn_Delete_Subject;
        private System.Windows.Forms.Button btn_Search_Subject;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENMH;

    }
}