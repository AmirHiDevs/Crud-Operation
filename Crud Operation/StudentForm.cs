using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
namespace Crud_Operation
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }


        private SQLiteConnection con;
        private SQLiteCommand cmd;
        private SQLiteDataAdapter dba;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        


        //set con
        private void setcon()
        {
            con = new SQLiteConnection("Data Source=db.db;Version=3;New=False;Compress=True");
        }

        //set exequery
        private void ExecuteQuery(string txtQuery)
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = txtQuery;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        //set db load
        private void dataload()
        {
            setcon();
            con.Open();
            cmd = con.CreateCommand();
            string cmdtxt = "select * from tb";
            dba = new SQLiteDataAdapter(cmdtxt, con);
            ds.Reset();
            dba.Fill(ds);
            dt = ds.Tables[0];
            dgv.DataSource = dt;
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            dataload();
        }

        private void cbtn_Click(object sender, EventArgs e)
        {
            string txtQuery = 
                "insert into tb (id,name,email)" +
                "values('" + txtid.Text+"','"+txtname.Text+"','"+txtmail.Text+"')";
                ExecuteQuery(txtQuery);
                dataload();

        }

        private void upbtn_Click(object sender, EventArgs e)
        {
            string txtQuery =
                "update tb set name ='" + txtname.Text + "', email='" + txtmail.Text + "' where id='" + txtid.Text + "'";
                ExecuteQuery(txtQuery);
                dataload();
        }

        private void rmbtn_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from tb where id='" + txtid.Text + "'";
            ExecuteQuery(txtQuery);
            dataload();
        }

       

      

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dgv.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            txtmail.Text = dgv.SelectedRows[0].Cells[2].Value.ToString();
        }
    }
}
