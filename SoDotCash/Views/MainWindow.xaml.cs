using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows;
using SoDotCash.ViewModels;


namespace SoDotCash.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TreeView_OnSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            var DC = (MainViewModel) DataContext;
            DC.SetSelectedItem(e.NewValue);
        }
    }
}
