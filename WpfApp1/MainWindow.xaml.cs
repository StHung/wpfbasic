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
using WpfApp1.ViewModels;

namespace WpfApp1
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

        private void DrawRecs(int row, int col, int padding)
        {
            canvasContainer.Children.Clear();
            canvasContainer.Margin = Padding;
            canvasContainer.Width = 400 - padding - 4;
            canvasContainer.Height = 400 - padding - 4;
            double elementWidth = (canvasContainer.Width) / row;
            double elementHeight = (canvasContainer.Height) / col;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Rectangle rectangle = new Rectangle();
                    rectangle.Width = elementWidth;
                    rectangle.Height = elementHeight;
                    rectangle.Stroke = new SolidColorBrush(Colors.Black);
                    rectangle.StrokeThickness = 1;
                    rectangle.Fill = new SolidColorBrush(Colors.Green);
                    Canvas.SetLeft(rectangle, i * elementWidth);
                    Canvas.SetTop(rectangle, j * elementHeight);
                    canvasContainer.Children.Add(rectangle);
                }
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DrawRecs(0, 0, 0);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var dataContext = (this.DataContext as MainViewModel)?.MainModel;
            if(dataContext != null)
                DrawRecs(dataContext.Row, dataContext.Column, dataContext.Padding);
        }

        private void Window_SourceUpdated(object sender, DataTransferEventArgs e)
        {
            canvasContainer.Children.Clear();
        }
    }
}
