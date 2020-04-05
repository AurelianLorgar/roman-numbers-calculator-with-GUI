// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System.Text;

namespace romanNumberCalculatorWithGUI {
    class ClickOnButton {

        MainWindow mainWindow = new MainWindow();

        public static StringBuilder numbers = new StringBuilder("");

        public static void addToMath(string number) {
            numbers.Append(number);
        }

        public static bool deleteFromMath(string sign) {
            bool result = false;

            if (numbers.Length != 0) {
                if (sign.Equals("<-")) {
                    numbers.Remove(numbers.Length - 1, 1);
                    return result = true;
                } else if (sign.Equals("Del")) {
                    numbers.Clear();
                    return result = true;
                }
            }

            return result;
        }
    }
}
