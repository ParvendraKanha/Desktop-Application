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
    public partial class FormErrorHandle : Form
    {
        //ConnectionClass objcon = new ConnectionClass();
        //SqlConnection con;
        //SqlCommand cmd;
        //DataTable dt;
        //SqlDataAdapter adp;
        public FormErrorHandle()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //if (txtFormnum.Text != "" && txtnewcode.Text != "")
            //{
            //    bool b = CheckDuplicate(txtnewcode.Text.ToString());
            //    if (b == false)
            //    {
            //        InsertData();
            //        txtnewcode.Text = "";
            //        txtFormnum.Text = "";
            //    }
            //    else
            //    {
            //        MessageBox.Show("Form number already exists!");
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Please enter old and new both formnumbers!");
            //}
        }

        //private void InsertData()
        //{
        //    try
        //    {
        //        con = new SqlConnection(objcon.SqlConn());
        //        con.Open();
        //        cmd = new SqlCommand();
        //        string strquery = "update member_master set application_no = '" + txtnewcode.Text.Trim().ToString() + "' where application_no = '" + txtFormnum.Text.Trim().ToString() + "'";
        //        cmd.CommandText = strquery;
        //        cmd.CommandType = CommandType.Text;
        //        cmd.Connection = con;
        //        cmd.ExecuteNonQuery();
        //        con.Close();
        //        //SaveStat = true;
        //        // c++;
        //        //progressBar1.PerformStep();
        //        MessageBox.Show("Form number has been updated");
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        //break;
        //    }
        //    finally
        //    {
        //        if (con.State == ConnectionState.Open)
        //            con.Close();
        //    }
        //}








        //private bool CheckDuplicate(string MEMBER_CODE)
        //{
        //    if (txtnewcode.Text.Length <= 6)
        //    {
        //        con = new SqlConnection(objcon.SqlConn());
        //        if (con.State == ConnectionState.Closed)
        //            con.Open();
        //        cmd = new SqlCommand("sp_all", con);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@calltype", 16);
        //        cmd.Parameters.AddWithValue("@app_no", txtFormnum.Text.Trim().ToString());
        //        cmd.Parameters.AddWithValue("@newapp_no", txtnewcode.Text.Trim().ToString());
        //        adp = new SqlDataAdapter();
        //        adp.SelectCommand = cmd;
        //        dt = new DataTable();
        //        adp.Fill(dt);

        //        var RowCount = Int32.Parse(dt.Rows[0]["sucess"].ToString());
        //        if (RowCount > 0)
        //        {

        //            con.Close();
        //            return true;

        //        }
        //        else
        //        {

        //            con.Close();
        //            return false;
        //        }
        //    }
        //    else
        //        return true;
        //}
    }
}
