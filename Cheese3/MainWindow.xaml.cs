using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Cheese3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Button[,] btns;
        List<string> piecesNames;

        public MainWindow()
        {
            InitializeComponent();

            piecesNames = new List<string> { "King", "Queen", "Bishop", "Rook", "Knight" };
            lisBoxFig.ItemsSource = piecesNames;

            btns = new Button[8, 8];
            CreateField();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateField()
        {

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    btns[i, j] = new Button();
                    btns[i, j].Click += new RoutedEventHandler(Field_Click);

                    if ((i + j) % 2 == 0)
                    {
                        btns[i, j].Background = Brushes.Black;
                        btns[i, j].Foreground = Brushes.White;
                    }
                    else
                    {
                        btns[i, j].Background = Brushes.White;
                        btns[i, j].Foreground = Brushes.Black;
                    }

                    cheeseCells.Children.Add(btns[i, j]);
                }
            }
        }
        private void Field_Click(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            int x = Grid.GetColumn(clickedButton);
            int y = Grid.GetRow(clickedButton);

            string selPieceName = piecesNames[lisBoxFig.SelectedIndex];
            clickedButton.Content = selPieceName;
        }

    }
}