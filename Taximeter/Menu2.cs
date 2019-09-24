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
    public partial class Menu2 : Form
    {
        public Menu2()
        {
            InitializeComponent();
        }
        double MLG, Fuel;
        int blc, NumTrip;

        private void BttnNetIncome_Click(object sender, EventArgs e)
        {
            blc = ClsGlobal.balance;
            MessageBox.Show("Your current balance is: " + blc + "$", "Current Balance", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bttnCarsFlLvl_Click(object sender, EventArgs e)
        {
            Fuel = ClsGlobal.Gaslvl;
            MessageBox.Show("Your Fuel level is: " + Fuel, "Fuel level", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            Menu fvd = new Menu();
            
            fvd.Show();
            this.Hide();
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
    }
}
