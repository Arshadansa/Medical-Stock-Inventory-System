CREATE TABLE medicne (
    [Medicine Id]   NVARCHAR (50)   NOT NULL,
    [Medicine Name] NVARCHAR (50)   NOT NULL,
    [Cost Price]    NUMERIC (18, 2) NOT NULL,
    [Sale Price]    NUMERIC (18, 2) NOT NULL,
    [Quantity]      INT             NOT NULL,
    [Company]       NVARCHAR (50)   NOT NULL,
    [Exp Date]      DATETIME        NOT NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([Medicine Id] ASC)
);

