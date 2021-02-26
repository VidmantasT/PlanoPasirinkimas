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

namespace PlanoPasirinkimas
{
    public partial class Form1 : Form
    {
        public List<Plans> plans = new List<Plans>();

        public Form1()
        {
            InitializeComponent();
        }

        private void selectPlan_btn_Click(object sender, EventArgs e)
        {
            ListViewItem listViewItem;

            openFileDialog1.ShowDialog();

            string filePath = openFileDialog1.FileName;

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 0; i < lines.Length; i++)
            {
                string[] tempArr = lines[i].Split(' ');
                string temp1 = tempArr[0];
                int temp2 = Convert.ToInt32(tempArr[1]);
                int temp3 = Convert.ToInt32(tempArr[2]);
                int temp4 = Convert.ToInt32(tempArr[3]);
                double temp5 = double.Parse(tempArr[4]);

                plans.Add(new Plans(temp1, temp2, temp3, temp4, temp5));
            }

            listView1.Items.Clear();
            foreach (var el in plans)
            {
                string[] tempArr = new string[5];

                tempArr[0] = el.GetTitle().ToString();
                tempArr[1] = el.GetGB().ToString();
                tempArr[2] = el.GetMinutes().ToString();
                tempArr[3] = el.GetSMS().ToString();
                tempArr[4] = el.GetPrice().ToString();

                listViewItem = new ListViewItem(tempArr);
                listView1.Items.Add(listViewItem);
            }
        }
    }
}
