using NHUNG_THOM.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHUNG_THOM.Model;
using System.IO;

namespace NHUNG_THOM
{
    public partial class SinhVien_Form : Form
    {
        private long MASV;
        private string classId;
        private SqlConnection ketnoi = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NHUNG_THOM_Connection"].ConnectionString);
        private DataTable dataSvien = new DataTable();
        private List<StudentModel> listStudent = new List<StudentModel>();
        private List<int> listStudentIndexChange = new List<int>();

        public SinhVien_Form()
        {
            InitializeComponent();
        }
        private void SinhVien_Form_Load(object sender, EventArgs e)
        {
            Color c = Color.FromArgb(0, 0, 68);
            btn_Add.BackColor = btn_Cancle.BackColor = btn_Exit.BackColor = c;
            btn_Add.FlatAppearance.BorderColor = btn_Cancle.FlatAppearance.BorderColor = btn_Exit.FlatAppearance.BorderColor = c;
            c = Color.FromArgb(102, 153, 204);
            btn_Add.ForeColor = btn_Cancle.ForeColor = btn_Exit.ForeColor = c;
            combobox_GioiTinh.SelectedIndex = 0;
            LoadLop();
        }

        private void LoadLop()
        {
            SqlCommand cmd = new SqlCommand("GetAllClass", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            ketnoi.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            Adapter.Fill(dataTable);
            ketnoi.Close();
            combobox_Lop.DisplayMember = "Text";
            combobox_Lop.ValueMember = "Value";

            combobox_MALOP.DisplayMember = "Text";
            combobox_MALOP.ValueMember = "Value";
            foreach (DataRow row in dataTable.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row[2].ToString(), row[1].ToString());
                ComboBoxItem item_2 = new ComboBoxItem(row[1].ToString(), row[2].ToString());
                combobox_Lop.Items.Add(item);
                combobox_MALOP.Items.Add(item_2);
            }
            combobox_Lop.SelectedIndex = 0;
        }

        private bool checkFullInfo()
        {
            bool ho_notNull = string.IsNullOrWhiteSpace(txt_Ho.Text.Trim());
            bool ten_notNull = string.IsNullOrWhiteSpace(txt_Ten.Text.Trim());
            bool diachi_notNull = string.IsNullOrWhiteSpace(txt_DiaChi.Text);
            bool noisinh_notNull = string.IsNullOrWhiteSpace(txt_NoiSinh.Text.Trim());

            if (ho_notNull == false && ten_notNull == false && diachi_notNull == false && noisinh_notNull == false)
                return true;

            return false;
        }

        private void combobox_Lop_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.classId = ((ComboBoxItem)combobox_Lop.SelectedItem).value;
        }
        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (checkFullInfo() == true)
            {
                SqlCommand cmd = new SqlCommand("NHAPSINHVIEN", ketnoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@HO", txt_Ho.Text.Trim());
                cmd.Parameters.AddWithValue("@TEN", txt_Ten.Text.Trim());
                cmd.Parameters.AddWithValue("@MALOP", this.classId);
                cmd.Parameters.AddWithValue("@NGAYSINH", birthDay.Value);
                cmd.Parameters.AddWithValue("@NOISINH", txt_NoiSinh.Text.Trim());
                cmd.Parameters.AddWithValue("@PHAI", combobox_GioiTinh.SelectedIndex);
                cmd.Parameters.AddWithValue("@DIACHI", txt_DiaChi.Text.Trim());
                cmd.Parameters.AddWithValue("@GHICHU", GhiChu.Text);
                ketnoi.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo sinh viên thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txt_Ho.Text = "";
                    txt_Ten.Text = "";
                    txt_NoiSinh.Text = "";
                    txt_DiaChi.Text = "";
                    GhiChu.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ketnoi.Close();
            }
            else
            {
                MessageBox.Show("Hãy nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            txt_Ho.Text = "";
            txt_Ten.Text = "";
            txt_NoiSinh.Text = "";
            txt_DiaChi.Text = "";
            GhiChu.Text = "";
        }

        private void combobox_MALOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.classId = ((ComboBoxItem)combobox_MALOP.SelectedItem).text;
            txt_TENLOP.Text = ((ComboBoxItem)combobox_MALOP.SelectedItem).value;
            LOAD_sinhvien_trong_lop();
        }
        private void LOAD_sinhvien_trong_lop()
        {
            dataSvien.Clear();
            SqlCommand cmd = new SqlCommand("LAY_DS_SV_THEO_LOP", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MALOP", this.classId);
            ketnoi.Open();
            try
            {
                //cmd.ExecuteNonQuery();
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                Adapter.Fill(dataSvien);
                listStudent.Clear();
                foreach (DataRow row in dataSvien.Rows)
                {
                    StudentModel student = new StudentModel();
                    student.MASV = Int32.Parse(row.ItemArray[0].ToString());
                    student.HO = row.ItemArray[1].ToString();
                    student.TEN = row.ItemArray[2].ToString();
                    student.PHAI = row.ItemArray[3].ToString();
                    student.DIACHI = row.ItemArray[4].ToString();
                    student.NGAYSINH = DateTime.Parse(row.ItemArray[5].ToString());
                    student.NOISINH = row.ItemArray[6].ToString();
                    student.GHICHU = row.ItemArray[7].ToString();
                    student.NGHIHOC = Boolean.Parse(row.ItemArray[8].ToString());
                    listStudent.Add(student);
                }

                dataGridView1.DataSource = dataSvien;
                dataGridView1.Visible = true;
            }
            catch (Exception ex)
            {
                dataGridView1.Visible = false;
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            ketnoi.Close();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Selected == true)
            {
                dataGridView1.CurrentRow.ReadOnly = false;
            }
        }

        private void btn_DeleteSV_Click(object sender, EventArgs e)
        {
            int MASV = Int32.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            bool success = false;
            SqlCommand cmd = new SqlCommand("XOA_SINHVIEN", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MASV", MASV);
            try
            {
                ketnoi.Open();
                cmd.ExecuteNonQuery();
                success = true;
                MessageBox.Show("Xóa sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                btn_DeleteSV.Visible = false;
            }
            catch (SqlException ex)
            {
                string error = "";
                success = false;
                foreach (string s in ex.Errors)
                {
                    error += s;
                }
                MessageBox.Show(error, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            ketnoi.Close();
            if (success == true)
            {
                LOAD_sinhvien_trong_lop();
            }            
        }

        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < listStudentIndexChange.Count; i++)
            {
                StudentModel student = listStudent.ElementAtOrDefault(i);
                SqlCommand cmd = new SqlCommand("SUA_THONGTIN_SINHVIEN", ketnoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MASV", student.MASV);
                cmd.Parameters.AddWithValue("@HO", student.HO);
                cmd.Parameters.AddWithValue("@TEN", student.TEN);
                cmd.Parameters.AddWithValue("@PHAI", student.PHAI);
                cmd.Parameters.AddWithValue("@NGAYSINH", student.NGAYSINH);
                cmd.Parameters.AddWithValue("@NOISINH", student.NOISINH);
                cmd.Parameters.AddWithValue("@DIACHI", student.DIACHI);
                cmd.Parameters.AddWithValue("@GHICHU", student.GHICHU);
                cmd.Parameters.AddWithValue("@NGHIHOC", student.NGHIHOC);
                ketnoi.Open();
                try
                {                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                catch (SqlException ex)
                {
                    string error = "";
                    for(int j = 0; j < ex.Errors.Count; j++)
                    {
                        error += ex.Errors[j].Message;
                    }
                    MessageBox.Show(error, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ketnoi.Close();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            if (cell != null)
            {
                StudentModel modelChange = listStudent.ElementAtOrDefault(cell.RowIndex);
                
                if (modelChange != null)
                {
                    switch (cell.ColumnIndex)
                    {
                        case 1:
                            modelChange.HO = cell.EditedFormattedValue.ToString();
                            break;
                        case 2:
                            modelChange.TEN = cell.EditedFormattedValue.ToString();
                            break;
                        case 3:
                            modelChange.PHAI = cell.EditedFormattedValue.ToString();
                            break;
                        case 4:
                            modelChange.DIACHI = cell.EditedFormattedValue.ToString();
                            break;
                        case 5:
                            modelChange.NGAYSINH = DateTime.Parse(cell.EditedFormattedValue.ToString());
                            break;
                        case 6:
                            modelChange.NOISINH = cell.EditedFormattedValue.ToString();
                            break;
                        case 7:
                            modelChange.GHICHU = cell.EditedFormattedValue.ToString();
                            break;
                        case 8:
                            modelChange.NGHIHOC = Boolean.Parse(cell.EditedFormattedValue.ToString());
                            break;
                    }
                    if (listStudentIndexChange.Any(x => x == cell.RowIndex) == false)
                    {
                        listStudentIndexChange.Add(cell.RowIndex);
                    }
                    btn_SAVE.Visible = true;
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            if (row != null)
            {
                if (row.Selected)
                {
                    btn_DeleteSV.Visible = true;
                }
            }
        }

    }
}
