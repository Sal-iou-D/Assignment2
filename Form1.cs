using System.Drawing.Text;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        private enum carColor { Red, Blue, Black, White }

        private carColor selectedColor;
        public Form1()
        {
            InitializeComponent();
        }

       

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string makeModel = carListBox.SelectedItem?.ToString();
            string yearText = textBoxYear.Text;
            int year;
            string summary = "";


            summaryLabel.ForeColor = Color.Black;

            if (radioButtonRed.Checked)
                selectedColor = carColor.Red;
            else if (radioButtonBlue.Checked)
                selectedColor = carColor.Blue;
            else if (radioButtonBlack.Checked)
                selectedColor = carColor.Black;
            else if (radioButtonWhite.Checked)
                selectedColor = carColor.White;


            if (string.IsNullOrEmpty(makeModel))
            {
                summaryLabel.Text = "Please select a make and model.";
                summaryLabel.ForeColor = Color.Red;
                return;
            }

           
            if (!int.TryParse(yearText, out year))
            {
                summaryLabel.Text = "Please enter a valid year.";
                summaryLabel.ForeColor = Color.Red;
                return;
            }

            
            switch (selectedColor)
            {
                case carColor.Red:
                    summary += "Red ";
                    break;
                case carColor.Blue:
                    summary += "Blue ";
                    break;
                case carColor.Black:
                    summary += "Black ";
                    break;
                case carColor.White:
                    summary += "White ";
                    break;
            }

            
            summary += $"{year} {makeModel} with the following features: ";

            
            var selectedFeatures = new List<string>();
            if (checkBoxAC.Checked)
                selectedFeatures.Add("Power Windows");
            if (checkBoxAC.Checked)
                selectedFeatures.Add("Air Conditioning");
            if (checkBoxSyrius.Checked)
                selectedFeatures.Add("Sirius Radio");
            if (checkBoxLane.Checked)
                selectedFeatures.Add("Lane Assistance");

            if (selectedFeatures.Count > 0)
            {
                summary += string.Join(", ", selectedFeatures);
            }
            else
            {
                summary += "no additional features";
            }

            
            summaryLabel.Text = $"You have purchased a {summary}.";
        }

        
        private void label1_Click(object sender, EventArgs e)
            {
                

            }

        private void carListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
