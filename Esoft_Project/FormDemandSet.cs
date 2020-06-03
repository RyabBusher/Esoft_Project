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
    public partial class FormDemandSet : Form
    {
        public FormDemandSet()
        {
            InitializeComponent();
            ShowClients();
            ShowAgents();
            ShowDemandsSet();
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
        void ShowAgents()
        {
            comboBoxAgent.Items.Clear();
            foreach (AgentsSet agentSet in Program.eSoftDB.AgentsSet)
            {
                string[] item = { agentSet.ID.ToString() + ". ", agentSet.FirstName, agentSet.MiddleName, agentSet.LastName };
                comboBoxAgent.Items.Add(string.Join(" ", item));
            }
        }
        void ShowDemandsSet()
        {
            listViewApartment.Items.Clear();
            listViewLands.Items.Clear();
            listViewHouse.Items.Clear();

            foreach (DemandSet demand in Program.eSoftDB.DemandSet)
            {
                if (demand.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        demand.MinPrice.ToString(),demand.MaxPrice.ToString(),demand.MinArea.ToString(),demand.MaxArea.ToString(),demand.MinRooms.ToString(),demand.MaxRooms.ToString(),
                        demand.MinFloor.ToString(),demand.MaxFloor.ToString(),demand.MinFloors.ToString(),demand.MaxFloors.ToString()
                    });
                    item.Tag = demand;
                    listViewApartment.Items.Add(item);
                }
                else if (demand.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                        {
                            demand.MinPrice.ToString(),demand.MaxPrice.ToString(),demand.MinArea.ToString(),demand.MaxArea.ToString(),demand.MinRooms.ToString(),demand.MaxRooms.ToString(),
                        demand.MinFloors.ToString(),demand.MaxFloors.ToString()
                        });
                    item.Tag = demand;
                    listViewHouse.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        demand.MinPrice.ToString(),demand.MaxPrice.ToString(),demand.MinArea.ToString(),demand.MaxArea.ToString()
                    });
                    {
                        item.Tag = demand;
                        listViewLands.Items.Add(item);
                    }
                }
                listViewApartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewHouse.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewLands.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDemandSet_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewApartment.Visible = true;
                labelMinMaxArea.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMinMaxRooms.Visible = true;
                textBoxMinRooms.Visible = true;
                textBoxMaxRooms.Visible = true;
                labelMinMaxFloor.Visible = true;
                textBoxMinFloor.Visible = true;
                textBoxMaxFloor.Visible = true;
                labelMinMaxFloors.Visible = true;
                textBoxMinFloors.Visible = true;
                textBoxMaxFloors.Visible = true;

                listViewLands.Visible = false;
                listViewHouse.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewHouse.Visible = true;
                labelMinMaxArea.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;
                labelMinMaxFloors.Visible = true;
                textBoxMinFloors.Visible = true;
                textBoxMaxFloors.Visible = true;

                listViewApartment.Visible = false;
                listViewLands.Visible = false;
                labelMinMaxRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinMaxFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewLands.Visible = true;
                labelMinMaxArea.Visible = true;
                textBoxMinArea.Visible = true;
                textBoxMaxArea.Visible = true;

                listViewApartment.Visible = false;
                listViewLands.Visible = false;
                labelMinMaxRooms.Visible = false;
                textBoxMinRooms.Visible = false;
                textBoxMaxRooms.Visible = false;
                labelMinMaxFloor.Visible = false;
                textBoxMinFloor.Visible = false;
                textBoxMaxFloor.Visible = false;
                labelMinMaxFloors.Visible = false;
                textBoxMinFloors.Visible = false;
                textBoxMaxFloors.Visible = false;

                textBoxMinPrice.Text = "";
                textBoxMaxPrice.Text = "";
                textBoxMinArea.Text = "";
                textBoxMaxArea.Text = "";
                textBoxMinRooms.Text = "";
                textBoxMaxRooms.Text = "";
                textBoxMinFloor.Text = "";
                textBoxMaxFloor.Text = "";
                textBoxMinFloors.Text = "";
                textBoxMaxFloors.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgent.SelectedItem != null && comboBoxClient.SelectedItem != null)
            {
                DemandSet demand = new DemandSet();
                demand.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                if (comboBoxType.SelectedIndex == 0)
                {
                    demand.Type = 0;
                    demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                    demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                    demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                    demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                }
                else if (comboBoxType.SelectedIndex==1)
                {
                    demand.Type = 1;
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                }
                else if(comboBoxType.SelectedIndex==2)
                {
                    demand.Type = 2;
                }
                Program.eSoftDB.DemandSet.Add(demand);
                Program.eSoftDB.SaveChanges();
                ShowDemandsSet();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void listViewLands_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewLands.Items.Clear();
            foreach (DemandSet demand in Program.eSoftDB.DemandSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    demand.IdAgent.ToString(),
                    demand.AgentsSet.LastName+" "+demand.AgentsSet.FirstName+" "+demand.AgentsSet.MiddleName,
                    demand.IdClient.ToString(),
                    demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName+" "+demand.ClientsSet.MIddleName,
                    demand.MinPrice.ToString(),demand.MaxPrice.ToString(),
                    demand.MinArea.ToString(),demand.MaxArea.ToString()
                });
                item.Tag = demand;
                listViewApartment.Items.Add(item);
            }
        }

        private void listViewApartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewApartment.Items.Clear();
            foreach (DemandSet demand in Program.eSoftDB.DemandSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    demand.IdAgent.ToString(),
                    demand.AgentsSet.LastName+" "+demand.AgentsSet.FirstName+" "+demand.AgentsSet.MiddleName,
                    demand.IdClient.ToString(),
                    demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName+" "+demand.ClientsSet.MIddleName,
                    demand.MinPrice.ToString(),demand.MaxPrice.ToString(),
                    demand.MinArea.ToString(),demand.MaxArea.ToString(),
                    demand.MinRooms.ToString(),demand.MaxRooms.ToString(),
                    demand.MinFloor.ToString(),demand.MaxFloor.ToString(),
                    demand.MinFloors.ToString(),demand.MaxFloors.ToString()
                });
                item.Tag = demand;
                listViewApartment.Items.Add(item);
            }
        }

        private void listViewHouse_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewHouse.Items.Clear();
            foreach (DemandSet demand in Program.eSoftDB.DemandSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    demand.IdAgent.ToString(),
                    demand.AgentsSet.LastName+" "+demand.AgentsSet.FirstName+" "+demand.AgentsSet.MiddleName,
                    demand.IdClient.ToString(),
                    demand.ClientsSet.LastName+" "+demand.ClientsSet.FirstName+" "+demand.ClientsSet.MIddleName,
                    demand.MinPrice.ToString(),demand.MaxPrice.ToString(),
                    demand.MinArea.ToString(),demand.MaxArea.ToString(),
                    demand.MinRooms.ToString(),demand.MaxRooms.ToString(),
                    demand.MinFloors.ToString(),demand.MaxFloors.ToString()
                });
                item.Tag = demand;
                listViewApartment.Items.Add(item);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewApartment.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                        demand.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                        demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                        demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                        demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                        demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                        demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                        demand.MinFloor = Convert.ToInt32(textBoxMinFloor.Text);
                        demand.MaxFloor = Convert.ToInt32(textBoxMaxFloor.Text);
                        demand.MinRooms = Convert.ToInt32(textBoxMinRooms.Text);
                        demand.MaxRooms = Convert.ToInt32(textBoxMaxRooms.Text);
                        Program.eSoftDB.SaveChanges();
                        ShowDemandsSet();
                    }
                }
                else if (comboBoxType.SelectedIndex == 1)
                {
                    if (listViewHouse.SelectedItems.Count == 1)
                    {
                    DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                    demand.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                    demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                    demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                    demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                    demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                    demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                    demand.MinFloors = Convert.ToInt32(textBoxMinFloors.Text);
                    demand.MaxFloors = Convert.ToInt32(textBoxMaxFloors.Text);
                    Program.eSoftDB.SaveChanges();
                    ShowDemandsSet();
                    }
                }
                    else if (comboBoxType.SelectedIndex == 2)
                    {
                    if (listViewLands.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                        demand.IdAgent = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                        demand.IdClient = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                        demand.MinPrice = Convert.ToInt32(textBoxMinPrice.Text);
                        demand.MaxPrice = Convert.ToInt32(textBoxMaxPrice.Text);
                        demand.MinArea = Convert.ToDouble(textBoxMinArea.Text);
                        demand.MaxArea = Convert.ToDouble(textBoxMaxArea.Text);
                        Program.eSoftDB.SaveChanges();
                        ShowDemandsSet();
                    }
            }
                else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxType.SelectedIndex == 0)
                {
                    if (listViewApartment.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                        Program.eSoftDB.DemandSet.Remove(demand);
                        Program.eSoftDB.SaveChanges();
                        ShowDemandsSet();
                    }
                    textBoxMinRooms.Text = "";
                    textBoxMaxRooms.Text = "";
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                }
                else if (comboBoxType.SelectedIndex==1)
                    { 
                        if (listViewHouse.SelectedItems.Count == 1)
                    {
                        DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                        Program.eSoftDB.DemandSet.Remove(demand);
                        Program.eSoftDB.SaveChanges();
                        ShowDemandsSet();
                    }
                    textBoxMinFloor.Text = "";
                    textBoxMaxFloor.Text = "";
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                }
                else if(comboBoxType.SelectedIndex==2)
                {
                    if(listViewLands.SelectedItems.Count==1)
                    {
                        DemandSet demand = listViewApartment.SelectedItems[0].Tag as DemandSet;
                        Program.eSoftDB.DemandSet.Remove(demand);
                        Program.eSoftDB.SaveChanges();
                        ShowDemandsSet();
                    }
                    textBoxMinArea.Text = "";
                    textBoxMaxArea.Text = "";
                    textBoxMinPrice.Text = "";
                    textBoxMaxPrice.Text = "";
                    comboBoxAgent.SelectedItem = null;
                    comboBoxClient.SelectedItem = null;
                }
            }
            catch
            {
                MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
