using System;
using System.Windows.Forms;

namespace Zoo
{
    public partial class WolfForm : Form
    {
        private WolfCollection collection = new WolfCollection();

        public WolfForm()
        {
            InitializeComponent();
        }

        private void WolfForm_Load(object sender, EventArgs e)
        {

        }

        private void FindWolf_Click(object sender, EventArgs e)
        {
            string key = txtSearchKey.Text;
            lstOutput.Items.Clear();
            var wolf = collection.GetWolfByKey(key);
            if (wolf != null)
            {
                lstOutput.Items.Add($"Breed: {wolf["breed"]}, Location: {wolf["location"]}, Weight: {wolf["weight"]} kg, Age: {wolf["age"]} years, Cost/day: {wolf["costperday"]} $");
            }
            else
            {
                lstOutput.Items.Add("Wolf not found.");
            }

        }

        private void Show_Click(object sender, EventArgs e)
        {
            lstOutput.Items.Clear();
            foreach (var wolf in collection.GetAllWolves())
            {
                lstOutput.Items.Add($"Breed: {wolf["breed"]}, Location: {wolf["location"]}, Weight: {wolf["weight"]} kg, Age: {wolf["age"]} years, Cost/day: {wolf["costperday"]} $");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtKey.Text;
                double weight = double.Parse(txtWeight.Text);
                int age = int.Parse(txtAge.Text);
                double costPerDay = double.Parse(txtCost.Text);
                string breed = txtBreed.Text;
                string location = txtLocation.Text;

                Wolf wolf = new Wolf(weight, age, costPerDay, breed, location);
                collection.AddWolf(key, wolf);

                MessageBox.Show("Wolf added!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}