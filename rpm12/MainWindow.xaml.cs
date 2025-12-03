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
using System.Windows.Threading;

namespace rpm12
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
        DispatcherTimer timer;
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            //timer.Tick += Timer_Tick; не работает
            timer.Interval = new TimeSpan(0, 0, 1, 0);
            timer.IsEnabled = true;
        }

        private void Timer_Tick(object sender, RoutedEventArgs e)
        {
            DateTime d = DateTime.Now;
            time.Text = d.ToString("HH:mm:");
            data.Text = d.ToString("dd.MM.yyyy");
        }
    }
}