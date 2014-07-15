Rhythm.ImportIPLocationData
===========================

A Windows Forms tool to import IP location data from MaxMind's free GeoLite CSV database into a SQL Server database:

![Client Screenshot](docs/images/client.png?raw=true "Client Screenshot")

Before running this tool, ensure this table exists in your database:

    CREATE TABLE ipLocations
    (
        num_start bigint NOT NULL,
        num_end bigint NOT NULL,
        latitude float NOT NULL,
        longitude float NOT NULL,
        specificity int NOT NULL
    ) ON [PRIMARY]

You can get a value for a specific IP address using this stored procedure (you'll need to do some bit shifting to convert the IP to a number first):

    CREATE PROCEDURE GetCoordinatesForIp
        @ipAddressNum as bigint
    AS
    BEGIN
    SET NOCOUNT ON;
        SELECT TOP 1
            latitude,
            longitude
        FROM ipLocations
        WHERE
            @ipAddressNum >= num_start
            AND @ipAddressNum <= num_end
        ORDER BY
            specificity DESC
    SET NOCOUNT OFF;
    END