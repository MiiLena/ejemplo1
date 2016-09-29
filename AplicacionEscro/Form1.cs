using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionEscro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnFuente_Click(object sender, EventArgs e)
        {
            FontDialog fuente = new FontDialog();
            if (fuente.ShowDialog() == DialogResult.OK)
            {
                this.lstCiudad.Font = fuente.Font;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK) 
            {
                this.lstCiudad.ForeColor = color.Color;
                this.lstCiudad.BackColor = color.Color;

            }
        }

             private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

             

             private void color()
             {
                 ColorDialog color1 = new ColorDialog();
                 this.lstCiudad.ForeColor = color1.Color; 
             }
             private void fuente()
             {
                 FontDialog fuente = new FontDialog();
                 this.lstCiudad.Font = fuente.Font;
             }

            
             

       
    }
}
