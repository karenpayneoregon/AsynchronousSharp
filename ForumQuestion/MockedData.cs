using System.Data;

namespace ForumQuestion
{
    public class MockedData
    {
        public static DataTable EmployeeDataTable()
        {
            var dt = new DataTable();

            dt.Columns.Add(new DataColumn()
            {
                ColumnName = "Id",
                DataType = typeof(int),
                AutoIncrement = true,
                AutoIncrementSeed = 1
            });

            dt.Columns.Add(new DataColumn() { ColumnName = "EmpNo",
                DataType = typeof(string) });
            dt.Columns.Add(new DataColumn() { ColumnName = "Section",
                DataType = typeof(string) });
            dt.Columns.Add(new DataColumn() { ColumnName = "Study1",
                DataType = typeof(string) });
            dt.Columns.Add(new DataColumn() { ColumnName = "Study2",
                DataType = typeof(string) });
            dt.Columns.Add(new DataColumn() { ColumnName = "Study3",
                DataType = typeof(string) });

            dt.Rows.Add(null, "E101", "ABC", "GOOD", "EXCEL", "NORMAL");
            dt.Rows.Add(null, "E102", "DEF", "NORMAL", "EXCEL","NORMAL");
            dt.Rows.Add(null, "E103", "GHI", "GOOD", "EXCEL","NORMAL");
            dt.Rows.Add(null, "E104", "JKL", "EXCEL", "EXCEL","NORMAL");
            dt.Rows.Add(null, "", "MNO", "EXCEL", "GOOD","GOOD");
            dt.Rows.Add(null, "", "ZML", "GOOD", "GOOD","GOOD");

            return dt;
        }
    }
}
