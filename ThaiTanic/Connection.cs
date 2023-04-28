namespace ThaiTanic
{
    internal class Connection
    {
            public static string HostName = "localhost";
            public static string User = "root";
            public static string Password = "";
            public static int Port = 3306;
            public static string DatabaseName = "thaitanic_db";

            public static string ConnectionString = $"datasource={HostName};username={User};password={Password};port={Port};database={DatabaseName}";
    }
}
