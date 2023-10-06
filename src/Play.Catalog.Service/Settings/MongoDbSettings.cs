namespace Play.Catalog.Service.Settings
{
    public class MongoDbSettings
    {
        public required string  Host{get;init;}
        public int Port{get;init;}

        public string DatabaseName=>$"Catalog";

        public string ConnectionString => $"mongodb://{Host}:{Port}";

    }
}