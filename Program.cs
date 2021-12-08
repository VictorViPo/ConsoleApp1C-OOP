using System;

namespace ConsoleApp2_OOP_C5
{
    internal class RationalNumber
    {
        private int numerator;    // Числитель
        private int denominator;  // Знаменатель

        // конструктор
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new DivideByZeroException("В знаменателе не может быть нуля");
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // Вызов первого конструктора 
        public RationalNumber(int number)
            : this(number, 1)
        { }

        // Перегрузка оператора для двух дробей
        public static bool operator ==(RationalNumber a, RationalNumber b)
        {
            Object aAsObj = a as Object;
            Object bAsObj = b as Object;
            if (aAsObj == null || bAsObj == null)
            {
                return aAsObj == bAsObj;
            }
            return a.Equals(b);
        }

        // Перегрузка оператора для дроби и числа
        public static bool operator ==(RationalNumber a, int b)
        {
            return a == new RationalNumber(b);
        }

        // Перегрузка оператора для числа и дроби
        public static bool operator ==(int a, RationalNumber b)
        {
            return new RationalNumber(a) == b;
        }

        // Перегрузка оператора для двух дробей
        public static bool operator !=(RationalNumber a, RationalNumber b)
        {
            return !(a == b);
        }

        // Перегрузка оператора для дроби и числа
        public static bool operator !=(RationalNumber a, int b)
        {
            return a != new RationalNumber(b);
        }

        // Перегрузка оператора для числа и дроби
        public static bool operator !=(int a, RationalNumber b)
        {
            return new RationalNumber(a) != b;
        }
        // Возвращает наибольший общий делитель
        private static int getGreatestCommonDivisor(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        // Возвращает сокращенную дробь
        public RationalNumber Reduce()
        {
            RationalNumber result = this;
            int greatestCommonDivisor = getGreatestCommonDivisor(numerator, denominator);
            result.numerator /= greatestCommonDivisor;
            result.denominator /= greatestCommonDivisor;
            return result;
        }

        // Метод сравнения двух дробей
        private int CompareTo(RationalNumber that)
        {
            if (Equals(that))
            {
                return 0;
            }
            RationalNumber a = this.Reduce();
            RationalNumber b = that.Reduce();
            if (a.numerator * b.denominator > b.numerator * a.denominator)
            {
                return 1;
            }
            return -1;
        }

        // Перегрузка оператора ">" для двух дробей
        public static bool operator >(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) > 0;
        }
        // Перегрузка оператора ">" для дроби и числа
        public static bool operator >(RationalNumber a, int b)
        {
            return a > new RationalNumber(b);
        }
        // Перегрузка оператора ">" для числа и дроби
        public static bool operator >(int a, RationalNumber b)
        {
            return new RationalNumber(a) > b;
        }
        // Перегрузка оператора "<" для двух дробей
        public static bool operator <(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) < 0;
        }
        // Перегрузка оператора "<" для дроби и числа
        public static bool operator <(RationalNumber a, int b)
        {
            return a < new RationalNumber(b);
        }
        // Перегрузка оператора "<" для числа и дроби
        public static bool operator <(int a, RationalNumber b)
        {
            return new RationalNumber(a) < b;
        }
        // Перегрузка оператора ">=" для двух дробей
        public static bool operator >=(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) >= 0;
        }
        // Перегрузка оператора ">=" для дроби и числа
        public static bool operator >=(RationalNumber a, int b)
        {
            return a >= new RationalNumber(b);
        }
        // Перегрузка оператора ">=" для числа и дроби
        public static bool operator >=(int a, RationalNumber b)
        {
            return new RationalNumber(a) >= b;
        }
        // Перегрузка оператора "<=" для двух дробей
        public static bool operator <=(RationalNumber a, RationalNumber b)
        {
            return a.CompareTo(b) <= 0;
        }
        // Перегрузка оператора "<=" для дроби и числа
        public static bool operator <=(RationalNumber a, int b)
        {
            return a <= new RationalNumber(b);
        }
        // Перегрузка оператора "<=" для числа и дроби
        public static bool operator <=(int a, RationalNumber b)
        {
            return new RationalNumber(a) <= b;
        }
    }
}
