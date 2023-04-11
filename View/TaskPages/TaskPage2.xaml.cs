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
    /// Логика взаимодействия для TaskPage2.xaml
    /// </summary>
    public partial class TaskPage2 : Page
    {
        public TaskPage2()
        {
            InitializeComponent();
        }
        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string A = (TbA.Text);
                double DecimalNumber = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[A.Length - i - 1] == '0') continue;
                    DecimalNumber += (double)Math.Pow(2, i);
                }
                MessageBox.Show($"{DecimalNumber}", "Системное сообщение",
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
