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

namespace _2ITUsers
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            // 1
            //MessageBox.Show("Hei fra Submit");
            string strFname = txtFname.Text;
            // 2
            // MessageBox.Show(strFname);
            string strLname = txtLname.Text;
            string strDOB = txtDOB.Text;
            string strAddress = txtAddress.Text;
            int intPostcode = Convert.ToInt32(txtPostcode.Text);
            string strCity = txtCity.Text;
            int intMobile = Convert.ToInt32(txtMobile.Text);
            string strEmail = txtEmail.Text;
            bool bolNewsletter = chkNewsletter.Checked;
            // 3 man får tilbake True eller False
            MessageBox.Show(bolNewsletter.ToString());

            string strDepartment = "";
            if (rbIM.Checked)
            {
                strDepartment = rbIM.Text;
            }
            else if (rbST.Checked)
            {
                strDepartment = rbST.Text;
            }
            else
            {
                strDepartment = rbEL.Text;
            }

            // 4
            // MessageBox.Show(strDepartment);

            // 5 koble med database
            string conStr = "Data Source=.\\SQLEXPRESS; Initial Catalog=2ITUsers; Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();

            // 6 hent insert statement fra database
            // test her først med hardcoded values om app får kontakt med database
            // 
            // string query = "insert into profile values ('Javed', 'Iqbal', '1971.10.20', 'Dalssvingen 17C', 1283, 'Oslo', 40077568, 'paijyj@gmail.com', 1, 'IM')";

            // 7 bytte hardcoded values med variables
            // string query = "insert into profile values ('" + strFname + "', '" + strLname + "', '" + strDOB + "', '" + strAddress + "', " + intPostcode + ", '" + strCity + "', " + intMobile + ", '" + strEmail + "', " + chkNewsletter + ", '" + strDepartment + "')";
            // 8 
            //MessageBox.Show(query);


            //SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            
        }
    }
}

/*
 * alle skal laste opp på GitHub og sende meg lenke på Teams i gruppe
 * 
*/
