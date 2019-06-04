using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApplication6
{

    public partial class Form1 : Form
    {
        List<string> country;
        List<List<string>> city;

        public void Country()
        {
            country.Add("Ukraine");
            country.Add("Bulgaria");
            country.Add("Japan");
        }

        public void City()
        {
            city.Add(new List<string>());
            city[0].Add("Kyiv");
            city[0].Add("Rivne");
            city[0].Add("Odessa");
            city[0].Add("Lviv");
            city[0].Add("Kharkiv");

            city.Add(new List<string>());
            city[1].Add("Varna");
            city[1].Add("Sofia");
            city[1].Add("Sn. Vlas");
            city[1].Add("Pirdop");

            city.Add(new List<string>());
            city[2].Add("Osaka");
            city[2].Add("Aizuwakamatsu");
            city[2].Add("Mino");
            city[2].Add("Shōbara");
            city[2].Add("Ebetsu");


        }
        public Form1()
        {
            InitializeComponent();

            country = new List<string>();
            Country();
            city = new List<List<string>>();
            City();

            cbCountry.Items.Add(country[0]);
            cbCountry.Items.Add(country[1]);
            cbCountry.Items.Add(country[2]);

           // Serial();
            Deserial();

        }


        BinaryFormatter bw = new BinaryFormatter();
        public void Serial()
        {
           
            using (FileStream fs = new FileStream("Countries.txt", FileMode.OpenOrCreate))
            {
               
                MyHack ob1 = new MyHack();
                ob1.city = city;
                ob1.country = country;
                bw.Serialize(fs, ob1);
            }
        }

        public void Deserial()
        {
            using (FileStream fs = new FileStream("Countries.txt", FileMode.OpenOrCreate))
            {
                MyHack ob2 = (MyHack)bw.Deserialize(fs);
                country = ob2.country;
                city = ob2.city;
            }
        }

        private void cbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbCity.Items.Clear();
            if (cbCountry.Text == "Ukraine")
                lbCity.Items.AddRange(city[0].ToArray());
            if (cbCountry.Text == "Bulgaria")
                lbCity.Items.AddRange(city[1].ToArray());
            if (cbCountry.Text == "Japan")
                lbCity.Items.AddRange(city[2].ToArray());
        }


        private void bAdd_Click(object sender, EventArgs e)
        {
            if (cbCountry.SelectedIndex > -1)
            {
                lbCity.Items.Add(tbAdd.Text);
                city[cbCountry.SelectedIndex].Add(tbAdd.Text);
                tbAdd.Clear();
                Serial();
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            if (lbCity.SelectedIndex > -1)
            {
                int index = lbCity.SelectedIndex;
                lbCity.Items.RemoveAt(index);
                city[cbCountry.SelectedIndex].RemoveAt(index);

            }
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            if (lbCity.SelectedIndex > -1)
            {
                lbCity.Items[lbCity.SelectedIndex] = tbRename.Text;
                city[cbCountry.SelectedIndex][lbCity.SelectedIndex] = tbRename.Text;

            }
        }
    }
    [Serializable]
    class MyHack
    {
        public List<string> country { get; set; }
        public List<List<string>> city { get; set; }
    }
}
