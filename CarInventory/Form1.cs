using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarInventory
{
    public partial class Form1 : Form
    {
        List<Car> carList = new List<Car>();

        public Form1()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int year = Convert.ToInt16(yearInput.Text);
            string make = makeInput.Text;
            string colour = colourInput.Text;
            int mileage = Convert.ToInt32(mileageInput.Text);

            Car newCar = new Car(year, make, colour, mileage);

            carList.Add(newCar);

            outputLabel.Text = "";

            //for (int i = 0; i < carList.Count(); i++)
            //{
            //    outputLabel.Text += carList[i].year + "\n";
            //    outputLabel.Text += carList[i].make + "\n";
            //    outputLabel.Text += carList[i].colour + "\n";
            //    outputLabel.Text += carList[i].mileage + "\n";
            //}


            //foreach loop does the same as te for loop above
            foreach (Car c in carList)
            {
                outputLabel.Text += c.year + "\n";
                outputLabel.Text += c.make + "\n";
                outputLabel.Text += c.colour + "\n";
                outputLabel.Text += c.mileage + "\n\n";
            }

        }
    }
}
