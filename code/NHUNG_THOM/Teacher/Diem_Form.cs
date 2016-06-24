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

namespace NHUNG_THOM
{
    public partial class Diem_Form : Form
    {
        private string classId;
        private string subjectId;
        private int lan;
        private int hocky;
        private DataTable dataTable = new DataTable();
        private SqlConnection ketnoi = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NHUNG_THOM_Connection"].ConnectionString);
        private List<StudentPoint> listStudentChange = new List<StudentPoint>();        

        public Diem_Form()
        {
            InitializeComponent();
        }

        private void combo_LOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.classId = ((ComboBoxItem)combo_LOP.SelectedItem).text;
            string Value = ((ComboBoxItem)combo_LOP.SelectedItem).value;
            txt_TENLOP.Text = Value;
            combox_MONHOC.Enabled = true;
            combox_MONHOC.Items.Clear();
            this.subjectId = null;
            LOAD_MONHOC_THEO_LOP();
        }
        private void comboBox_LAN_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lan = Int32.Parse(comboBox_LAN.SelectedItem.ToString());
            int x = 0;
            enable_Start_button();
        }
        private void LOAD_MONHOC_THEO_LOP()
        {
            dataTable.Clear();            
            SqlCommand cmd = new SqlCommand("LAY_DS_MONHOC_THUOC_LOP", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MALOP", this.classId);
            ketnoi.Open();

            try
            {
                cmd.ExecuteNonQuery();
                SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                Adapter.Fill(dataTable);
            }
            catch (SqlException ex)
            {

            }

            ketnoi.Close();
            combox_MONHOC.DisplayMember = "Text";
            combox_MONHOC.ValueMember = "Value";
            foreach (DataRow row in dataTable.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row[4].ToString(), row[3].ToString());
                combox_MONHOC.Items.Add(item);
            }
        }
        private void LOAD_LOP()
        {
            dataTable.Clear();
            //ketnoi.ConnectionString = ConfigurationSettings.AppSettings["NHUNG_THOM_Connection"];
            SqlCommand cmd = new SqlCommand("GetAllClass", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            ketnoi.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            Adapter.Fill(dataTable);
            ketnoi.Close();
            combo_LOP.DisplayMember = "Text";
            combo_LOP.ValueMember = "Value";
            foreach (DataRow row in dataTable.Rows)
            {
                ComboBoxItem item = new ComboBoxItem(row[1].ToString(), row[2].ToString());
                combo_LOP.Items.Add(item);
            }
            foreach (DataColumn column in dataTable.Columns)
            {
                int x = 0;
            }
        }
        private void Diem_Form_Load(object sender, EventArgs e)
        {
            LOAD_LOP();
            comboBox_LAN.SelectedIndex = 0;
        }

        private void combox_MONHOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.subjectId = ((ComboBoxItem)combox_MONHOC.SelectedItem).value;
            enable_Start_button();            
        }
        private void enable_Start_button()
        {
            if ( txt_HKY.TextLength >= 1 && this.subjectId != null && this.classId != null)
            {
                btn_Start.Enabled = true;
            }
        }

        private void txt_HKY_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int lan = Int32.Parse(txt_HKY.Text.Trim());
                enable_Start_button();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {            
            this.hocky = Int32.Parse(txt_HKY.Text.Trim());            
            dataGridView1.Visible = true;
            btn_Start.Enabled = false;
            //txt_HKY.Enabled = false;
            this.listStudentChange.Clear();
            
            if (this.lan == 1)
            {
                
                SqlCommand cmd = new SqlCommand("LAY_DS_DIEM_THILAN1", ketnoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MALOP", this.classId);
                cmd.Parameters.AddWithValue("@MAMH", this.subjectId);
                cmd.Parameters.AddWithValue("@HOCKY", this.hocky);
                ketnoi.Open();
                DataTable dataTable_Student = new DataTable();
                try
                {
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter Adapter = new SqlDataAdapter(cmd);                    
                    Adapter.Fill(dataTable_Student);
                } catch (SqlException ex)
                {

                }
                ketnoi.Close();
                foreach (DataRow row in dataTable_Student.Rows)
                {
                    string x = row.ItemArray[4].ToString();
                    if (!string.IsNullOrWhiteSpace(x))
                    {
                        StudentPoint student = new StudentPoint(row.ItemArray[1].ToString(), float.Parse(row.ItemArray[4].ToString()), this.subjectId);
                        student.exited = true;
                        listStudentChange.Add(student);
                    }
                }
                dataGridView1.DataSource = dataTable_Student;                                
            }
            else
            {
                SqlCommand cmd = new SqlCommand("LAY_DS_DIEM_THILAN1_CHUADAT", ketnoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MALOP", this.classId);
                cmd.Parameters.AddWithValue("@MAMH", this.subjectId);
                cmd.Parameters.AddWithValue("@HOCKY", this.hocky);
                ketnoi.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable_Student = new DataTable();
                    Adapter.Fill(dataTable_Student);
                    ketnoi.Close();
                    dataGridView1.DataSource = dataTable_Student;
                }catch (SqlException ex)
                {
                    string error = "";
                    for(int i = 0; i < ex.Errors.Count; i++)
                    {
                        error += ex.Errors[i].Message + "\n";
                    }
                    dataGridView1.Visible = false;
                    MessageBox.Show(error, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                ketnoi.Close();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {            
            DataGridViewCell cell = dataGridView1.CurrentCell;
            try
            {                
                try
                {                    
                    float diem = float.Parse(cell.Value.ToString().Trim());
                    if (diem == -1 || (diem >=0 && diem <= 10))
                    {                        
                        DataGridViewRow row = dataGridView1.Rows[cell.RowIndex];
                        string studentId = row.Cells["MASV"].Value.ToString();
                        StudentPoint studentExit = listStudentChange.Find(x => (x.subjectId == this.subjectId && x.studentId == studentId));
                        if (studentExit == null)
                        {
                            StudentPoint studentChange = new StudentPoint(studentId, diem, this.subjectId);                            
                            this.listStudentChange.Add(studentChange);
                        }
                        else
                        {
                            studentExit.point = diem;                            
                        }

                        btn_SAVE.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Điểm trong khoảng từ 0 -> 10. Nếu sinh viên vắng thì nhập -1", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Điểm trong khoảng từ 0 -> 10. Nếu sinh viên vắng thì nhập -1", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }catch (Exception ex)
            {
                string k = ex.Message;
            }
        }

        private void SAVE_POINT(StudentPoint student)
        {
            SqlCommand cmd = new SqlCommand("NHAPDIEM", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MASV", student.studentId);
            cmd.Parameters.AddWithValue("@MAMH", student.subjectId);
            cmd.Parameters.AddWithValue("@HOCKY", this.hocky);
            cmd.Parameters.AddWithValue("@LAN", this.lan);
            cmd.Parameters.AddWithValue("@DIEM", student.point);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            ketnoi.Close();
        }
        private void UPDATE_POINT(StudentPoint student)
        {
            SqlCommand cmd = new SqlCommand("SUA_DIEM", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MASV", student.studentId);
            cmd.Parameters.AddWithValue("@MAMH", student.subjectId);
            cmd.Parameters.AddWithValue("@HOCKY", this.hocky);
            cmd.Parameters.AddWithValue("@LAN", this.lan);
            cmd.Parameters.AddWithValue("@DIEM", student.point);
            ketnoi.Open();
            cmd.ExecuteNonQuery();
            ketnoi.Close();
        }
        private void btn_SAVE_Click(object sender, EventArgs e)
        {
            foreach(StudentPoint student in listStudentChange.ToList())
            {
                if (student.exited == false)
                {
                    SAVE_POINT(student);
                }
                else
                {
                    UPDATE_POINT(student);
                }
            }
        }        
    }
}
