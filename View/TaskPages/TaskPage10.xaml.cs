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
using RVP.Task6.Core;
using RVP.Task6.View.TaskPages;

namespace RVP.Task6.View.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage10.xaml
    /// </summary>
    public partial class TaskPage10 : Page
    {
        public TaskPage10()
        {
            InitializeComponent();
        }
    

        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] N = new int[12];
                string[] M = new string[12];
                Random ran = new Random();
                int k;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(1, 299);
                    string B = Convert.ToString(k, 2);
                    M[i] = B;
                }

                MessageBox.Show($"{string.Join(", ", M)}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
