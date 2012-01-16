using System;
using System.Collections.Generic;
using System.Linq;
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

namespace GANAAN_CUSTOMER_MGR
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
        }

        void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // 검색조건 콤보박스 생성
            cboSearchCondition.Items.Add("전체");
            cboSearchCondition.SelectedIndex = 0;

            // 검색실행            
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // SQLite 호출
            // 없으면 DB 생성
            // 또는 DB 파일 찾기
            // 파일명은 GANAAN.db

        }
    }
}
