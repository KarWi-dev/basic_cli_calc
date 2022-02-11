using System;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.Intrinsics.X86;
namespace Calculator0._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double Zahl1, Zahl2, Result = 0;            
            char End;  //prüft ob user neue rechnung will
            string Operator;
            int Bla; //prüft ob ergebniss ausgegeben werden muss
            do  //loopdiloop startet hier
            {
                Bla = 1;     //muss hier(!!!) auf 1 stehen
                Console.Write("First number please:");
                Zahl1 = Convert.ToDouble(Console.ReadLine()); //einlesen zahl1 als double
                Console.Write("\nOperator please:\n+,-,*,/,!\nsqrt, sin, cos, tan\n%% for Modulo\n% for percent (x% of n):"); 
                Operator = Console.ReadLine();  //einlesen operator
                if (Operator == "sqrt" || Operator == "!" || Operator == "sin" || Operator == "cos" || Operator == "tan") 
                { //testet auf operationen die nur eine zahl brauchen
                    switch (Operator)
                    {
                        case "sqrt":
                            Result = Math.Sqrt(Zahl1);//errechnung der quadratwurzel
                            break;
                        case "!":
                            Zahl2 = Zahl1; //fakultät wird errechnet
                            for (double i = Zahl1 - 1; i > 0; i--)
                            {
                            Zahl2 *= i;
                            }
                            Result = Zahl2;
                            break;//bringt switch zum halten und macht danach weiter
                        case "sin":
                            Result = Math.Sin(Zahl1);//sin, cos, tan können hier berechnet werden
                            break;
                        case "cos":
                            Result = Math.Cos(Zahl1);
                            break;
                        case "tan":
                            Result = Math.Tan(Zahl1);
                            break;
                    }                           
                }                
                else
                {
                    Console.Write("\nSecond number please:");
                    Zahl2 = Convert.ToDouble(Console.ReadLine());//einlesen Zahl2 als double                    
                    if (Operator == "/" && Zahl2 == 0)//testet auf NullDivision
                    {
                            Console.WriteLine("\nZeroDevision!! Try Again!\n");
                            Bla = 0;//"bla = 0 also wird kein ergebniss ausgegeben
                    }
                    switch (Operator)//vergleicht "Operator" mit den cases und führt das entsprechende aus
                    {
                        case "+":
                            Result = Zahl1 + Zahl2;
                            break;  
                        case "-":
                            Result = Zahl1 - Zahl2;
                            break;
                        case "*":
                            Result = Zahl1 * Zahl2;
                            break;
                        case "/":
                            Result = Zahl1 / Zahl2;
                            break;
                        case "%%":
                            Result = Zahl1 % Zahl2;
                            break;
                        case "%":
                            Result = (Zahl2 / 100) * Zahl1;
                            break;
                        default:  //wenn kein passender operator eingegeben wurde
                            Console.WriteLine("\n***Please use one of the allowed operators***\n");
                            Bla = 0;
                            break;
                    }                    
                }
                if (Bla == 1) //fragt ab ob bla = 1 oder 0 um zu bestimmen ob "Result" augegeben werden muss
                {
                    Console.WriteLine($"--------------------------\nYour result is {Result}!\n");  //gibt das ergebnis aus
                }               
                Console.Write("Again?\t\ty/Y = yes\tAny other = no\n...:");
                End = Convert.ToChar(Console.ReadLine());       //einlesen "End" als char
                End = (End == 'Y') ? End = 'y' : End = End;      // stellt sicher das auch GROSS Y geht / ohne End = End gehts net???
                Console.WriteLine("----------------------------------------------\n\n");
            }
            while (End == 'y');    //loop wird wiederholt solange End = y       
        }
    }
}