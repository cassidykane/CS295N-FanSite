IF OBJECT_ID(N'__EFMigrationsHistory') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181114032021_Initial')
BEGIN
    CREATE TABLE [PrintSources] (
        [PrintSourceID] int NOT NULL IDENTITY,
        [Author] nvarchar(max) NULL,
        [Title] nvarchar(max) NULL,
        CONSTRAINT [PK_PrintSources] PRIMARY KEY ([PrintSourceID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181114032021_Initial')
BEGIN
    CREATE TABLE [Stories] (
        [StoryID] int NOT NULL IDENTITY,
        [Date] datetime2 NOT NULL,
        [StoryText] nvarchar(max) NOT NULL,
        [Title] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Stories] PRIMARY KEY ([StoryID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181114032021_Initial')
BEGIN
    CREATE TABLE [WebSources] (
        [WebSourceID] int NOT NULL IDENTITY,
        [Title] nvarchar(max) NULL,
        [Url] nvarchar(max) NULL,
        CONSTRAINT [PK_WebSources] PRIMARY KEY ([WebSourceID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181114032021_Initial')
BEGIN
    CREATE TABLE [Comments] (
        [CommentID] int NOT NULL IDENTITY,
        [CommentText] nvarchar(max) NULL,
        [StoryID] int NULL,
        CONSTRAINT [PK_Comments] PRIMARY KEY ([CommentID]),
        CONSTRAINT [FK_Comments_Stories_StoryID] FOREIGN KEY ([StoryID]) REFERENCES [Stories] ([StoryID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181114032021_Initial')
BEGIN
    CREATE TABLE [Ratings] (
        [RatingID] int NOT NULL IDENTITY,
        [RatingNumber] int NOT NULL,
        [StoryID] int NULL,
        CONSTRAINT [PK_Ratings] PRIMARY KEY ([RatingID]),
        CONSTRAINT [FK_Ratings_Stories_StoryID] FOREIGN KEY ([StoryID]) REFERENCES [Stories] ([StoryID]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181114032021_Initial')
BEGIN
    CREATE INDEX [IX_Comments_StoryID] ON [Comments] ([StoryID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181114032021_Initial')
BEGIN
    CREATE INDEX [IX_Ratings_StoryID] ON [Ratings] ([StoryID]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20181114032021_Initial')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20181114032021_Initial', N'2.0.1-rtm-125');
END;

GO

