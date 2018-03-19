using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VelibSoapClientWinForms.VelibSoapServiceReference;

namespace VelibSoapClientWinForms
{
    public partial class VelibSoapClientWinForms : Form
    {
        private VelibSoapServiceClient client;

        public VelibSoapClientWinForms()
        {
            client = new VelibSoapServiceClient();

            InitializeComponent();
            LoadContracts();
        }

        private void LoadContracts()
        {
            listContracts.DataSource = client.GetContracts();
            listContracts.DisplayMember = "Name";
        }

        private void ListStations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var station = listStations.SelectedItem as VelibSoapStation;
            if (station == null)
            {
                return;
            }

            label2.Text = station.Name;
            label4.Text = station.AvailableBikes.ToString();
            label6.Text = station.AvailableBikeStands.ToString();
            label8.Text = station.ContractName;
            label10.Text = station.BikeStands.ToString();
            label12.Text = station.Address;
            label14.Text = station.Number.ToString();
        }

        private void ListContracts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var contract = listContracts.SelectedItem as VelibSoapContract;
            if (contract == null)
            {
                return;
            }

            listStations.DataSource = client.GetStations(contract);
            listStations.DisplayMember = "Name";
        }
    }
}
