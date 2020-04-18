using NHibernate.Cfg.Loquacious;
using NHibernate.Driver.MySqlConnector;

namespace NHibernate.Cfg
{
    public static class ConnectionConfigurationExtensionMySqlConnector
    {
        public static void MySqlConnectorDriver(this IDbIntegrationConfigurationProperties cfg) => cfg.Driver<MySqlConnectorDriver>();
    }
}