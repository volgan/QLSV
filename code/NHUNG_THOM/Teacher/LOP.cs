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
using System.Configuration;
using NHUNG_THOM.Teacher;

namespace NHUNG_THOM
{
    public partial class LOP : Form
    {
        private string ClassID;
        private string className;
        private DataTable dataTable = new DataTable();
        private SqlConnection ketnoi = new SqlConnection(ConfigurationManager.ConnectionStrings["NHUNG_THOM_Connection"].ConnectionString);
        private Boolean checkRowClick = false;       

        public LOP()
        {
            InitializeComponent();
        }

        private void KetNoiCSDL()
        {
            dataTable.Clear();
            //ketnoi.ConnectionString = ConfigurationSettings.AppSettings["NHUNG_THOM_Connection"];
            SqlCommand cmd = new SqlCommand("GetAllClass", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            ketnoi.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            Adapter.Fill(dataTable);
            ketnoi.Close();
            dataGridView1.DataSource = dataTable;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                row.ReadOnly = true;
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            String malop = txt_MALOP.Text;
            String tenlop = txt_TENLOP.Text;            

            SqlCommand cmd = new SqlCommand("NHAPLOP", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MALOP", malop.Trim());
            cmd.Parameters.AddWithValue("@TENLOP", tenlop.Trim());
            ketnoi.Open();
            try
            {
                cmd.ExecuteNonQuery();
                SetSuccess("Tạo lớp thành công");
            }
            catch (SqlException ex)
            {
                SetError(ex);
            }
            ketnoi.Close();
            KetNoiCSDL();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }

        private void dataGridView1_SelectionChanged(object sender, System.EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Selected == true)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Selected)
                        {

                            checkRowClick = true;
                            btn_Delete.Enabled = true;
                            btn_Add.Enabled = false;                            
                            btn_ViewPoint.Enabled = true;
                            btn_Add_Subject_To_Class.Enabled = true;
                            foreach (DataGridViewCell cell in row.Cells)
                            {                                
                                if (cell.ColumnIndex == 1)
                                {
                                    this.ClassID = cell.Value.ToString().Trim();
                                }
                                else if (cell.ColumnIndex == 2)
                                {
                                    this.className = cell.Value.ToString().Trim();
                                    break;
                                }
                            }
                            txt_MALOP.DataBindings.Clear();
                            txt_MALOP.DataBindings.Add("text", dataGridView1.DataSource, "MALOP");
                            txt_TENLOP.DataBindings.Clear();
                            txt_TENLOP.DataBindings.Add("text", dataGridView1.DataSource, "TENLOP");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Update_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_MALOP.Text))
            {
                SqlCommand cmd = new SqlCommand("SUA_THONGTIN_LOP", ketnoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MALOP_OLD", this.ClassID);
                cmd.Parameters.AddWithValue("@MALOP_NEW", txt_MALOP.Text);
                cmd.Parameters.AddWithValue("@TENLOP", txt_TENLOP.Text);
                ketnoi.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    SetSuccess("Cập nhật thông tin lớp thành công");
                }
                catch (SqlException ex)
                {
                    SetError(ex);
                }
                ketnoi.Close();
                KetNoiCSDL();
            }
        }

        private void btn_Delete_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_MALOP.Text))
            {
                SqlCommand cmd = new SqlCommand("XOA_LOP", ketnoi);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MALOP", ClassID);
                ketnoi.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                    SetSuccess("Xóa lớp thành công");
                }
                catch (SqlException ex)
                {
                    SetError(ex);
                }
                ketnoi.Close();
                KetNoiCSDL();
            }
        }
        private void SetError(SqlException ex)
        {
            string error = "";
            for (int i = 0; i < ex.Errors.Count; i++)
                error += ex.Errors[i].Message + "\n";
            MessageBox.Show(error, "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void SetSuccess(string SuccessMess)
        {
            MessageBox.Show(SuccessMess, "THÀNH CÔNG", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void txt_MALOP_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_MALOP.Text.Trim()))
            {
                if (!txt_MALOP.Text.Trim().Equals(this.ClassID) && checkRowClick == true)
                {
                    btn_Update.Enabled = true;
                    btn_Add_Subject_To_Class.Enabled = false;
                    btn_ViewPoint.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    btn_Update.Enabled = false;
                }
            }
            else
            {
                btn_Update.Enabled = false;
            }
        }

        private void txt_TENLOP_TextChanged(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_TENLOP.Text.Trim()))
            {
                if (!txt_TENLOP.Text.Trim().Equals(TENLOP) && checkRowClick == false)
                {
                    btn_Update.Enabled = true;
                    btn_Add_Subject_To_Class.Enabled = false;
                    btn_ViewPoint.Enabled = false;
                    btn_Delete.Enabled = false;
                }
                else
                {
                    btn_Update.Enabled = false;
                }
            }
            else
            {
                btn_Update.Enabled = false;
            }
        }

        private void btn_Cancle_Click(object sender, System.EventArgs e)
        {
            txt_MALOP.Text = "";
            txt_TENLOP.Text = "";
            btn_Delete.Enabled = false;
            btn_Add.Enabled = true;
            btn_Add_Subject_To_Class.Enabled = false;
            btn_ViewPoint.Enabled = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    row.Selected = false;
                    break;
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender,
            DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn newColumn = dataGridView1.Columns[e.ColumnIndex];
            DataGridViewColumn oldColumn = dataGridView1.SortedColumn;
            ListSortDirection direction;

            if (oldColumn != null)
            {
                if (oldColumn == newColumn && dataGridView1.SortOrder == System.Windows.Forms.SortOrder.Ascending)
                {
                    direction = ListSortDirection.Descending;
                }
                else
                {
                    direction = ListSortDirection.Ascending;
                    oldColumn.HeaderCell.SortGlyphDirection = System.Windows.Forms.SortOrder.None;
                }
            }
            else
            {
                direction = ListSortDirection.Ascending;
            }
            dataGridView1.Sort(newColumn, direction);
            newColumn.HeaderCell.SortGlyphDirection = direction == ListSortDirection.Ascending ?
                System.Windows.Forms.SortOrder.Ascending : System.Windows.Forms.SortOrder.Descending;
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.Programmatic;
            }
        }

        private void btn_Add_Subject_To_Class_Click(object sender, System.EventArgs e)
        {
            btn_Add_Subject_To_Class.Enabled = false;
            Form addSubjectToClass_Form = new SubjectAddToClass_Form(this.ClassID, this.className);
            addSubjectToClass_Form.ShowDialog();
            btn_Add_Subject_To_Class.Enabled = true;

        }

        private void btn_ViewPoint_Click(object sender, EventArgs e)
        {
            Form viewPoint = new Teacher.ViewPoint(this.ClassID);
            viewPoint.ShowDialog();
        }
        
    }
}
