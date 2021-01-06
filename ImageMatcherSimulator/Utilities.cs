using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ImageMatcherSimulator
{
    public static class Utilities
    {
        public static void ExecuteCase(Pixel[,] image1, Pixel[,] image2)
        {
            PrintImage(image1);

            PrintImage(image2);

            Console.WriteLine($"Calculating Regions for {nameof(image1)}");
            var regions1 = GetRegions(image1);
            Console.WriteLine(JsonConvert.SerializeObject(regions1));
            Console.WriteLine($"Total regions in {nameof(image1)}: {regions1.Count}");

            Console.WriteLine($"Calculating Regions for {nameof(image2)}");
            var regions2 = GetRegions(image2);
            Console.WriteLine(JsonConvert.SerializeObject(regions2));
            Console.WriteLine($"Total regions in {nameof(image2)}: {regions2.Count}");

            var count = CountRegionMatches(regions1, regions2);

            if (count > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"{count} region(s) match.", ConsoleColor.Green);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{count} region(s) match.");
            }
        }

        public static int CountRegionMatches(List<List<Pixel>> regions1, List<List<Pixel>> regions2)
        {
            return regions1.Count(r1 => regions2.Any(r2 => AreSame(r1, r2)));
        }

        public static bool AreSame(List<Pixel> region1, List<Pixel> region2)
        {
            return region1.Count == region2.Count && region1.All(c => region2.Contains(c));
        }

        public static List<List<Pixel>> GetRegions(Pixel[,] image)
        {
            var regions = new List<List<Pixel>>();

            var visited = new HashSet<Pixel>();

            for (int row = 0; row < image.GetLength(0); row++)
            {
                for (int col = 0; col < image.GetLength(1); col++)
                {
                    var region = new List<Pixel>();

                    PopulateRegion(row, col, image, visited, region);

                    if (region.Count > 0)
                    {
                        regions.Add(region);
                        Console.WriteLine($"Region found with {region.Count} cell(s): {JsonConvert.SerializeObject(region)}");
                    }
                }

            }

            return regions;
        }

        public static void PopulateRegion(int row, int col, Pixel[,] image, HashSet<Pixel> visited, List<Pixel> region)
        {
            if (image[row, col].Content == 0) return;

            if (!visited.Contains(image[row, col]))
            {
                region.Add(image[row, col]);

                visited.Add(image[row, col]);

                if (row - 1 >= 0)
                {
                    PopulateRegion(row - 1, col, image, visited, region);
                }

                if (row + 1 < image.GetLength(0))
                {
                    PopulateRegion(row + 1, col, image, visited, region);
                }

                if (col - 1 >= 0)
                {
                    PopulateRegion(row, col - 1, image, visited, region);
                }

                if (col + 1 < image.GetLength(1))
                {
                    PopulateRegion(row, col + 1, image, visited, region);
                }
            }
        }

        public static void PrintImage(Pixel[,] image)
        {
            for (int row = 0; row < image.GetLength(0); row++)
            {
                for (int col = 0; col < image.GetLength(1); col++)
                {
                    Console.Write(image[row, col].Content);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
