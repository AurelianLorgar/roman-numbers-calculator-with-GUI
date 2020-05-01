// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System.Text;
using System.Windows;

namespace romanNumberCalculatorWithGUI {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        MathOperations mathOperations = new MathOperations();
        StringBuilder number = new StringBuilder("");
        string numbers;

        public MainWindow() {
            InitializeComponent();
        }

        private void buttonI_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("I");
            number.Append("I");
        }

        private void buttonV_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("V");
            number.Append("V");
        }

        private void buttonX_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("X");
            number.Append("X");
        }

        private void buttonL_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("L");
            number.Append("L");
        }

        private void buttonC_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("C");
            number.Append("C");
        }

        private void buttonD_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("D");
            number.Append("D");
        }

        private void buttonM_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("M");
            number.Append("M");
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("+");
            number.Append("+");
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("-");
            number.Append("-");
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("*");
            number.Append("*");
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("/");
            number.Append("/");
        }

        private void buttonSolution_Click(object sender, RoutedEventArgs e) {

            textBoxSolution.Clear();
            numbers = number.ToString().ToUpper();
            string numbersTextBox = textBoxMath.Text.ToUpper();

            if (!numbersTextBox.Equals(numbers)) {
                numbers = numbersTextBox;
            }

            textBoxSolution.AppendText(mathOperations.GetSolution(numbers));
        }

        private void buttonDeleteOne_Click(object sender, RoutedEventArgs e) {

            if (number.Length > 0) {
                number.Remove(number.Length - 1, 1);
                textBoxMath.Clear();
                textBoxMath.AppendText(number.ToString());

                if (numbers != null) {
                    numbers = numbers.Remove(numbers.Length - 1, 1);
                }

            }
        }

        private void buttonDeleteAll_Click(object sender, RoutedEventArgs e) {

            if (number.Length > 0) {
                number.Clear();
                numbers = "";
                textBoxMath.Text = textBoxMath.Text.Remove(0, textBoxMath.Text.Length);
                textBoxSolution.Text = textBoxSolution.Text.Remove(0, textBoxSolution.Text.Length);
            }
        }
    }
}
