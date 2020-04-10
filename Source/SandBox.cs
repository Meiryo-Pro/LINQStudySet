using System;
using System.Linq;

namespace Test.LINQ
{
    class SandBox
    {
        public static void Main(string[] args)
        {
            var sfcSoftTable = new SfcSoftTable();
            var softTitles = from val in sfcSoftTable.GetSoftTable()
                             where val.Title.StartsWith("ドラえもん")
                             select val.Title;

            foreach (var title in softTitles)
            {
                Console.WriteLine(title);
            }
        }

    }
}
