namespace StartV2.Trenuuri;

public class RouteSearch
{
    public static void SearchRoutes(List<Route> allRoutes, string departureStation, string arrivalStation,
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
                foreach (var directroute in foundRoutes)
                {
                    Console.WriteLine($"Numele rutei este: {route.nameRoute}");
                    Console.WriteLine($"Durata totala a rutei este: {route.Duration}");
                    Console.WriteLine($"Pretul de baza este: {route.Prices} lei");
                    Console.WriteLine($"statiile si programul: ");
                    foreach (var station in route.Stations)
                    {
                        Console.WriteLine(
                            $" {station.Name}-Arrival :{station.ArrivalTime},Departure :{station.DepartureTime}");

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
}