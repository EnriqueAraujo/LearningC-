using System;

namespace TesteCode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Organizador de vetor");
            Console.WriteLine("-------------------------------------------");

            var opcaoUsuario = menuInput();

            int [] valores = new int[0];
            int aux = 0;
            bool verificaVetor = false;

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
                        validaVetor(ref valores, ref verificaVetor);

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
    
                        break;
                    case "3":
                        //Boble sort decrescente
                        validaVetor(ref valores, ref verificaVetor);

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

                        break;
                    case "4":
                        //Printar vetor
                        validaVetor(ref valores, ref verificaVetor);

                        for(int i=0; i < valores.Length; i++)
                        {
                            Console.WriteLine(valores[i]);
                        }
                        finalizar();

                        break;
                    default:
                        Console.WriteLine("Digite uma opção valida");
                        break;
                }
            opcaoUsuario = menuInput(); 
            }

            encerrar();

        }

         public static  string menuInput()
        {
            //Printa menu e captura input do usuario
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Selecione uma opção");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("1- Carregar vetor\n 2- Ordernar vetor em ordem crescente\n 3- Ordernar vetor em ordem decrescente\n 4- Exibir vetor\n X- Sair");
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

        public static void 

        public static void validaVetor(ref int[] valores, ref bool verificaVetor)
        {
           if (!verificaVetor)
                {
                    Console.WriteLine("Vetor não inicializado, inicializando...");
                    carregarVetor(ref valores, ref verificaVetor);
                }
        }

        public static void finalizar()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Operação Realizada com Sucesso!!");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();
        }

        public static void encerrar()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Programa Encerrado");
            Console.WriteLine();
            Console.WriteLine("Obrigado por utilizar!!");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
        }
        
    }
}
