// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Data;
using System.Text;
using System.Windows;

namespace romanNumberCalculatorWithGUI {
    class MathOperations {

        public static string getSolution(string numbers) {

            bool check = false;

            char[] mathSignsChar = { '+', '-', '*', '/' };
            string[] mathSignsString = { "+", "-", "*", "/" };
            string[] numbersRomanArray = { "" };

            string numbersTemp = null;
            string solutionString;

            int solutionInt = 0;

            char delimiter = '@';

            if (Check.checkDoubleSigns(numbers).Equals(true) || Check.checkTransfer(numbers).Equals(true)) {
                MessageBox.Show("Проверьте введённый пример на правильность записи", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return solutionString = "";
            }

            for (int i = 0; i < numbers.Length; i++) {
                StringBuilder numbersSB = new StringBuilder(numbers);
                for (int j = 0; j < mathSignsChar.Length; j++) {
                    if (numbersSB[i].Equals(mathSignsChar[j])) {
                        string sign = numbersSB[i].ToString();
                        numbersTemp = numbersSB.Replace(sign, delimiter + sign + delimiter).ToString();
                        break;
                    }
                }
            }

            if (numbersTemp == null) {
                numbersTemp = numbers;
            }

            for (int i = 0; i < numbersTemp.Length; i++) {
                if (numbersTemp[i].Equals(delimiter)) {
                    numbersRomanArray = numbersTemp.Split(delimiter);
                    check = true;
                    break;
                }
            }

            if (check == false) {
                numbersRomanArray[0] = numbersTemp;
            }

            string[] numbersArabicArray = new string[numbersRomanArray.Length];

            for (int i = 0; i < numbersRomanArray.Length; i++) {
                check = true;
                for (int j = 0; j < mathSignsString.Length; j++) {
                    if (numbersRomanArray[i].Equals(mathSignsString[j])) {
                        numbersArabicArray[i] = numbersRomanArray[i];
                        check = false;
                        break;
                    }
                }
                if (check) {
                    numbersArabicArray[i] = (RomanToArabic.transfer(numbersRomanArray[i].ToCharArray())).ToString();
                } 
            }

            numbers = string.Join(null, numbersArabicArray);
            try {
                var solution = new DataTable().Compute(numbers, null);
                double solutionDouble = Convert.ToDouble(solution.ToString());
                solutionInt = Convert.ToInt32(Math.Round(solutionDouble, 0));
            } catch (Exception e) {
                MessageBox.Show(e.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return solutionString = "";
            }
            
            solutionString = ArabicToRoman.transfer(solutionInt); //-V3008

            return solutionString;
        }
    }
}