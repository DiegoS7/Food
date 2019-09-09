using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comidas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            alimentos.Items.Add("Pozole");
            alimentos.Items.Add("Tostadas de Pata");
        }
        private void Alimentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indice = alimentos.SelectedIndex;
            label1.Text = indice.ToString();
            label2.Text = alimentos.Items[indice].ToString();
        }

        private void Añadir_Click(object sender, EventArgs e)
        {
            alimentos.Items.Add(textBox1.Text);
        }

   
    }
}
