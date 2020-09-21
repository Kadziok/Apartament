using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apartament3
{
    public partial class Nowa : UserControl
    {
        public Nowa()
        {
            InitializeComponent();
           
        }
        public void LoadData()
        {
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(new string[] { "OLX", "Booking", "Airbnb" });
            List<List<string>> tempList = Connection.Query("SELECT imie, nazwisko, telefon FROM Klienci;");
            List<string> clientList = new List<string>();
            clientList.Add("---");
            foreach (List<string> el in tempList)
            {
                clientList.Add(el[0] + " | " + el[1] + " | " + el[2]);
            }
            comboBox2.Items.Clear();
            comboBox2.Items.AddRange(clientList.ToArray());
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String s = comboBox2.Text;
            if(s.IndexOf("|") == -1)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                textBox2.Text = s.Substring(0, s.IndexOf("|") - 1);
                s = s.Substring(s.IndexOf("|") + 2);
                textBox3.Text = s.Substring(0, s.IndexOf("|") - 1);
                s = s.Substring(s.IndexOf("|") + 2);
                textBox4.Text = s;
            }
        }
        public static void DodajRezerwacaje(string przyjazd, string wyjazd, 
            string sposob, string cena, string imie, string nazwisko, string telefon,
            string liczbaOsob)
        {
            List<List<string>> l = Connection.Query("SELECT idKlienta "+
                "FROM Klienci WHERE telefon='" + telefon + "';");
            if (!l.Any())
            {
                Connection.Query("INSERT INTO Klienci (imie, nazwisko, telefon, uwagi)"
                    + " VALUES ('" + imie + "', '" + nazwisko + "', '" + telefon + "', '');");
                l = Connection.Query("SELECT idKlienta " +
                "FROM Klienci WHERE telefon='" + telefon + "';");
            }
            Connection.Query("INSERT INTO rezerwacje (idKlienta, sposob,"
                +"przyjazd, wyjazd, cena, liczbaOsob)"
                + " VALUES ('" + l[0][0] + "', '" + sposob + "', '"
                + przyjazd + "', '" + wyjazd + "', '"+cena+ "', '"+liczbaOsob+"');");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            List<List<string>> l = Connection.Query("SELECT idRezerwacji " +
                    "FROM rezerwacje WHERE przyjazd<'" + Connection.SQLDate(dateTimePicker2.Value)
                    + "' AND wyjazd>'" + Connection.SQLDate(dateTimePicker1.Value) + "';");
            if (dateTimePicker1.Value > dateTimePicker2.Value
                || l.Count > 0 || !Double.TryParse(textBox1.Text, out double x))
            {
                Connection.form.ErrorMessage("Popraw dane", "Błąd");
            }
            else
            {
                DodajRezerwacaje(Connection.SQLDate(dateTimePicker1.Value),
                Connection.SQLDate(dateTimePicker2.Value), comboBox1.Text,
                textBox1.Text, textBox2.Text, textBox3.Text,
                textBox4.Text, textBox5.Text);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
            }
        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                panel1.Visible = true;
                uwagi.Visible = true;
                uwagi.Text = "Niepoprawny zakres dat";
            }
            else
            {
                List<List<string>> l = Connection.Query("SELECT idRezerwacji " +
                    "FROM rezerwacje WHERE przyjazd<'" + Connection.SQLDate(dateTimePicker2.Value)
                    + "' AND wyjazd>'" + Connection.SQLDate(dateTimePicker1.Value) + "';");
                if(l.Count > 0)
                {
                    panel1.Visible = true;
                    uwagi.Visible = true;
                    uwagi.Text = "Podany okres nie jest dostępny";
                }
                else
                {
                    panel1.Visible = false;
                    uwagi.Visible = false;
                }

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Connection.form.ShowStart();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(!Double.TryParse(textBox1.Text, out double x))
            {
                panel1.Visible = true;
                uwagi.Visible = true;
                uwagi.Text = "Niepoprawna cena";
            }
            else
            {
                panel1.Visible = false;
                uwagi.Visible = false;
            }
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker2_ValueChanged(sender, e);
        }
    }
}
