using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CUESYSv._01
{
    public partial class Form2 : Form
    {
        dbConn mysqlConn = new dbConn();
        public Form2()
        {
            InitializeComponent();
            dbConfig();
            mysqlConn.connect();
        }
        public bool dbConfig()
        {
            try
            {
                mysqlConn.varConfigServer = " odukwec.cucstudents.org";
                mysqlConn.varConfigDatabase = "oc_CUEsys";
                mysqlConn.varConfigUser = "oc_CUEDadmin";
                mysqlConn.varConfigPass = "12345";
                return true;
            }
            catch { return false; }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysqlConn.connOpen();
            string Date = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            string varPaid;
            if (checkBox1.Checked == true) { varPaid = "Y"; }
            else { varPaid = "N"; }
            mysqlConn.insertBooking(CustContact.Text, Airline.Text, Origin.Text, Destination.Text, FlightNumber.Text, Date, Time.Text, Cost.Text, varPaid);
            MessageBox.Show("Booking Comfirmed!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
