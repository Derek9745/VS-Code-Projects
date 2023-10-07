using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Windows;
class DiceGame{


 public static void Main(String[] Args){
   
  Console.WriteLine("Welcome to The Last Throw \nwhich mode would you like to play?\n1. Best of 1\n2. Best of 3\n3. Best of 5");
  int answer = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine(answer);
  startGame(answer);
}

public  static int startGame(int answer){

  switch(answer){
      case 1:
        Console.WriteLine("Beginning best of 1");
        int playerResult = Rolldice();
        int computerResult = Rolldice();
        Console.WriteLine("You rolled a" + playerResult + " Your opponent rolled a " + computerResult);

          if(playerResult>computerResult){
            Console.WriteLine("You Win!");
          }
          else if(playerResult == computerResult){
            Console.WriteLine("Draw!");
          }
          else if (playerResult <computerResult){
            Console.WriteLine("You Lose");
        }
        break;

      case 2: 
        Console.WriteLine("Beginning best of 3");
        break;

      case 3: 
        Console.WriteLine("Beginning best of 5");
        break;
    }

    return answer;

}

  static int Rolldice(){

      Random rand = new Random();
      int numb = rand.Next(1,6);
      return numb;

  }



}

 