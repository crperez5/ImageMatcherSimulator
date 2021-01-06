using Newtonsoft.Json;
using System;

namespace ImageMatcherSimulator
{
    public class Pixel : IEquatable<Pixel>
    {
        [JsonProperty("X")]
        public int CoordX { get; set; }

        [JsonProperty("Y")]
        public int CoordY { get; set; }

        [JsonIgnore]
        public int Content { get; set; }

        public Pixel(int x, int y, int content)
        {
            CoordX = x;
            CoordY = y;
            Content = content;
        }

        public override string ToString()
        {
            return $"({CoordX}, {CoordY})";
        }

        public bool Equals(Pixel other)
        {
            if (other == null)
                return false;

            if (this.CoordX == other.CoordX && this.CoordY == other.CoordY)
                return true;
            else
                return false;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Pixel personObj = obj as Pixel;
            if (personObj == null)
                return false;
            else
                return Equals(personObj);
        }

        public override int GetHashCode()
        {
            return this.CoordX.GetHashCode() + this.CoordY.GetHashCode();
        }
    }
}
