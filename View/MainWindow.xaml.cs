using RVP.Task6.Core;
using RVP.Task6.View.TaskPages;
using RVP.Task6.View;
using System.Windows;


namespace RVP.Task6.View.TaskPages
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      InitializeComponent();
    }
    private void CloseBtn_Click(object sender, RoutedEventArgs e)
    {
        Application.Current.Shutdown();
    }
    private void MinimizeBtn_Click(object sender, RoutedEventArgs e)
    {
        this.WindowState = WindowState.Minimized;
    }
}
