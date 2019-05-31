CREATE DATABASE AirportInfo

CREATE TABLE [dbo].[DepartureBoard](
[FlightNumber] [char](20) NOT NULL,
[From] [char](100)NOT NULL,
[To] [char](100) NOT NULL,
[DepartureDate] [datetimeoffset] NOT NULL,
[ArrivalDate] [datetimeoffset] NOT NULL,
[FlightTime][char](20) NOT NULL,
[Airline][char](50)NOT NULL,
[AirplaneModel][char](20) NOT NULL
)

INSERT INTO [dbo].[DepartureBoard](
[FlightNumber],
[From],
[To] ,
[DepartureDate],
[ArrivalDate],
[FlightTime],
[Airline],
[AirplaneModel])
VALUES ('123M','Berlin,Germany','Moscow,Russia','2019-06-01 13:00:00','2019-06-01 18:25:00','3h25m','Aeroflot','Boeing-737' ),
('126F','Moscow,Russia','Omsk,Russia','2019-07-10 00:30:00','2019-07-10 6:30:00','4h0m','S7','Boeing-737' )

SELECT * FROM [dbo].[DepartureBoard]


