namespace NHUNG_THOM
{
    partial class LOP
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
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Cancle = new System.Windows.Forms.Button();
            this.label_TENLOP = new System.Windows.Forms.Label();
            this.txt_TENLOP = new System.Windows.Forms.TextBox();
            this.txt_MALOP = new System.Windows.Forms.TextBox();
            this.label_MALOP = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MALOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENLOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add_Subject_To_Class = new System.Windows.Forms.Button();
            this.btn_ViewPoint = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Add
            // 
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Location = new System.Drawing.Point(12, 110);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 0;
            this.btn_Add.Text = "THÊM";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Enabled = false;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Update.Location = new System.Drawing.Point(126, 110);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Update.Size = new System.Drawing.Size(91, 23);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "CẬP NHẬT";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Location = new System.Drawing.Point(256, 110);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "XÓA";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.Enabled = false;
            this.btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Search.Location = new System.Drawing.Point(372, 110);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_Search.TabIndex = 0;
            this.btn_Search.Text = "TÌM KIẾM";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // btn_Cancle
            // 
            this.btn_Cancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancle.Location = new System.Drawing.Point(488, 110);
            this.btn_Cancle.Name = "btn_Cancle";
            this.btn_Cancle.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancle.TabIndex = 1;
            this.btn_Cancle.Text = "HỦY";
            this.btn_Cancle.UseVisualStyleBackColor = true;
            this.btn_Cancle.Click += new System.EventHandler(this.btn_Cancle_Click);
            // 
            // label_TENLOP
            // 
            this.label_TENLOP.AutoSize = true;
            this.label_TENLOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TENLOP.Location = new System.Drawing.Point(9, 52);
            this.label_TENLOP.Name = "label_TENLOP";
            this.label_TENLOP.Size = new System.Drawing.Size(75, 17);
            this.label_TENLOP.TabIndex = 2;
            this.label_TENLOP.Text = "TÊN LỚP";
            // 
            // txt_TENLOP
            // 
            this.txt_TENLOP.Location = new System.Drawing.Point(92, 50);
            this.txt_TENLOP.MaxLength = 40;
            this.txt_TENLOP.Name = "txt_TENLOP";
            this.txt_TENLOP.Size = new System.Drawing.Size(309, 20);
            this.txt_TENLOP.TabIndex = 3;
            this.txt_TENLOP.TextChanged += new System.EventHandler(this.txt_TENLOP_TextChanged);
            // 
            // txt_MALOP
            // 
            this.txt_MALOP.Location = new System.Drawing.Point(92, 10);
            this.txt_MALOP.MaxLength = 8;
            this.txt_MALOP.Name = "txt_MALOP";
            this.txt_MALOP.Size = new System.Drawing.Size(309, 20);
            this.txt_MALOP.TabIndex = 3;
            this.txt_MALOP.TextChanged += new System.EventHandler(this.txt_MALOP_TextChanged);
            // 
            // label_MALOP
            // 
            this.label_MALOP.AutoSize = true;
            this.label_MALOP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MALOP.Location = new System.Drawing.Point(9, 9);
            this.label_MALOP.Name = "label_MALOP";
            this.label_MALOP.Size = new System.Drawing.Size(66, 17);
            this.label_MALOP.TabIndex = 2;
            this.label_MALOP.Text = "MÃ LỚP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Index,
            this.MALOP,
            this.TENLOP});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(0, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(584, 218);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // Index
            // 
            this.Index.DataPropertyName = "STT";
            this.Index.HeaderText = "STT";
            this.Index.Name = "Index";
            this.Index.ReadOnly = true;
            // 
            // MALOP
            // 
            this.MALOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MALOP.DataPropertyName = "MALOP";
            this.MALOP.HeaderText = "MÃ LỚP";
            this.MALOP.MaxInputLength = 8;
            this.MALOP.Name = "MALOP";
            this.MALOP.ReadOnly = true;
            // 
            // TENLOP
            // 
            this.TENLOP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TENLOP.DataPropertyName = "TENLOP";
            this.TENLOP.HeaderText = "TÊN LỚP";
            this.TENLOP.MaxInputLength = 40;
            this.TENLOP.Name = "TENLOP";
            this.TENLOP.ReadOnly = true;
            // 
            // btn_Add_Subject_To_Class
            // 
            this.btn_Add_Subject_To_Class.Enabled = false;
            this.btn_Add_Subject_To_Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add_Subject_To_Class.Location = new System.Drawing.Point(427, 6);
            this.btn_Add_Subject_To_Class.Name = "btn_Add_Subject_To_Class";
            this.btn_Add_Subject_To_Class.Size = new System.Drawing.Size(146, 23);
            this.btn_Add_Subject_To_Class.TabIndex = 1;
            this.btn_Add_Subject_To_Class.Text = "THÊM MÔN HỌC";
            this.btn_Add_Subject_To_Class.UseVisualStyleBackColor = true;
            this.btn_Add_Subject_To_Class.Click += new System.EventHandler(this.btn_Add_Subject_To_Class_Click);
            // 
            // btn_ViewPoint
            // 
            this.btn_ViewPoint.Enabled = false;
            this.btn_ViewPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ViewPoint.Location = new System.Drawing.Point(427, 46);
            this.btn_ViewPoint.Name = "btn_ViewPoint";
            this.btn_ViewPoint.Size = new System.Drawing.Size(146, 23);
            this.btn_ViewPoint.TabIndex = 1;
            this.btn_ViewPoint.Text = "XEM ĐIỂM TỔNG KẾT";
            this.btn_ViewPoint.UseVisualStyleBackColor = true;
            this.btn_ViewPoint.Click += new System.EventHandler(this.btn_ViewPoint_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_Update);
            this.panel1.Controls.Add(this.btn_Delete);
            this.panel1.Controls.Add(this.btn_ViewPoint);
            this.panel1.Controls.Add(this.txt_TENLOP);
            this.panel1.Controls.Add(this.btn_Add_Subject_To_Class);
            this.panel1.Controls.Add(this.txt_MALOP);
            this.panel1.Controls.Add(this.btn_Search);
            this.panel1.Controls.Add(this.btn_Cancle);
            this.panel1.Controls.Add(this.label_TENLOP);
            this.panel1.Controls.Add(this.label_MALOP);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(584, 164);
            this.panel1.TabIndex = 6;
            // 
            // LOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 382);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LOP";
            this.RightToLeftLayout = true;
            this.Text = "LỚP";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Cancle;
        private System.Windows.Forms.Button btn_Add_Subject_To_Class;
        private System.Windows.Forms.Button btn_ViewPoint;
        private System.Windows.Forms.Label label_TENLOP;
        private System.Windows.Forms.TextBox txt_TENLOP;
        private System.Windows.Forms.TextBox txt_MALOP;
        private System.Windows.Forms.Label label_MALOP;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn MALOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENLOP;        

    }
}

