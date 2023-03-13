using Microsoft.Data.SqlClient;

namespace CodeScan
{
	public class StuffDoer
	{
        public bool DoSomeStuff(string? id)
        {
            using (SqlCommand command = new())
            {
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "SELECT * FROM SomeTable WHERE Id = " + id; // This should trigger a code scan alert
            }

            return true;
        }
    }
}
