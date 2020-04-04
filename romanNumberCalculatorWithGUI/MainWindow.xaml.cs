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
            textBoxMath.Text += "V";
            ClickOnButton.addToMath("V");
        }

        private void buttonX_Click(object sender, RoutedEventArgs e) {
            textBoxMath.Text += "X";
            ClickOnButton.addToMath("X");
        }

        private void buttonL_Click(object sender, RoutedEventArgs e) {
            textBoxMath.Text += "L";
            ClickOnButton.addToMath("L");
        }

        private void buttonC_Click(object sender, RoutedEventArgs e) {
            textBoxMath.Text += "C";
            ClickOnButton.addToMath("C");
        }

        private void buttonD_Click(object sender, RoutedEventArgs e) {
            textBoxMath.Text += "D";
            ClickOnButton.addToMath("D");
        }

        private void buttonM_Click(object sender, RoutedEventArgs e) {
            textBoxMath.Text += "M";
            ClickOnButton.addToMath("M");
        }

        private void buttonPlus_Click(object sender, RoutedEventArgs e) {
            textBoxMath.Text += "+";
            ClickOnButton.addToMath("+");
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e) {
            textBoxMath.Text += "-";
            ClickOnButton.addToMath("-");
        }

        private void buttonMultiply_Click(object sender, RoutedEventArgs e) {
            textBoxMath.Text += "*";
            ClickOnButton.addToMath("*");
        }

        private void buttonDivide_Click(object sender, RoutedEventArgs e) {
            textBoxMath.Text += "/";
            ClickOnButton.addToMath("/");
        }

        private void buttonSolution_Click(object sender, RoutedEventArgs e) {

        }

        private void buttonDeleteOne_Click(object sender, RoutedEventArgs e) {
            if (ClickOnButton.deleteFromMath("<-").Equals(true)) {
                if (textBoxMath.Text.Length > 0) {
                    textBoxMath.Text = textBoxMath.Text.Substring(0, (textBoxMath.Text.Length - 1));
                    return;
                }
            }
        }

        private void buttonDeleteAll_Click(object sender, RoutedEventArgs e) {
            if (ClickOnButton.deleteFromMath("Del").Equals(true)) {
                if (textBoxMath.Text.Length > 0) {
                    textBoxMath.Text = textBoxMath.Text.Remove(0, textBoxMath.Text.Length);
                }
            }
        }
    }
}
