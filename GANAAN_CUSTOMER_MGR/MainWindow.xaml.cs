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
        const string strDbFileName = "GANAAN_CUSTOMER.db";
        Control_DB db = new Control_DB();

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainWindow_Loaded);
            this.Closed += new EventHandler(MainWindow_Closed);
        }

        void MainWindow_Closed(object sender, EventArgs e)
        {
            //TODO: 종료시 DB 파일을 백업한다. 년별로 폴더를 생성하여 뒤에 날짜를 붙여 복사본을 만든다.
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
            // 파일 확인
            bool bExit = Control_File.CheckFile(strDbFileName);

            // SQLite 호출
            db.test();
            // 없으면 DB 생성
            // 또는 DB 파일 찾기
            // 파일명은 GANAAN.db
        }
      
    }
}
