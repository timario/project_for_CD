using System;
using System.Windows;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace app_for_CD
{
    public partial class Form_agreement : Form
    {
        public Form_agreement()
        {
            this.SetConnection();
            InitializeComponent();
            
        }

        OracleConnection con = null;

        private void Form_agreement_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "needDataset.NEW_TBCB". При необходимости она может быть перемещена или удалена.
            //this.nEW_TBCBTableAdapter.Fill(this.needDataset.NEW_TBCB);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet2.CHANG_BND_ISU". При необходимости она может быть перемещена или удалена.
         

        }

        private void SetConnection()
        {
            string ConnectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            con = new OracleConnection(ConnectionString);
            try
            {
                con.Open();
            }
            catch (Exception e)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Add add = new Add();
            add.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void button7_Click_1(object sender, EventArgs e)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                //Add table headers going cell by cell.
                oSheet.Cells[1, 1] = "First Name";
                oSheet.Cells[1, 2] = "Last Name";
                oSheet.Cells[1, 3] = "Full Name";
                oSheet.Cells[1, 4] = "Salary";


                // Create an array to multiple values at once.
                string[,] saNames = new string[5, 2];

                saNames[0, 0] = "John";
                saNames[0, 1] = "Smith";
                saNames[1, 0] = "Tom";
                saNames[1, 1] = "Brown";
                saNames[2, 0] = "Sue";
                saNames[2, 1] = "Thomas";
                saNames[3, 0] = "Jane";
                saNames[3, 1] = "Jones";
                saNames[4, 0] = "Adam";
                saNames[4, 1] = "Johnson";
                oSheet.Cells[2, 1] = saNames[0, 0];
            }
            
            catch (Exception theException)
            {
                String errorMessage;
                errorMessage = "Error: ";
                errorMessage = String.Concat(errorMessage, theException.Message);
                errorMessage = String.Concat(errorMessage, " Line: ");
                errorMessage = String.Concat(errorMessage, theException.Source);

                MessageBox.Show(errorMessage, "Error");
            }
        }
    }
    
}
