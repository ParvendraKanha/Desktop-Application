using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemberPaymentShareCapital
{
    class ConnectionClass
    {
        public string Constr()
        {


          //  return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + System.Windows.Forms.Application.StartupPath + "\\MeMregnddb.mdb;User Id=Admin;password=KyP@321; Jet OLEDB:Database Password=KyP@321;Persist Security Info=True;Jet OLEDB:System database=" + System.Windows.Forms.Application.StartupPath + "\\MeMregnddb.mdw";


              return "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\MeMregnddb.mdb; User Id=Admin;password=KyP@321; Jet OLEDB:Database Password=nddbds@789;Persist Security Info=True;Jet OLEDB:System database=C:\\MeMregnddb.mdw";

             // return "Provider=Microsoft.ACE.OLEDB.4.0;Data Source=C:\\MeMregnddb.mdb; User Id=Admin;password=KyP@321; Jet OLEDB:Database Password=KyP@321;Persist Security Info=True;Jet OLEDB:System database=C:\\MeMregnddb.mdw";

        }

        public string SqlConn()
        {
            string connetionString = null;
            //connetionString = "Data Source=H81-M1\\SQLEXPRESS;Initial Catalog=IMMS_00004_Blank;User ID=sa;Password=sa@123"; // bmc1
            // connetionString = "Data Source=H81-M1\\SQLEXPRESS;Initial Catalog=IMMS_00004_Blank;User ID=sa;Password=sareil";// bmc2
            // connetionString = "Data Source=SakhiMAH45921RB;Initial Catalog=MILKNET;User ID=sa;Password=CFdwrEK$G4c$";// server
            connetionString = "Data Source=NDDBDS-245L\\SQLEXPRESS;Initial Catalog=Kanha;Integrated Security=true;Connection Timeout=1500;";

           // connetionString = "Data Source=SakhiMAH45921RB;Initial Catalog=MILKNET;Integrated Security=true;Connection Timeout=1500";
            // server
          //  connetionString = "Data Source=45.114.245.181;Initial Catalog=MILKNET;uid=sa;pwd=M!lknet@123;Connection Timeout=1500";// server

          //  connetionString = "Data Source=.;Initial Catalog=MILKNET;User ID=sa;Password=pass@123";

            return connetionString;
            
            //SqlConnection cnn;
            //cnn = new SqlConnection(connetionString);
            //try
            //{
            //    cnn.Open();
            //    MessageBox.Show ("Connection Open ! ");
            //    cnn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Can not open connection ! "+ ex);
            //}


        }

        public string EverestSqlConn()
        {
            string connetionString = null;
            //connetionString = "Data Source=H81-M1\\SQLEXPRESS;Initial Catalog=IMMS_00004_Blank;User ID=sa;Password=sareil123"; // bmc1
            // connetionString = "Data Source=H81-M1\\SQLEXPRESS;Initial Catalog=IMMS_00004_Blank;User ID=sa;Password=sareil";// bmc2
            // connetionString = "Data Source=SakhiMAH45921RB;Initial Catalog=MILKNET;User ID=sa;Password=CFdwrEK$G4c$";// server

            connetionString = "Data Source=NDDBDS-245L;Initial Catalog=MILKNET;Integrated Security=true;Connection Timeout=1500;uid=sa;pwd=Welcome1;";
            // server
            //  connetionString = "Data Source=45.114.245.181;Initial Catalog=EIPLSAKHI1819;uid=sa;pwd=M!lknet@123;Connection Timeout=1500";// server

           

            // connetionString = "Data Source=.;Initial Catalog=MILKNET;User ID=sa;Password=pass@123";

            return connetionString;

            //SqlConnection cnn;
            //cnn = new SqlConnection(connetionString);
            //try
            //{
            //    cnn.Open();
            //    MessageBox.Show ("Connection Open ! ");
            //    cnn.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Can not open connection ! "+ ex);
            //}


        }
    }
}
