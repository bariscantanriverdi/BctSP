namespace BctSP
{
    public class BctSpOptions
    {
        /// <summary>
        /// Database connection string directly or configuration path to connection string.
        /// </summary>
        public string BctSpConnectionStringOrConfigurationPath { get; set; }

        /// <summary>
        /// Database type.
        /// </summary>
        public BctSpDatabaseType? DatabaseType { get; set; }
    }
}