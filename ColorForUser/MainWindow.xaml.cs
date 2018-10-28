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

namespace ColorForUser
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>

    ///Создайте приложение, которое хранит цветовую схему для каждого пользователя
    ///и автоматически загружает корректную цветовую схему при его открытии пользователем.  

    public partial class MainWindow : Window
    {
        Dictionary<String, SolidColorBrush> users;
        Random rand;
        SolidColorBrush b;
        public MainWindow()
        {
            InitializeComponent();
            rand = new Random();
            b = new SolidColorBrush(Color.FromRgb((byte)rand.Next(255), (byte)rand.Next(255), (byte)rand.Next(255)));
            users.Add("User1", b);

            
        }

    }
}
