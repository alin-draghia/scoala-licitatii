
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/13/2014 09:58:10
-- Generated from EDMX file: d:\DEV.0\scola-licitatii\LicitatiiDAL\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [licitatii];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Utilizatori'
CREATE TABLE [dbo].[Utilizatori] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(max)  NOT NULL,
    [Prenume] nvarchar(max)  NOT NULL,
    [Username] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Produse'
CREATE TABLE [dbo].[Produse] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nume] nvarchar(max)  NOT NULL,
    [Descriere] nvarchar(max)  NULL,
    [PretDeInceput] decimal(18,0)  NOT NULL,
    [PretLicitat] decimal(18,0)  NULL,
    [DataDeInceput] datetime  NOT NULL,
    [DataDeSfarsit] datetime  NOT NULL,
    [VanzatorId] int  NULL,
    [CumparatorId] int  NULL
);
GO

-- Creating table 'Utilizatori_Vanzator'
CREATE TABLE [dbo].[Utilizatori_Vanzator] (
    [Adresa] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Utilizatori_Cumparator'
CREATE TABLE [dbo].[Utilizatori_Cumparator] (
    [CNP] nvarchar(max)  NOT NULL,
    [Telefon] nvarchar(max)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Utilizatori'
ALTER TABLE [dbo].[Utilizatori]
ADD CONSTRAINT [PK_Utilizatori]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Produse'
ALTER TABLE [dbo].[Produse]
ADD CONSTRAINT [PK_Produse]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Utilizatori_Vanzator'
ALTER TABLE [dbo].[Utilizatori_Vanzator]
ADD CONSTRAINT [PK_Utilizatori_Vanzator]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Utilizatori_Cumparator'
ALTER TABLE [dbo].[Utilizatori_Cumparator]
ADD CONSTRAINT [PK_Utilizatori_Cumparator]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [VanzatorId] in table 'Produse'
ALTER TABLE [dbo].[Produse]
ADD CONSTRAINT [FK_VanzatorProdus]
    FOREIGN KEY ([VanzatorId])
    REFERENCES [dbo].[Utilizatori_Vanzator]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VanzatorProdus'
CREATE INDEX [IX_FK_VanzatorProdus]
ON [dbo].[Produse]
    ([VanzatorId]);
GO

-- Creating foreign key on [CumparatorId] in table 'Produse'
ALTER TABLE [dbo].[Produse]
ADD CONSTRAINT [FK_CumparatorProdus]
    FOREIGN KEY ([CumparatorId])
    REFERENCES [dbo].[Utilizatori_Cumparator]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_CumparatorProdus'
CREATE INDEX [IX_FK_CumparatorProdus]
ON [dbo].[Produse]
    ([CumparatorId]);
GO

-- Creating foreign key on [Id] in table 'Utilizatori_Vanzator'
ALTER TABLE [dbo].[Utilizatori_Vanzator]
ADD CONSTRAINT [FK_Vanzator_inherits_Utilizator]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Utilizatori]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Utilizatori_Cumparator'
ALTER TABLE [dbo].[Utilizatori_Cumparator]
ADD CONSTRAINT [FK_Cumparator_inherits_Utilizator]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Utilizatori]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------