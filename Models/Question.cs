using System.Collections.Generic;

namespace csharp_python.Models
{
  public class Question
  {
    public string Query { get; set; }
    public string Response { get; set; }

    public Dictionary<string, Question> Directions { get; set; }

    public Question(string query)
    {
        Query = query;
        Directions = new Dictionary<string, Question>();
    }

  }
}