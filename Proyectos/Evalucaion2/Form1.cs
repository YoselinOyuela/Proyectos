using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evalucaion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ejecutarbutton_Click(object sender, EventArgs e)
        {
            Clasepromedio promedio = new Clasepromedio( NombretextBox.Text, Convert.ToDecimal(NumerotextBox.Text), Convert.ToDecimal(Not1textBox.Text), Convert.ToDecimal(Not2textBox.Text), Convert.ToDecimal(Not3textBox.Text), Convert.ToDecimal(Not4textBox.Text));
           
           
            
            
            

            decimal calcular;
            calcular = (Convert.ToDecimal(Not1textBox.Text) + Convert.ToDecimal(Not2textBox.Text) + Convert.ToDecimal(Not3textBox.Text) + Convert.ToDecimal(Not4textBox.Text)) / 4;



            if (calcular >= 70)
            {
                MessageBox.Show($" ¡! Aprobado su promedio es de !!" + calcular);
            }
            else
            {
                MessageBox.Show("  !!Esta reprobado su promedio es de!! " + calcular);
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
             
           
            
                NombretextBox.Clear();
                NumerotextBox.Clear();
                Not1textBox.Clear();
                Not2textBox.Clear();
                Not3textBox.Clear();
                Not4textBox.Clear();
            }
        }
    }
}
       
    
