using csharp_python.Models;

namespace csharp_python
{
  public class Game
  {
    public Question init()
    {
      Question q1 = new Question("What is your name?");
      Question q2 = new Question("What is your Quest?");
      Question q3 = new Question("What is your favorite Color?");
      Question q4 = new Question("What is the air speed velocity of an unlaiden swallow?");

      q1.Directions.Add("next", q2);
      q2.Directions.Add("previous", q1);
      q2.Directions.Add("next", q3);
      q3.Directions.Add("previous", q2);
      q3.Directions.Add("next", q4);
      q4.Directions.Add("previous", q3);

        return q1;
    }
  }
}