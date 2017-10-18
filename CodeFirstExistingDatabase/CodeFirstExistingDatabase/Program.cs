using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstExistingDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}

//Package Manager Console
/*
PM> enable-migrations
Checking if the context targets an existing database...
Code First Migrations enabled for project CodeFirstExistingDatabase.
PM> add-migration InitialModel
Scaffolding migration 'InitialModel'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration InitialModel' again.
PM> add-migration InitialModel -IgnoreChange -Force
Re-scaffolding migration 'InitialModel'.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702120735024_InitialModel].
Applying explicit migration: 201702120735024_InitialModel.
Running Seed method.
PM> add-migration AddCategoriesTable
Scaffolding migration 'AddCategoriesTable'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration AddCategoriesTable' again.
PM> add-migration AddCategoriesTable -Force
Re-scaffolding migration 'AddCategoriesTable'.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702120740487_AddCategoriesTable].
Applying explicit migration: 201702120740487_AddCategoriesTable.
Running Seed method.
PM> add-migration AddCategoryColumnToCoursesTable
Scaffolding migration 'AddCategoryColumnToCoursesTable'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration AddCategoryColumnToCoursesTable' again.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702120747095_AddCategoryColumnToCoursesTable].
Applying explicit migration: 201702120747095_AddCategoryColumnToCoursesTable.
Running Seed method.
PM> add-migration AddDatePublishedColumnToCoursesTable
Scaffolding migration 'AddDatePublishedColumnToCoursesTable'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration AddDatePublishedColumnToCoursesTable' again.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702120751513_AddDatePublishedColumnToCoursesTable].
Applying explicit migration: 201702120751513_AddDatePublishedColumnToCoursesTable.
Running Seed method.
PM> add-migration RenameTitleToNameInCourseTable
Scaffolding migration 'RenameTitleToNameInCourseTable'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration RenameTitleToNameInCourseTable' again.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702120753342_RenameTitleToNameInCourseTable].
Applying explicit migration: 201702120753342_RenameTitleToNameInCourseTable.
Running Seed method.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
No pending explicit migrations.
Running Seed method.
PM> add-migration DeleteDatePublishedColumnFromCoursesTable
Scaffolding migration 'DeleteDatePublishedColumnFromCoursesTable'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration DeleteDatePublishedColumnFromCoursesTable' again.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702120800084_DeleteDatePublishedColumnFromCoursesTable].
Applying explicit migration: 201702120800084_DeleteDatePublishedColumnFromCoursesTable.
Running Seed method.
PM> add-migration DeleteCategoryColumnFromCourseTable
Scaffolding migration 'DeleteCategoryColumnFromCourseTable'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration DeleteCategoryColumnFromCourseTable' again.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702120808296_DeleteCategoryColumnFromCourseTable].
Applying explicit migration: 201702120808296_DeleteCategoryColumnFromCourseTable.
Running Seed method.
PM> add-migration DeleteCategoriesTable
Scaffolding migration 'DeleteCategoriesTable'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration DeleteCategoriesTable' again.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702120809265_DeleteCategoriesTable].
Applying explicit migration: 201702120809265_DeleteCategoriesTable.
Running Seed method.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
No pending explicit migrations.
Running Seed method.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
No pending explicit migrations.
Running Seed method.
PM> update-database -TargetMigration:DeleteDatePublishedColumnFromCoursesTable
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Reverting migrations: [201702120809265_DeleteCategoriesTable, 201702120808296_DeleteCategoryColumnFromCourseTable].
Reverting explicit migration: 201702120809265_DeleteCategoriesTable.
System.Data.SqlClient.SqlException (0x80131904): Invalid object name '_Categories'.
   at System.Data.SqlClient.SqlConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at System.Data.SqlClient.SqlInternalConnection.OnError(SqlException exception, Boolean breakConnection, Action`1 wrapCloseInAction)
   at System.Data.SqlClient.TdsParser.ThrowExceptionAndWarning(TdsParserStateObject stateObj, Boolean callerHasConnectionLock, Boolean asyncClose)
   at System.Data.SqlClient.TdsParser.TryRun(RunBehavior runBehavior, SqlCommand cmdHandler, SqlDataReader dataStream, BulkCopySimpleResultSet bulkCopyHandler, TdsParserStateObject stateObj, Boolean& dataReady)
   at System.Data.SqlClient.SqlCommand.RunExecuteNonQueryTds(String methodName, Boolean async, Int32 timeout, Boolean asyncWrite)
   at System.Data.SqlClient.SqlCommand.InternalExecuteNonQuery(TaskCompletionSource`1 completion, String methodName, Boolean sendToPipe, Int32 timeout, Boolean& usedCache, Boolean asyncWrite, Boolean inRetry)
   at System.Data.SqlClient.SqlCommand.ExecuteNonQuery()
   at System.Data.Entity.Infrastructure.Interception.DbCommandDispatcher.<NonQuery>b__0(DbCommand t, DbCommandInterceptionContext`1 c)
   at System.Data.Entity.Infrastructure.Interception.InternalDispatcher`1.Dispatch[TTarget,TInterceptionContext,TResult](TTarget target, Func`3 operation, TInterceptionContext interceptionContext, Action`3 executing, Action`3 executed)
   at System.Data.Entity.Infrastructure.Interception.DbCommandDispatcher.NonQuery(DbCommand command, DbCommandInterceptionContext interceptionContext)
   at System.Data.Entity.Internal.InterceptableDbCommand.ExecuteNonQuery()
   at System.Data.Entity.Migrations.DbMigrator.ExecuteSql(MigrationStatement migrationStatement, DbConnection connection, DbTransaction transaction, DbInterceptionContext interceptionContext)
   at System.Data.Entity.Migrations.Infrastructure.MigratorLoggingDecorator.ExecuteSql(MigrationStatement migrationStatement, DbConnection connection, DbTransaction transaction, DbInterceptionContext interceptionContext)
   at System.Data.Entity.Migrations.DbMigrator.ExecuteStatementsInternal(IEnumerable`1 migrationStatements, DbConnection connection, DbTransaction transaction, DbInterceptionContext interceptionContext)
   at System.Data.Entity.Migrations.DbMigrator.ExecuteStatementsWithinTransaction(IEnumerable`1 migrationStatements, DbTransaction transaction, DbInterceptionContext interceptionContext)
   at System.Data.Entity.Migrations.DbMigrator.ExecuteStatementsWithinNewTransaction(IEnumerable`1 migrationStatements, DbConnection connection, DbInterceptionContext interceptionContext)
   at System.Data.Entity.Migrations.DbMigrator.ExecuteStatementsInternal(IEnumerable`1 migrationStatements, DbConnection connection, DbInterceptionContext interceptionContext)
   at System.Data.Entity.Migrations.DbMigrator.ExecuteStatementsInternal(IEnumerable`1 migrationStatements, DbConnection connection)
   at System.Data.Entity.Migrations.DbMigrator.<>c__DisplayClass30.<ExecuteStatements>b__2e()
   at System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy.<>c__DisplayClass1.<Execute>b__0()
   at System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy.Execute[TResult](Func`1 operation)
   at System.Data.Entity.SqlServer.DefaultSqlExecutionStrategy.Execute(Action operation)
   at System.Data.Entity.Migrations.DbMigrator.ExecuteStatements(IEnumerable`1 migrationStatements, DbTransaction existingTransaction)
   at System.Data.Entity.Migrations.DbMigrator.ExecuteStatements(IEnumerable`1 migrationStatements)
   at System.Data.Entity.Migrations.Infrastructure.MigratorBase.ExecuteStatements(IEnumerable`1 migrationStatements)
   at System.Data.Entity.Migrations.DbMigrator.ExecuteOperations(String migrationId, VersionedModel targetModel, IEnumerable`1 operations, IEnumerable`1 systemOperations, Boolean downgrading, Boolean auto)
   at System.Data.Entity.Migrations.DbMigrator.RevertMigration(String migrationId, DbMigration migration, XDocument targetModel)
   at System.Data.Entity.Migrations.Infrastructure.MigratorLoggingDecorator.RevertMigration(String migrationId, DbMigration migration, XDocument targetModel)
   at System.Data.Entity.Migrations.DbMigrator.Downgrade(IEnumerable`1 pendingMigrations)
   at System.Data.Entity.Migrations.Infrastructure.MigratorLoggingDecorator.Downgrade(IEnumerable`1 pendingMigrations)
   at System.Data.Entity.Migrations.DbMigrator.UpdateInternal(String targetMigration)
   at System.Data.Entity.Migrations.DbMigrator.<>c__DisplayClassc.<Update>b__b()
   at System.Data.Entity.Migrations.DbMigrator.EnsureDatabaseExists(Action mustSucceedToKeepDatabase)
   at System.Data.Entity.Migrations.Infrastructure.MigratorBase.EnsureDatabaseExists(Action mustSucceedToKeepDatabase)
   at System.Data.Entity.Migrations.DbMigrator.Update(String targetMigration)
   at System.Data.Entity.Migrations.Infrastructure.MigratorBase.Update(String targetMigration)
   at System.Data.Entity.Migrations.Design.ToolingFacade.UpdateRunner.Run()
   at System.AppDomain.DoCallBack(CrossAppDomainDelegate callBackDelegate)
   at System.AppDomain.DoCallBack(CrossAppDomainDelegate callBackDelegate)
   at System.Data.Entity.Migrations.Design.ToolingFacade.Run(BaseRunner runner)
   at System.Data.Entity.Migrations.Design.ToolingFacade.Update(String targetMigration, Boolean force)
   at System.Data.Entity.Migrations.UpdateDatabaseCommand.<>c__DisplayClass2.<.ctor>b__0()
   at System.Data.Entity.Migrations.MigrationsDomainCommand.Execute(Action command)
ClientConnectionId:55e1284b-f55a-429f-ab04-580c91f20bff
Error Number:208,State:1,Class:16
Invalid object name '_Categories'.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
No pending explicit migrations.
Running Seed method.
PM> add-migration PopulateCategoriesTable
Scaffolding migration 'PopulateCategoriesTable'.
The Designer Code for this migration file includes a snapshot of your current Code First model. This snapshot is used to calculate the changes to your model when you scaffold the next migration. If you make additional changes to your model that you want to include in this migration, then you can re-scaffold it by running 'Add-Migration PopulateCategoriesTable' again.
PM> update-database
Specify the '-Verbose' flag to view the SQL statements being applied to the target database.
Applying explicit migrations: [201702120827484_PopulateCategoriesTable].
Applying explicit migration: 201702120827484_PopulateCategoriesTable.
Running Seed method.
*/