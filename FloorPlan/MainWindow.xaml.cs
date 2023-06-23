using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace FloorPlan
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<String> roomList = new List<string>();
        List<String> roomColor = new List<string>();

        public MainWindow()
        {
            InitializeComponent();

            roomList.Add("대표실");
            roomList.Add("직원실");
            roomList.Add("영상실");
            roomList.Add("용접실");
            roomList.Add("화장실");
            roomList.Add("창고실");

            roomColor.Add("Red");
            roomColor.Add("Blue");
            roomColor.Add("Yellow");
            roomColor.Add("Green");
            roomColor.Add("SkyBlue");
            roomColor.Add("DarkBlue");

            ComboBoxList.ItemsSource = roomList;
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            RedTextBlock.Text = (RedBlock.ActualHeight * RedBlock.ActualWidth).ToString();
            BlueTextBlock.Text = (BlueBlock.ActualHeight * BlueBlock.ActualWidth).ToString();
            YellowTextBlock.Text = (YellowBlock.ActualHeight * YellowBlock.ActualWidth).ToString();
            GreenTextBlock.Text = (GreenBlock.ActualHeight * GreenBlock.ActualWidth).ToString();
            SkyBlueTextBlock.Text = (SkyBlueBlock.ActualHeight * SkyBlueBlock.ActualWidth).ToString();
            DarkBlueTextBlock.Text = (DarkBlueBlock.ActualHeight * DarkBlueBlock.ActualWidth).ToString();

            Red_x.Text = RedBlock.ActualWidth.ToString();
            Blue_x.Text = BlueBlock.ActualWidth.ToString();
            Yellow_x.Text = YellowBlock.ActualWidth.ToString();
            Green_x.Text = GreenBlock.ActualWidth.ToString();
            SkyBlue_x.Text = SkyBlueBlock.ActualWidth.ToString();
            DarkBlue_x.Text = DarkBlueBlock.ActualWidth.ToString();

            Red_y.Text = RedBlock.ActualHeight.ToString();
            Blue_y.Text = BlueBlock.ActualHeight.ToString();
            Yellow_y.Text = YellowBlock.ActualHeight.ToString();
            Green_y.Text = GreenBlock.ActualHeight.ToString();
            SkyBlue_y.Text = SkyBlueBlock.ActualHeight.ToString();
            DarkBlue_y.Text = DarkBlueBlock.ActualHeight.ToString();

            Red_size.Text = (RedBlock.ActualHeight * RedBlock.ActualWidth).ToString();
            Blue_size.Text = (BlueBlock.ActualHeight * BlueBlock.ActualWidth).ToString();
            Yellow_size.Text = (YellowBlock.ActualHeight * YellowBlock.ActualWidth).ToString();
            Green_size.Text = (GreenBlock.ActualHeight * GreenBlock.ActualWidth).ToString();
            SkyBlue_size.Text = (SkyBlueBlock.ActualHeight * SkyBlueBlock.ActualWidth).ToString();
            DarkBlue_size.Text = (DarkBlueBlock.ActualHeight * DarkBlueBlock.ActualWidth).ToString();

            



            // 타일 갯수 출력
            Red_count.Text = (count(RedBlock)).ToString();
            Blue_count.Text = (count(BlueBlock)).ToString();
            Yellow_count.Text = (count(YellowBlock)).ToString();
            Green_count.Text = (count(GreenBlock)).ToString();
            SkyBlue_count.Text = (count(SkyBlueBlock)).ToString();
            DarkBlue_count.Text = (count(DarkBlueBlock)).ToString();

            /*
            Red_count.Text = (((int)(RedBlock.ActualHeight / tileWidth) + 1) * ((int)(RedBlock.ActualWidth / tileHight) + 1)).ToString();
            Blue_count.Text = (((int)(BlueBlock.ActualHeight / tileWidth) + 1) * ((int)(BlueBlock.ActualWidth / tileHight) + 1)).ToString();
            Yellow_count.Text = (((int)(YellowBlock.ActualHeight / tileWidth) + 1) * ((int)(YellowBlock.ActualWidth / tileHight) + 1)).ToString();
            Green_count.Text = (((int)(GreenBlock.ActualHeight / tileWidth) + 1) * ((int)(GreenBlock.ActualWidth / tileHight) + 1)).ToString();
            SkyBlue_count.Text = (((int)(SkyBlueBlock.ActualHeight / tileWidth) + 1) * ((int)(SkyBlueBlock.ActualWidth / tileHight) + 1)).ToString();
            DarkBlue_count.Text = (((int)(DarkBlueBlock.ActualHeight / tileWidth) + 1) * ((int)(DarkBlueBlock.ActualWidth / tileHight) + 1)).ToString();
            */


        }
        
        //타일 갯수 계산
        public int count (Rectangle x)
        {
            double tileHight = 10;
            double tileWidth = 10;
            int tileHightCount = (int)Math.Ceiling(x.ActualHeight / tileHight);
            int tileWidthCount = (int)Math.Ceiling(x.ActualWidth / tileWidth);
            return (int) tileHightCount * tileWidthCount;
        }

       

        //red box = 대표실
        public void Red_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(roomList[0], roomColor[0], MessageBoxButton.OK);
            roomList[0] = Interaction.InputBox("바꾸실 이름을 입력하세요", "change");
        }

        //blue box = 직원실
        private void Blue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(roomList[1], roomColor[1], MessageBoxButton.OK);
            roomList[1] = Interaction.InputBox("바꾸실 이름을 입력하세요", "change");

        }

        //yellow box = 영상실
        private void Yellow_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(roomList[2], roomColor[2], MessageBoxButton.OK);
            roomList[2] = Interaction.InputBox("바꾸실 이름을 입력하세요", "change");

        }

        //green box = 용접실
        private void Green_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(roomList[3], roomColor[3], MessageBoxButton.OK);
            roomList[3] = Interaction.InputBox("바꾸실 이름을 입력하세요", "change");

        }

        //skyblue box = 화장실
        private void SkyBlue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(roomList[4], roomColor[5], MessageBoxButton.OK);
            roomList[4] = Interaction.InputBox("바꾸실 이름을 입력하세요", "change");

        }

        //darkblue box = 창고실
        private void DarkBlue_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show(roomList[5], roomColor[6], MessageBoxButton.OK);
            roomList[5] = Interaction.InputBox("바꾸실 이름을 입력하세요", "change");

        }
    }
}
