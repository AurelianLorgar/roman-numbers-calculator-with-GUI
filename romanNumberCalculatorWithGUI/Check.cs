// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++, C#, and Java: http://www.viva64.com

namespace romanNumberCalculatorWithGUI {
    class Check {

        public static bool checkDoubleSigns(string numbers) {

            bool result = false;
            bool resultMiddle = false;
            char[] arrayOfNumbersChar = numbers.ToCharArray();
            char[] mathSignsChar = { '+', '-', '*', '/' };

            for (int i = 1; i < arrayOfNumbersChar.Length; i++) {
                for (int j = 0; j < mathSignsChar.Length; j++) {
                    if ((arrayOfNumbersChar[i - 1].Equals(mathSignsChar[j]))) {
                        resultMiddle = true;
                    }
                    if (resultMiddle) {
                        if ((arrayOfNumbersChar[i].Equals(mathSignsChar[j]))) {
                            return result = true;
                        } else {
                            resultMiddle = false;
                        }
                    } 
                }     
            }
            return result;
        }

        public static bool checkTransfer(string numbers) {
            char[] arrayOfMathChar = { 'M', 'D', 'C', 'L', 'X', 'V', 'I', '+', '-', '*', '/' };
            char[] arrayOfMath = numbers.ToCharArray();
            byte errTest = 0;
            byte err = 0;
            bool result = false;

            for (int i = 0; i < arrayOfMath.Length; i++) {
                for (int j = 0; j < arrayOfMathChar.Length; j++) {
                    if (arrayOfMathChar[j] != arrayOfMath[i]) {
                        errTest++;
                    }
                }
                if (errTest != 11) {
                    errTest = 0;
                } else {
                    err++;
                }
            }

            if (err > 0) {
                return result = true;
            } else {
                return result;
            }
        }
    }
}