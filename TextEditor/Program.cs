
namespace TextEditor
{
    class Program
    {

        static void Main(string[] args)
        {
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("**** SEJA BEM-VINDO (A) ****");
            Console.WriteLine("1 - Criar novo arquivo");
            Console.WriteLine("2 - Abrir arquivo");
            Console.WriteLine("0 - Sair");
            Console.Write("O que você deseja fazer? ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 0: System.Environment.Exit(0); break;
                case 1: Edit(); break;
                case 2: Open(); break;
                default: Menu(); break;
            }
            static void Open()
            {

            }
            static void Edit()
            {

            }
        }

    }
}