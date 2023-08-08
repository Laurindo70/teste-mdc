namespace TestMDC.Endpoints.Exercise5
{
    public class TableEndpoint : ITableEndpoint
    {
        public List<int> GerateTable(int Number)
        {
            List<int> table = new List<int>();

            for (int i = 1 ; i <= 10; i++)
            {
                table.Add(i*Number);
            }

            return table;
        }
    }
}
