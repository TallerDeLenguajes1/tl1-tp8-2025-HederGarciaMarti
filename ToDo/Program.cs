using Distribuidora;
internal class Program
{
    private static void Main(string[] args)
    {
        int cantidadTareas, n = 1;

        List<Tarea> tareasPendientes = [];
        List<Tarea> tareasRealizadas = new List<Tarea>();

        Console.WriteLine("Ingrese la cantidad de tareas a realizar");
        string entrada = Console.ReadLine();
        bool valides = int.TryParse(entrada, out cantidadTareas);

        if (valides)
        {
            CargarDatos(cantidadTareas, tareasPendientes);
        }
        else
        {
            Console.WriteLine("Error, no ingreso un numero");
        }
        while (n == 1)
        {
            Console.WriteLine("Presione 1 para mover tarea de pendiente a realizada");
            Console.WriteLine("Presione 2 para buscar tarea por palabraClave");
            Console.WriteLine("Presione 3 para mostrar la cantidad de tareas en una lista");
            Console.WriteLine("Presione 4 para mostrar ambas listas");
            string respuesta = Console.ReadLine();
            bool verdadero = int.TryParse(respuesta, out int n_1);
            if (verdadero)
            {
                switch (n_1)
                {
                    case 1:
                        Console.WriteLine("Ingrese el id de la tarea que desea marcar como realizada");
                        string entrada1 = Console.ReadLine();
                        bool valides1 = int.TryParse(entrada1, out int id);
                        if (valides1)
                        {
                            var tarea = tareasPendientes.Find(t => t.TareaId == id);
                            if (tarea != null)
                            {
                                tareasPendientes.Remove(tarea);
                                tareasRealizadas.Add(tarea);
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese la palabra de la tarea que desea buscar: ");
                        string palabra = Console.ReadLine();
                        EncontrarTarea(tareasPendientes,tareasRealizadas, palabra);
                        break;
                    case 3:
                        Console.WriteLine("Que tarea desea ver la cantidad: ");
                        Console.WriteLine("Presione 1 para Tareas Pendiente || Presione 2 para Tareas Realizas");
                        string entrada2 = Console.ReadLine();
                        int numeroT = int.Parse(entrada2);
                        if (numeroT == 1)
                        {
                            Console.WriteLine("Cantidad de tareas en la lista: " + tareasPendientes.Count);
                        }
                        else
                        {
                            Console.WriteLine("Cantidad de tareas en la lista: " + tareasRealizadas.Count);
                        }
                        break;
                    case 4:
                        MostrarTarea(tareasPendientes, "Pendientes");
                        MostrarTarea(tareasRealizadas, "Realizadas");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
            Console.WriteLine("Presione 1 para realizar otra operacion || 0 para salir");
            string valor = Console.ReadLine();
            n = int.Parse(valor);
        }
    }


    private static void EncontrarTarea(List<Tarea> tareas, List<Tarea> tareas2, string palabra)
    {
        var buscarTarea = tareas.Find(t => t.Descripcion == palabra);
        if (buscarTarea == null)
        {
            buscarTarea = tareas2.Find(t => t.Descripcion == palabra);
        }
        if (buscarTarea != null)
        {
            Console.WriteLine("Tarea encontrada:");
            Console.WriteLine($"Id de la tarea: {buscarTarea.TareaId}");
            Console.WriteLine($"Descripcion de la tarea: {buscarTarea.Descripcion}");
            Console.WriteLine($"Duracion de la tarea: {buscarTarea.Duracion}");
        }else
        {
            Console.WriteLine("Tarea no encontrada en ninguna lista");
        }
    }

    private static void MostrarTarea(List<Tarea> tareas, string nombre)
    {
        foreach (var item in tareas)
        {
            Console.WriteLine($"Lista de Tareas: {nombre}");
            Console.WriteLine($"Id de la tarea: {item.TareaId}");
            Console.WriteLine($"Descripcion de la tarea: {item.Descripcion}");
            Console.WriteLine($"Duracion de la tarea: {item.Duracion}");
            Console.WriteLine(" ");
        }
    }

    private static void CargarDatos(int cantidadTareas, List<Tarea> tareasPendientes)
    {
        Random rand = new Random();
        for (int i = 0; i < cantidadTareas; i++)
        {
            Console.WriteLine($"Ingrese la descripcion de la tarea numero {i + 1}");
            string descripcion = Console.ReadLine();
            int duracion = rand.Next(10, 100);
            Tarea NuevaTarea = new Tarea
            {
                TareaId = i + 1,
                Descripcion = descripcion,
                Duracion = duracion,
            };
            tareasPendientes.Add(NuevaTarea);
        }
    }
}