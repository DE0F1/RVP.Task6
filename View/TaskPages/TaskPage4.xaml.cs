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
    /// Логика взаимодействия для TaskPage4.xaml
    /// </summary>
    public partial class TaskPage4 : Page
    {
        public TaskPage4()
        {
            InitializeComponent();
        }
        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string A = (TbA.Text);
                int DecimalNumber = 0;

                for (int i = 0; i < A.Length; i++)
                {
                    if (A[A.Length - i - 1] == '0') continue;
                    DecimalNumber += (int)Math.Pow(2, i);
                }
                string B = Convert.ToString(DecimalNumber, 16);
                MessageBox.Show($"{B}", "Системное сообщение",
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
