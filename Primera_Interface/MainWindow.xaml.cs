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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Primera_Interface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Grid migrid = new Grid();

            this.Content = migrid;

            WrapPanel Panel1 = new WrapPanel();
           
            Button boton = new Button();

            TextBlock Block1 = new TextBlock();

            Block1.Text = "enviar";

            migrid.Children.Add(boton);

            Panel1.Children.Add(Block1);

            boton.Content = Panel1;

            boton.Width = 150;
            boton.Height = 40;


        }
    }
}
