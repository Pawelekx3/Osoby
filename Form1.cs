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
        List<Person> oPersonlist = new List<Person>();

        public class Person
        {
            public int PersonId { get; private set; }
            public string FirstName { get; private set; }
            public string LastName { get; private set; }
            public int Age { get; private set; }

            public Person(string sFirstName, string sLastName, int nAge)
            {
                FirstName = sFirstName;
                LastName = sLastName;
                Age = nAge;
            }

            



        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
}

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            oPersonlist.Add(new Person(textBox1.Text, textBox2.Text, System.Convert.ToInt16(textBox3.Text)));
            label8.Text = System.Convert.ToString(oPersonlist.Count);
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = oPersonlist.Count;

            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = oPersonlist.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            oPersonlist.RemoveAt(System.Convert.ToInt16(numericUpDown2.Value - 1));
            label8.Text = System.Convert.ToString(oPersonlist.Count);
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = oPersonlist.Count;

            numericUpDown2.Minimum = 1;
            numericUpDown2.Maximum = oPersonlist.Count;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int nPersonsNo = (int)numericUpDown1.Value -1;
            
            Person oPerson = oPersonlist[nPersonsNo];
            textBox1.Text = oPerson.FirstName;
            textBox2.Text = oPerson.LastName;
            textBox3.Text = Convert.ToString(oPerson.Age);


        }
    }
}
