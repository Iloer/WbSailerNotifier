namespace WbSailerNotifier.Configurations
{
    public class DataBaseConfiguration
    {
        public string DbUserName { get; set; }
        public string DbPassword { get; set; }
        public string DbConnection { get; set; }

        public string FullConnectionString
            => MergeWithDelimiter(MergeWithDelimiter(DbConnection, $"Username={DbUserName}", ';'),
                $"Password={DbPassword}", ';');

        private string MergeWithDelimiter(string one, string another, char delimiter)
        {
            if (string.IsNullOrEmpty(one))
            {
                return another;
            }
            if (string.IsNullOrEmpty(another))
            {
                return one;
            }
            return $"{one.TrimEnd(delimiter)}{delimiter}{another.TrimStart(delimiter)}";
        }
    }
}
