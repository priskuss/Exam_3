namespace Exam_Unit_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Popping_Functions.Square(5));
            //Console.WriteLine(Popping_Functions.InchesToMm(10));
            //Console.WriteLine(My_Books.BooksAfter1992());
            //Console.WriteLine(My_Books.BooksBefore2004());
            //Console.WriteLine(string.Join("\n", My_Books.IsbnByAuthor("Brandon Sanderson")));
            //Console.WriteLine(string.Join("\n", My_Books.Alphabetical(true).Select(b => b.title)));
            //Console.WriteLine(Left_Right_Up_Down.Nodes(Left_Right_Up_Down.LoadNodes()));
            //Console.WriteLine(Left_Right_Up_Down.Deepest(Left_Right_Up_Down.LoadNodes()));
            //Console.WriteLine(Left_Right_Up_Down.Sum(Left_Right_Up_Down.LoadNodes()));
            int[] flattened = Flattened_Numbers.FetchAndFlattenArray().GetAwaiter().GetResult();
            Console.WriteLine(string.Join(", ", flattened));
        }
    }
}
