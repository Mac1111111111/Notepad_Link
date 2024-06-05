using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M.s.M
{
    public partial class Form1 : Form
    {
        private List<string> muistiinpanot = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LisaaMuistiinpanoButton_Click(object sender, EventArgs e)
        {
            string uusiMuistiinpano = muistiinpanoTextBox.Text;
            muistiinpanot.Add(uusiMuistiinpano);
            PaivitaMuistiinpanoLista();
            muistiinpanoTextBox.Clear();
        }

        private void PoistaMuistiinpanoButton_Click(object sender, EventArgs e)
        {
            if (muistiinpanoLista.SelectedIndex != -1)
            {
                muistiinpanot.RemoveAt(muistiinpanoLista.SelectedIndex);
                PaivitaMuistiinpanoLista();
                muistiinpanoTextBox.Clear();
            }
        }
        private void PaivitaMuistiinpanoLista()
        {
            muistiinpanoLista.Items.Clear();
            foreach (string muistiinpano in muistiinpanot)
            {
                muistiinpanoLista.Items.Add(muistiinpano);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string avainsana = hakuTextBox.Text.ToLower(); // Otetaan hakusana ja muutetaan pieniksi kirjaimiksi
            List<string> hakutulokset = muistiinpanot.Where(note => note.ToLower().Contains(avainsana)).ToList();

            // Tyhjennetään nykyinen lista ja lisätään hakutulokset
            muistiinpanoLista.Items.Clear();
            foreach (string tulos in hakutulokset)
            {
                muistiinpanoLista.Items.Add(tulos);
            }
        }
    }
}
