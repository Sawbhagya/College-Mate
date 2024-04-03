CREATE TABLE [new_event] (
    [id]            INT           IDENTITY (1, 1) NOT NULL,
	[Name]          VARCHAR (50)  NOT NULL,
    [Date]          VARCHAR (50)  NOT NULL,
    [Type_of_Event] VARCHAR (50)  NOT NULL,
    [Description]   VARCHAR (MAX) NOT NULL,
    [Deadline] int,
    CONSTRAINT [PK_new_event] PRIMARY KEY CLUSTERED ([id] ASC)
);

