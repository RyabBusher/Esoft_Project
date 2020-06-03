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
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
            ShowAgents();
        }

        private void FormAgent_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgentsSet agentSet = new AgentsSet();
            agentSet.FirstName = textBoxFirstName.Text;
            agentSet.MiddleName = textBoxMiddleName.Text;
            agentSet.LastName = textBoxLastName.Text;
            agentSet.Comission = textBoxComission.Text;
            Program.eSoftDB.AgentsSet.Add(agentSet);
            Program.eSoftDB.SaveChanges();
        }
        void ShowAgents()
        {
            listViewAgent.Items.Clear();
            foreach (ClientsSet clientsSet in Program.eSoftDB.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsSet.id.ToString(), clientsSet.FirstName, clientsSet.MIddleName, clientsSet.LastName, clientsSet.Phone, clientsSet.Email
                });
                item.Tag = clientsSet;
                listViewAgent.Items.Add(item);
            }
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

            private void button3_Delete(object sender, EventArgs e)
        {
            {
                try
                {
                    if (listViewAgent.SelectedItems.Count == 1)
                    {
                        AgentsSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                        Program.eSoftDB.AgentsSet.Remove(agentSet);
                        Program.eSoftDB.SaveChanges();
                        ShowAgents();
                    }
                    textBoxFirstName.Text = "";
                    textBoxMiddleName.Text = "";
                    textBoxLastName.Text = "";
                    textBoxComission.Text = "";
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить, эта запись уже используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgent.SelectedItems.Count == 1)
            {
                AgentsSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.Comission = textBoxComission.Text;
                Program.eSoftDB.SaveChanges();
                ShowAgents();
            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxComission.Text = "";
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            {
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    AgentsSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentsSet;
                    agentSet.FirstName = textBoxFirstName.Text;
                    agentSet.MiddleName = textBoxMiddleName.Text;
                    agentSet.LastName = textBoxLastName.Text;
                    agentSet.Comission = textBoxComission.Text;
                    Program.eSoftDB.SaveChanges();
                    ShowAgents();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
