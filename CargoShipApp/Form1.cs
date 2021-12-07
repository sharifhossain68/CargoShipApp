using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShipApp
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }

       

      

       

        private void track_motorCycle_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycle.Value;
            UpdateUI();
        }
        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_trucks.Value;
            UpdateUI();
        }
        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_cars.Value;
            UpdateUI();
        }

        private void track_trainTrucks_Scroll(object sender, EventArgs e)
        {
            ship.TrainCount = track_trainTrucks.Value;
            UpdateUI();
        }

        private void btn_newShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            UpdateUI();

        }
        private void UpdateUI()
        {
            progressBar1.Maximum = ship.Capacity;

            if (ship.GetShipLoad() <= ship.Capacity)
            {
                progressBar1.Value = ship.GetShipLoad();
            }
            label_Shiplevel.Text = ship.ToString();

            label_CyclesCount.Text = ship.CycleCount.ToString();
            label_CarsCount.Text = ship.CarCount.ToString();
            label_TrucksCount.Text = ship.TruckCount.ToString();
            label_TraincarCount.Text = ship.TrainCount.ToString();

            //ProgressBar
            if (ship.OverUnder() == 0)
            {
                progressBar1.ForeColor = Color.Green;
            }
             if(ship.OverUnder() >0)
            {
                progressBar1.ForeColor = Color.Yellow;
            }
             if (ship.OverUnder() < 0)
            {
                progressBar1.ForeColor = Color.Red;
            }       

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
        }
    }
}
