using System.CodeDom;

namespace Introduction_To_Programming
{
    public partial class ParkingApplication : Form
    {

        private decimal total = 0;

        const decimal CarPrice = 2.50m;
        

        public ParkingApplication()
        {
            InitializeComponent();
        }

        private void Car_Button_Click(object sender, EventArgs e)
        {
            total = total + CarPrice;
            NewVehicles_ListBox.Items.Add("Car");
            UpdatePrice();
        }

        private void UpdatePrice()
        {
            TotalPrice_TextBox.Text = "€ " + total;
        }


        private void Reset()
        {
            NewVehicles_ListBox.Items.Clear();
            total = 0;
            UpdatePrice();
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Reset();
        }
        // GPG Test
    }
}