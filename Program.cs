using System;

class Program {

  //the list with the elements that are printed on the board
  static int[,] numbers = 
  {
    {1,2,3},
    {4,5,6},
    {7,8,9}
  };

  static bool win = false;


  public static void Main (string[] args) {
    Console.Clear();
    
    while(win != true)
    {
      
      for(int i = 1; i <= 2; i++)
      {
        Console.Clear();
        Console.WriteLine("If niether of you win, type \"end\"");
        if(i == 1)
        {
          Boxes(numbers);
          Player(i);
          if(CheckWin(numbers))
          {
            Boxes(numbers);
            Console.WriteLine("Player1 Won!");
            win = true;
            break;
          }
        }
        if(i == 2)
        {
          Boxes(numbers);
          Player(i);
          if(CheckWin(numbers))
          {
            Boxes(numbers);
            Console.WriteLine("Player2 Won!");
            win = true;
            break;
          }
        }
      }

    }
  }








  ///<summary>
  ///this creates the grid and the numbers in them
  ///</summary>
  public static void Boxes(int[,] numbers)
  {
    
    //bruh this looks so messy
    //creates the "board" with the elements from the array
    
    Console.WriteLine("     |     |   ");
    PrintLine(numbers,0);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |   ");
    PrintLine(numbers,1);
    Console.WriteLine("_____|_____|_____");
    Console.WriteLine("     |     |   ");
    PrintLine(numbers,2);
    Console.WriteLine("     |     |   ");
  }


  public static void PrintLine(int[,] numbers, int j)
  {
    for(int i = 0; i < 3; i++)
    {
      if(i == 2)
      {
        if(numbers[j,i]==-1)
        {
          Console.WriteLine("  X  ");
        }else if(numbers[j,i] == 0)
        {
          Console.WriteLine("  O  ");
        }else
        {
          Console.WriteLine("  {0}  ",numbers[j,i]);
        }
        
      }
      else
      {
        if(numbers[j,i] == -1)
        {
          Console.Write("  X  |");
        }else if(numbers[j,i] == 0)
        {
          Console.Write("  O  |");
        }else
        {
          Console.Write("  {0}  |",numbers[j,i]);
        }
        
      }
        
    }
  }


  ///<summary>
  ///Checks if someone may have won and returns a value when true
  ///</summary>

  public static bool CheckWin(int[,] numbers)
  {
    for(int i = 0; i <= 2; i++)
    {
      if(numbers[0,i] == numbers[1,i] && numbers[1,i] == numbers[2,i])
      {
        return true;
      }
      if(numbers[i,0] == numbers[i,1] && numbers[i,1] == numbers[i,2])
      {
        return true;
      }
    }
    if(numbers[0,0] == numbers[1,1] && numbers[1,1] == numbers[2,2])
    {
      return true;
    }
    if(numbers[0,2] == numbers[1,1] && numbers[1,1] == numbers[2,0])
    {
      return true;
    }
    return false;
  }

  ///<summary>
  ///allows the player to input (also depending if it is player 1 or 2)
  ///</summary>
  public static void Player(int i)
  {
    
    if(i == 1)
    {
      Console.Write($"Player{i}: where would you like to put your X?>> ");
    }else if(i == 2)
    {
      Console.Write($"Player{i}: where would you like to put your O?>> ");
    }
    
    string input = Console.ReadLine();
    if(input == "end")
    {
      Environment.Exit(0);
    }


    int changePos = CheckInput(input,i);
    Change(i, changePos, numbers);
  }
  ///<summary>
  ///Checks that the users input is correct, if not it runs through Player() again.
  ///</summary>
  public static int CheckInput(string input,int i)
  {
    int changePos;
    bool success = int.TryParse(input, out changePos);
    if(success == false)
    {
      Console.WriteLine("\nPlease Enter a Number!");
      Player(i);
    }else if(changePos > 9 || changePos < 1)
    {
      Console.WriteLine("\nInvalid input! Number is too high or low!!!!!!!!");
      Player(i);
    }
    return changePos;
  }

  ///<summary>
  ///changes the elements in the array depending on the players input
  ///</summary>
  public static void Change(int i, int changePos,int[,] numbers)
  {
    if(i == 1)
    {
      switch(changePos)
      {
        case 1:
          if(numbers[0,0] == -1 || numbers[0,0] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[0,0] = -1;  //-1 means a X will be there
          }
          
          break;


        case 2:
          if(numbers[0,1] == -1 || numbers[0,1] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[0,1] = -1;  //-1 means a X will be there
          }
          
          break;



        case 3:
          if(numbers[0,2] == -1 || numbers[0,2] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[0,2] = -1;  //-1 means a X will be there
          }
          
          break;



        case 4:
          if(numbers[1,0] == -1 || numbers[1,0] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[1,0] = -1;  //-1 means a X will be there
          }
          
          break;



        case 5:
          if(numbers[1,1] == -1 || numbers[1,1] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[1,1] = -1;  //-1 means a X will be there
          }
          
          break;



        case 6:
          if(numbers[1,2] == -1 || numbers[1,2] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[1,2] = -1;  //-1 means a X will be there
          }
          
          break;



        case 7:
          if(numbers[2,0] == -1 || numbers[2,0] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[2,0] = -1;  //-1 means a X will be there
          }
          
          break;



        case 8:
          if(numbers[2,1] == -1 || numbers[2,1] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[2,1] = -1;  //-1 means a X will be there
          }
          
          break;



        case 9:
          if(numbers[2,2] == -1 || numbers[2,2] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[2,2] = -1;  //-1 means a X will be there
          }
          
          break;
      }
    }
    if(i == 2)
    {
      switch(changePos)
      {
        case 1:
          if(numbers[0,0] == -1 || numbers[0,0] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[0,0] = 0;  //0 means an O will be there
          }
          
          break;
        case 2:
          if(numbers[0,1] == -1 || numbers[0,1] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!\n");
            Player(i);
          }else
          {
            numbers[0,1] = 0;  //0 means an O will be there
          }
          
          break;
        case 3:
          if(numbers[0,2] == -1 || numbers[0,2] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[0,2] = 0;  //0 means an O will be there
          }
          
          break;
        case 4:
          if(numbers[1,0] == -1 || numbers[1,0] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[1,0] = 0;  //0 means an O will be there
          }
          
          break;
        case 5:
          if(numbers[1,1] == -1 || numbers[1,1] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[1,1] = 0;  //0 means an O will be there
          }
          
          break;
        case 6:
          if(numbers[1,2] == -1 || numbers[1,2] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[1,2] = 0;  //0 means an O will be there
          }
          
          break;
        case 7:
          if(numbers[2,0] == -1 || numbers[2,0] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[2,0] = 0;  //0 means an O will be there
          }
          
          break;
        case 8:
          if(numbers[2,1] == -1 || numbers[2,1] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[2,1] = 0;  //0 means an O will be there
          }
          
          break;
        case 9:
          if(numbers[2,2] == -1 || numbers[2,2] == 0)
          {
            Console.WriteLine("Somthing Already exists here, try again!");
            Player(i);
          }else
          {
            numbers[2,2] = 0;  //0 means an O will be there
          }
          break;
      }
    }
  }


}
