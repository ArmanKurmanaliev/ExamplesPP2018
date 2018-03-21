using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CalcBase2
{
    class Calc
    {
        public enum OPERATION
        {
            NONE,
            NUMBER,
            PLUS,
            MINUS,
            MULT,
            DIV,
            EQUAL
        }

        OPERATION operation;
        string prevOper;
        int result;
        int prevNumber;

        public Calc()
        {
            operation = OPERATION.NONE;
            result = 0;
            prevOper = "";
            prevNumber = 0;
        }

        public string number_clicked(string textBoxValue, string digit)
        {
            if (operation == OPERATION.NUMBER)
            {
                if (textBoxValue == "0")
                    textBoxValue = "";
                return textBoxValue + digit;
            }
                
            result = int.Parse(textBoxValue);
            operation = OPERATION.NUMBER;
            return digit;
        }

        public string operation_clicked(string textBoxValue, string op)
        {
            prevNumber = int.Parse(textBoxValue);

            string returnValue = textBoxValue;

            if (operation == OPERATION.NUMBER)
                returnValue = equal(textBoxValue);
            if (op == "+")
                operation = OPERATION.PLUS;
            if (op == "-")
                operation = OPERATION.MINUS;
            if (op == "*")
                operation = OPERATION.MULT;
            if (op == "/")
                operation = OPERATION.DIV;
            prevOper = op;
            return returnValue;
        }

        public string equal(string textBoxValue)
        {
            if (operation == OPERATION.NUMBER)
                prevNumber = int.Parse(textBoxValue);
            if (prevOper == "")
            {
                result = int.Parse(textBoxValue);
                return textBoxValue;
            }
            if (prevOper == "-")
                result = result - prevNumber;
            if (prevOper == "+")
                result = result + prevNumber;
            if (prevOper == "*")
                result = result * prevNumber;
            if (prevOper == "/")
                result = result / prevNumber;
            operation = OPERATION.EQUAL;

            return result.ToString();
        }

    }
}
