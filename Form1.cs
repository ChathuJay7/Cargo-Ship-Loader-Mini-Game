using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CargoShipGUI
{
    public partial class Form1 : Form
    {
        Ship ship = new Ship();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Style = ProgressBarStyle.Continuous;
        }

        private void btn_newShip_Click(object sender, EventArgs e)
        {
            ship = new Ship();
            updateUI();
        }

        private void updateUI()
        {
            // set all of the controls to match the ship properties
            progressBar1.Maximum = ship.Capacity;

            if(ship.getShipLoad() <= ship.Capacity)
            {
                progressBar1.Value = ship.getShipLoad();
            }

            label_shipLabel.Text = ship.ToString();

            // motorcycles
            label_cycleCount.Text = ship.CycleCount.ToString();

            // cars
            label_carCount.Text = ship.CarCount.ToString();

            // trucks
            label_truckCount.Text = ship.TruckCount.ToString();

            // train cars
            label_trainCount.Text = ship.TrainCarCount.ToString();


            if(ship.overUnder() == 0)
            {
                progressBar1.ForeColor = Color.Green;
            }

            if(ship.overUnder() > 0)
            {
                progressBar1.ForeColor= Color.Yellow;
            }

            if(ship.overUnder() < 0)
            {
                progressBar1.ForeColor = Color.Red;
            }
        }

        private void track_motorCycles_Scroll(object sender, EventArgs e)
        {
            ship.CycleCount = track_motorCycles.Value;
            updateUI();
        }

        private void track_trucks_Scroll(object sender, EventArgs e)
        {
            ship.TruckCount = track_trucks.Value;
            updateUI();
        }

        private void track_cars_Scroll(object sender, EventArgs e)
        {
            ship.CarCount = track_cars.Value;
            updateUI();
        }

        private void track_trainCars_Scroll(object sender, EventArgs e)
        {
            ship.TrainCarCount = track_trainCars.Value;
            updateUI();
        }
    }
}
