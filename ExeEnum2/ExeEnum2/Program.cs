using System;
using ExeEnum2.Entitis;

namespace ExeEnum2
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Havea nice trip");
            Comment c2 = new Comment("Wow that's awesome!");
            Post p1 = new Post(
                DateTime.Parse("21/03/2018 13:05:44"),
                "Travelling to New Zelanding",
                "I'm go to visit this new wonderful country",
                12);

            p1.AddComment(c1);
            p1.AddComment(c2);

            Comment c3 = new Comment("HGood Night");
            Comment c4 = new Comment("May thr force be with you");
            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);

            p2.AddComment(c3);
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
