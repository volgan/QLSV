namespace NHUNG_THOM
{
    partial class TeacherForm
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
            this.btn_SV = new System.Windows.Forms.Button();
            this.btn_Class = new System.Windows.Forms.Button();
            this.btn_Subject = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.btn_BackUp = new System.Windows.Forms.Button();
            this.btn_Point = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_SV
            // 
            this.btn_SV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SV.Location = new System.Drawing.Point(28, 12);
            this.btn_SV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_SV.Name = "btn_SV";
            this.btn_SV.Size = new System.Drawing.Size(129, 55);
            this.btn_SV.TabIndex = 0;
            this.btn_SV.Text = "SINH VIÊN";
            this.btn_SV.UseVisualStyleBackColor = true;
            this.btn_SV.Click += new System.EventHandler(this.btn_SV_Click);
            // 
            // btn_Class
            // 
            this.btn_Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Class.Location = new System.Drawing.Point(211, 12);
            this.btn_Class.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Class.Name = "btn_Class";
            this.btn_Class.Size = new System.Drawing.Size(129, 55);
            this.btn_Class.TabIndex = 0;
            this.btn_Class.Text = "LỚP";
            this.btn_Class.UseVisualStyleBackColor = true;
            this.btn_Class.Click += new System.EventHandler(this.btn_Class_Click);
            // 
            // btn_Subject
            // 
            this.btn_Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Subject.Location = new System.Drawing.Point(211, 114);
            this.btn_Subject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Subject.Name = "btn_Subject";
            this.btn_Subject.Size = new System.Drawing.Size(129, 55);
            this.btn_Subject.TabIndex = 0;
            this.btn_Subject.Text = "MÔN HỌC";
            this.btn_Subject.UseVisualStyleBackColor = true;
            this.btn_Subject.Click += new System.EventHandler(this.btn_Subject_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restore.Location = new System.Drawing.Point(387, 12);
            this.btn_Restore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(151, 55);
            this.btn_Restore.TabIndex = 0;
            this.btn_Restore.Text = "RESTORE";
            this.btn_Restore.UseVisualStyleBackColor = true;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btn_BackUp
            // 
            this.btn_BackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackUp.Location = new System.Drawing.Point(387, 114);
            this.btn_BackUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_BackUp.Name = "btn_BackUp";
            this.btn_BackUp.Size = new System.Drawing.Size(151, 55);
            this.btn_BackUp.TabIndex = 0;
            this.btn_BackUp.Text = "BACKUP ";
            this.btn_BackUp.UseVisualStyleBackColor = true;
            this.btn_BackUp.Click += new System.EventHandler(this.btn_BackUp_Click);
            // 
            // btn_Point
            // 
            this.btn_Point.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Point.Location = new System.Drawing.Point(28, 114);
            this.btn_Point.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Point.Name = "btn_Point";
            this.btn_Point.Size = new System.Drawing.Size(129, 55);
            this.btn_Point.TabIndex = 0;
            this.btn_Point.Text = "ĐIỂM";
            this.btn_Point.UseVisualStyleBackColor = true;
            this.btn_Point.Click += new System.EventHandler(this.btn_Point_Click);
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 203);
            this.Controls.Add(this.btn_Point);
            this.Controls.Add(this.btn_BackUp);
            this.Controls.Add(this.btn_Restore);
            this.Controls.Add(this.btn_Subject);
            this.Controls.Add(this.btn_Class);
            this.Controls.Add(this.btn_SV);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TeacherForm";
            this.Text = "Teacher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SV;
        private System.Windows.Forms.Button btn_Class;
        private System.Windows.Forms.Button btn_Subject;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Button btn_BackUp;
        private System.Windows.Forms.Button btn_Point;

    }
}