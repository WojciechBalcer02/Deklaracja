using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.RegularExpressions;

namespace Deklaracja
{
    public partial class Form1 : Form
    {
        String technicy;
        String pierwszyKolejny;
        String teoriaPraktyka;
        String kwalifikacja;
        String symbol;
        Boolean dzialaj = true;
        public Form1()
        {
            InitializeComponent();
            changetext.Text = kwalifikacja;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            qualifications.Items.Clear();
            qualifications.Items.Add("INF.02");
            qualifications.Items.Add("INF.03");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void programmer_CheckedChanged(object sender, EventArgs e)
        {
            qualifications.Items.Clear();
            qualifications.Items.Add("INF.03");
            qualifications.Items.Add("INF.04");
        }

        private void confirm_Click(object sender, EventArgs e)
        {
            
            String nazwisko = @"^[A-Z]{1,20}$";
            Regex rn = new Regex(nazwisko);

            if (rn.IsMatch(lastname.Text))
            {
                dzialaj = true;
                lastname.BackColor = Color.White;
            }
            else
            {
                lastname.BackColor = Color.Red;
                dzialaj = false;
            }


            String imie = @"^[A-Z]{1,20}$";
            Regex ri = new Regex(imie);

            if (ri.IsMatch(name.Text))
            {
                dzialaj = true;
                name.BackColor = Color.White;
            }
            else
            {
                name.BackColor = Color.Red;
                dzialaj = false;
            }

            String dataUro = @"^[0-3][0-9]\.[0-1][0-2]\.[1-2][0-9][0-9][0-9]$";
            Regex rdu = new Regex(dataUro);

            if (rdu.IsMatch(dateofbirth.Text))
            {
                dzialaj = true;
                dateofbirth.BackColor = Color.White;
            }
            else
            {
                dateofbirth.BackColor = Color.Red;
                dzialaj = false;
            }

            String miejsceUro = @"^[A-Z]{1,20}$";
            Regex rmu = new Regex(miejsceUro);

            if (rmu.IsMatch(placeofbrith.Text))
            {
                dzialaj = true;
                placeofbrith.BackColor = Color.White;
            }
            else
            {
                placeofbrith.BackColor = Color.Red;
                dzialaj = false;
            }

            String peselS = @"^[0-9]{11}$";
            Regex rp = new Regex(peselS);

            if (rp.IsMatch(pesel.Text))
            {
                dzialaj = true;
                pesel.BackColor = Color.White;
            }
            else
            {
                pesel.BackColor = Color.Red;
                dzialaj = false;
            }

            String kod = @"^[0-9]{2}-[0-9]{3}$";
            Regex rk = new Regex(kod);

            if (rk.IsMatch(code.Text))
            {
                dzialaj = true;
                code.BackColor = Color.White;
            }
            else
            {
                code.BackColor = Color.Red;
                dzialaj = false;
            }


            


            if (dzialaj == true)
            {
                

                if (programmer.Checked)
                {
                    technicy = "Technik programista";
                    symbol = "351406";
                }
                else if (computerspecialist.Checked)
                {
                    technicy = "Technik informatyk";
                    symbol = "351203";
                }
                if (first.Checked)
                {
                    pierwszyKolejny = "po raz pierwszy";

                    teoriaPraktyka = " ";
                }
                else if (second.Checked)
                {
                    pierwszyKolejny = "po raz kolejny ";


                    if ((practice.Checked) && (written.Checked))
                    {
                        teoriaPraktyka = "do części praktycznej i teoretycznej";
                    }
                    else if (practice.Checked)
                    {
                        teoriaPraktyka = "do części praktycznej";
                    }
                    else if (written.Checked)
                    {
                        teoriaPraktyka = "do części teoretycznej";
                    }
                }
                if (qualifications.SelectedItem.Equals("INF.02"))
                {
                    kwalifikacja = "Administracja i eksploatacja systemów komputerowych, urządzeń\r\nperyferyjnych i lokalnych sieci komputerowych";
                }
                else if (qualifications.SelectedItem.Equals("INF.03"))
                {
                    kwalifikacja = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz\r\nbazami danych";
                }
                else if (qualifications.SelectedItem.Equals("INF.04"))
                {
                    kwalifikacja = "Projektowanie, programowanie i testowanie aplikacji";
                }


                viewtext.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie" +
            " przeprowadzanego w terminie " + listofterms.SelectedItem + "\n\n Dane osobowe ucznia \n Nazwisko: \t\t" +
            lastname.Text + "\n Imię (imona): \t \t" + name.Text + "\n Data i miejsce urodzenia: \t" + dateofbirth.Text + " " + placeofbrith.Text +
            "\n Pesel: \t\t\t" + pesel.Text + "\n\n Adres korespondencyjny\n miejscowość: \t\t" + town.Text + "\n ulica i numer domu: \t" + address.Text +
            "\n kod pocztowy i poczta: \t" + code.Text + "\t " + postoffice.Text + "\n nr telefonu z kierunkowym: \t" + phonenumber.Text +
            "\n email: \t\t\t\t" + email.Text + "\n Deklaruje przystąpienie do egzaminu " + pierwszyKolejny + teoriaPraktyka +
            "\n\n Oznaczenie kwalifikacji zgodne z podstawą programową: " + qualifications.SelectedItem + "\n" +
            "Nazwa kwalifikacji: " + kwalifikacja + "\n\n Symbol cyfrowy zawodu: " + symbol + "\n Nazwa zawodu: " + technicy;

            }
            else
            {
                MessageBox.Show("Popraw błędy");
            }




        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewtext_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void first_CheckedChanged(object sender, EventArgs e)
        {
            practice.Enabled = false;
            written.Enabled = false;
        }

        private void second_CheckedChanged(object sender, EventArgs e)
        {
            practice.Enabled = true;
            written.Enabled = true;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            viewtext.Text = " ";
            lastname.Clear();
            name.Clear();
            dateofbirth.Clear();
            placeofbrith.Clear();
            town.Clear();
            code.Clear();
            postoffice.Clear();
            phonenumber.Clear();
            email.Clear();
            pesel.Clear();
            address.Clear();
        }

        private void save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (Stream s = File.Open(saveFileDialog.FileName, FileMode.CreateNew))
                using (StreamWriter sw = new StreamWriter(s))
                {
                    sw.WriteLine(viewtext.Text);
                }
            }
        }

        private void qualifications_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (qualifications.SelectedItem.Equals("INF.02"))
            {
                kwalifikacja = "Administracja i eksploatacja systemów komputerowych, urządzeń\r\nperyferyjnych i lokalnych sieci komputerowych";
            }
            else if (qualifications.SelectedItem.Equals("INF.03"))
            {
                kwalifikacja = "Tworzenie i administrowanie stronami i aplikacjami internetowymi oraz\r\nbazami danych";
            }
            else if (qualifications.SelectedItem.Equals("INF.04"))
            {
                kwalifikacja = "Projektowanie, programowanie i testowanie aplikacji";
            }
            changetext.Text = kwalifikacja;
        }
    }
}
