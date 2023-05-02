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

namespace CADvizorMain.Views
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CADvizorLogin : Window
    {
        public CADvizorLogin()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            //새로운 창 뛰움
            CADvizorMain.Views.CADvizorPlatform mainWindow = new CADvizorPlatform();
            mainWindow.Show();

            //기존창 닫음
            this.Close();
        }

        private void TxtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                //아래 조건이 성립하려면 로그인하는 계정에 대해서 정합성 체크해줘야된다.


                //새로운 창 뛰움
                CADvizorMain.Views.CADvizorPlatform mainWindow = new CADvizorPlatform();
                mainWindow.Show();

                //기존창 닫음
                this.Close();
            }
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }
    }
}
