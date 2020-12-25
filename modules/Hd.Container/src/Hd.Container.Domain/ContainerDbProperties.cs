namespace Hd.Container
{
    public static class ContainerDbProperties
    {
        public static string DbTablePrefix { get; set; } = "Container";

        public static string DbSchema { get; set; } = null;

        public const string ConnectionStringName = "Container";
    }
}
