namespace lesson77
{
    /*
     * интерфейсы и полиморфизм
     */

    

   
    public class ConsoleDataProcessor : IDataProcessor
    {
        void IDataProcessor.ProcessData(IDataProvider dataProvider)
        {
            Console.WriteLine(dataProvider.GetData());
        }
    }

    class DbDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из БД";
        }
    }
    class FileDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из файла";
        }
    }
    class APIDataProvider : IDataProvider
    {
        public string GetData()
        {
            return "Данные из API";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IDataProcessor processor = new ConsoleDataProcessor();
            processor.ProcessData(new DbDataProvider());
            processor.ProcessData(new FileDataProvider());
            processor.ProcessData(new APIDataProvider());
        }
    }
}
