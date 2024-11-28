using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDays.Items.Add("Saturday");
            cmbDays.Items.Add("Sunday");
            cmbDays.Items.Add("monday");
            cmbDays.Items.Add("tuesday");
            cmbDays.Items.Add("wednesday");
            cmbDays.Items.Add("thursday");
            cmbDays.Items.Add("friday");
            
            cmbDays.Items.Add("exam day");
            label1.Text = "current number of items : " + Convert.ToString(cmbDays.Items.Count);
            label2.Text = "initial number of items " + Convert.ToString(cmbDays.Items.Count);


        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnshow1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cmbDays.Text);
        }

        private void btnshow2_Click(object sender, EventArgs e)
        {
            string itemText = cmbDays.GetItemText(cmbDays.SelectedItem);
            MessageBox.Show(itemText);
        }

        private void btnshow3_Click(object sender, EventArgs e)
        {
            cmbDays.Items.RemoveAt(0);
            label1.Text = "current number of items" + Convert.ToString(cmbDays.Items.Count);
        }

        private void btnshow4_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count>=1)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 1);
                label1.Text= "current number of items "+ Convert.ToString(cmbDays.Items.Count);
            }
            else
            {
                MessageBox.Show("can't remove last item");
            }
        }

        private void btnshow5_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 2)
            {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 2);
                label1.Text = "current number of items " + Convert.ToString(cmbDays.Items.Count);
            }
            else
            {
                MessageBox.Show("can't remove the selected item item");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnshow6_Click(object sender, EventArgs e)
        {
            if (cmbDays.Items.Count >= 3)
                {
                cmbDays.Items.RemoveAt(cmbDays.Items.Count - 2);
                label1.Text = "current number of items " + Convert.ToString(cmbDays.Items.Count);
            }
            else
            {
                MessageBox.Show("can't remove the selected item item");
            }    
        }

        private void btnshow7_Click(object sender, EventArgs e)
        {
            if(cmbDays.Items.Count >= 1)
            {
                cmbDays.Items.Clear();
                label1.Text = "current number of items " + Convert.ToString(cmbDays.Items.Count);
            }

        }

        private void btnshow8_Click(object sender, EventArgs e)
        {
            
            cmbDays.Items.Add(cmbDays);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
