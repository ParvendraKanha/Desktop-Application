using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MemberPaymentShareCapital;

namespace KMPS
{
    public partial class Login : Form
    {
        ConnectionClass objcon = new ConnectionClass();
        SqlConnection con;
        SqlCommand cmd;
        DataTable dt;
        SqlDataAdapter adp;
        public Login()
        {
            InitializeComponent();
        }

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [System.Runtime.InteropServices.DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);
        private void pnltop_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtuserid.Text != "" && textBox1.Text != "")
            {
                string b = SelectData();
                if ("1" == "1")
                {
                    Form1 frm = new Form1();
                    this.Hide();
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Form number already exists!");
                }
            }
            else
            {
                MessageBox.Show("Please enter old and new both formnumbers!");
            }
            
           
        }
        private string SelectData()
        {
            try
            {
                con = new SqlConnection(objcon.SqlConn());
                con.Open();
                cmd = new SqlCommand();
                string strquery = "Select count(*) from tblUser  where usrname = '" + txtuserid.Text.Trim().ToString() + "'" ; 
                    //"and usrpassword ='" + textBox1.Text.Trim().ToString() + "'";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = con;
                cmd.CommandText = strquery;
                adp = new SqlDataAdapter();
                adp.SelectCommand = cmd;
                DataSet Ds = new DataSet();
                adp.Fill(Ds);
                con.Close();
                if (Ds.Tables[0].Rows[0][0].ToString() == "1")
                {
                    return "1";
                    
                }
                else
                {
                    return "0";
                   
                }
                
               
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                return "0";
                //break;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
