using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diccionario
{
    public partial class UserControl1: UserControl
    {
        private Dictionary<string, string> diccionario = new Dictionary<string, string>();
        public UserControl1()
        {
            InitializeComponent();
            diccionario.Add("hi", "hola");
            diccionario.Add("bye", "adios");
            diccionario.Add("aqui", "here");
            diccionario.Add("table", "mesa");
            diccionario.Add("dog", "perro");
            diccionario.Add("cat", "gato");
            diccionario.Add("cow", "vaca");
            diccionario.Add("bull", "toro");
            diccionario.Add("chair", "silla");
            diccionario.Add("friend", "amigo");
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (diccionario.TryGetValue(textBox1.Text.ToLower(), out string tmp))
            {
                label2.Text = tmp;
            }
            else
            {
                label2.Text = "No hay traducción registrada.";
            }
        }
    }
}
