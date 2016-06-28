USE master
GO

IF (NOT EXISTS (SELECT 1 FROM master.dbo.sysdatabases WHERE name = 'SkateOne' ))
BEGIN
     CREATE DATABASE SkateOne
END
GO

USE SkateOne
GO

IF (NOT EXISTS (SELECT 1 FROM sys.syslogins where name = 'SkateU'))
BEGIN
     CREATE LOGIN SkateU WITH 
            PASSWORD = 'hellspawn',
            DEFAULT_DATABASE = SkateOne , 
            CHECK_EXPIRATION = OFF , 
            CHECK_POLICY = OFF;
END

IF (NOT EXISTS (SELECT 1 FROM sys.syslogins where name = 'SkateReportU'))
BEGIN
     CREATE LOGIN SkateReportU WITH 
            PASSWORD = 'hellspawn', 
            DEFAULT_DATABASE = SkateOne , 
            CHECK_EXPIRATION = OFF, 
            CHECK_POLICY =OFF;
END

IF (NOT EXISTS (SELECT 1 FROM SkateOne.sys.database_principals where name = 'SkateU' ))
BEGIN
     CREATE USER SkateU FOR LOGIN SkateU WITH DEFAULT_SCHEMA = Skate ;
END

IF (NOT EXISTS (SELECT 1 FROM SkateOne.sys.database_principals where name = 'SkateReportU' ))
BEGIN
     CREATE USER SkateReportU FOR LOGIN SkateReportU WITH DEFAULT_SCHEMA = Report ;
END
GO

IF NOT EXISTS ( SELECT 1 FROM sys.schemas WHERE name = 'Skate')
BEGIN
     EXEC('CREATE SCHEMA Skate');
END

IF NOT EXISTS ( SELECT 1 FROM sys.schemas WHERE name = 'Report')
BEGIN
     EXEC('CREATE SCHEMA Report');
END

GRANT SELECT ON SCHEMA ::Skate TO SkateU
GRANT SELECT ON SCHEMA ::Report TO SkateReportU
