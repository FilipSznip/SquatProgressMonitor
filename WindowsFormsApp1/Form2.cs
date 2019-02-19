using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Session;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        Broker b;
        public Form2()
        {
            InitializeComponent();
            b = new Broker();
            cmbSquat.DataSource = b.CmbSQuat();
            this.squatTableAdapter.Fill(this.baza1DataSet.Squat);
            if (cmbSquat.Items.Count != 0)
            {
                textBox1.Text = b.TotalVolume().ToString();
                Info();
                b.SaveMaxVolume();
                b.SaveMaxWeight();
                textBox2.Text = b.MaxSquat().ToString();
                textBox3.Text = b.GetMaxVolume().ToString();
                textBox4.Text = b.GetMaxWeight().ToString();
            }
        }
        // Update old record where Id = Id from combobox and refresh
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Squats newSq = new Squats();
                Squats oldSq = new Squats();

                oldSq = cmbSquat.SelectedItem as Squats;
                newSq.Weights = int.Parse(txtWeight.Text);
                newSq.Reps = int.Parse(txtReps.Text);
                b.AddSquat(newSq, oldSq);
                this.squatTableAdapter.Fill(this.baza1DataSet.Squat);
                textBox1.Text = b.TotalVolume().ToString();
                Info();
                b.SaveMaxVolume();
                b.SaveMaxWeight();
                textBox2.Text = b.MaxSquat().ToString();
                textBox3.Text = b.GetMaxVolume().ToString();
                textBox4.Text = b.GetMaxWeight().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number");
            }
        }
        // Insert record into the table and refresh combobox. If table is clear, set identity as 0.
        private void btnIns_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSquat.Items.Count ==0)
                {
                    b.ResetInc();
                }

                Squats s = new Squats();
                s.Weights = Convert.ToInt32(txtInsW.Text);
                s.Reps = Convert.ToInt32(txtInsR.Text);
                b.InsertSquat(s);
                cmbSquat.DataSource = b.CmbSQuat();
                this.squatTableAdapter.Fill(this.baza1DataSet.Squat);
                textBox1.Text = b.TotalVolume().ToString();
                Info();
                b.SaveMaxVolume();
                b.SaveMaxWeight();
                textBox2.Text = b.MaxSquat().ToString();
                textBox3.Text = b.GetMaxVolume().ToString();
                textBox4.Text = b.GetMaxWeight().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a number");
            }
        }
        // Check if current volume/weight is bigger than threshold volume/weight.
        private void Info()
        {
            if (b.TotalVolume() <= b.GetMaxVolume())
            {
                label6.Text = "To low Volume, lack of progress";
                label6.ForeColor = Color.Red;
            }
            else
            {
                label6.Text = "Volume is suitable, progress achieved";
                label6.ForeColor = Color.Green;
            }
        }
      
        // Delete data from the table and set current weight/volume as 0. Refresh combobox.
        private void ResBtn_Click(object sender, EventArgs e)
        {
            b.Delete();
            b.ResetInc();
            cmbSquat.DataSource = b.CmbSQuat();
            this.squatTableAdapter.Fill(this.baza1DataSet.Squat);
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = b.GetMaxVolume().ToString();
            textBox4.Text = b.GetMaxWeight().ToString();
        }

    }
}
