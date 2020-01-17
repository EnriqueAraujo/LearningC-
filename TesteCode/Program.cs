using System;

namespace TesteCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            inicio();

            var opcaoUsuario = menuInput();
            int [] valores = new int[0];
            bool verificaVetor = false;
            int aux = 0;

            //mantém a aplicação rodando até o usuario sair
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        //Carrega vetor
                        carregarVetor(ref valores, ref verificaVetor);

                        break;
                    case "2":
                        // Boble sort crescente
                        boobleSort(ref valores, ref verificaVetor, ref aux);
    
                        break;
                    case "3":
                        //Boble sort decrescente
                        boobleSortInverso(ref valores, ref verificaVetor, ref aux);

                        break;
                    case "4":
                        //Printar vetor
                        printaVetor(ref valores, ref verificaVetor);

                        break;
                    default:
                        Console.WriteLine("Opção invalida\nPor favor, digite uma opção valida");
                        break;
                }
            opcaoUsuario = menuInput(); 
            }

            encerrar();

        }

        public static void inicio()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Organizador de vetor");
            Console.WriteLine("-------------------------------------------");
        }


         public static  string menuInput()
        {
            //Printa menu e captura input do usuario
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1- Carregar vetor\n2- Ordernar vetor em ordem crescente\n3- Ordernar vetor em ordem decrescente\n4- Exibir vetor\nX- Sair");
            Console.WriteLine("-------------------------------------------\n");

            string opcaoUsuario = Console.ReadLine();
            Console.WriteLine();
            return opcaoUsuario;
        }

        
        public static void carregarVetor(ref int[] valores, ref bool verificaVetor)
        {
                Console.WriteLine("Informe a quantidade de posições que deseja armazenar");
                int n = Convert.ToInt32(Console.ReadLine()); 
                valores = new int[n];

                for (int i=0; i < n; i++)
                {
                    Console.WriteLine($"Digite o {i+1}° valor");
                    valores[i] = Convert.ToInt32(Console.ReadLine());
                }

                verificaVetor = true;

                finalizar();
        }

        public static void boobleSort(ref int[] valores, ref bool verificador, ref int aux)
        {
            validaVetor(ref valores, ref verificador);

            aux = 0;

            for (int i=0; i < valores.Length; i++)
            {
                for (int j=i+1; j < valores.Length; j++)
                {
                    if (valores[i] > valores[j])
                    {
                    aux = valores[i];
                    valores[i] = valores[j];
                    valores[j] = aux; 
                    }
                }
            }

            finalizar();
        } 

        public static void boobleSortInverso(ref int[] valores, ref bool verificador, ref int aux)
        {

            validaVetor(ref valores, ref verificador);

            aux = 0;

            for (int i=0; i < valores.Length; i++)
            {
                for (int j=i+1; j < valores.Length; j++)
                {
                    if (valores[i] < valores[j])
                    {
                        aux = valores[i];
                        valores[i] = valores[j];
                        valores[j] = aux; 
                    }
                }
            }

            finalizar();

        }

        public static void printaVetor(ref int[] valores, ref bool verificador)
        {

            validaVetor(ref valores, ref verificador);

            for(int i=0; i < valores.Length; i++)
            {
                Console.WriteLine(valores[i]);
            }

            finalizar();
        }

        public static void validaVetor(ref int[] valores, ref bool verificaVetor)
        {
           if (!verificaVetor)
                {
                    Console.WriteLine("Vetor não inicializado, inicializando...\n");
                    carregarVetor(ref valores, ref verificaVetor);
                }
        }

        public static void finalizar()
        {
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Operação Realizada com Sucesso!!");
            Console.WriteLine("-------------------------------------------\n");
        }

        public static void encerrar()
        {
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Programa Encerrado\n");
            Console.WriteLine("Obrigado por utilizar!!");
            Console.WriteLine("-------------------------------------------\n");
        }
        
    }
}
