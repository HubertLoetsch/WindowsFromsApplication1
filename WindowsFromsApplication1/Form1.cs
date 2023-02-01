using System.Data.SqlClient;
using System.Text;
using Dapper;
using System.Data.Common;
using System.Data.SqlClient;

namespace WindowsFromsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ProjectConnection NewConnection = new ProjectConnection();
            NewConnection.Connection_Today();
           
            SqlCommand comm = new SqlCommand();
            comm.Connection = ProjectConnection.conn;


            //There are two Field in the Table but int is (1,1) so parameter
            //is not required.

            comm.CommandText = "Insert into master.dbo.Zoo values (@Location)";
            comm.Parameters.AddWithValue("Location", textBox1.Text);
            comm.ExecuteNonQuery();

            MessageBox.Show(textBox1.Text + "      added.", "Added");
            textBox1.Clear();
        }
    }
}