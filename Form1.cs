using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IceCream
{
    public partial class Form1: Form
    {
        //Doug Titus
        //COP2010
        //In class project - Ice Cream POS 

        public Form1()
        {
            InitializeComponent();
        }


        int scoopsQty = 0;
        double unitPrice = 0;
        double totalPrice = 0; 

        private void btnComputePrice_Click(object sender, EventArgs e)
        {
            try
            {
                scoopsQty = int.Parse(txtScoops.Text);
                unitPrice = double.Parse(txtUnitPrice.Text);
                totalPrice = scoopsQty * unitPrice;
                txtTotal.Text = totalPrice.ToString("c");
            }//end try

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }//end catch

        }//end method

        private void btnClear_Click(object sender, EventArgs e)
        {
            scoopsQty = 0;
            unitPrice = 0;
            totalPrice = 0;
            txtScoops.Clear();
            txtUnitPrice.Clear();
            txtTotal.Clear();
        }//end method

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
            //Application.Exit();
        }//end method


    }//end class
}//end namespace
