﻿using System.Windows;

namespace TransparentRabbitStartUp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DragMove();
        }
    }
}
