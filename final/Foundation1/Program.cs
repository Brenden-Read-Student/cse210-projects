using System;

class Program
{
    static void Main(string[] args)
    {
        Comment comment1 = new Comment();
        comment1._commentName = "Noah";
        comment1._comment = "This video is not available";

        Comment comment2 = new Comment();
        comment2._commentName = "Marck";
        comment2._comment = "This video is great";

        Comment comment3 = new Comment();
        comment3._commentName = "Brad";
        comment3._comment = "With there was more to this video";

        Comment comment4 = new Comment();
        comment4._commentName = "Clark";
        comment4._comment = "When can I get this good?";

        Comment comment5 = new Comment();
        comment5._commentName = "Kent";
        comment5._comment = "Did this work?";

        Comment comment6 = new Comment();
        comment6._commentName = "Carle";
        comment6._comment = "Where is this?";

        Comment comment7 = new Comment();
        comment7._commentName = "Tayla";
        comment7._comment = "That looks so cool?";

        Comment comment8 = new Comment();
        comment8._commentName = "Abby";
        comment8._comment = "Is this really for beginners?";

        Comment comment9 = new Comment();
        comment9._commentName = "Lucy";
        comment9._comment = "I'm goint to try that";



        Video video1 = new Video();
        video1._title = "swiming tutorial";
        video1._author = "Martin";
        video1._length = 300;
        video1._comList.Add(comment1);
        video1._comList.Add(comment2);
        video1._comList.Add(comment3);

        Video video2 = new Video();
        video2._title = "Car drifting tutorial";
        video2._author = "Connor";
        video2._length = 1000;
        video2._comList.Add(comment4);
        video2._comList.Add(comment5);
        video2._comList.Add(comment6);

        Video video3 = new Video();
        video3._title = "Jet skie tricks tutorial";
        video3._author = "Chad";
        video3._length = 600;
        video3._comList.Add(comment7);
        video3._comList.Add(comment8);  
        video3._comList.Add(comment9);      




        video1.Display();
        Console.WriteLine();
        video2.Display();
        Console.WriteLine();
        video3.Display();
        Console.WriteLine();
    }
}