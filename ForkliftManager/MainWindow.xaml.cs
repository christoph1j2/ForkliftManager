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

namespace ForkliftManager
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CloseAppButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult res = MessageBox.Show("Are you sure you want to quit?", "Exit", MessageBoxButton.YesNo, MessageBoxImage.Information);
            if(res == MessageBoxResult.Yes)
            {
                this.Close();
            }
            else if(res == MessageBoxResult.No)
            {
                
            }
        }
    }
}
