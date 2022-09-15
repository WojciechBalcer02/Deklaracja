using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Deklaracja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            viewtext.Text = "Deklaruję przystąpienie do egzaminu potwierdzającego kwalifikacje w zawodzie" +
            " przeprowadzanego w terminie " + listofterms.SelectedItem + "\n\n Dane osobowe ucznia \n Nazwisko: \t\t" +
            lastname.Text + "\n Imię (imona): \t \t" + name.Text + "\n Data i miejsce urodzenia: \t" + dateofbirth.Text + " " + placeofbrith.Text +
            "\n Pesel: \t\t\t" + pesel.Text + "\n\n Adres korespondencyjny\n miejscowość \t\t" + town.Text + "\n ulica i numer domu: \t" + address.Text +
            "\n kod pocztowy i poczta: \t" + code.Text + "\t " + postoffice.Text + "\n nr telefonu z kierunkowym: \t" + phonenumber.Text +
            "\n email: \t" + email.Text;


        }

        private void lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewtext_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
