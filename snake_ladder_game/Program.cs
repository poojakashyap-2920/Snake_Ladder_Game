using System.ComponentModel.Design;

namespace snake_ladder_game
{
  public class Program
    {
        static void Main(string[] args)
        {
           Ladder_Snake ob = new Ladder_Snake();
            ob.Game();
            }
        }
       
    }
    public class Ladder_Snake
    {
        int[] ladder = { 1,4,8,21,28,50,71,88};
        int[] snake = { 32, 36, 63, 88, 95, 97 };
        Random r = new Random();
       // int randomNumber1 = r.Next();

        int player1;
        int player2;
       // int startposition = 0;
       
    int currentposition = 0;
    int currentposition1 = 0;
        public void Game()
        {
            while (currentposition<100 || currentposition1<100)
            {
                Console.WriteLine("1.player1\n"+
                    "2.player2");
                int option = int.Parse(Console.ReadLine());
              
                switch (option)
                {
                    case 1:
                        SnakeLadder_player1();
                        break;
                    case 2:
                        SnakeLadder_player2();
                        break;
                        default: break;
                }

            }
        }
        public int SnakeLadder_player1()
        {
        int maxposition = 100;
       // int currentposition = 0;
        Console.WriteLine("roll dice");
        int randomnumber = r.Next(1,7);
        Console.WriteLine("roll dice "+ randomnumber);
        currentposition = randomnumber+ currentposition;
        if (currentposition > 100)
        {
            Console.WriteLine("player 1 exceeded the maximum position.");
            return currentposition;
            Console.WriteLine("current position :" + currentposition);
        }
        if (currentposition == 100)
        {
            Console.WriteLine("player 1 won...");
         
        }
        Console.WriteLine("currentposition player 1 :  " + currentposition);
       while(currentposition>=100)
        {
            if (currentposition == 1 || currentposition == 8 || currentposition == 21 || currentposition == 28 || currentposition == 50 || currentposition == 71)
            {
                Console.WriteLine(" player 1 got ladder increase 10");
                currentposition = currentposition + 10;
                Console.WriteLine("currentpostion player 1 : " + currentposition);

            }
            else if (currentposition == 32 || currentposition == 36 || currentposition == 63 || currentposition == 88 || currentposition == 95 || currentposition == 97)
            {
                Console.WriteLine(" player 1 cautch snake decrease 10");
                currentposition = currentposition - 10;
                Console.WriteLine("currentpostion player 1 : " + currentposition);
            }
            
        }
       
        return currentposition;
    }
        public int SnakeLadder_player2()
        {
        int maxposition = 100;
        Console.WriteLine("roll dice");
        int randomnumber = r.Next(1, 7);
        Console.WriteLine("dice = " + randomnumber);
        currentposition1 = randomnumber + currentposition1;
        if (currentposition1 >100)
        {
            Console.WriteLine("player 2 exceed 100 ");
            return  currentposition1;
            Console.WriteLine("current position : "+currentposition1);
        }
        if (currentposition1 == 100)
        {
            Console.WriteLine("player 2 won...");
        
        }

        Console.WriteLine("currentpostion1 player 2  : " + currentposition1);
        while(currentposition1 > maxposition) {

            if (currentposition1 == 1 || currentposition1 == 8 || currentposition1 == 21 || currentposition1 == 28 || currentposition1 == 50 || currentposition1 == 71)
            {
                Console.WriteLine(" player 1 got ladder increase 10");
                currentposition1 = currentposition1 + 10;
                Console.WriteLine("currentpostion player 2  : " + currentposition1);

            }
            else if (currentposition1 == 32 || currentposition1 == 36 || currentposition1 == 63 || currentposition1 == 88 || currentposition1 == 95 || currentposition1 == 97)
            {
                Console.WriteLine(" player 2 cautch snake decrease 10 ");
                currentposition1 = currentposition1 - 10;
                Console.WriteLine("currentpostion player 2  :" + currentposition1);

            }
            if (currentposition1 == 100)
            {
                Console.WriteLine("player 2 won...");
                break;

            }
        }
        return currentposition1;
    }
    }

