// Hello World! program
namespace HelloWorld
{
    class Program {         
        static void Main(string[] args)
        {
            while(true) {

            string Unos = Console.ReadLine();
            if(Unos == "x") {break;}
            string[] tokens = Unos.Split(" ");
            int priv = Int32.Parse(tokens[0]);
            int drugi = Int32.Parse(tokens[2]);
            string znak = tokens[1];

            if (znak == "+") {
                Console.WriteLine(priv + drugi);
            }
            

            }

            }
        }
    }
