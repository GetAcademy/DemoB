namespace DemoB
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = MyConsole.Ask("Hva heter du? ");
            Console.WriteLine($"Hei, {name}!");

            int year = MyConsole.AskForInt("I hvilket år er du født? ");
            int age = 2022 - year;

            bool hadBirthday = MyConsole.AskYesOrNo("Har du hatt bursdag i år (j/n)? ");
            if (!hadBirthday) age--;

            Console.WriteLine($"Da er du {age} år gammel.");
        }
    }
}