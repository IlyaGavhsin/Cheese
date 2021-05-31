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
        public MainWindow()
        {
            InitializeComponent();

            cheeseCells.Rows = 8;
            cheeseCells.Columns = 8;

            Button[,] btns = new Button[9, 9];
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    btns[i, j] = new Button();
                    btns[i, j].Width = 100;
                    btns[i, j].Height = 100;


                    if ((i + j) % 2 == 0)
                    {
                        btns[i, j].Background = Brushes.Black;
                    }
                    else
                        btns[i, j].Background = Brushes.White; 

                    cheeseCells.Children.Add(btns[i, j]);
                }
            }
        }
    }
}
