Random random = new Random();
bool jogarNovamente = true;
int min = 1;
int max = 100;
int palpite;
int numero;
int palpites;
String resposta;

while (jogarNovamente)
{
    palpite = 0;
    palpites = 0;
    resposta = "";
    numero = random.Next(min, max + 1);
    while(palpite != numero)
    {
        Console.WriteLine("\nAdvinhe um numero entre " + min + "-" + max + ":");
        palpite= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Palpite: " + palpite);

        if(palpite > numero )
        {
            Console.WriteLine(palpite + " e muito alto");
        }
        else if (palpite < numero )
        {
            Console.WriteLine(palpite + " e muito baixo");
        }
        palpites++;
    }
    Console.WriteLine("\nNumero: " + numero);
    Console.WriteLine("Voce ganhou!");
    Console.WriteLine("Palpites: " + palpites);
    Console.WriteLine("Gostaria de jogar novamente? (S/N) \n");
    resposta = Console.ReadLine();
    resposta = resposta.ToUpper();

    if (resposta == "S")
    {
        jogarNovamente = true;
    }
    else
    {
        jogarNovamente = false;
    }
}
