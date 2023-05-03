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

namespace CADvizorMain.Views.Pages
{
    /// <summary>
    /// HomePage.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();

            news1.MouseLeftButtonDown += news1_MouseLeftButtonDown;
            news2.MouseLeftButtonDown += News2_MouseLeftButtonDown;
            news3.MouseLeftButtonDown += News3_MouseLeftButtonDown;
            news4.MouseLeftButtonDown += News4_MouseLeftButtonDown;

        }

        private void News4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.newswire.co.kr/newsRead.php?no=959908");
        }

        private void News3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.newswire.co.kr/newsRead.php?no=964002");
        }

        private void News2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.newswire.co.kr/newsRead.php?no=964780");
        }

        private void news1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.newswire.co.kr/newsRead.php?no=962766");
        }

    }
}
