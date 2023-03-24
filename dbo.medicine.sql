CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Medicine Id] NCHAR(40) NOT NULL, 
    [Medicine Name] NCHAR(40) NOT NULL, 
    [Cost Price] NUMERIC(18, 2) NOT NULL, 
    [Sale Price] NUMERIC(18, 2) NOT NULL, 
    [Quantity] INT NOT NULL, 
    [Company] NCHAR(40) NOT NULL, 
    [Exp Date] DATE NULL
);


