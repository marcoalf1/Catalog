namespace Catalog.Settings{
    public class MongoDBSettings
    {
        public string? HostName { get; set; }
        public int Port { get; set; }


        public string ConnectionString 
        { 
            get
            {
                return $"mongodb://{HostName}:{Port}";
            } 
        }
    }
}