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
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            tbA.Focus();
            tbValue.Focus();
        }
        DispatcherTimer timer;
        /// <summary>
        /// создане таймера для строки состояния
        /// </summary>
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Tick += Timer;
            timer.Interval = new TimeSpan(0, 0, 0, 0);
            timer.IsEnabled = true;
        }
        private void Timer(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            time.Text = dt.ToString("HH:mm");
            data.Text = dt.ToString("dd.MM.yyyy");
        }

        /// <summary>
        /// кнопка расчета первого задания
        /// </summary>
        private void btnCalc_Click(object sender, RoutedEventArgs e)
        {
           bool a, b,c;
            a = int.TryParse(tbA.Text, out int A);
            b = int.TryParse(tbB.Text, out int B);
            c = int.TryParse(tbB.Text, out int C);
            if (a && b && c)
            {
                int V = A*B*C;
                int S = 2 * (A * B + A * C + B * C);
                tbArea.Text=S.ToString();
                tbVolume.Text=V.ToString();
            }
            else
            {
                MessageBox.Show("Неверное введенные данные. Пожалуйста, проверьте еще раз!");
            }
            
        }

        /// <summary>
        /// кнопка о программе
        /// </summary>
        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №12 \r\nСоздание интерфейса приложения. \r\n5. Реализовать расчет задачи: \r\n• Даны длины ребер a, b, c прямоугольного параллелепипеда.\r\n Найти его объем V = a·b·c и площадь поверхности S = 2·(a·b + b·c + a·c). \r\n• Дано двузначное число. Найти сумму и произведение его цифр.\r\n Выполнила:\r\nстудентка гр. ИСП-31 Кирюшова В. ");
        }

        /// <summary>
        /// кнопка выхода
        /// </summary>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// кнопка в меню для очистки всех полей
        /// </summary>
        private void miClean_Click(object sender, RoutedEventArgs e)
        {
            tbVolume.Clear();
            tbArea.Clear();
            tbA.Clear();
            tbB.Clear();
            tbC.Clear();
        }

        /// <summary>
        /// Событие, которое очищает пола ответов при изменении поля "сторона а"
        /// </summary>
        private void tbA_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbVolume.Clear();
            tbArea.Clear();
        }

        /// <summary>
        /// Событие, которое очищает пола ответов при изменении поля "сторона b"
        /// </summary>
        private void tbB_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbVolume.Clear();
            tbArea.Clear();
        }

        /// <summary>
        /// Событие, которое очищает пола ответов при изменении поля "сторона c"
        /// </summary>
        private void tbC_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbVolume.Clear();
            tbArea.Clear();
        }

        /// <summary>
        /// кнопка расчета второго задания
        /// </summary>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            bool f1 = int.TryParse(tbValue.Text, out int value);
            if (f1 && value>9 && value<100)
            {
                int ed = value % 10;
                int dec = value/10;
                int sum = ed + dec;
                int mult = ed * dec;
                tbSum.Text = sum.ToString();
                tbMult.Text = mult.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка ввода данных! Проверьте, число должно быть двузначным больше 9 и меньше 100.");
            }
        }
        /// <summary>
        /// Событие, которое очищает пола ответов при изменении поля "двузначное число"
        /// </summary>
        private void tbValue_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbMult.Clear();
            tbSum.Clear();
        }
    }
}