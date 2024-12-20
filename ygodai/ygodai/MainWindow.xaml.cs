using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ygodai
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random random = new Random();
        int a; int b;
        int rov;
        int c1 = 0; int c2 = 0;


        public MainWindow()
        {
            InitializeComponent();

        }

        private void newgame_Click(object sender, RoutedEventArgs e)
        {
            c1 = 0;
            c2 = 0;
            cifr1.Content = c1;
            cifr2.Content = c2;
            OT.Text = "";
            DO.Text = "";
            end.IsEnabled = true;
            end2.IsEnabled = true;
            zadat.IsEnabled = true;
            MessageBox.Show(
                        "FIGHT",
                        "Новая игра", MessageBoxButton.OK);

        }

        private void end_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                
                int P = Convert.ToInt32(Player.Text);

                if (P == rov)
                {
                    c1++;
                    rov = random.Next(a, b);
                }
                else if (P > rov)
                {
                    MessageBox.Show(
                        "Введеное число меньше загадоного",
                        "Победа", MessageBoxButton.OK);
                }
                else if (P < rov)
                {
                    MessageBox.Show(
                        "Введеное число больше загадоного",
                        "Победа", MessageBoxButton.OK);
                }
                cifr1.Content = c1;

                if (c1 == 3 || c1 > 3)
                {
                    cifr1.Content = 3;
                    MessageBox.Show(
                        "Игрок 1 победил",
                        "Победа", MessageBoxButton.OK);
                    end.IsEnabled = false;
                }
            } catch { }
        }

        private void end2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int P = Convert.ToInt32(Player.Text);
                if (P == rov)
                {
                    c2++;
                    rov = random.Next(a, b);
                }
                else if (P > rov)
                {
                    MessageBox.Show(
                        "Введеное число меньше загадоного",
                        "Победа", MessageBoxButton.OK);
                }
                else if (P < rov)
                {
                    MessageBox.Show(
                        "Введеное число больше загадоного",
                        "Победа", MessageBoxButton.OK);
                }
                cifr2.Content = c2;

                if (c2 == 3 || c2 > 3)
                {
                    cifr2.Content = 3;
                    MessageBox.Show(
                        "Игрок 2 победил",
                        "Победа", MessageBoxButton.OK);
                    end2.IsEnabled = false;
                }
            }
            catch { }
            
        }

        private void zadat_Click(object sender, RoutedEventArgs e)
        {
            a = Convert.ToInt32(OT.Text);
            b = Convert.ToInt32(DO.Text);
            rov = random.Next(a, b);
            zadat.IsEnabled = false;
        }
    }
}