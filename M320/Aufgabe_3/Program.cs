namespace Aufgabe_3
{
    internal class calculator
    {
        static void Main(string[] args)

        {
            int a;
            int b;
            int ergebnis;
            String eingabe;


            Console.WriteLine("Geben Sie die erste Zahl ein: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie die zweite Zahl ein: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben sie den Operator ein: ");
            eingabe = Convert.ToString(Console.ReadLine());

            if (eingabe == "+")
            {
                ergebnis = a + b;

                Console.WriteLine("Das Ergbenis ist: " + ergebnis);
            }

            else if (eingabe == "-")
            {
                ergebnis = a - b;

                Console.WriteLine("Das Ergbenis ist: " + ergebnis);
            }

            else if (eingabe == "*")
            {


                Console.WriteLine("Das Ergbenis ist: " + a * b);
            }

            else if (eingabe == "/")
            {

                Console.WriteLine("Das Ergbenis ist: " + a / b);
            }
            else
            {
                System.Environment.Exit(0);
            }
        }
    }
}