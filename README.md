# NHibernate.MySqlConnector

# Description

This package provides an alternative MySql/MariaDB driver for NHibernate
in addition to `NHibernate.Driver.MySqlDataDriver` provided by `nhibernate-core`.

It uses the [MySqlConnector](https://github.com/mysql-net/MySqlConnector) library
which is an alternative to [MySql.Data](https://www.nuget.org/packages/MySql.Data/) 
that may be more performant in async-heavy workloads.

## Usage

Set `connection.driver_class` in you NHibernate session factory config to:

 - `connection.driver_class`: `NHibernate.MySqlConnector.Driver.MySqlConnectorDriver, NHibernate.MySqlConnector` 

Values of the other parameters should stay the same as when using `MySql.Data`:

 - `connection.provider`: `NHibernate.Connection.DriverConnectionProvider`

 - `dialect`: `NHibernate.Dialect.MySQL5Dialect`
