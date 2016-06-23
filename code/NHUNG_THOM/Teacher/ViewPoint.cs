using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NHUNG_THOM.Teacher
{
    public partial class ViewPoint : Form
    {
        private string classId;
        private SqlConnection ketnoi = new SqlConnection(ConfigurationManager.ConnectionStrings["NHUNG_THOM_Connection"].ConnectionString);
        public ViewPoint(string classId)
        {
            InitializeComponent();
        }

        private void ViewPoint_Load(object sender, EventArgs e)
        {

        }
    }
}
