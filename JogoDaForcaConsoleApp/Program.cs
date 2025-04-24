namespace JogoDaForcaConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frutas = [
            "ABACAXI",
            "ACEROLA",
            "ACAI",
            "ARACA",
            "ABACATE",
            "BACABA",
            "BACURI",
            "BANANA",
            "CAJA",
            "CAJU",
            "CARAMBOLA",
            "CUPUACU",
            "GRAVIOLA",
            "GOIABA",
            "JABUTICABA",
            "JENIPAPO",
            "MACA",
            "MANGABA",
            "MANGA",
            "MARACUJA",
            "MURICI",
            "PEQUI",
            "PITANGA",
            "PITAYA",
            "SAPOTI",
            "TANGERINA",
            "UMBU",
            "UVA",
            "UVAIA"
            ];

            while (true)
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("------------------------");
                    Console.WriteLine("1 - Jogar");
                    Console.WriteLine("2 - Sair");
                    Console.Write("Escolha uma opção: ");
                    string opcao = Console.ReadLine();

                    if (opcao == "2")
                    {
                        Console.WriteLine("Saindo do jogo...");
                        break;
                    }
                    else if (opcao != "1")
                    {
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente...");
                        Console.ReadKey();
                        continue;
                    }


                    Random geradorDeNumero = new Random();

                    int indicePalavraEscolhida = geradorDeNumero.Next(frutas.Length);

                    string palavraSecreta = frutas[indicePalavraEscolhida];

                    char[] letrasEncontradas = new char[palavraSecreta.Length];

                    for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                    {
                        letrasEncontradas[caractere] = '_';
                    }



                    int quantidadeErros = 0;
                    HashSet<char> letrasChutadas = new HashSet<char>();


                    bool jogadorEnforcou = false;
                    bool jogadorAcertou = false;


                    do
                    {
                        string dicaDaPalavra = string.Join("", letrasEncontradas);

                        Console.Clear();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Jogo da Forca");
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Palavra Secreta: " + dicaDaPalavra);
                        Console.WriteLine("------------------------");

                        if (quantidadeErros == 0)
                        {
                            Console.WriteLine(" ___________        ");
                            Console.WriteLine(" |/                 ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine("_|____              ");
                        }

                        else if (quantidadeErros == 1)
                        {
                            Console.WriteLine(" ___________        ");
                            Console.WriteLine(" |/                 ");
                            Console.WriteLine(" |         O        ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine("_|____              ");
                        }
                        else if (quantidadeErros == 2)
                        {
                            Console.WriteLine(" ___________        ");
                            Console.WriteLine(" |/                 ");
                            Console.WriteLine(" |         O        ");
                            Console.WriteLine(" |         |        ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine("_|____              ");
                        }
                        else if (quantidadeErros == 3)
                        {
                            Console.WriteLine(" ___________        ");
                            Console.WriteLine(" |/                 ");
                            Console.WriteLine(" |         O        ");
                            Console.WriteLine(" |        /|        ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine("_|____              ");
                        }
                        else if (quantidadeErros == 4)
                        {
                            Console.WriteLine(" ___________        ");
                            Console.WriteLine(" |/                 ");
                            Console.WriteLine(" |         O        ");
                            Console.WriteLine(" |        /|\\      ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine("_|____              ");
                        }
                        else if (quantidadeErros == 5)
                        {
                            Console.WriteLine(" ___________        ");
                            Console.WriteLine(" |/                 ");
                            Console.WriteLine(" |         O        ");
                            Console.WriteLine(" |        /|\\      ");
                            Console.WriteLine(" |        /         ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine("_|____              ");
                        }
                        else if (quantidadeErros == 6)
                        {
                            Console.WriteLine(" ___________        ");
                            Console.WriteLine(" |/                 ");
                            Console.WriteLine(" |         O        ");
                            Console.WriteLine(" |        /|\\      ");
                            Console.WriteLine(" |        / \\      ");
                            Console.WriteLine(" |      ------      ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine("_|____              ");
                        }
                        Console.WriteLine("Tens 6 chances de errar até ser enforcado");
                        Console.WriteLine("Quantidade de erros: " + quantidadeErros);
                        Console.WriteLine("Letras já chutadas: " + string.Join(" ", letrasChutadas));
                        Console.WriteLine("------------------------");

                        Console.Write("Digite uma Letra: ");
                        char chute = char.ToUpper(Console.ReadLine()[0]);
                        letrasChutadas.Add(chute);


                        bool letraFoiEncontrada = false;

                        for (int contador = 0; contador < palavraSecreta.Length; contador++)
                        {
                            char letraAtual = palavraSecreta[contador];
                            if (chute == letraAtual)
                            {
                                letrasEncontradas[contador] = letraAtual;
                                letraFoiEncontrada = true;
                            }
                        }

                        if (letraFoiEncontrada == false)
                            quantidadeErros++;

                        dicaDaPalavra = string.Join("", letrasEncontradas);

                        jogadorAcertou = dicaDaPalavra == palavraSecreta;
                        jogadorEnforcou = quantidadeErros > 6;

                        Console.Clear();
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Jogo da Forca");
                        Console.WriteLine("------------------------");
                        Console.WriteLine("Palavra Secreta: " + dicaDaPalavra);
                        Console.WriteLine("------------------------");

                        if (jogadorAcertou)
                        {
                            Console.WriteLine("------------------------");
                            Console.WriteLine("Parabéns Você Acertou!! A Palavra Secreta! Era: " + palavraSecreta);
                            Console.WriteLine("------------------------");
                        }
                        else if (jogadorEnforcou)
                        {
                            Console.Clear();
                            Console.WriteLine("------------------------");
                            Console.WriteLine("Jogo da Forca");
                            Console.WriteLine("------------------------");
                            Console.WriteLine(" ___________        ");
                            Console.WriteLine(" |/        |        ");
                            Console.WriteLine(" |         O        ");
                            Console.WriteLine(" |        /|\\      ");
                            Console.WriteLine(" |        / \\      ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine(" |                  ");
                            Console.WriteLine("_|____              ");
                            Console.WriteLine("------------------------");
                            Console.WriteLine("Que Azar, ;( Tente Novamente ! A Palavra Secreta! Era: " + palavraSecreta);
                            Console.WriteLine("------------------------");
                        }

                    } while (jogadorAcertou == false && jogadorEnforcou == false);

                    Console.WriteLine("Deseja jogar novamente? (S/N)");
                    string resposta = Console.ReadLine().ToUpper();

                    if (resposta != "S")
                    {
                        Console.WriteLine("Obrigado por jogar!");
                        break;
                    }


                }

            }
        }
    }
}
