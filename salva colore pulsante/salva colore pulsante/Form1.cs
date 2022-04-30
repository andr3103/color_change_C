using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace salva_colore_pulsante
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sve_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog chiudi = new SaveFileDialog();
            if (chiudi.ShowDialog() == DialogResult.OK)
            {
                StreamWriter scrvi = new StreamWriter(File.Create(chiudi.FileName));
                scrvi.Write(textBox1.Text);
                scrvi.Close();
                scrvi.Dispose();

            }
        }

        private void opn_button_Click(object sender, EventArgs e)
        {
            OpenFileDialog apri = new OpenFileDialog();
            apri.Title = "sciegli un file da aprire";
            apri.Filter = "Text File|*.txt|All Files|*.*";
            if (apri.ShowDialog() == DialogResult.OK)
            {
                label3.Text = apri.SafeFileName;
                label4.Text = apri.FileName;
                StreamReader leggi = new StreamReader(apri.FileName);
                textBox1.Text = leggi.ReadToEnd();
                leggi.Close();
                apri.Dispose();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void color_button_Click(object sender, EventArgs e)
        {

            string colore = textBox1.Text;
            if (colore == "")
            {
                MessageBox.Show("Il campo è vuoto");
                color_button.BackColor = Color.Transparent;
            }
            else
            {
                color_button.BackColor = Color.FromName(colore);
            }

        }
    }
}
