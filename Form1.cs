using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Arboles;

namespace Arboles_2023_II
{
    public partial class Form1 : Form
    {
        private Arbol arbol;
        public Form1()
        {
            InitializeComponent();
            arbol=new Arbol(ptbArbol);
        }

        private void txtbDato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar ==(char)Keys.Enter   )
            {
                int dato =int.Parse( txtbDato.Text);
                arbol.inserta_nodo(arbol.Raiz, null, dato,0);
                txtbDato.Clear();
            }
            else if (e.KeyChar ==(char)Keys.P )
            {
                arbol.preorden(arbol.Raiz);
            }
        }
    }
}
