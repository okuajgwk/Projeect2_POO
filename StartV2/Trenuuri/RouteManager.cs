namespace StartV2.Trenuuri;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class RouteManager
{
    // Funcție pt a salva rutele într-un fisier JSON
    public static void SaveRoutesToFile(List<Route> routes, string fileName)
    {
        string json = JsonSerializer.Serialize(routes, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(fileName, json);
    }

    // Funcție pentru a citi rutele din fisier JSON
    public static List<Route> LoadRoutesFromFile(string fileName)
    {
        if (File.Exists(fileName))
        {
            string json = File.ReadAllText(fileName);
            return JsonSerializer.Deserialize<List<Route>>(json);
        }

        return new List<Route>(); // Returnează o listă goală dacă fișierul nu există
    }
}
static void AddRoute(List<Route> routes, List<Station>stations)
{
    // adaug o ruta
    Console.Clear();
    Console.WriteLine("Adăugați o rută:");

    // Detalii rută
    Console.Write("Introduceți numele rutei: ");
    string routeName = Console.ReadLine();
    // Detalii stații
    List<Station> stations = new List<Station>();
    string addStation = "da";
    while (addStation.ToLower() == "da")
    {
        Console.Write("Introduceți numele stației: ");
        string stationName = Console.ReadLine();
        Console.Write("Introduceți ora de sosire (format: yyyy-MM-dd HH:mm): ");
        DateTime arrivalTime = DateTime.Parse(Console.ReadLine());
        Console.Write("Introduceți ora de plecare (format: yyyy-MM-dd HH:mm): ");
        DateTime departureTime = DateTime.Parse(Console.ReadLine());

        var station = new Station(stationName, arrivalTime, departureTime);
        stations.Add(station);

        Console.Write("Doriți să adăugați o altă stație? (da/nu): ");
        addStation = Console.ReadLine();
    }

    Console.Write("Introduceți prețul de bază al rutei: ");
    decimal basePrice = decimal.Parse(Console.ReadLine());

    // creez ruta si o adaug in lista de rute
    var route = new Route(routeName, Tren, basePrice)
    {
        Stations = stations,
        Duration = stations[stations.Count - 1].DepartureTime - stations[0].ArrivalTime
    };

    routes.Add(route);
    Console.WriteLine("Ruta a fost adăugată cu succes.");
    Console.ReadKey();
}
 static void SearchRoutes(List<Route> allRoutes, string departureStation, string arrivalStation,
        bool directRoute)
    {
        var foundRoutes = new List<Route>();
        foreach (var route in allRoutes)
        {
            //caut ruta directa pentru destinatia si locul meu de plecare
            if (directRoute)
            {
                //verific daca ruta contine statiile de plecare si destinatie si daca sunt in ordinea corecta
                if (route.Stations.Any(station => station.Name == departureStation) &&
                    route.Stations.Any(station => station.Name == arrivalStation))
                {
                    int departureIndex = route.Stations.FindIndex(s => s.Name == departureStation);
                    int destinationIndex = route.Stations.FindIndex(s => s.Name == arrivalStation);
                    //verific daca statiile sunt in ordinea corecta
                    if (departureIndex < destinationIndex)
                    {
                        foundRoutes.Add(route);
                    }
                }
            }

            if (foundRoutes.Count > 0)
            {
                foreach (var directrouteRoute in foundRoutes)
                {
                    Console.WriteLine($"Numele rutei este: {route.nameRoute}");
                    Console.WriteLine($"Durata totala a rutei este: {route.Duration}");
                    Console.WriteLine($"Pretul de baza este: {route.Prices} lei");
                    Console.WriteLine($"statiile si programul: ");
                    foreach (var station in route.Stations)
                    {
                        Console.WriteLine(
                            $"  {station.Name}-Arrival :{station.ArrivalTime},Departure :{station.DepartureTime}");

                    }

                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Nu s-au gasit rute pentru criteriile dvs. de cautare!");
            }
        }
    }