using System;
using NHibernate.Cfg.Loquacious;
using NHibernate.Driver.MySqlConnector;

// ReSharper disable once CheckNamespace
namespace NHibernate.Cfg
{
    public static class ConnectionConfigurationExtensionMySqlConnector
    {
        [Obsolete("Use config classes directly. Since NHibernate 5.3")]
        public static void MySqlConnectorDriver(this IDbIntegrationConfigurationProperties cfg) => cfg.Driver<MySqlConnectorDriver>();
    }
}