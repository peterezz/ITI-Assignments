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
using System.Windows.Shapes;

namespace Wpf_Day8
{
    /// <summary>
    /// Interaction logic for Task03.xaml
    /// </summary>
    public partial class Task03 : Window
    {
        public Task03()
        {
            InitializeComponent();
            LstStd.ItemsSource = new List<Student>()
            {
                new Student(1,23,"Peter",3.2f,"/Images/wallpaperflare.com_wallpaper 02.jpg"),
                new Student(2,24,"Ahmed",3.5f,"/Images/wallpaperflare.com_wallpaper 03.jpg"),
                new Student(3,23,"Sameh",3.6f,"/Images/wallpaperflare.com_wallpaper 04.jpg"),
                new Student(4,23,"Rwan",4.0f, "/Images/wallpaperflare.com_wallpaper 05.jpg"),
            };
        }
    }
}
