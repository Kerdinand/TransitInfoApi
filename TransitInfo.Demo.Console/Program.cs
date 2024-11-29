// See https://aka.ms/new-console-template for more information

using TransitInfo.Data.Gtfs.IO;
using TransitInfo.Data.Gtfs.Structs;
using TransitInfo.GtfsReader.Lib;

Console.WriteLine(new Reader().Read<Agency>("I:\\Projects\\TransitInfo\\GtfsData\\HVV\\agency.txt").Count);

new GeoJsonBuilder().SaveShapeJsonToFile("I:\\Projects\\TransitInfo\\GtfsData\\HVV\\shapes.txt", "I:\\Projects\\TransitInfo\\GtfsData\\HVV\\shapes.json");