
namespace CoolSmFramework.CoolSeleniumFramework.Utils
{
    public static class GetRandom
    {
        public static string Text()
        {
            var arr = File.ReadAllText(Directories.ResourcesDirectory + "/Names.txt").Split(",");
            string res = arr[new Random().Next(0, arr.Length)];
            return res;
        }
    }
}
