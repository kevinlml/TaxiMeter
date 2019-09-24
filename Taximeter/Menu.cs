using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taximeter
{
    public partial class Menu : Form
    {
        int    NumTrip, blc;
        double GasCost, MLG, Stime, Etime, Vspeed, Fuel ,FlLiters;
        private void BttnGaslvl_Click(object sender, EventArgs e)
        {
            if (txtInitialFuel.Text == "")
            {
                txtInitialFuel.Focus();
            }
            else
            {
                ClsGlobal.Gaslvl = Convert.ToDouble(txtInitialFuel.Text);
                lblGaslvl.Text = txtInitialFuel.Text;
                BttnGaslvl.Enabled = false;
                txtInitialFuel.Enabled = false;
                bttnPickUpPgr.Enabled = true;
                bttnMenuFillGas.Enabled = true;
                bttn2dmenu.Enabled = true;
            }
        }

        private void bttnCarsFlLvl_Click(object sender, EventArgs e)
        {

        }

        private void bttn2dmenu_Click(object sender, EventArgs e)
        {
            Menu2 fvd = new Menu2();
            fvd.Show();
            this.Hide();
        }

        private void bttnMenuFillGass_Click(object sender, EventArgs e)
        {
            bttnPickUpPgr.Enabled = false;
            bttnMenuFillGas.Enabled = false;
            this.Width = 410;
        }

        private void bttnback_Click(object sender, EventArgs e)
        {
            this.Width = 150;
            txtIntlTime.Enabled = false;
            txtFnlTime.Enabled = false;
            txtIS.Enabled = false;
            BttnCle.Enabled = false;
            bttnback.Enabled = false;
            bttnMenuFillGas.Enabled = true;
            bttnPickUpPgr.Enabled = true;
            lblprice.Text = "0";

        }

        private void bttnback2_Click(object sender, EventArgs e)
        {
            this.Width = 150;
            bttnPickUpPgr.Enabled = true;
            bttnMenuFillGas.Enabled = true;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btnrefuel_Click(object sender, EventArgs e)
        {
            double totalGascost, finalprice;
            FlLiters = Convert.ToDouble(txtLitters.Text);
            GasCost = Convert.ToDouble(txtgasprice.Text);
            blc = ClsGlobal.balance;
            totalGascost = (GasCost / 100) + 1;
            finalprice = FlLiters * totalGascost;
            lblGasTotal.Text = finalprice.ToString();

            if (blc > finalprice)
            {
                Fuel = Fuel + FlLiters;
                ClsGlobal.Gaslvl = Fuel;
                lblGaslvl.Text = Fuel.ToString();
                MessageBox.Show("Refuel successed fuel", "Refuel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                blc = blc - Convert.ToInt32(finalprice);
                ClsGlobal.balance = blc;
            }
            else
            {
                MessageBox.Show("Not enough balance to make the transaction", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }

        }

        private void BttnTtlnTrips_Click(object sender, EventArgs e)
        {
            NumTrip = ClsGlobal.NumerOfTrips;
            MessageBox.Show("Number of trips done: " + NumTrip, "Trips", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BttnCarsMilage_Click(object sender, EventArgs e)
        {
            MLG = ClsGlobal.Mileage;
            MessageBox.Show("Milage: " + MLG, "MLG", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void BttnCle_Click(object sender, EventArgs e)
        {
            double TimeTraveling, TravalingPrice;
            Stime = Convert.ToInt32(txtIntlTime.Text);
            Etime = Convert.ToInt32(txtFnlTime.Text);
            
            
            TimeTraveling = (Etime - Stime);

            if (TimeTraveling > 12)
            { MessageBox.Show("A single trip cannot be more than 12 hours", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtIS.Text == "" || txtFnlTime.Text == "" || txtFnlTime.Text == "")
            {
                txtIS.Focus();
            }
            else if (TimeTraveling <= 12)
            {
               
                if (Stime >= 0 && Etime <= 8)
                {

                    TravalingPrice = (Stime - Etime) * -30;
                    lblprice.Text = TravalingPrice.ToString();
                    blc = ClsGlobal.balance + Convert.ToInt32(lblprice.Text);
                   
                    ClsGlobal.balance = blc;
                }
                else if (Stime >= 0 && Etime > 8 && Etime <= 12)
                {
                    double x;
                    x = (8 - Stime) * 30;
                    TravalingPrice = (Etime - 8) * 20 + x;
                    lblprice.Text = TravalingPrice.ToString();
                    blc = ClsGlobal.balance + Convert.ToInt32(lblprice.Text);
                    
                    ClsGlobal.balance = blc;
                }
                else if (Stime >= 8 && Etime <= 14)
                {
                    TravalingPrice = (Etime - Stime) * 20;
                    lblprice.Text = TravalingPrice.ToString();
                    blc = ClsGlobal.balance + Convert.ToInt32(lblprice.Text);
                   
                    ClsGlobal.balance = blc;
                }
                else if (Stime >= 8 && Etime > 14 && Etime <= 20)
                {
                    double x;
                    x = (14 - Stime) * 20;
                    TravalingPrice = (Etime - 14) * 25 + x;

                    lblprice.Text = TravalingPrice.ToString();
                    blc = ClsGlobal.balance + Convert.ToInt32(lblprice.Text);
                    
                    ClsGlobal.balance = blc;
                }
                else if (Stime >= 14 && Etime <= 0)
                {
                    TravalingPrice = (Etime - Stime) * 25;
                    lblprice.Text = TravalingPrice.ToString();
                    blc = ClsGlobal.balance + Convert.ToInt32(lblprice.Text);
                    
                    ClsGlobal.balance = blc;
                }
                else if (Stime >= 14 && Etime > 0 && Etime <= 2)
                {
                    double x;
                    x = (14 - Stime) * 25;
                    TravalingPrice = (Etime - 14) * 30 + x;

                    lblprice.Text = TravalingPrice.ToString();
                    blc = ClsGlobal.balance + Convert.ToInt32(lblprice.Text);
                   
                    ClsGlobal.balance = blc;
                }
                else
                {
                    MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Fuel = ClsGlobal.Gaslvl;
                Vspeed = Convert.ToInt32(txtIS.Text);
                Fuel = Fuel - (((Etime - Stime) * Math.Abs(Math.Tan(Vspeed * (Etime - Stime)))) + Math.Abs(Math.Cos(Vspeed)));
                lblGaslvl.Text = Convert.ToString(Convert.ToInt32(Fuel));
                MLG = MLG + Math.Pow(Vspeed, 2 * (Etime - Stime)) - Vspeed * Etime - Stime;
                lblMileage.Text = Convert.ToString(MLG);
                ClsGlobal.Gaslvl = Fuel;
                ClsGlobal.Mileage = MLG;
                NumTrip = NumTrip + 1;
                ClsGlobal.NumerOfTrips = NumTrip;
                txtIntlTime.Clear();
                txtIS.Clear();
                txtFnlTime.Clear();
            }
        }

        private void BttnNetIncome_Click(object sender, EventArgs e)
        {   }

      
        public Menu()
        {
            InitializeComponent();
            blc = ClsGlobal.balance;
            if (blc == 0)
            { txtInitialFuel.Focus(); }
            else {
                BttnGaslvl.Enabled = false;
                txtInitialFuel.Enabled = false;
                bttnPickUpPgr.Enabled = true;
                bttnMenuFillGas.Enabled = true;
                bttn2dmenu.Enabled = true;
            }
        
    }

        private void bttnPickUpPgr_Click(object sender, EventArgs e)
        {
            this.Width = 276;
            txtIntlTime.Enabled = true;
            txtFnlTime.Enabled = true;
            txtIS.Enabled = true;
            BttnCle.Enabled = true;
            bttnMenuFillGas.Enabled = false;
            bttnPickUpPgr.Enabled = false;
        }

       
    }
}





