using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LanzamientoDeDado
{
    public partial class Form1 : Form
    {
        Dado d = new Dado();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Text = "";
            txtResultado.Text += d.Lanzamiento();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Text = "";
            LanzarCien();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lanzarDosCien();
        }
        public void lanzarDosCien()
        {
            int[] resultado = new int[11];
            for(int i = 0; i <100; i++)
            {
                int re = d.Lanzamiento() + d.Lanzamiento();
                resultado[re - 2]++;
            }
            for (int i = 0; i<resultado.Length; i++)
            {
                txtResultado.Text += "El resultado de la suma " + (i + 2) + " aparecio: "+resultado[i]+"\r\n";
            }
        }
        public void LanzarCien()
        {
            int[] resultado = new int[6];
            for (int i = 0; i < 100; i++)
            {
                int re = d.Lanzamiento();
                resultado[re - 1]++;
            }

            for (int i = 0; i < resultado.Length; i++)
            {
                txtResultado.Text += "La Cara " + (i + 1) + " callo:" + resultado[i] + "\r\n";
            }
        }
    }
}
