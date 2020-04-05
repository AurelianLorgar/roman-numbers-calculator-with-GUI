// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System.Windows;

namespace romanNumberCalculatorWithGUI {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void buttonI_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("I");
            ClickOnButton.addToMath("I");
        }

        private void buttonV_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("V");
            ClickOnButton.addToMath("V");
        }

        private void buttonX_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("X");
            ClickOnButton.addToMath("X");
        }

        private void buttonL_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("L");
            ClickOnButton.addToMath("L");
        }

        private void buttonC_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("C");
            ClickOnButton.addToMath("C");
        }

        private void buttonD_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("D");
            ClickOnButton.addToMath("D");
        }

        private void buttonM_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("M");
            ClickOnButton.addToMath("M");
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("+");
            ClickOnButton.addToMath("+");
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("-");
            ClickOnButton.addToMath("-");
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("*");
            ClickOnButton.addToMath("*");
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e) {
            textBoxMath.AppendText("/");
            ClickOnButton.addToMath("/");
        }

        private void buttonSolution_Click(object sender, RoutedEventArgs e) {

            ClickOnButton clickOnButton = new ClickOnButton();
            string numbers = ClickOnButton.numbers.ToString().ToUpper();
            string numbersTextBox = textBoxMath.Text.ToUpper();

            if (!numbersTextBox.Equals(numbers)) {
                numbers = numbersTextBox;
            }

            textBoxSolution.AppendText(MathOperations.getSolution(numbers));
        }

        private void buttonDeleteOne_Click(object sender, RoutedEventArgs e) {
            if (ClickOnButton.deleteFromMath("<-").Equals(true)) {
                if (textBoxMath.Text.Length > 0) {
                    textBoxMath.Text = textBoxMath.Text.Substring(0, (textBoxMath.Text.Length - 1));
                }
            }
        }

        private void buttonDeleteAll_Click(object sender, RoutedEventArgs e) {
            if (ClickOnButton.deleteFromMath("Del").Equals(true)) {
                if (textBoxMath.Text.Length > 0) {
                    textBoxMath.Text = textBoxMath.Text.Remove(0, textBoxMath.Text.Length);
                }
                if (textBoxSolution.Text.Length > 0) {
                    textBoxSolution.Text = textBoxSolution.Text.Remove(0, textBoxSolution.Text.Length);
                }
            }
        }
    }
}