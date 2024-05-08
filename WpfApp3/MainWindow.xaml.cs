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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetComboBoxItems();
            AddFigureInBoard();
        }
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Border clickedBorder = (Border)sender;
            Point centerPoint = new Point(clickedBorder.ActualWidth / 2, clickedBorder.ActualHeight / 2);
            Point centerPointRelativeToWindow = clickedBorder.PointToScreen(centerPoint);
            TextCoord.Text = $"X={centerPointRelativeToWindow.X}, Y={centerPointRelativeToWindow.Y}";
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SetComboBoxItems()
        {
            CoordX.Items.Add("A");
            CoordX.Items.Add("B");
            CoordX.Items.Add("C");
            CoordX.Items.Add("D");
            CoordX.Items.Add("E");
            CoordX.Items.Add("F");
            CoordX.Items.Add("G");
            CoordX.Items.Add("H");
            CoordY.Items.Add("1");
            CoordY.Items.Add("2");
            CoordY.Items.Add("3");
            CoordY.Items.Add("4");
            CoordY.Items.Add("5");
            CoordY.Items.Add("6");
            CoordY.Items.Add("7");
            CoordY.Items.Add("8");
            Figure.Items.Add("K");
            Figure.Items.Add("Q");
            Figure.Items.Add("N");
            Figure.Items.Add("R");
            Figure.Items.Add("B");
            Color.Items.Add("White");
            Color.Items.Add("Black");

        }

        private void AddFigureInBoard()
        {
            var coordX = CoordX.Text;
            var coordY = CoordY.Text;
            var color = Color.Text;
            var text = new TextBlock();
            text.Text = Figure.Text;
            text.HorizontalAlignment = HorizontalAlignment.Center;
            text.VerticalAlignment = VerticalAlignment.Center;
            text.FontFamily = new FontFamily("Arial");
            text.FontSize = 25;
            switch (color)
            {
                case "White":
                    text.Foreground = Brushes.White;
                    break;
                case "Black":
                    text.Foreground = Brushes.Black;
                    break;
                default:
                    break;
            }

            switch (coordX + coordY)
            {
                case "A1":
                    A1.Child = text;
                    break;
                case "A2":
                    A2.Child = text;
                    break;
                case "A3":
                    A3.Child = text;
                    break;
                case "A4":
                    A4.Child = text;
                    break;
                case "A5":
                    A5.Child = text;
                    break;
                case "A6":
                    A6.Child = text;
                    break;
                case "A7":
                    A7.Child = text;
                    break;
                case "A8":
                    A8.Child = text;
                    break;
                case "B1":
                    B1.Child = text;
                    break;
                case "B2":
                    B2.Child = text;
                    break;
                case "B3":
                    B3.Child = text;
                    break;
                case "B4":
                    B4.Child = text;
                    break;
                case "B5":
                    B5.Child = text;
                    break;
                case "B6":
                    B6.Child = text;
                    break;
                case "B7":
                    B7.Child = text;
                    break;
                case "B8":
                    B8.Child = text;
                    break;
                case "C1":
                    C1.Child = text;
                    break;
                case "C2":
                    C2.Child = text;
                    break;
                case "C3":
                    C3.Child = text;
                    break;
                case "C4":
                    C4.Child = text;
                    break;
                case "C5":
                    C5.Child = text;
                    break;
                case "C6":
                    C6.Child = text;
                    break;
                case "C7":
                    C7.Child = text;
                    break;
                case "C8":
                    C8.Child = text;
                    break;
                case "D1":
                    D1.Child = text;
                    break;
                case "D2":
                    D2.Child = text;
                    break;
                case "D3":
                    D3.Child = text;
                    break;
                case "D4":
                    D4.Child = text;
                    break;
                case "D5":
                    D5.Child = text;
                    break;
                case "D6":
                    D6.Child = text;
                    break;
                case "D7":
                    D7.Child = text;
                    break;
                case "D8":
                    D8.Child = text;
                    break;
                case "E1":
                    E1.Child = text;
                    break;
                case "E2":
                    E2.Child = text;
                    break;
                case "E3":
                    E3.Child = text;
                    break;
                case "E4":
                    E4.Child = text;
                    break;
                case "E5":
                    E5.Child = text;
                    break;
                case "E6":
                    E6.Child = text;
                    break;
                case "E7":
                    E7.Child = text;
                    break;
                case "E8":
                    E8.Child = text;
                    break;
                case "F1":
                    F1.Child = text;
                    break;
                case "F2":
                    F2.Child = text;
                    break;
                case "F3":
                    F3.Child = text;
                    break;
                case "F4":
                    F4.Child = text;
                    break;
                case "F5":
                    F5.Child = text;
                    break;
                case "F6":
                    F6.Child = text;
                    break;
                case "F7":
                    F7.Child = text;
                    break;
                case "F8":
                    F8.Child = text;
                    break;
                case "G1":
                    G1.Child = text;
                    break;
                case "G2":
                    G2.Child = text;
                    break;
                case "G3":
                    G3.Child = text;
                    break;
                case "G4":
                    G4.Child = text;
                    break;
                case "G5":
                    G5.Child = text;
                    break;
                case "G6":
                    G6.Child = text;
                    break;
                case "G7":
                    G7.Child = text;
                    break;
                case "G8":
                    G8.Child = text;
                    break;
                case "H1":
                    H1.Child = text;
                    break;
                case "H2":
                    H2.Child = text;
                    break;
                case "H3":
                    H3.Child = text;
                    break;
                case "H4":
                    H4.Child = text;
                    break;
                case "H5":
                    H5.Child = text;
                    break;
                case "H6":
                    H6.Child = text;
                    break;
                case "H7":
                    H7.Child = text;
                    break;
                case "H8":
                    H8.Child = text;
                    break;
                default:
                    break;
            }
        }
        private void Start(object sender, RoutedEventArgs e)
        {
            AddFigureInBoard();
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            A1.Child = null;
            A2.Child = null;
            A3.Child = null;
            A4.Child = null;
            A5.Child = null;
            A6.Child = null;
            A7.Child = null;
            A8.Child = null;
            B1.Child = null;
            B2.Child = null;
            B3.Child = null;
            B4.Child = null;
            B5.Child = null;
            B6.Child = null;
            B7.Child = null;
            B8.Child = null;
            C1.Child = null;
            C2.Child = null;
            C3.Child = null;
            C4.Child = null;
            C5.Child = null;
            C6.Child = null;
            C7.Child = null;
            C8.Child = null;
            D1.Child = null;
            D2.Child = null;
            D3.Child = null;
            D4.Child = null;
            D5.Child = null;
            D6.Child = null;
            D7.Child = null;
            D8.Child = null;
            E1.Child = null;
            E2.Child = null;
            E3.Child = null;
            E4.Child = null;
            E5.Child = null;
            E6.Child = null;
            E7.Child = null;
            E8.Child = null;
            F1.Child = null;
            F2.Child = null;
            F3.Child = null;
            F4.Child = null;
            F5.Child = null;
            F6.Child = null;
            F7.Child = null;
            F8.Child = null;
            G1.Child = null;
            G2.Child = null;
            G3.Child = null;
            G4.Child = null;
            G5.Child = null;
            G6.Child = null;
            G7.Child = null;
            G8.Child = null;
            H1.Child = null;
            H2.Child = null;
            H3.Child = null;
            H4.Child = null;
            H5.Child = null;
            H6.Child = null;
            H7.Child = null;
            H8.Child = null;
            TextCoord.Text = null;
        }
    }
}