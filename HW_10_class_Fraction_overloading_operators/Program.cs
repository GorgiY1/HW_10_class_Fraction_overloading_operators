using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_10_class_Fraction_overloading_operators
{
    class Fraction
    {
        public double numerator { get; set; }
        public double denominator { get; set; }
        public Fraction()
        {
            this.numerator = 1;
            this.denominator = 1;
        }
        public Fraction(double numerator, double denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        public static Fraction operator+(Fraction f1, Fraction f2)
        {
            if (f1.denominator == 0 || f2.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            if (f1.denominator == f2.denominator)
            {
                return new Fraction { numerator = f1.numerator + f2.numerator, denominator = f1.denominator};
            }
            else if(f1.denominator > 1 && f2.denominator > 1)
            {
                bool compareComplete = false;
                if (f1.denominator % f2.denominator == 0)
                {
                    double factorDenom = 0;
                    factorDenom = f1.denominator / f2.denominator;
                    return new Fraction { numerator = f1.numerator + (f2.numerator* factorDenom), denominator = (f2.denominator * factorDenom) };
                }
                if (f2.denominator % f1.denominator == 0)
                {
                    double factorDenom = 0;
                    factorDenom = f2.denominator / f1.denominator;
                    return new Fraction { numerator = f2.numerator + (f1.numerator * factorDenom), denominator = (f1.denominator * factorDenom) };

                }

                if (compareComplete == false)
                {
                    double factorDenom = 0;
                    factorDenom = f2.denominator * f1.denominator;
                    return new Fraction { numerator = (f1.numerator * (factorDenom/f1.denominator)) + (f2.numerator * (factorDenom / f2.denominator)), denominator = factorDenom };

                }
            }
            else
            {
                if (f1.denominator == 1 && f2.denominator > 1)
                {
                    return new Fraction { numerator = (f1.numerator* f2.denominator) + f2.numerator, denominator = f2.denominator };
                }
                if (f2.denominator == 1 && f1.denominator > 1)
                {
                    return new Fraction { numerator = f1.numerator + (f2.numerator * f1.denominator), denominator = f1.denominator };
                }
            }
            return new Fraction();
        }
        public static Fraction operator +(Fraction f1, double d)
        {
            Fraction f2 = new Fraction(d, 1);
            if (f1.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            if (f1.denominator == f2.denominator)
            {
                return new Fraction { numerator = f1.numerator + f2.numerator, denominator = f1.denominator };
            }
            else if (f1.denominator > 1 && f2.denominator > 1)
            {
                bool compareComplete = false;
                if (f1.denominator % f2.denominator == 0)
                {
                    double factorDenom = 0;
                    factorDenom = f1.denominator / f2.denominator;
                    return new Fraction { numerator = f1.numerator + (f2.numerator * factorDenom), denominator = (f2.denominator * factorDenom) };
                }
                if (f2.denominator % f1.denominator == 0)
                {
                    double factorDenom = 0;
                    factorDenom = f2.denominator / f1.denominator;
                    return new Fraction { numerator = f2.numerator + (f1.numerator * factorDenom), denominator = (f1.denominator * factorDenom) };

                }

                if (compareComplete == false)
                {
                    double factorDenom = 0;
                    factorDenom = f2.denominator * f1.denominator;
                    return new Fraction { numerator = (f1.numerator * (factorDenom / f1.denominator)) + (f2.numerator * (factorDenom / f2.denominator)), denominator = factorDenom };

                }
            }
            else
            {
                if (f1.denominator == 1 && f2.denominator > 1)
                {
                    return new Fraction { numerator = (f1.numerator * f2.denominator) + f2.numerator, denominator = f2.denominator };
                }
                if (f2.denominator == 1 && f1.denominator > 1)
                {
                    return new Fraction { numerator = f1.numerator + (f2.numerator * f1.denominator), denominator = f1.denominator };
                }
            }
            return new Fraction();
        }
        public static Fraction operator-(Fraction f1, Fraction f2)
        {
            if (f1.denominator == 0 || f2.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            if (f1.denominator == f2.denominator)
            {
                if (f1.numerator == f2.numerator)
                {
                    return new Fraction { numerator = 0, denominator = 1 };
                }
                return new Fraction { numerator = f1.numerator - f2.numerator, denominator = f1.denominator };
            }
            else if (f1.denominator > 1 && f2.denominator > 1)
            {
                bool compareComplete = false;
                if (f1.denominator % f2.denominator == 0)
                {
                    double factorDenom = 0;
                    factorDenom = f1.denominator / f2.denominator;
                    return new Fraction { numerator = f1.numerator - (f2.numerator * factorDenom), denominator = (f2.denominator * factorDenom) };
                }
                if (f2.denominator % f1.denominator == 0)
                {
                    double factorDenom = 0;
                    factorDenom = f2.denominator / f1.denominator;
                    return new Fraction { numerator = f2.numerator - (f1.numerator * factorDenom), denominator = (f1.denominator * factorDenom) };

                }

                if (compareComplete == false)
                {
                    double factorDenom = 0;
                    factorDenom = f2.denominator * f1.denominator;
                    return new Fraction { numerator = (f1.numerator * (factorDenom / f1.denominator)) - (f2.numerator * (factorDenom / f2.denominator)), denominator = factorDenom };

                }
            }
            else
            {
                if (f1.denominator == 1 && f2.denominator > 1)
                {
                    return new Fraction { numerator = (f1.numerator * f2.denominator) - f2.numerator, denominator = f2.denominator };
                }
                if (f2.denominator == 1 && f1.denominator > 1)
                {
                    return new Fraction { numerator = f1.numerator - (f2.numerator * f1.denominator), denominator = f1.denominator };
                }
            }
            return new Fraction();
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            if (f1.denominator == 0 || f2.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            return new Fraction { numerator = f1.numerator * f2.numerator, denominator = f1.denominator * f2.denominator };
        }
        public static Fraction operator *(Fraction f1, int n)
        {
            if (f1.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            return new Fraction{ numerator = f1.numerator *n, denominator = f1.denominator};
        }
        public static Fraction operator *(int n, Fraction f1)
        {
            if (f1.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            return new Fraction { numerator = f1.numerator * n, denominator = f1.denominator};
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f1.denominator == 0 || f2.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            return new Fraction { numerator = f1.numerator * f2.denominator, denominator = f1.denominator * f2.numerator };
        }

        // overloading Equals() method, GetHeshCode()  and == != < > 
        public override bool Equals(object obj)
        {
            return this.ToString() == obj.ToString();
        }
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
        public static bool operator == (Fraction f1, Fraction f2)
        {
            if (f1.denominator == 0 || f2.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            if (f1.numerator/f1.denominator == f2.numerator / f2.denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return !(f1 == f2);
        }
        public static bool operator >(Fraction f1, Fraction f2)
        {
            if (f1.denominator == 0 || f2.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            if (f1.numerator / f1.denominator > f2.numerator / f2.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            if (f1.denominator == 0 || f2.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            if (f1.numerator / f1.denominator < f2.numerator / f2.denominator)
            {
                return true;
            }
            return false;
            
        }

        public static bool operator true(Fraction f)
        {
            if (f.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            if (f.numerator < f.denominator)
            {
                return true;
            }
            return false;
        }
        public static bool operator false(Fraction f)
        {
            if (f.denominator == 0)
            {
                throw new DivideByZeroException("Divide By Zero Exception!");
            }
            if (f.numerator > f.denominator)
            {
                return true;
            }
            return false;
            
        }
        public override string ToString()
        {
            return $"{numerator}\n-- = {numerator/ denominator}\n{denominator}\n";
        }
    }

    class Program
    {
        public static string ShowFraction(string oper, Fraction f1, Fraction f2, Fraction res)
        {
            return $"{f1.numerator}      {f2.numerator}      {res.numerator}   \n--  {oper}  --  =  --  =  {res.numerator/res.denominator}\n{f1.denominator}      {f2.denominator}      {res.denominator} \n";
        }
        public static string ShowFraction(string oper, Fraction f1, Fraction f2, bool res)
        {
            return $"{f1.numerator}       {f2.numerator}      \n--  {oper}  --  =  {res}\n{f1.denominator}       {f2.denominator}      \n";
        }
        public static string ShowFraction(string oper, Fraction f1)
        {
            return $"{f1.numerator}       \n--  {oper}  \n{f1.denominator}       \n";
        }
        static void Main(string[] args)
        {
            /*Разработать класс Fraction, представляющий простую дробь. 
            В классе предусмотреть два поля: числитель и знаменатель дроби.
            Выполнить перегрузку следующих операторов: +,-,*,/,==,!=,<,>, true и false.w
          Арифметические действия и сравнение выполняется в соответствии с правилами работы с дробями. 
          Оператор true возвращает true если дробь правильная (числитель меньше знаменателя), 
          оператор false возвращает true если дробь неправильная (числитель больше знаменателя).
          Выполнить перегрузку операторов, необходимых для успешной компиляции следующего фрагмента кода:

                  Fraction f = new Fraction(3, 4);
                  int a = 10;
                  Fraction f1 = f * a;
                  Fraction f2 = a * f;
                  double d = 1.5;
                  Fraction f3 = f + d;

          Develop a Fraction class that represents a simple fraction.
          Provide two fields in the class: the numerator and denominator of the fraction.
          Overload the following operators: +,-,*,/,==,!=,<,>, true and false.w
          Arithmetic operations and comparison are performed in accordance with the rules for working with fractions.
          The true operator returns true if the fraction is correct (the numerator is less than the denominator),
          false operator returns true if the fraction is not correct (the numerator is greater than the denominator).
          Overload the operators necessary to successfully compile the following code snippet:*/

            Fraction fr = new Fraction(3, 4);
            int a = 10;
            Fraction fr1 = fr * a;
            Fraction temp = new Fraction(a, 1);

            Console.WriteLine(ShowFraction("*", fr, temp, fr1));
           
            Fraction fr2 = a * fr;

            Console.WriteLine(ShowFraction("*", temp, fr, fr2));

            double d = 1.5;
            Fraction fr3 = fr + d;
            Fraction temp1 = new Fraction(d, 1); // for show function

            Console.WriteLine(ShowFraction("+", fr, temp1, fr3));

            Random random = new Random();
            
            int menu = 0;
           
            do
            {
                Console.WriteLine("\n=====================================================");
                Console.WriteLine($"\n   Select an operation: ");
                Console.WriteLine($"1. The Operation +, Fraction 1 + Fraction 2: ");
                Console.WriteLine($"2. The Operation -, Fraction 1 - Fraction 2: ");
                Console.WriteLine($"3. The Operation *, Fraction 1 * Fraction 2: ");
                Console.WriteLine($"4. The Operation /, Fraction 1 / Fraction 2: ");
                Console.WriteLine($"5. The Operation ==, Fraction 1 == Fraction 2: ");
                Console.WriteLine($"6. The Operation !=, Fraction 1 != Fraction 2: ");
                Console.WriteLine($"7. The Operation <, Fraction 1 < Fraction 2: ");
                Console.WriteLine($"8. The Operation >, Fraction 1 > Fraction 2: ");
                Console.WriteLine($"9. The Operation true, Fraction is true or false: ");
                Console.WriteLine($"10. The Operation false, Fraction is false or true: ");

                Console.WriteLine($"0. Exit: ");
                Console.WriteLine("=======================================================\n");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:

                        do
                        {
                            try
                            {
                                Fraction res = new Fraction(), f1 = new Fraction(random.Next(0, 5), random.Next(0, 5)), f2 = new Fraction(random.Next(0, 5), random.Next(0, 5));
                          
                                res = f1 + f2;
                                Console.WriteLine(ShowFraction("+", f1, f2, res));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "");

                        break;

                    case 2:

                        do
                        {
                            try
                            {
                                Fraction res = new Fraction(), f1 = new Fraction(random.Next(0, 5), random.Next(0, 5)), f2 = new Fraction(random.Next(0, 5), random.Next(0, 5));
                                
                                res = f1 - f2;
                                Console.WriteLine(ShowFraction("-", f1, f2, res));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "") ;
                            break;

                    case 3:

                        do
                        {
                            try
                            {
                                Fraction res = new Fraction(), f1 = new Fraction(random.Next(0, 5), random.Next(0, 5)), f2 = new Fraction(random.Next(0, 5), random.Next(0, 5));

                                res = f1 * f2;
                                Console.WriteLine(ShowFraction("*", f1, f2, res));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "");
                        break;

                    case 4:

                        do
                        {
                            try
                            {
                                Fraction res = new Fraction(), f1 = new Fraction(random.Next(0, 5), random.Next(0, 5)), f2 = new Fraction(random.Next(0, 5), random.Next(0, 5));

                                res = f1 / f2;
                                Console.WriteLine(ShowFraction(":", f1, f2, res));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "");
                        break;

                    case 5:

                        do
                        {
                            try
                            {
                                Fraction f1 = new Fraction(random.Next(0, 5), random.Next(0, 5)), f2 = new Fraction(random.Next(0, 5), random.Next(0, 5));

                                Console.WriteLine(ShowFraction("==", f1, f2, f1 == f2));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "");
                        break;

                    case 6:

                        do
                        {
                            try
                            {
                                Fraction f1 = new Fraction(random.Next(0, 5), random.Next(0, 5)), f2 = new Fraction(random.Next(0, 5), random.Next(0, 5));

                                Console.WriteLine(ShowFraction("!=", f1, f2, f1 != f2));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "");
                        break;

                    case 7:

                        do
                        {
                            try
                            {
                                Fraction f1 = new Fraction(random.Next(0, 5), random.Next(0, 5)), f2 = new Fraction(random.Next(0, 5), random.Next(0, 5));

                                Console.WriteLine(ShowFraction(">", f1, f2, f1 > f2));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "");
                        break;

                    case 8:

                        do
                        {
                            try
                            {
                                Fraction f1 = new Fraction(random.Next(0, 5), random.Next(0, 5)), f2 = new Fraction(random.Next(0, 5), random.Next(0, 5));

                                Console.WriteLine(ShowFraction("<", f1, f2, f1 < f2));
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "");
                        break;
                    case 9:

                        do
                        {
                            try
                            {
                                Fraction f1 = new Fraction(random.Next(0, 5), random.Next(0, 5));
                                Console.WriteLine("operator true: ");
                                if (f1)
                                {
                                    Console.WriteLine(ShowFraction("= true", f1));
                                }
                                else
                                {
                                    Console.WriteLine(ShowFraction("= false", f1));
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "");
                        break;

                    case 10:

                        do
                        {
                            try
                            {
                                Fraction f1 = new Fraction(random.Next(0, 5), random.Next(0, 5));
                                Console.WriteLine("operator false: ");
                                if (f1)
                                {
                                    Console.WriteLine(ShowFraction("= false", f1));
                                }
                                else
                                {
                                    Console.WriteLine(ShowFraction("= true", f1));
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            Console.WriteLine("Go To continue generating fractions, press the Enter key, in the Go menu, input something");

                        } while (Console.ReadLine() == "");
                        break;
                    default:
                        break;
                }

            } while (menu != 0);



            Console.ReadKey();
        }
    }
}
