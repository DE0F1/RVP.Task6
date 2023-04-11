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
using RVP.Task6.Core; using RVP.Task6.View.TaskPages;

namespace RVP.Task6.View.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для TaskPage7.xaml
    /// </summary>
    public partial class TaskPage7 : Page
    {
        public TaskPage7()
        {
            InitializeComponent();
        }

        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int A = Convert.ToInt32(TbA.Text);
                int[] N = new int[15];
                int[] M = new int[15];
                Random ran = new Random();
                int k;
                for (int i = 0; i < N.Length; i++)
                {
                    k = ran.Next(10, 99);
                    M[i] = k;
                    int T = int.Parse(new string(k.ToString().OrderByDescending(x => x).ToArray()));
                    N[i] = T;
                }

                MessageBox.Show($"Исходный массив=\n{string.Join(", ", M)}\nРезультат=\n{string.Join(", ", N)}", "Системное сообщение",
                         MessageBoxButton.OK,
                         MessageBoxImage.Information);
                TbA.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Системное сообщение", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
