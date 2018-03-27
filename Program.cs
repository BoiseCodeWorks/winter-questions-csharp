using System;
using csharp_python.Models;

namespace csharp_python
{
  class Program
  {

    static void Main(string[] args)
    {
      Game game = new Game();
      Question currentQuestion = game.init();
      System.Console.WriteLine(currentQuestion.Query);
      currentQuestion = currentQuestion.Directions["next"];
      System.Console.WriteLine(currentQuestion.Query);
      currentQuestion = currentQuestion.Directions["next"];
      System.Console.WriteLine(currentQuestion.Query);
      currentQuestion = currentQuestion.Directions["previous"];
      System.Console.WriteLine(currentQuestion.Query);
    }
  }
}
