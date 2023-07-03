using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_POE_PROG6221
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index;
        public Form1()
        {
            InitializeComponent();
        }
        //this are the pictures to make the interface easier to look at
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //this is the button function for the next button
        private void button2_Click(object sender, EventArgs e)
        {
            if (index < listPanel.Count - 1)
                listPanel[++index].BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        //add fuctions for the next and previous button to work with the interface
        private void Form1_Load(object sender, EventArgs e)
        {
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel.Add(panel4);
            listPanel.Add(panel5);
            listPanel.Add(panel6);
            listPanel.Add(panel7);
            
            listPanel[index].BringToFront();

        }
        //this is the button function for the previous button
        private void previous_Click(object sender, EventArgs e)
        {
            if(index > 0)
                listPanel[--index].BringToFront();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
        //this is the button function to read the input of submit in for it display 
        private void button1_Click(object sender, EventArgs e)
        {
            string name1;
            string name2;
            int number1;
            int name3;
            string name4;
            int number2;
            string name5;
            name1 = textBox1.Text;
            name2 = richTextBox1.Text;
            number1= Convert.ToInt32(textBox2.Text);
            name3 = Convert.ToInt32(textBox3.Text);
            name4 = textBox4.Text;
            number2 = Convert.ToInt32(textBox5.Text);
            name5 = richTextBox2.Text;
            label45.Text = "The name of the recipe you have chosen is: " + name1;
            label65.Text = "The name of the ingredient you have chosen is:" + name2;
            label67.Text = "The number of the ingredients you wrote is:" + number1;
            label68.Text = "The quantity of the ingredient is:" + name3 + "per spoon";
            label69.Text = "The unit of measurement you wrote is: " + name4;
            label70.Text = "The number of steps you wrote is:" + number2;
            label29.Text = "The full description of steps you wrote is:" + name5;




        }
        //this is the button function to display half the input value
        private void button2_Click_1(object sender, EventArgs e)
        {
            
            double number1;
            number1 = Convert.ToDouble(textBox7.Text);
            double number2 = 0.5;
            double sum1 = number1 * number2;
            label32.Text = "Your Original value is: " + number1 + "per spoon";
            label32.Text = "The halved value is: " + sum1 + "per spoon";
        }
        //this is the button function to display double the input value
        private void button3_Click(object sender, EventArgs e)
        {
            int number1;
            number1 = Convert.ToInt32(textBox7.Text);
            int number2 = 2;
            int sum1 = number1 * number2;
            label32.Text = "Your Origanal value is: " + number1 + "per spoon";
            label32.Text = "Your doubled values is: " + sum1 + "per spoon"; 
        }
        //this is the button fuction to display triple the input value
        private void button4_Click(object sender, EventArgs e)
        {
            int number1;
            number1 = Convert.ToInt32(textBox7.Text);
            int number2 = 3;
            int sum1 = number1 * number2;
            label32.Text = "Your Origanal value is: " + number1 + "per spoon";
            label32.Text = "Your doubled values is: " + sum1 + "per spoon";
        }
        //this is the button that displays the calories you typed in
        private void button5_Click(object sender, EventArgs e)
        {
            string name1;
            int number1;
            name1 = textBox6.Text;
            number1 = Convert.ToInt32(textBox13.Text);
            label48.Text = "The food group that you chose is: " + name1;
            label71.Text = "The calories of the food group is:" + number1 + "calories";

        }

        private void label48_Click(object sender, EventArgs e)
        {

        }
        // this is button function that prints out the individual components a the calories and calculate the total of the calories in order for it check whether you have exceeded the amount of required
        private void button6_Click(object sender, EventArgs e)
        {
            int number1;
            int number2;
            int number3;
            int number4;
            
            number1 = Convert.ToInt32(textBox9.Text);
            number2 = Convert.ToInt32(textBox8.Text);
            number3 = Convert.ToInt32(textBox10.Text);
            number4 = Convert.ToInt32(textBox12.Text);
            int sum1 = number2 + number3 + number1 + number4;
            label63.Text = "Protien Calories are" + number1 + "Calories";
            label72.Text = "Grain Calaries are " + number2 + "Calories";
            label73.Text = "Vegetable Calories are " + number3 +"Calories";
            label74.Text = "Dariy Calaries are "+ number4 +"Calories";
            if (sum1 > 300)
            {
                label75.Text ="The total calories have exceed 300 calories";
            }
            else
            {
                label75.Text = "The total calories are within range";
            }
        }
        // this button function check if the groups are in the right place
        private void button7_Click(object sender, EventArgs e)
        {
            string name1;
            string name2;
            name1 = textBox11.Text;

            if (name1 == "chicken" || name1 == "beef " || name1 == "lamb")
            {
                label54.Text = "This ingredient belongs to Protien group";
            }
            else
                label54.Text = "This ingredient does not belong to Protien try again";
            if (name1 == "pap" || name1 == "mielies" || name1 == "bread")
            {
                label54.Text = "This ingredient belongs to Grain group";
            }
            else
                label54.Text = "This ingredient does not belong to Grain group ";
            if (name1 == "sauce" || name1 == "roasted vegetable")
            {
                label54.Text = "This ingredient belongs to Vegetable group";
            }
            else
                label54.Text = "This ingredient does not belong to Vegetable group ";
            if (name1 == "pudding" || name1 == "custurd" || name1 == "ice-cream")
            {
                label54.Text = "This ingredient belongs to Dairy group";
            }
            else
                label54.Text = "This ingredient does not belong to Dairy group ";

        }
    }
}
