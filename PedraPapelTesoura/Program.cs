// See https://aka.ms/new-console-template for more information
{
string[] opcoes = {"papel", "pedra" , "tesoura" };
Random random = new Random();


while(true)
{
Console.WriteLine("Escolha entre pedra, papel ou tesoura (ou digite sair para terminar o jogo): ");
   string jogador = Console.ReadLine().ToLower();

if(jogador == "sair")
  {
  break;
  }  

string computador = opcoes[random.Next(opcoes.Length)];
Console.WriteLine($"O computador escolheu: {computador}");

if(jogador == computador)
Console.WriteLine(" Empate ");
else if ( jogador == "pedra" && computador == "tesoura" || jogador == "papel" && computador == "pedra" || jogador == "tesoura" && computador == "papel")
Console.WriteLine(" Você venceu! ");
else
Console.WriteLine(" Computador venceu! ");
Console.WriteLine();
}
}

