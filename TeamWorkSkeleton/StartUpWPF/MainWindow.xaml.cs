﻿namespace StartUpWPF
{
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
    using System.Windows.Navigation;
    using System.Windows.Shapes;

    /// <summary>
    /// App runs here.
    /// Call Methods elsewhere.
    /// </summary>
    public partial class MainWindow : Window
    {
        static int startLeft = 10;
        static int startTop = 10;
        Ellipse shape = new Ellipse() { Width = 10, Height = 10, Fill = Brushes.Blue };

        public MainWindow()
        {
            InitializeComponent();
            PlayField.Children.Add(shape);
            // TODO: Run App here
        }

       
        

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            startTop += 10;
            startLeft += 10;

            
            Canvas.SetTop(shape, startTop);
            Canvas.SetLeft(shape, startLeft);

            PlayField.Children[0] = shape;
        }
    }
}
