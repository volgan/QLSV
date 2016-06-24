using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer;
using NHUNG_THOM.Teacher;
using System.IO;
using System.Data.SqlClient;
using System.Globalization;
using System.Configuration;
namespace NHUNG_THOM
{
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }

        private void btn_Class_Click(object sender, EventArgs e)
        {
            btn_Class.Enabled = false;
            Form classForm = new LOP();
            classForm.ShowDialog();
            btn_Class.Enabled = true;
        }

        private void btn_Subject_Click(object sender, EventArgs e)
        {
            btn_Subject.Enabled = false;
            Form subjectForm = new MONHOC();
            subjectForm.ShowDialog();
            btn_Subject.Enabled = true;
        }

        private void btn_SV_Click(object sender, EventArgs e)
        {
            btn_SV.Enabled = false;
            Form studentForm = new SinhVien_Form();
            studentForm.ShowDialog();
            btn_SV.Enabled = true;
        }

        private void btn_Point_Click(object sender, EventArgs e)
        {
            btn_Point.Enabled = false;
            Form pointForm = new Diem_Form();
            if (pointForm.ShowDialog() == DialogResult.Cancel)
            {
                btn_Point.Enabled = true;
            }
        }

        private void btn_BackUp_Click(object sender, EventArgs e)
        {
            SqlConnection ketnoi = new SqlConnection(ConfigurationManager.ConnectionStrings["NHUNG_THOM_Connection"].ConnectionString);
            string fileDate = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            fileDate = fileDate.Replace(":", string.Empty);
            string location = Path.GetPathRoot(Application.ExecutablePath) + "/NHUNG_THOM/database/";

            ////string sql = "BACKUP DATABASE [NHUNG_THOM] TO  DISK = '" + location + ".bak'  WITH NOFORMAT, NOINIT,  NAME = N'NHUNG_THOM-Full Database Backup', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";
            SqlCommand cmd = new SqlCommand("BACKUP_DATABSE", ketnoi);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@fileDate", fileDate);
            cmd.Parameters.AddWithValue("@path", location);
            ketnoi.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Backup Database success");                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ketnoi.Close();
            int x = 0;
        }

        private void btn_Restore_Click(object sender, EventArgs e)
        {
            Form restore_form = new RestoreDB_Form();
            restore_form.ShowDialog();
        }

    }
}
