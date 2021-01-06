namespace ImageMatcherSimulator.Scenarios
{
    public static class Catalog
    {
        public static void MatchingRegions4x4Image1(Pixel[,] image1)
        {
            image1[0, 0] = new Pixel(0, 0, 1);
            image1[0, 1] = new Pixel(0, 1, 0);
            image1[0, 2] = new Pixel(0, 2, 1);
            image1[0, 3] = new Pixel(0, 3, 0);

            image1[1, 0] = new Pixel(1, 0, 0);
            image1[1, 1] = new Pixel(1, 1, 1);
            image1[1, 2] = new Pixel(1, 2, 0);
            image1[1, 3] = new Pixel(1, 3, 0);

            image1[2, 0] = new Pixel(2, 0, 0);
            image1[2, 1] = new Pixel(2, 1, 0);
            image1[2, 2] = new Pixel(2, 2, 0);
            image1[2, 3] = new Pixel(2, 3, 0);

            image1[3, 0] = new Pixel(3, 0, 0);
            image1[3, 1] = new Pixel(3, 1, 0);
            image1[3, 2] = new Pixel(3, 2, 0);
            image1[3, 3] = new Pixel(3, 3, 0);
        }

        public static void MatchingRegions4x4Image2(Pixel[,] image1)
        {
            image1[0, 0] = new Pixel(0, 0, 1);
            image1[0, 1] = new Pixel(0, 1, 0);
            image1[0, 2] = new Pixel(0, 2, 1);
            image1[0, 3] = new Pixel(0, 3, 0);

            image1[1, 0] = new Pixel(1, 0, 0);
            image1[1, 1] = new Pixel(1, 1, 1);
            image1[1, 2] = new Pixel(1, 2, 0);
            image1[1, 3] = new Pixel(1, 3, 0);

            image1[2, 0] = new Pixel(2, 0, 0);
            image1[2, 1] = new Pixel(2, 1, 0);
            image1[2, 2] = new Pixel(2, 2, 0);
            image1[2, 3] = new Pixel(2, 3, 0);

            image1[3, 0] = new Pixel(3, 0, 0);
            image1[3, 1] = new Pixel(3, 1, 0);
            image1[3, 2] = new Pixel(3, 2, 0);
            image1[3, 3] = new Pixel(3, 3, 0);
        }

        public static void NoMatchingRegions4x4Image1(Pixel[,] image1)
        {
            image1[0, 0] = new Pixel(0, 0, 0);
            image1[0, 1] = new Pixel(0, 1, 0);
            image1[0, 2] = new Pixel(0, 2, 1);
            image1[0, 3] = new Pixel(0, 3, 0);

            image1[1, 0] = new Pixel(1, 0, 0);
            image1[1, 1] = new Pixel(1, 1, 1);
            image1[1, 2] = new Pixel(1, 2, 1);
            image1[1, 3] = new Pixel(1, 3, 1);

            image1[2, 0] = new Pixel(2, 0, 0);
            image1[2, 1] = new Pixel(2, 1, 1);
            image1[2, 2] = new Pixel(2, 2, 0);
            image1[2, 3] = new Pixel(2, 3, 0);

            image1[3, 0] = new Pixel(3, 0, 1);
            image1[3, 1] = new Pixel(3, 1, 1);
            image1[3, 2] = new Pixel(3, 2, 1);
            image1[3, 3] = new Pixel(3, 3, 1);
        }

        public static void MatchingRegions6x6Image1(Pixel[,] image1)
        {
            image1[0, 0] = new Pixel(0, 0, 1);
            image1[0, 1] = new Pixel(0, 1, 1);
            image1[0, 2] = new Pixel(0, 2, 1);
            image1[0, 3] = new Pixel(0, 3, 0);
            image1[0, 4] = new Pixel(0, 4, 0);
            image1[0, 5] = new Pixel(0, 5, 1);

            image1[1, 0] = new Pixel(1, 0, 0);
            image1[1, 1] = new Pixel(1, 1, 0);
            image1[1, 2] = new Pixel(1, 2, 1);
            image1[1, 3] = new Pixel(1, 3, 0);
            image1[1, 4] = new Pixel(1, 4, 0);
            image1[1, 5] = new Pixel(1, 5, 1);

            image1[2, 0] = new Pixel(2, 0, 1);
            image1[2, 1] = new Pixel(2, 1, 0);
            image1[2, 2] = new Pixel(2, 2, 1);
            image1[2, 3] = new Pixel(2, 3, 0);
            image1[2, 4] = new Pixel(2, 4, 0);
            image1[2, 5] = new Pixel(2, 5, 1);

            image1[3, 0] = new Pixel(3, 0, 0);
            image1[3, 1] = new Pixel(3, 1, 0);
            image1[3, 2] = new Pixel(3, 2, 1);
            image1[3, 3] = new Pixel(3, 3, 0);
            image1[3, 4] = new Pixel(3, 4, 0);
            image1[3, 5] = new Pixel(3, 5, 1);

            image1[4, 0] = new Pixel(4, 0, 0);
            image1[4, 1] = new Pixel(4, 1, 0);
            image1[4, 2] = new Pixel(4, 2, 1);
            image1[4, 3] = new Pixel(4, 3, 0);
            image1[4, 4] = new Pixel(4, 4, 0);
            image1[4, 5] = new Pixel(4, 5, 1);

            image1[5, 0] = new Pixel(5, 0, 0);
            image1[5, 1] = new Pixel(5, 1, 0);
            image1[5, 2] = new Pixel(5, 2, 1);
            image1[5, 3] = new Pixel(5, 3, 1);
            image1[5, 4] = new Pixel(5, 4, 0);
            image1[5, 5] = new Pixel(5, 5, 1);
        }

        public static void MatchingRegions6x6Image2(Pixel[,] image1)
        {
            image1[0, 0] = new Pixel(0, 0, 1);
            image1[0, 1] = new Pixel(0, 1, 1);
            image1[0, 2] = new Pixel(0, 2, 1);
            image1[0, 3] = new Pixel(0, 3, 0);
            image1[0, 4] = new Pixel(0, 4, 0);
            image1[0, 5] = new Pixel(0, 5, 0);

            image1[1, 0] = new Pixel(1, 0, 0);
            image1[1, 1] = new Pixel(1, 1, 0);
            image1[1, 2] = new Pixel(1, 2, 1);
            image1[1, 3] = new Pixel(1, 3, 0);
            image1[1, 4] = new Pixel(1, 4, 0);
            image1[1, 5] = new Pixel(1, 5, 0);

            image1[2, 0] = new Pixel(2, 0, 0);
            image1[2, 1] = new Pixel(2, 1, 0);
            image1[2, 2] = new Pixel(2, 2, 1);
            image1[2, 3] = new Pixel(2, 3, 0);
            image1[2, 4] = new Pixel(2, 4, 0);
            image1[2, 5] = new Pixel(2, 5, 0);

            image1[3, 0] = new Pixel(3, 0, 0);
            image1[3, 1] = new Pixel(3, 1, 0);
            image1[3, 2] = new Pixel(3, 2, 1);
            image1[3, 3] = new Pixel(3, 3, 0);
            image1[3, 4] = new Pixel(3, 4, 0);
            image1[3, 5] = new Pixel(3, 5, 0);

            image1[4, 0] = new Pixel(4, 0, 0);
            image1[4, 1] = new Pixel(4, 1, 0);
            image1[4, 2] = new Pixel(4, 2, 1);
            image1[4, 3] = new Pixel(4, 3, 0);
            image1[4, 4] = new Pixel(4, 4, 0);
            image1[4, 5] = new Pixel(4, 5, 0);

            image1[5, 0] = new Pixel(5, 0, 0);
            image1[5, 1] = new Pixel(5, 1, 0);
            image1[5, 2] = new Pixel(5, 2, 1);
            image1[5, 3] = new Pixel(5, 3, 1);
            image1[5, 4] = new Pixel(5, 4, 0);
            image1[5, 5] = new Pixel(5, 5, 0);
        }

        public static void NoMatchingRegions4x4Image2(Pixel[,] image1)
        {
            image1[0, 0] = new Pixel(0, 0, 0);
            image1[0, 1] = new Pixel(0, 1, 0);
            image1[0, 2] = new Pixel(0, 2, 1);
            image1[0, 3] = new Pixel(0, 3, 0);

            image1[1, 0] = new Pixel(1, 0, 0);
            image1[1, 1] = new Pixel(1, 1, 1);
            image1[1, 2] = new Pixel(1, 2, 1);
            image1[1, 3] = new Pixel(1, 3, 1);

            image1[2, 0] = new Pixel(2, 0, 0);
            image1[2, 1] = new Pixel(2, 1, 1);
            image1[2, 2] = new Pixel(2, 2, 1);
            image1[2, 3] = new Pixel(2, 3, 0);

            image1[3, 0] = new Pixel(3, 0, 1);
            image1[3, 1] = new Pixel(3, 1, 1);
            image1[3, 2] = new Pixel(3, 2, 1);
            image1[3, 3] = new Pixel(3, 3, 1);
        }

        public static void NoMatchingRegions6x6Image1(Pixel[,] image1)
        {
            image1[0, 0] = new Pixel(0, 0, 1);
            image1[0, 1] = new Pixel(0, 1, 1);
            image1[0, 2] = new Pixel(0, 2, 0);
            image1[0, 3] = new Pixel(0, 3, 1);
            image1[0, 4] = new Pixel(0, 4, 0);
            image1[0, 5] = new Pixel(0, 5, 1);

            image1[1, 0] = new Pixel(1, 0, 1);
            image1[1, 1] = new Pixel(1, 1, 1);
            image1[1, 2] = new Pixel(1, 2, 0);
            image1[1, 3] = new Pixel(1, 3, 0);
            image1[1, 4] = new Pixel(1, 4, 0);
            image1[1, 5] = new Pixel(1, 5, 1);

            image1[2, 0] = new Pixel(2, 0, 0);
            image1[2, 1] = new Pixel(2, 1, 1);
            image1[2, 2] = new Pixel(2, 2, 0);
            image1[2, 3] = new Pixel(2, 3, 0);
            image1[2, 4] = new Pixel(2, 4, 1);
            image1[2, 5] = new Pixel(2, 5, 1);

            image1[3, 0] = new Pixel(3, 0, 1);
            image1[3, 1] = new Pixel(3, 1, 1);
            image1[3, 2] = new Pixel(3, 2, 0);
            image1[3, 3] = new Pixel(3, 3, 1);
            image1[3, 4] = new Pixel(3, 4, 1);
            image1[3, 5] = new Pixel(3, 5, 0);

            image1[4, 0] = new Pixel(4, 0, 0);
            image1[4, 1] = new Pixel(4, 1, 1);
            image1[4, 2] = new Pixel(4, 2, 1);
            image1[4, 3] = new Pixel(4, 3, 1);
            image1[4, 4] = new Pixel(4, 4, 0);
            image1[4, 5] = new Pixel(4, 5, 0);

            image1[5, 0] = new Pixel(5, 0, 0);
            image1[5, 1] = new Pixel(5, 1, 0);
            image1[5, 2] = new Pixel(5, 2, 1);
            image1[5, 3] = new Pixel(5, 3, 0);
            image1[5, 4] = new Pixel(5, 4, 0);
            image1[5, 5] = new Pixel(5, 5, 0);
        }

        public static void NoMatchingRegions6x6Image2(Pixel[,] image1)
        {
            image1[0, 0] = new Pixel(0, 0, 1);
            image1[0, 1] = new Pixel(0, 1, 1);
            image1[0, 2] = new Pixel(0, 2, 1);
            image1[0, 3] = new Pixel(0, 3, 0);
            image1[0, 4] = new Pixel(0, 4, 0);
            image1[0, 5] = new Pixel(0, 5, 0);

            image1[1, 0] = new Pixel(1, 0, 0);
            image1[1, 1] = new Pixel(1, 1, 0);
            image1[1, 2] = new Pixel(1, 2, 1);
            image1[1, 3] = new Pixel(1, 3, 0);
            image1[1, 4] = new Pixel(1, 4, 0);
            image1[1, 5] = new Pixel(1, 5, 0);

            image1[2, 0] = new Pixel(2, 0, 0);
            image1[2, 1] = new Pixel(2, 1, 0);
            image1[2, 2] = new Pixel(2, 2, 1);
            image1[2, 3] = new Pixel(2, 3, 1);
            image1[2, 4] = new Pixel(2, 4, 1);
            image1[2, 5] = new Pixel(2, 5, 0);

            image1[3, 0] = new Pixel(3, 0, 0);
            image1[3, 1] = new Pixel(3, 1, 0);
            image1[3, 2] = new Pixel(3, 2, 1);
            image1[3, 3] = new Pixel(3, 3, 1);
            image1[3, 4] = new Pixel(3, 4, 1);
            image1[3, 5] = new Pixel(3, 5, 0);

            image1[4, 0] = new Pixel(4, 0, 0);
            image1[4, 1] = new Pixel(4, 1, 0);
            image1[4, 2] = new Pixel(4, 2, 1);
            image1[4, 3] = new Pixel(4, 3, 1);
            image1[4, 4] = new Pixel(4, 4, 0);
            image1[4, 5] = new Pixel(4, 5, 0);

            image1[5, 0] = new Pixel(5, 0, 1);
            image1[5, 1] = new Pixel(5, 1, 1);
            image1[5, 2] = new Pixel(5, 2, 1);
            image1[5, 3] = new Pixel(5, 3, 1);
            image1[5, 4] = new Pixel(5, 4, 0);
            image1[5, 5] = new Pixel(5, 5, 0);
        }
    }
}
