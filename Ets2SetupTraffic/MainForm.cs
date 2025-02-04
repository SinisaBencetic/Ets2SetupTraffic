using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ets2SetupTraffic
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            var mainFormModel = new MainFormModel()
            {
                TruckMinSpeed = int.Parse(txtTruckMinSpeed.Text),
                TruckMaxSpeed = int.Parse(txtTruckMaxSpeed.Text),
                CarMinSpeed = int.Parse(txtCarMinSpeed.Text),
                CarMaxSpeed = int.Parse(txtCarMaxSpeed.Text),
                BusMinSpeed = int.Parse(txtBusMinSpeed.Text),
                BusMaxSpeed = int.Parse(txtBusMaxSpeed.Text)
            };
            TrafficManager.Run(mainFormModel);
        }


        private void LoadFormValues()
        {
            txtSinTruckMin.Text = ConfigurationManager.AppSettings["TruckMinSpeed"];
            txtSinTruckMax.Text = ConfigurationManager.AppSettings["TruckMaxSpeed"];
            txtSinTruckMinCritical.Text = ConfigurationManager.AppSettings["TruckMinCriticalSpeed"];
            txtSinTruckSpikeFactor.Text = ConfigurationManager.AppSettings["TruckSpikeFactor"];
            txtSinTruckSpikeZone.Text = ConfigurationManager.AppSettings["TruckSpikeZone"];
            txtSinTruckCycleMultiplier.Text = ConfigurationManager.AppSettings["TruckCycleMultiplier"];

            txtSinBusMin.Text = ConfigurationManager.AppSettings["BusMinSpeed"];
            txtSinBusMax.Text = ConfigurationManager.AppSettings["BusMaxSpeed"];
            txtSinBusMinCritical.Text = ConfigurationManager.AppSettings["BusMinCriticalSpeed"];
            txtSinBusSpikeFactor.Text = ConfigurationManager.AppSettings["BusSpikeFactor"];
            txtSinBusSpikeZone.Text = ConfigurationManager.AppSettings["BusSpikeZone"];
            txtSinBusCycleMultiplier.Text = ConfigurationManager.AppSettings["BusCycleMultiplier"];

            txtSinCarMin.Text = ConfigurationManager.AppSettings["CarMinSpeed"];
            txtSinCarMax.Text = ConfigurationManager.AppSettings["CarMaxSpeed"];
            txtSinCarMinCritical.Text = ConfigurationManager.AppSettings["CarMinCriticalSpeed"];
            txtSinSpikeCarSpikeFactor.Text = ConfigurationManager.AppSettings["CarSpikeFactor"];
            txtSinSpikeCarZone.Text = ConfigurationManager.AppSettings["CarSpikeZone"];
            txtSinSpikeCarCycleMultiplier.Text = ConfigurationManager.AppSettings["CarCycleMultiplier"];
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFormValues();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txtSinTruckMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSinTruckMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSinTruckMinCritical_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSinSpikeGenerate_Click(object sender, EventArgs e)
        {
            SinSpikeModel model = BindSinSpikeModel();

            var msg = TrafficManager.RunSinusSpike(model);
            if (!string.IsNullOrWhiteSpace(msg))
            {
                {
                    MessageBox.Show(msg);
                }
            }
        }

        private SinSpikeModel BindSinSpikeModel()
        {
            var model = new SinSpikeModel()
            {
                Truck = new SinSpikeGenericModel()
                {
                    MinSpeed = int.Parse(txtSinTruckMin.Text),
                    MaxSpeed = int.Parse(txtSinTruckMax.Text),
                    MinCriticalSpeed = int.Parse(txtSinTruckMinCritical.Text),
                    SpikeFactor = double.Parse(txtSinTruckSpikeFactor.Text),
                    SpikeZone = double.Parse(txtSinTruckSpikeZone.Text),
                    CycleMultiplier = int.Parse(txtSinTruckCycleMultiplier.Text)
                },
                Bus = new SinSpikeGenericModel()
                {
                    MinSpeed = int.Parse(txtSinBusMin.Text),
                    MaxSpeed = int.Parse(txtSinBusMax.Text),
                    MinCriticalSpeed = int.Parse(txtSinBusMinCritical.Text),
                    SpikeFactor = double.Parse(txtSinBusSpikeFactor.Text),
                    SpikeZone = double.Parse(txtSinBusSpikeZone.Text),
                    CycleMultiplier = int.Parse(txtSinBusCycleMultiplier.Text)
                },
                Car = new SinSpikeGenericModel()
                {
                    MinSpeed = int.Parse(txtSinCarMin.Text),
                    MaxSpeed = int.Parse(txtSinCarMax.Text),
                    MinCriticalSpeed = int.Parse(txtSinCarMinCritical.Text),
                    SpikeFactor = double.Parse(txtSinSpikeCarSpikeFactor.Text),
                    SpikeZone = double.Parse(txtSinSpikeCarZone.Text),
                    CycleMultiplier = int.Parse(txtSinSpikeCarCycleMultiplier.Text)
                },                
            };
            return model;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void btnTruckDebug_Click(object sender, EventArgs e)
        {
            var model = BindSinSpikeModel();
            var response = TrafficManager.SinusSpikeDebug(model.Truck, TrafficManager.GetTruckList());
            MessageBox.Show(response.Value);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            var model = BindSinSpikeModel();
            var response = TrafficManager.SinusSpikeDebug(model.Car, TrafficManager.GetCarList());
            MessageBox.Show(response.Value);
        }

        private void btnSinSpikeBusDebug_Click(object sender, EventArgs e)
        {
            var model = BindSinSpikeModel();
            var response = TrafficManager.SinusSpikeDebug(model.Bus, TrafficManager.GetBusList());
            MessageBox.Show(response.Value);
        }
    }
}
