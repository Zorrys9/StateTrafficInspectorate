﻿using Logic.LogicsModel;
using Logic.Models;
using System;
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

namespace StateTrafficInspectorate.UnRegisteredUser
{
    /// <summary>
    /// Логика взаимодействия для CheckCurrentTransport.xaml
    /// </summary>
    public partial class CheckCurrentTransport : Window
    {
        public CheckCurrentTransport()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            CheckTransport checkTransport = new CheckTransport();
            checkTransport.Show();
            this.Close();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                CategoryTransport.ItemsSource = LogicCategoryTransport.GetNameCategory();
                TypeOfDrive.ItemsSource = LogicTypeOfDrive.GetNameType();

                TransportModel transport = LogicTransport.GetCurrentTransport();
                Manufacturer.Text = transport.Manufacturer;
                Model.Text = transport.Model;
                YearTransport.Text = transport.YearTransport;
                NumberEngine.Text = transport.NumberEngine;
                ModelEngine.Text = transport.ModelEngine;
                YearEngine.Text = transport.YearEngine;
                PowerEngineK.Text = transport.PowerEngineKVT;
                PowerEngineH.Text = transport.PowerEngineH;
                MaxLoad.Text = transport.MaxLoad.ToString();
                Weight.Text = transport.Weight.ToString();
                Color.Text = transport.Color;
                VIN.Text = transport.VIN;
                Description.Text = transport.Description;
                CategoryTransport.SelectedIndex = transport.CategoryTransport - 1;
                TypeOfDrive.SelectedIndex = transport.TypeOfDrive - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
