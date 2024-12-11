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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=.\\SQLEXPRESS; Initial Catalog=2ITUsers; Integrated Security=True";
            SqlConnection con = new SqlConnection(conStr);
            con.Open();


            string qury = "select * from users";
            SqlCommand cmd = new SqlCommand(qury, con);

            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show("The user id is: " + dr.GetValue(0) + " and first name is: " + dr.GetValue(1));
            }
        }
    }
}
/*
 * - velg Form1.cs[Design] - se på Properties på høyre side
 * - det er likt som css
 * - forklar igjen om namespace, : inherit (arve), public, partial, void, ...
 * - høyre trykk på InitializeComponent() - Go To Definition - for å bli 
 *      kjent med hva som helst object
 * - velg Form1.cs[Design] - View - Toolbox - drag and drop Button
 * - se på properties om Button - endre tekst fra button1 til Hent user data
 * - forklar også litt om index og navn property
 * - double click on Button for å få click event i codebehind - skriv kode sql, ...
 * - Oppave: vise bilde Oppgave-2ITUsers.jpeg
 * - lage ny table: profile i database: 2ITUsers
 * - Add new file i prosjektet - høyre trykk på 2ITUsers - Add - 
 *      Form (Windows Form)...
 * - drag and drop objecter/Controls fra Toolbox for å lage layout 
 * - endre tekst, index og navn på Controls
 * - double click on Submit button to open click event in codebehind
 * - skrive kode for å lagre data i database når man trykker på Submit
*/