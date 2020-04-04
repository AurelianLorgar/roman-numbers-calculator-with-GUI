using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace romanNumberCalculatorWithGUI {
    class ClickOnButton {

        MainWindow mainWindow = new MainWindow();

        static StringBuilder numbers = new StringBuilder("");

        public static void addToMath(string number) {
            numbers.Append(number);
            //TODO: удалить
            System.Diagnostics.Debug.WriteLine(numbers.ToString());
        }

        public static bool deleteFromMath(string sign) {
            bool result = false;

            if (numbers.Length != 0) {
                if (sign.Equals("<-")) {
                    numbers.Remove(numbers.Length - 1, 1);
                    System.Diagnostics.Debug.WriteLine(numbers.ToString());
                    return result = true;
                } else if (sign.Equals("Del")) {
                    numbers.Clear();
                    System.Diagnostics.Debug.WriteLine(numbers.ToString());
                    return result = true;
                }
            }

            return result;
        }
    }
}
