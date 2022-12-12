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

namespace Feljegyzesek
{
    public partial class Form1 : Form
    {
        public string kivfile = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if (nincsadat())
            {

                return;

            }

            FileSaveDialog.Filter = "Minden fájl (*.*)|*.*|Szöveg Fájl (*.txt)|*.txt|Vesszővel tagolt szövegfájl (*.csv)|*.csv";
            FileSaveDialog.FileName = FajlnevText.Text;

            if (FileSaveDialog.ShowDialog() == DialogResult.OK)
            {

                string szoveg = string.Join(";", FajlnevText.Text, DatumPick.Value.ToString(), FajlszovegBox.Text);
                kivfile = FileSaveDialog.FileName;
                File.WriteAllText(kivfile, szoveg);

                FajlnevText.Text = "";
                DatumPick.ResetText();
                FajlszovegBox.Text = "";

            }
            else
            {

                MessageBox.Show("Nincs kiválasztva!", "Hiányzó Adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }
        private void OpenButton_Click(object sender, EventArgs e)
        {

            if (FileOpenDialog.ShowDialog() == DialogResult.OK)
            {

                kivfile = FileOpenDialog.FileName;
                string beolvasottszoveg = File.ReadAllText(kivfile);
                string[] adatok = beolvasottszoveg.Split(';');

                FajlnevText.Text = adatok[0];
                DatumPick.Value = DateTime.Parse(adatok[1]);
                FajlszovegBox.Text = adatok[2];

            }

        }
        private bool nincsadat()
        {

            if (string.IsNullOrEmpty(FajlnevText.Text))
            {

                MessageBox.Show("Nem adott meg nevet!", "Hiányzó Adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FajlnevText.Focus();
                return true;

            }
            if (string.IsNullOrEmpty(FajlszovegBox.Text))
            {

                MessageBox.Show("Nem adott meg szöveget!", "Hiányzó adat!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                FajlszovegBox.Focus();
                return true;

            }

            return false;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

            string szoveg = string.Join(";", FajlnevText.Text, DatumPick.Value.ToString(), FajlszovegBox.Text);
            kivfile = FileSaveDialog.FileName;
            File.WriteAllText(kivfile, szoveg);

            FajlnevText.Text = "";
            DatumPick.ResetText();
            FajlszovegBox.Text = "";

            MessageBox.Show("Adatok módosítása sikeres!", "Siker!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }
    }
}
