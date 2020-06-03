using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            if (FormAuthorization.users.type == "agent")
            {
                buttonOpenAgents.Enabled = false;
            }
            labelHello.Text = "Продуктивного вам дня, " + FormAuthorization.users.login;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonAgents_Click(object sender, EventArgs e)
        {
            Form formAgent = new FormAgent();
            formAgent.Show();
        }

        private void buttonOpenClients_Click(object sender, EventArgs e)
        {
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void buttonOpenRealestates_Click(object sender, EventArgs e)
        {
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }

        private void buttonOpenSupplies_Click(object sender, EventArgs e)
        {
            Form formSupplies = new FormSupply();
            formSupplies.Show();
        }

        private void buttonOpenDemands_Click(object sender, EventArgs e)
        {
            Form formDemands = new FormDemandSet();
            formDemands.Show();
        }
    }
}
