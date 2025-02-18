﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Webshop_domain.Business;

namespace Webshop_WPF
{
    /// <summary>
    /// Interaction logic for Aanmelden.xaml
    /// </summary>
    public partial class Aanmelden : Window
    {
        private Controller _controller;
        public Aanmelden()
        {
            InitializeComponent();
            _controller = new Controller();
        }

        private void btnShowklanten_Click(object sender, RoutedEventArgs e)
        {
            Klanten klantenvenster = new Klanten();
            klantenvenster.Show();
        }

        private void btnAanmelden_Click(object sender, RoutedEventArgs e)
        {
            Klant klant = new Klant(
                tbxGebruikersnaam.Text, tbxPaswoord.Text, tbxVoornaam.Text, tbxAchternaam.Text, tbxGeboortedatum.Text, Convert.ToInt32(tbxPostcode.Text), tbxStraat.Text, Convert.ToInt32(tbxHuisnummer.Text), tbxEmail.Text, tbxTelefoonnummer.Text);
            _controller.addKlant(klant);
        }

        private void btnaddMandje_Click(object sender, RoutedEventArgs e)
        {
            AddWinkelwagen addvenster = new AddWinkelwagen();
            addvenster.Show();
        }

        private void btnVerlanglijstje_Click(object sender, RoutedEventArgs e)
        {
            AddVerlanglijstje verlanglijstjevenster = new AddVerlanglijstje();
            verlanglijstjevenster.Show();
        }
    }
}
