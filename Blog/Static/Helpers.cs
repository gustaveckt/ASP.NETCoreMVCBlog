
using Blog.Models;
using Slugify;

namespace Blog.Static
{
    public static class Helpers
    {
        public static string StringRandom(int length = 4)
        {
            const string chars = "abcdefghijsklmnopqrstuvwxyz0123456789";
            Random random = new();

            return new string(Enumerable.Repeat(chars, length)
                .Select(str => str[random.Next(str.Length)])
                .ToArray());
        }

        public static string Slug(string inputString)
        {
            SlugHelper helper = new();
            return helper.GenerateSlug(inputString);
        }

        public static string UniqSlug(string inputString, int randomLength = 4)
        {
            SlugHelper helper = new();
            return StringRandom(randomLength) + "-" + helper.GenerateSlug(inputString);
        }
    }
}
