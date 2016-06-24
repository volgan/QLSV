using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHUNG_THOM.Teacher
{
    public partial class RestoreDB_Form : Form
    {
        private string[] listPath;
        public RestoreDB_Form()
        {
            InitializeComponent();
        }

        private void RestoreDB_Form_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(new DataColumn() { ColumnName = "Index", DataType = Type.GetType("System.Int32") });
            dataTable.Columns.Add(new DataColumn() { ColumnName = "FileName",  DataType = Type.GetType("System.String")});
            dataTable.Columns.Add(new DataColumn() { ColumnName = "CreateDate", DataType = Type.GetType("System.DateTime") });

            DataRow row;
            string path = Path.GetPathRoot(Application.ExecutablePath) + "/NHUNG_THOM/database/";
            try
            {
                listPath = Directory.GetFiles(path, "*.bak");
                int index = 1;

                foreach (string path_ in listPath)
                {                   
                    row = dataTable.NewRow();
                    row["Index"] = index;
                    row["FileName"] = Path.GetFileName(path_);;
                    row["CreateDate"] = File.GetCreationTime(path_);
                    dataTable.Rows.Add(row);
                    index++;
                }

                DataView view = new DataView(dataTable);

                dataGridView1.DataSource = view;
            }
            catch (Exception ex) 
            {
               MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            if (cell.ColumnIndex == 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc thực hiện thao tác này không?", "Truy vấn", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    SqlConnection ketnoi = new SqlConnection(@"Data Source=(localdb)\v11.0;Initial Catalog=master;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("RESTORE_DATABSE", ketnoi);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@path", listPath[dataGridView1.CurrentCell.RowIndex]);
                    ketnoi.Open();
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Restore Database success", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    ketnoi.Close();
                }
            }
        }
    }
}
