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
    public partial class FormSupply : Form
    {
        public FormSupply()
        {
            InitializeComponent();
            ShowAgents();
            ShowClients();
            ShowRealEstate();
            ShowSupplySet();
        }
        void ShowAgents()
        {
            comboBoxAgent.Items.Clear();
            foreach (AgentsSet agentSet in Program.eSoftDB.AgentsSet)
            {
                string[] item = { agentSet.ID.ToString() + ". ", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxAgent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsSet clientSet in Program.eSoftDB.ClientsSet)
            {
                string[] item = { clientSet.id.ToString() + ".", clientSet.FirstName, clientSet.MIddleName, clientSet.LastName };
                comboBoxClient.Items.Add(string.Join(" ", item));
            }
        }
        void ShowRealEstate()
        {
            comboBoxRealEstate.Items.Clear();
            foreach (RealEstateSet realEstateSet in Program.eSoftDB.RealEstateSet)
            {
                string[] item = { realEstateSet.Id.ToString() + ".", realEstateSet.Adress_City + ",", realEstateSet.Adress_Street + ",", "д." + realEstateSet.Adress_House + ",", "кв." + realEstateSet.Adress_Number };
                comboBoxRealEstate.Items.Add(string.Join(" ", item));
            }
        }
        void ShowSupplySet()
        {
            listViewSupplySet.Items.Clear();
            foreach (SupplySet supply in Program.eSoftDB.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supply.IdAgent.ToString(),supply.IdClient.ToString(),supply.IdRealEstate.ToString(),supply.Price.ToString()
                });
                item.Tag = supply;
                listViewSupplySet.Items.Add(item);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormSupply_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgent.SelectedItem != null && comboBoxClient.SelectedItem != null && comboBoxRealEstate != null && textBoxPrice.Text!="")
            {
                SupplySet supply = new SupplySet();
                supply.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.eSoftDB.SupplySet.Add(supply);
                Program.eSoftDB.SaveChanges();
                ShowSupplySet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(listViewSupplySet.SelectedItems.Count==1)
            {
                SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                supply.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                supply.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                supply.IdRealEstate = Convert.ToInt32(comboBoxRealEstate.SelectedItem.ToString().Split('.')[0]);
                supply.Price = Convert.ToInt64(textBoxPrice.Text);
                Program.eSoftDB.SupplySet.Add(supply);
                Program.eSoftDB.SaveChanges();
                ShowSupplySet();
            }
        }

        private void listViewSupplySet_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewSupplySet.Items.Clear();
            foreach(SupplySet supply in Program.eSoftDB.SupplySet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    supply.IdAgent.ToString(),
                    supply.AgentsSet.LastName+" "+supply.AgentsSet.FirstName+" "+supply.AgentsSet.MiddleName,
                    supply.IdClient.ToString(),
                    supply.ClientsSet.LastName+" "+supply.ClientsSet.FirstName+" "+supply.ClientsSet.MIddleName,
                    supply.RealEstateSet.ToString(),
                    "г. "+supply.RealEstateSet.Adress_City+" Ул. "+supply.RealEstateSet.Adress_Street+" д. "+supply.RealEstateSet.Adress_House+" кв. "+supply.RealEstateSet.Adress_Number,
                    supply.Price.ToString()
                });
                item.Tag = supply;
                listViewSupplySet.Items.Add(item);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(listViewSupplySet.SelectedItems.Count==1)
                {
                    SupplySet supply = listViewSupplySet.SelectedItems[0].Tag as SupplySet;
                    Program.eSoftDB.SupplySet.Remove(supply);
                    Program.eSoftDB.SaveChanges();
                    ShowSupplySet();
                }
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxRealEstate.SelectedItem = null;
                textBoxPrice.Text = "";
            }
            catch
            {
                MessageBox.Show("невозможно удалить, эта запись уже используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }
