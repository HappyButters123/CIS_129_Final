CREATE TABLE [dbo].[Table] (
    [UnitId]           INT DEFAULT ((0)) NOT NULL,
    [PowerInKilowattHoursPerMonth]      INT DEFAULT ((0)) NOT NULL,
    [PowerInKilowattHoursPerDay]      INT DEFAULT ((0)) NOT NULL,
    [AreaInSquareFeet] INT DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([UnitId] ASC)
);

