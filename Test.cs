public static class Test
{

    public static void SquareTest()
    {
        int result = PoppingFunctions.Square(5);
        Console.WriteLine(result == 25 ? ":) SquareTest passed" : ":( SquareTest failed");
    }

    public static void InchesToMmTest()
    {
        double result = PoppingFunctions.InchesToMm(10);
        Console.WriteLine(Math.Abs(result - 254) < 0.001 ? ":) InchesToMmTest passed" : ":( InchesToMmTest failed");
    }

    public static void RootTest()
    {
        double result = PoppingFunctions.Root(4);
        Console.WriteLine(Math.Abs(result - 2) < 0.001 ? ":) RootTest passed" : ":(RootTest failed");
    }

    public static void CubeTest()
    {
        int result = PoppingFunctions.Cube(3);
        Console.WriteLine(result == 27 ? ":) CubeTest passed" : ":( CubeTest failed");
    }

    public static void CircleAreaTest()
    {
        double result = PoppingFunctions.CircleArea(10);
        Console.WriteLine(Math.Abs(result - 314.1592653589793) < 0.001 ? ":) CircleAreaTest passed" : ":( CircleAreaTest failed");
    }

    public static void GreetingTest()
    {
        string result = PoppingFunctions.Greeting("Who");
        Console.WriteLine(result == "Hello, Who" ? ":) GreetingTest passed" : ":( GreetingTest failed");
    }
    public static void FlattenedNumbersTest()
    {
        bool result = FlattenedNumbers.Flatten(new object[] { 1, new object[] { 2, 3 }, 4 }).SequenceEqual(new int[] { 1, 2, 3, 4 });
        Console.WriteLine(result ? ":) FlattenedNumbersTest passed" : ":( FlattenedNumbersTest failed");
    }
    public static void TheBooksTest()
    {
        Book[] result = MyBooks.TheBooks();
        Console.WriteLine(result.All(b => b.title.StartsWith("The")) ? ":) TheBooksTest passed" : ":( TheBooksTest failed");
    }

    public static void TAuthorsTest()
    {
        Book[] result = MyBooks.TAuthors();
        Console.WriteLine(result.All(b => b.author.Contains('t')) ? ":) TAuthorsTest passed" : ":( TAuthorsTest failed");
    }

    public static void BooksAfter1992Test()
    {
        int result = MyBooks.BooksAfter1992();
        Console.WriteLine(result == MyBooks.books.Where(b => b.publication_year > 1992).Count() ? ":) BooksAfter1992Test passed" : ":( BooksAfter1992Test failed");
    }
    public static void BooksBefore2004Test()
    {
        int result = MyBooks.BooksBefore2004();
        Console.WriteLine(result == MyBooks.books.Where(b => b.publication_year < 2004).Count() ? ":) BooksBefore2004Test passed" : ":( BooksBefore2004Test failed");
    }

    public static void IsbnByAuthorTest()
    {
        string[] result = MyBooks.IsbnByAuthor("Author Name");
        Console.WriteLine(result.SequenceEqual(MyBooks.books.Where(b => b.author == "Author Name").Select(b => b.isbn)) ? ":) IsbnByAuthorTest passed" : ":( IsbnByAuthorTest failed");
    }

    public static void AlphabeticalOrderTest()
    {
        Book[] result = MyBooks.AlphabeticalOrder(true);
        Console.WriteLine(result.SequenceEqual(MyBooks.books.OrderBy(b => b.title)) ? ":) AlphabeticalOrderTest passed" : ":( AlphabeticalOrderTest failed");
    }
    public static void ChronologicalOrderTest()
    {
        Book[] result = MyBooks.ChronologicalOrder(true);
        Console.WriteLine(result.SequenceEqual(MyBooks.books.OrderBy(b => b.publication_year)) ? ":) ChronologicalOrderOrderTest passed" : ":( ChronologicalOrderTest failed");
    }

    public static void GroupByLastNameTest()
    {
        Book[] result = MyBooks.GroupByLastName();
        Console.WriteLine(result.SequenceEqual(MyBooks.books.OrderBy(b => b.author.Split(' ').Last())) ? ":) GroupByLastNameTest passed" : ":( GroupByLastNameTest failed");
    }

    public static void GroupByFirstNameTest()
    {
        Book[] result = MyBooks.GroupByFirstName();
        Console.WriteLine(result.SequenceEqual(MyBooks.books.OrderBy(b => b.author.Split(' ').First())) ? ":) GroupByFirstNameTest passed" : ":( GroupByFirstNameTest failed");
    }
    public static void LoadNodesTest()
    {
        Node rootNode = TreeNode.LoadNodes().GetAwaiter().GetResult();
        Console.WriteLine(rootNode != null ? ":) LoadNodesTest passed" : ":( LoadNodesTest failed");
    }

    public static void SumTest()
    {
        Node rootNode = new Node
        {
            value = 1,
            left = new Node
            {
                value = 2,
                left = new Node { value = 3 },
                right = new Node { value = 4 }
            },
            right = new Node { value = 5 }
        };
        int result = TreeNode.Sum(rootNode);
        Console.WriteLine(result == 15 ? ":) SumTest passed" : ":( SumTest failed");
    }

    public static void DeepestTest()
    {
        Node rootNode = new Node
        {
            value = 1,
            left = new Node
            {
                value = 2,
                left = new Node { value = 3 },
                right = new Node { value = 4 }
            },
            right = new Node { value = 5 }
        };
        int result = TreeNode.Deepest(rootNode);
        Console.WriteLine(result == 3 ? ":) DeepestTest passed" : ":( DeepestTest failed");
    }

    public static void NodesTest()
    {
        Node rootNode = new Node
        {
            value = 1,
            left = new Node
            {
                value = 2,
                left = new Node { value = 3 },
                right = new Node { value = 4 }
            },
            right = new Node { value = 5 }
        };
        int result = TreeNode.Nodes(rootNode);
        Console.WriteLine(result == 5 ? ":) NodesTest passed" : ":( NodesTest failed");
    }
}