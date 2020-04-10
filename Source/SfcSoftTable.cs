namespace Test.LINQ
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;
    class SfcSoftTable
    {
        private List<SfcSoftData> softTable;
        public SfcSoftTable()
        {
            softTable = new List<SfcSoftData>();
            softTable = CreateTable();
        }

        public List<SfcSoftData> GetSoftTable()
        {
            return this.softTable;
        }
        public List<SfcSoftData> CreateTable()
        {
            var softTable = new List<SfcSoftData>();
            using (var reader = new StreamReader(@"c:\test\NSFData.csv"))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    string[] data = reader.ReadLine().Split("\t");
                    softTable.Add(new SfcSoftData
                    {
                        Id = int.Parse(data[0]),
                        ReleaseDate = DateTime.Parse(data[1]),
                        Title = data[2],
                        Maker = data[3],
                        Price = int.Parse(data[4]),
                    });
                }
            }

            return softTable;
        }
    }
}