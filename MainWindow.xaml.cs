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

namespace Практическая_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Parallelepiped parall = new Parallelepiped();
        Ball ball = new Ball();
        private void Compare1_Click(object sender, RoutedEventArgs e)
        {

            //получаем длину,ширину и высоту параллелепипеда
            int a = Convert.ToInt32(A.Text);
            int b = Convert.ToInt32(B.Text);
            int c = Convert.ToInt32(C.Text);
            parall.volume = a * b * c;

            double p = 3.14;
            int r = Convert.ToInt32(R.Text);//получаем радиус шара
            ball.volume = Convert.ToInt32((Math.Pow(r, 3) * 4 * p) / 3);//вычисляем объем шара

            //записываем объем фигур в текстбоксы
            Inform.Text = "Объем:" + parall.volume.ToString();
            Inform1.Text = "Объем:" + ball.volume.ToString();
            //сравниваем фигуры
            if (parall.volume.CompareTo(ball.volume) == 1) MessageBox.Show("Параллелепипед больше");
            if (parall.volume.CompareTo(ball.volume) == -1) MessageBox.Show("Шар больше");
            if (parall.volume.CompareTo(ball.volume) == 0) MessageBox.Show("Фигуры равны");
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                parall.A = Convert.ToInt32(A.Text);
                parall.B = Convert.ToInt32(B.Text);
                parall.C = Convert.ToInt32(C.Text);
                Inform.Text = parall.Show();
            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }

            try
            {
                ball.R = Convert.ToInt32(R.Text);
                Inform1.Text = ball.Show();
            }
            catch
            {
                MessageBox.Show("ОШИБКА");
            }
        }



        private void Oprogramme_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выполнил Потапкин. Задание:. Создать интерфейс – фигура (объем). Создать классы - параллелепипед, шар. Классы должны включать конструкторы, функцию для формирования строкиинформации о фигуре.Объем шара V = 4 r3/ 3.Сравнение производить по объему.");

        }
    }
}

