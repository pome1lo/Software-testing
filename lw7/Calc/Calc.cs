using System;

namespace Calc
{
    public class Calc
    {

        private double _lastResult;
        private double _num1;
        private double _num2;
        private string _operand;

        public double Calculate(double num1, double num2, string operand)
        {
            _num1 = num1;
            _num2 = num2;
            _operand = operand;

            switch (_operand)
            {
                case "+": return Amount();
                case "-": return Difference();
                case "*": return Multiplication();
                case "/": return Division();
                default: throw new Exception("Ошибка: некорректный оператор.\"");
            }
        }

        public double Calculate(double num1, string operand)
        {
            _num1 = num1;
            _operand = operand;

            switch (_operand)
            {
                case "|": return Module();
                default: throw new Exception("Ошибка: некорректный оператор.\"");
            }
        }

        private double Multiplication()
        {
            var result = _num1 * _num2;
            Console.WriteLine("Результат: " + result);
            _lastResult = result;
            return result;
        }
        private double Division()
        {
            if (_num2 != 0)
            {
                var result = _num1 / _num2;
                Console.WriteLine("Результат: " + result);
                _lastResult = result;
                return result;
            }
            throw new Exception("Ошибка: деление на ноль невозможно.");
        }
        private double Amount()
        {
            var result = _num1 + _num2;
            Console.WriteLine("Результат: " + result);
            _lastResult = result;
            return result;
        }
        private double Difference()
        {
            var result = _num1 - _num2;
            Console.WriteLine("Результат: " + result);
            _lastResult = result;
            return result;
        }

        private double Module()
        {
            if (_num1 < 0)
                return -_num1;
            return _num1;
        }

        public double GetLastReuslt()
        {
            return _lastResult;
        }
    }
}