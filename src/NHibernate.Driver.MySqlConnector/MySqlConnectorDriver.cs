using System;
using System.Data.Common;

using MySqlConnector;

using NHibernate.AdoNet;
using NHibernate.Engine;

namespace NHibernate.Driver.MySqlConnector
{
    /// <summary>
    /// Provides a database driver for MySQL using <a href="https://mysqlconnector.net/">MySqlConnector</a>.
    /// </summary>
    /// <remarks>
    /// Uses <see cref="GenericBatchingBatcherFactory"/> for batching.
    /// </remarks>
    public class MySqlConnectorDriver : DriverBase, IEmbeddedBatcherFactoryProvider
    {
        public override bool UseNamedPrefixInSql => true;

        public override bool UseNamedPrefixInParameter => true;

        public override string NamedPrefix => "@";

        public override bool SupportsMultipleQueries => true;

        public override bool SupportsMultipleOpenReaders => false;

        /// <summary>
        /// MySqlConnector prepares commands if <b>IgnorePrepare</b> is set to false in the connection string (default is true),
        /// otherwise calling <see cref="MySqlCommand.Prepare"/> is a no-op.
        /// </summary>
        protected override bool SupportsPreparingCommands => true;

        public override DbConnection CreateConnection() => new MySqlConnection();

        public override DbCommand CreateCommand() => new MySqlCommand();

        public override IResultSetsCommand GetResultSetsCommand(ISessionImplementor session) => new BasicResultSetsCommand(session);

        // As of v5.7, lower dates may "work" but without guarantees.
        // https://dev.mysql.com/doc/refman/5.7/en/datetime.html
        /// <inheritdoc />
        public override DateTime MinDate => new DateTime(1000, 1, 1);
        
        public System.Type BatcherFactoryClass => typeof(GenericBatchingBatcherFactory);
    }
}
