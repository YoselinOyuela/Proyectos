using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_matriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Resultadobutton_Click(object sender, EventArgs e)
        {
            int fila = Convert.ToInt32(FilatextBox.Text);
            int columna = Convert.ToInt32(ColumntextBox.Text);
            int[,] Matriz = new int[fila, columna];

            Random numeros = new Random();

            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Matriz[i, j] = numeros.Next(1, 100);

                }

                dataGridView1.ColumnCount = columna;
                dataGridView1.RowCount = fila;


            }
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = Matriz[i, j].ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FilatextBox.Clear();
            ColumntextBox.Clear();
           
        }

        private void Salirbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }


}

