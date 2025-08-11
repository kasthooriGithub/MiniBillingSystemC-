using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1stSemiProject
{
    public partial class mainfrm : Form
    {
        double ChocolateCake=1200.00;
        double ButterCake = 750.00;
        double ChocolateSwissRoll = 380.00;
        double RibbonCake = 995.00;
        double VanillaMuffin = 825.00;
        double BlueberryMuffin = 825.00;
        double CreamBun = 220.00;
        double LionDatecake = 750.00;
        double RollVeg = 80.00;
        double ButterRusk = 675.00;
        double TeaBun = 110.00;

        double[] items=new double[12];
        

        public mainfrm()
        {
            InitializeComponent();
        }

        private void mainfrm_Load(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {
                iExit = MessageBox.Show("confirm if you went to exit", "Billing Invoice System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            qty_CCake.Value = 0;
            qty_ButterCake.Value = 0;
            qty_VanillaMuffin.Value = 0;
            qty_CSwissRoll.Value = 0;
            qty_ButterRusk.Value = 0;
            qty_BlueberryMaffin.Value = 0;
            qty_RibbonCake.Value = 0;
            qty_TeaBun.Value = 0;
            qty_Roll.Value = 0;
            qty_CreamBun.Value = 0;  
            qty_LDCake.Value = 0;

            rt_receipt.Clear();
            lbl_COI_CCake.Text = "";
            lbl_COI_ButterCake.Text = "";
            lbl_COI_VanillaMuffin.Text = "";
            lbl_COI_CSwissRoll.Text = "";
            lbl_COI_ButterRusk.Text = "";
            lbl_COI_BlueberryMuffin.Text = "";
            lbl_COI_RibbonCake.Text = "";
            lbl_COI_TeaBun.Text = "";
            lbl_COI_Roll.Text = "";
            lbl_COI_CreamBun.Text = "";
            lbl_COI_LDCake.Text = "";
            lbl_qtyItems.Text = "";
            lbl_total.Text = "";
        }

        private void btn_print_Click(object sender, EventArgs e)
        {
            try
            {
              printPreviewDialog1.ShowDialog();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message, "Billing Ivoice System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                System.Drawing.Font fntString = new System.Drawing.Font("Times New Roman",20,FontStyle.Regular);
                e.Graphics.DrawString(rt_receipt.Text, fntString,Brushes.Black,120,120);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Billing Invoice System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_Receipt_Click(object sender, EventArgs e)
        {
           

            rt_receipt.Clear();
            rt_receipt.AppendText(label2.Text + "\t" + "\t" + lbl.Text + "\t" + label5.Text + "\n" + "\n");
            rt_receipt.AppendText(lbl_C_Cake.Text + "\t" + "\t"+ "\t" + qty_CCake.Value + "\t"+ "\t" + lbl_COI_CCake.Text + "\n");
            rt_receipt.AppendText(lbl_ButterCake.Text + "\t" + "\t" + qty_ButterCake.Value + "\t" + "\t" + lbl_COI_ButterCake.Text + "\n");
            rt_receipt.AppendText(lbl_C_SwissRoll.Text + "\t" + "\t" + qty_CSwissRoll.Value + "\t" + "\t" + lbl_COI_CSwissRoll.Text + "\n");
            rt_receipt.AppendText(lbl_RibbonCake.Text + "\t" + "\t" + qty_RibbonCake.Value + "\t" + "\t" + lbl_COI_RibbonCake.Text+ "\n");
            rt_receipt.AppendText(lbl_VanillaMuffin.Text + "\t" + "\t" + qty_VanillaMuffin.Value + "\t" + "\t" + lbl_COI_VanillaMuffin.Text + "\n");
            rt_receipt.AppendText(lbl_Blueberry.Text + "\t" + "\t" + qty_BlueberryMaffin.Value + "\t" + "\t" + lbl_COI_BlueberryMuffin.Text + "\n");
            rt_receipt.AppendText(lbl_CreamBun.Text + "\t" + "\t" + qty_CreamBun.Value + "\t" + "\t" + lbl_COI_CreamBun.Text + "\n");
            rt_receipt.AppendText(lbl_LDCake.Text+ "\t" + "\t" + qty_LDCake.Value + "\t" + "\t" + lbl_COI_LDCake.Text + "\n");
            rt_receipt.AppendText(lbl_V_roll.Text + "\t" + "\t" + qty_Roll.Value + "\t" + "\t" + lbl_COI_Roll.Text + "\n");
            rt_receipt.AppendText(lbl_ButterRusk.Text + "\t" + "\t" + qty_ButterRusk.Value + "\t" + "\t" + lbl_COI_ButterRusk.Text + "\n");
            rt_receipt.AppendText(lbl_TeaBun.Text + "\t" + "\t" + "\t" + qty_TeaBun.Value + "\t" + "\t" + lbl_COI_TeaBun.Text + "\n" + "\n");
            rt_receipt.AppendText(label27.Text + "\t" + "\t" + "\t" + lbl_qtyItems.Text + "\t" + "\t" + lbl_total.Text + "\n");
        }

        private void qty_CCake_ValueChanged(object sender, EventArgs e)
        {
            double i= Convert.ToDouble(qty_CCake.Value);
            lbl_COI_CCake.Text = string.Format("{0:C}",i * ChocolateCake);
        }

        private void qty_ButterCake_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(qty_ButterCake.Value);
            lbl_COI_ButterCake.Text = string.Format("{0:C}", i * ButterCake);
        }

        private void qty_CSwissRoll_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(qty_CSwissRoll.Value);
            lbl_COI_CSwissRoll.Text = string.Format("{0:C}", i * ChocolateSwissRoll);
        }

        private void qty_RibbonCake_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(qty_RibbonCake.Value);
            lbl_COI_RibbonCake.Text = string.Format("{0:C}", i * RibbonCake);
        }

        private void qty_VanillaMuffin_ValueChanged(object sender, EventArgs e)
        {
            double i=Convert.ToDouble(qty_VanillaMuffin.Value);
            lbl_COI_VanillaMuffin.Text = string.Format("{0:C}", i * VanillaMuffin);
        }

        private void qty_BlueberryMaffin_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(qty_BlueberryMaffin.Value);
            lbl_COI_BlueberryMuffin.Text = string.Format("{0:C}", i * BlueberryMuffin);
        }

        private void qty_CreamBun_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(qty_CreamBun.Value);
            lbl_COI_CreamBun.Text = string.Format("{0:C}", i * CreamBun);
        }

        private void qty_LDCake_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(qty_LDCake.Value);
            lbl_COI_LDCake.Text = string.Format("{0:C}", i *LionDatecake);
        }

        private void qty_Roll_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(qty_Roll.Value);
            lbl_COI_Roll.Text = string.Format("{0:C}", i * RollVeg);
        }

        private void qty_ButterRusk_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(qty_ButterRusk.Value);
            lbl_COI_ButterRusk.Text = string.Format("{0:C}", i * ButterRusk);
        }

        private void qty_TeaBun_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(qty_TeaBun.Value);
            lbl_COI_TeaBun.Text = string.Format("{0:C}", i * TeaBun);
        }

        private void btn_total_Click(object sender, EventArgs e)
        {
            double[] q=new double[12];
            q[0] = Convert.ToDouble(qty_CCake.Value);
            q[1] = Convert.ToDouble(qty_ButterCake.Value);
            q[2] = Convert.ToDouble(qty_CSwissRoll.Value);
            q[3] = Convert.ToDouble(qty_RibbonCake.Value);
            q[4] = Convert.ToDouble(qty_VanillaMuffin.Value);
            q[5] = Convert.ToDouble(qty_BlueberryMaffin.Value);
            q[6] = Convert.ToDouble(qty_CreamBun.Value);
            q[7] = Convert.ToDouble(qty_LDCake.Value);
            q[8] = Convert.ToDouble(qty_Roll.Value);
            q[9] = Convert.ToDouble(qty_ButterRusk.Value);
            q[10] = Convert.ToDouble(qty_TeaBun.Value);

            q[11] = q[0] + q[1] + q[2] + q[3] + q[4] + q[5] + q[6] + q[7] + q[8] + q[9] + q[10] ;
            lbl_qtyItems.Text = Convert.ToString(q[11]);

            items[0] = q[0] * ChocolateCake;
            items[1] = q[1] * ButterCake;
            items[2] = q[2] * ChocolateSwissRoll;
            items[3] = q[3] * RibbonCake;
            items[4] = q[4] * VanillaMuffin;
            items[5] = q[5] * BlueberryMuffin;
            items[6] = q[6] * CreamBun;
            items[7] = q[7] * LionDatecake;
            items[8] = q[8] * RollVeg;
            items[9] = q[9] * ButterRusk;
            items[10] = q[10] * TeaBun;

            items[11] = items[0] + items[1]  + items[2] + items[3] + items[4] + items[5] + items[6] + items[7] + items[8] + items[9] + items[10];
            lbl_total.Text = string.Format("{0:C}", items[11]);
            
        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
