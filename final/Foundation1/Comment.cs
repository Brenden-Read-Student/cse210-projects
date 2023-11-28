using System;

class Comment
{
   public string _commentName;
   public string _comment;

   public void PrintComment()
   {
        Console.WriteLine($"{_commentName} Comented: {_comment} ");
   }

}