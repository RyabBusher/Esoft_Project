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
    public partial class FormRealEstate : Form
    {
        public FormRealEstate()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowRealEstateSet();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormRealEstate_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxType.SelectedIndex == 0)
            {
                listViewRealEstateSet_Apartment.Visible = true;
                labelFloor.Visible = true;
                textBoxFloor.Visible = true;
                labelRooms.Visible = true;
                textBoxRooms.Visible = true;

                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAdress_City.Text = "";
                textBoxAdress_House.Text = "";
                textBoxAdress_Street.Text = "";
                textBoxAdress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                listViewRealEstateSet_House.Visible = true;
                labelTotalFloors.Visible = true;
                textBoxTotalFloors.Visible = true;

                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;

                textBoxAdress_City.Text = "";
                textBoxAdress_House.Text = "";
                textBoxAdress_Street.Text = "";
                textBoxAdress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxFloor.Text = "";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                listViewRealEstateSet_Land.Visible = true;

                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Apartment.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                textBoxAdress_City.Text = "";
                textBoxAdress_House.Text = "";
                textBoxAdress_Street.Text = "";
                textBoxAdress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            RealEstateSet realEstate = new RealEstateSet();
            realEstate.Adress_City = textBoxAdress_City.Text;
            realEstate.Adress_Street = textBoxAdress_Street.Text;
            realEstate.Adress_House = textBoxAdress_House.Text;
            realEstate.Adress_Number = textBoxAdress_Number.Text;
            realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
            realEstate.Coordinate_longtitiude = Convert.ToDouble(textBoxCoordinate_longtitude.Text);
            realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);

            if (comboBoxType.SelectedIndex == 0)
            {
                realEstate.Type = 0;
                realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                realEstate.Type = 1;
                realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors);
            }
            else
            {
                realEstate.Type = 2;
            }
            Program.eSoftDB.RealEstateSet.Add(realEstate);
            Program.eSoftDB.SaveChanges();
            ShowRealEstateSet();
        }
        void ShowRealEstateSet()
        {
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();

            foreach (RealEstateSet realEstate in Program.eSoftDB.RealEstateSet)
            {
                if (realEstate.Type == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.Adress_City, realEstate.Adress_Street,realEstate.Adress_House,realEstate.Adress_Number,
                        realEstate.Coordinate_latitude.ToString(),realEstate.Coordinate_longtitiude.ToString(),realEstate.TotalArea.ToString(),
                        realEstate.Rooms.ToString(),realEstate.Floor.ToString()
                    });
                    item.Tag = realEstate;
                    listViewRealEstateSet_Apartment.Items.Add(item);
                }
                else if (realEstate.Type == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                        {
                            realEstate.Adress_City, realEstate.Adress_Street,realEstate.Adress_House,realEstate.Adress_Number,
                        realEstate.Coordinate_latitude.ToString(),realEstate.Coordinate_longtitiude.ToString(),realEstate.TotalArea.ToString(),
                        realEstate.TotalFloors.ToString()
                        });
                    item.Tag = realEstate;
                    listViewRealEstateSet_House.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        realEstate.Adress_City, realEstate.Adress_Street,realEstate.Adress_House,realEstate.Adress_Number,
                        realEstate.Coordinate_latitude.ToString(),realEstate.Coordinate_longtitiude.ToString(),realEstate.TotalArea.ToString()
                    });
                    {
                        item.Tag = realEstate;
                        listViewRealEstateSet_Land.Items.Add(item);
                    }
                }
                listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(comboBoxType.SelectedIndex==0)
            {
                if(listViewRealEstateSet_Apartment.SelectedItems.Count==1)
                {
                    RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                    realEstate.Adress_City = textBoxAdress_City.Text;
                    realEstate.Adress_Street = textBoxAdress_Street.Text;
                    realEstate.Adress_House = textBoxAdress_House.Text;
                    realEstate.Adress_Number = textBoxAdress_Number.Text;
                    realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longtitiude = Convert.ToDouble(textBoxCoordinate_longtitude.Text);
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                    realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
                    Program.eSoftDB.SaveChanges();
                    ShowRealEstateSet();
                }
                else if (comboBoxType.SelectedIndex==1)
                {
                    if(listViewRealEstateSet_House.SelectedItems.Count==1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                        realEstate.Adress_City = textBoxAdress_City.Text;
                        realEstate.Adress_Street = textBoxAdress_Street.Text;
                        realEstate.Adress_House = textBoxAdress_House.Text;
                        realEstate.Adress_Number = textBoxAdress_Number.Text;
                        realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                        realEstate.Coordinate_longtitiude = Convert.ToDouble(textBoxCoordinate_longtitude.Text);
                        realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                        realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors);
                        Program.eSoftDB.SaveChanges();
                        ShowRealEstateSet();
                    }
                }
                else
                {
                    if(listViewRealEstateSet_Land.SelectedItems.Count == 2)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                        realEstate.Adress_City = textBoxAdress_City.Text;
                        realEstate.Adress_Street = textBoxAdress_Street.Text;
                        realEstate.Adress_House = textBoxAdress_House.Text;
                        realEstate.Adress_Number = textBoxAdress_Number.Text;
                        realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                        realEstate.Coordinate_longtitiude = Convert.ToDouble(textBoxCoordinate_longtitude.Text);
                        realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                        Program.eSoftDB.SaveChanges();
                        ShowRealEstateSet();
                    }
                }
            }
        }

        private void listViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                textBoxAdress_City.Text = realEstate.Adress_City;
                textBoxAdress_Street.Text = realEstate.Adress_Street;
                textBoxAdress_House.Text = realEstate.Adress_House;
                textBoxAdress_Number.Text = realEstate.Adress_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longtitude.Text = realEstate.Coordinate_longtitiude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxRooms.Text = realEstate.Rooms.ToString();
                textBoxTotalFloors.Text = realEstate.TotalFloors.ToString();
            }
            else
            {
                textBoxAdress_City.Text = "";
                textBoxAdress_Street.Text = "";
                textBoxAdress_House.Text = "";
                textBoxAdress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxTotalFloors.Text = "";
            }
        }

        private void listViewRealEstateSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_House.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                textBoxAdress_City.Text = realEstate.Adress_City;
                textBoxAdress_Street.Text = realEstate.Adress_Street;
                textBoxAdress_House.Text = realEstate.Adress_House;
                textBoxAdress_Number.Text = realEstate.Adress_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longtitude.Text = realEstate.Coordinate_longtitiude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxTotalFloors.Text = realEstate.TotalFloors.ToString();
            }
            else
            {
                textBoxAdress_City.Text = "";
                textBoxAdress_Street.Text = "";
                textBoxAdress_House.Text = "";
                textBoxAdress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";
            }
        }

        private void listViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
            {
                RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                textBoxAdress_City.Text = realEstate.Adress_City;
                textBoxAdress_Street.Text = realEstate.Adress_Street;
                textBoxAdress_House.Text = realEstate.Adress_House;
                textBoxAdress_Number.Text = realEstate.Adress_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longtitude.Text = realEstate.Coordinate_longtitiude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
            }
            else
            {
                textBoxAdress_City.Text = "";
                textBoxAdress_Street.Text = "";
                textBoxAdress_House.Text = "";
                textBoxAdress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longtitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
                try
                {
                    if (comboBoxType.SelectedIndex == 0)
                    {
                    if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                    {
                        RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                        Program.eSoftDB.RealEstateSet.Remove(realEstate);
                        Program.eSoftDB.SaveChanges();
                        ShowRealEstateSet();
                    }
                    textBoxAdress_City.Text = "";
                    textBoxAdress_Street.Text = "";
                    textBoxAdress_House.Text = "";
                    textBoxAdress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longtitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxRooms.Text = "";
                    textBoxFloor.Text = "";
                    }
                    else if (comboBoxType.SelectedIndex == 1)
                    {
                        if (listViewRealEstateSet_House.SelectedItems.Count == 1) ;
                        {
                            RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                            Program.eSoftDB.RealEstateSet.Remove(realEstate);
                            Program.eSoftDB.SaveChanges();
                            ShowRealEstateSet();
                        }
                        textBoxAdress_City.Text = "";
                        textBoxAdress_Street.Text = "";
                        textBoxAdress_House.Text = "";
                        textBoxAdress_Number.Text = "";
                        textBoxCoordinate_latitude.Text = "";
                        textBoxCoordinate_longtitude.Text = "";
                        textBoxTotalArea.Text = "";
                        textBoxTotalFloors.Text = "";
                    }
                    else
                    {
                        if (listViewRealEstateSet_Land.SelectedItems.Count == 1);
                        {
                            RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                            Program.eSoftDB.RealEstateSet.Remove(realEstate);
                            Program.eSoftDB.SaveChanges();
                            ShowRealEstateSet();
                        }
                        textBoxAdress_City.Text = "";
                        textBoxAdress_Street.Text = "";
                        textBoxAdress_House.Text = "";
                        textBoxAdress_Number.Text = "";
                        textBoxCoordinate_latitude.Text = "";
                        textBoxCoordinate_longtitude.Text = "";
                        textBoxTotalArea.Text = "";
                    }
                }
                catch
                {
                    MessageBox.Show("Невозможно удалить, эта запись уже используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }
