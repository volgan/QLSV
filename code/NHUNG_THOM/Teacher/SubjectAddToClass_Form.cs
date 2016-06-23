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
    public partial class SubjectAddToClass_Form : Form
    {
        private string classId;
        private string className;
        private string subjectId;
        private DataTable dataTable = new DataTable();
        private SqlConnection ketnoi = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["NHUNG_THOM_Connection"].ConnectionString);
        public SubjectAddToClass_Form(string classId, string className)
        {
            InitializeComponent();
            this.classId = classId;
            this.className = className;
        }
        private void KetNoiCSDL()
        {
            dataTable.Clear();
            SqlCommand cmd = new SqlCommand("LAY_DS_MONHOC_KHONG_THUOC_LOP", ketnoi);
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
            dataGridView1.DataSource = dataTable;
        }

        private void SubjectAddToClass_Form_Load(object sender, EventArgs e)
        {
            KetNoiCSDL();
            label1.Text = this.className;
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
                            btn_Add.Enabled = true;
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (cell.ColumnIndex == 1)
                                {
                                    this.subjectId = cell.Value.ToString();
                                    break;
                                }
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {

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

        private void btn_Add_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("CHON_MONHOC_CHO_LOP", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@MALOP", this.classId);
            cmd.Parameters.AddWithValue("@MAMH", this.subjectId);
            ketnoi.Open();
            try
            {
                cmd.ExecuteNonQuery();
                btn_Add.Enabled = false;
            }
            catch (SqlException ex)
            {
                
            }
            ketnoi.Close();
            KetNoiCSDL();
        }
        private void btn_Exit_Click(object sender, EventArgs e )
        {
            this.Close();
        }
    }
}
