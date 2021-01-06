using ImageMatcherSimulator;
using ImageMatcherSimulator.Scenarios;
using System;

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Choose a scenario:");

        Console.WriteLine("Case (0): Two 6x6 images that have no matching regions.");
        Console.WriteLine("Case (1): Two 4x4 images that have no matching regions.");
        Console.WriteLine("Case (2): Two 6x6 images that have one matching region.");
        Console.WriteLine("Case (3): Two 4x4 images that have three matching regions.");

        var key = Console.ReadKey();

        Console.WriteLine();

        switch (key.Key.ToString())
        {
            case "D0":
                NoMatchingRegions6x6();
                break;
            case "D1":
                NoMatchingRegions4x4();
                break;
            case "D2":
                MatchingRegions6x6();
                break;
            case "D3":
                MatchingRegions4x4();
                break;
            default:
                break;
        }

        Console.ReadKey();
    }

    public static void MatchingRegions4x4()
    {
        var image1 = new Pixel[4, 4];

        var image2 = new Pixel[4, 4];

        Catalog.MatchingRegions4x4Image1(image1);

        Catalog.MatchingRegions4x4Image2(image2);

        Utilities.ExecuteCase(image1, image2);
    }

    public static void MatchingRegions6x6()
    {
        var image1 = new Pixel[6, 6];

        var image2 = new Pixel[6, 6];

        Catalog.MatchingRegions6x6Image1(image1);

        Catalog.MatchingRegions6x6Image2(image2);

        Utilities.ExecuteCase(image1, image2);
    }

    public static void NoMatchingRegions4x4()
    {
        var image1 = new Pixel[4, 4];

        var image2 = new Pixel[4, 4];

        Catalog.NoMatchingRegions4x4Image1(image1);

        Catalog.NoMatchingRegions4x4Image2(image2);

        Utilities.ExecuteCase(image1, image2);
    }

    public static void NoMatchingRegions6x6()
    {
        var image1 = new Pixel[6, 6];

        var image2 = new Pixel[6, 6];

        Catalog.NoMatchingRegions6x6Image1(image1);

        Catalog.NoMatchingRegions6x6Image2(image2);

        Utilities.ExecuteCase(image1, image2);
    }
}
