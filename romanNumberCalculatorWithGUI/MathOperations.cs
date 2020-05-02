// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

using System;
using System.Data;
using System.Windows;
using RomanCalculator;

namespace romanNumberCalculatorWithGUI {
    class MathOperations {

        Check check = new Check();
        RomanToArabic romanToArabic = new RomanToArabic();
        ArabicToRoman arabicToRoman = new ArabicToRoman();

        public string GetSolution(string numbers) {

            string[] mathSignsString = { "+", "-", "*", "/" };
            string[] numbersRomanArray = { "" };

            string solutionString;

            int solutionInt = 0;

            char delimiter = '@';

            if (Check.CheckDoubleSigns(numbers).Equals(true) || Check.CheckTransfer(numbers.ToCharArray()).Equals(true)) {
                MessageBox.Show("Проверьте введённый пример на правильность записи", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return solutionString = "";
            }

            for (int i = 0; i < mathSignsString.Length; i++) {
                numbers = numbers.Replace(mathSignsString[i], delimiter + mathSignsString[i] + delimiter);
            }

            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i].Equals(delimiter)) {
                    numbersRomanArray = numbers.Split(delimiter);
                    break;
                }
            }

            string[] numbersArabicArray = new string[numbersRomanArray.Length];

            for (int i = 0; i < numbersRomanArray.Length; i++) {
                bool check = true;
                for (int j = 0; j < mathSignsString.Length; j++) {
                    if (numbersRomanArray[i].Equals(mathSignsString[j])) {
                        numbersArabicArray[i] = numbersRomanArray[i];
                        check = false;
                        break;
                    }
                }
                if (check) {
                    numbersArabicArray[i] = (romanToArabic.Transfer(numbersRomanArray[i].ToCharArray())).ToString();
                }     
            }

            numbers = string.Join(null, numbersArabicArray);

            if (Check.CheckDoubleSigns(numbers).Equals(true)) {
                MessageBox.Show("Проверьте введённый пример на правильность записи", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
                return solutionString = "";
            }

            try {
                var solution = new DataTable().Compute(numbers, null);
                double solutionDouble = Convert.ToDouble(solution.ToString());
                solutionInt = Convert.ToInt32(Math.Round(solutionDouble, 0));
            }
            catch (Exception e) {
                MessageBox.Show(e.Message, "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return solutionString = "";
            }

            solutionString = arabicToRoman.Transfer(solutionInt);

            return solutionString;
        }
    }
}