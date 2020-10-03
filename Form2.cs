using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CollectionApplication
{
    public partial class Form2 : Form
    {

        Hashtable fruitDictionary;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            fruitDictionary = new Hashtable();

            fruitDictionary.Add("Apple", 90.50);
            fruitDictionary.Add("Banana", "Php 25.00");
            fruitDictionary.Add("Grapes", "Violet");
            fruitDictionary.Add("Orange", 15);

            listBox1.Items.Clear();
            foreach (String key in fruitDictionary.Keys)
            {
                listBox1.Items.Add(key + " : " + fruitDictionary[key].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String fruitSearch = textBox1.Text;
            String fruitValue = fruitDictionary[fruitSearch].ToString();

            textBox2.Text = fruitValue;
        }
    }
}
