using Tuna.Excel.Extensions;

namespace Tuna.Excel.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CreateDocument()
        {

            using (Document document = new Document(@"C:\Users\29135\Desktop\test.xlsx"))
            {
                //document.Sheets.FirstOrDefault((s) => s.Name == "asf");

            }
        }
    }
}