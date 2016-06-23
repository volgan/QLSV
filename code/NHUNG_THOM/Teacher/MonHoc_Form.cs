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
    public partial class MONHOC : Form
    {
        private SqlConnection ketnoi = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NHUNG_THOM_Connection"].ConnectionString);
        private string SubjectID;
        private string SubjectName;
        public MONHOC()
        {
            InitializeComponent();
        }
        private void KetNoiCSDL()
        {

            //ketnoi.ConnectionString = ConfigurationSettings.AppSettings["NHUNG_THOM_Connection"];
            SqlCommand cmd = new SqlCommand("LAY_DS_MONHOC", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            ketnoi.Open();
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            Adapter.Fill(dataTable);
            ketnoi.Close();
            dataGridView1.DataSource = dataTable;
        }

        private void MONHOC_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
        }

        private void btn_Add_Subject_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("NHAPMONHOC", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MAMH", txt_MaMH.Text.Trim());
            cmd.Parameters.AddWithValue("@TENMH", txt_TenMH.Text.Trim());
            ketnoi.Open();
            try
            {
                cmd.ExecuteNonQuery();
                txt_MaMH.Text = "";
                txt_TenMH.Text = "";
                SetSuccess("Thêm môn học thành công");
            }
            catch (SqlException ex)
            {
                SetError(ex);
            }
            ketnoi.Close();
            KetNoiCSDL();
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
        private void btn_Edit_Subject_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to edit this subject?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(txt_MaMH.Text))
                {
                    SqlCommand cmd = new SqlCommand("SUA_THONGTIN_MONHOC", ketnoi);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MAMH_OLD", SubjectID);
                    cmd.Parameters.AddWithValue("@MAMH_NEW", txt_MaMH.Text.Trim());
                    cmd.Parameters.AddWithValue("@TENMH", txt_TenMH.Text.Trim());
                    ketnoi.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        txt_MaMH.Text = "";
                        txt_TenMH.Text = "";
                        SetSuccess("Cập nhật môn học thành công");
                    }
                    catch (SqlException ex)
                    {
                        SetError(ex);
                    }
                    ketnoi.Close();
                    KetNoiCSDL();
                }
            }
        }

        private void btn_Delete_Subject_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete this subject?", "Question", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(txt_MaMH.Text))
                {
                    SqlCommand cmd = new SqlCommand("XOA_MONHOC", ketnoi);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@MAMH", txt_MaMH.Text);
                    ketnoi.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        SetSuccess("Xóa môn học thành công");
                    }
                    catch (SqlException ex)
                    {
                        SetError(ex);
                    }
                    ketnoi.Close();
                    KetNoiCSDL();
                }
            }
        }       


        private void txt_MaMH_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_MaMH.Text.Trim()))
            {
                bool check1 = txt_MaMH.Text.Trim().Equals(SubjectID);
                bool check2 = !string.IsNullOrWhiteSpace(SubjectID);
               if (txt_MaMH.Text.Trim().Equals(SubjectID) == false && !string.IsNullOrWhiteSpace(SubjectID))
                {
                    btn_Edit_Subject.Enabled = true;
                }
                else
                {
                    btn_Edit_Subject.Enabled = false;
                }
            }
            else
            {
                btn_Edit_Subject.Enabled = false;
            }
        }

        private void txt_TenMH_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txt_TenMH.Text.Trim()))
            {
                if (!txt_TenMH.Text.Trim().Equals(SubjectName) && !string.IsNullOrWhiteSpace(SubjectName))
                {
                    btn_Edit_Subject.Enabled = true;
                }
                else
                {
                    btn_Edit_Subject.Enabled = false;
                }
            }
            else
            {
                btn_Edit_Subject.Enabled = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Selected == true)
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Selected)
                        {
                            btn_Delete_Subject.Enabled = true;
                            btn_Add_Subject.Enabled = false;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.ColumnIndex == 1)
                                {
                                    SubjectID = cell.Value.ToString();
                                }
                                if (cell.ColumnIndex == 2)
                                {
                                    SubjectName = cell.Value.ToString();
                                }
                            }
                            txt_MaMH.DataBindings.Clear();
                            txt_MaMH.DataBindings.Add("text", dataGridView1.DataSource, "MAMH");
                            txt_TenMH.DataBindings.Clear();
                            txt_TenMH.DataBindings.Add("text", dataGridView1.DataSource, "TENMH");
                            break;
                        }
                    }
                }
            }catch (Exception ex)
            {

            }
        }

        private void btn_Cancle_Click(object sender, EventArgs e)
        {
            txt_MaMH.Text = "";
            txt_TenMH.Text = "";
            btn_Delete_Subject.Enabled = false;
            btn_Edit_Subject.Enabled = false;
            btn_Add_Subject.Enabled = true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected)
                {
                    row.Selected = false;
                    break;
                }
            }
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
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

    }
}
