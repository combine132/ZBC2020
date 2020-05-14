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

namespace WPF_Testing
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

        void LangButton(object sender, RoutedEventArgs e)
        {
            RadioButton sprogSkift = (sender as RadioButton);

            string greetings;

            switch (sprogSkift.Content.ToString())
            {
                case "Dansk":
                    greetings = "Hej";
                    break;
                case "English":
                    greetings = "Hello";
                    break;
                case "Deutsch":
                    greetings = "Hallo";
                    break;
                case "Français":
                    greetings = "Salut";
                    break;
                default:
                    greetings = "something went wrong lol loser";
                    break;
            }
            hilsen.Text = greetings + " WPF";
        }
    }
}
