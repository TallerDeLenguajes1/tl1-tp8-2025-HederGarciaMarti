namespace Distribuidora
{
    public class Tarea
    {
        private int tareaId;
        private string descripcion;
        private int duracion;
        public Tarea() { }

        public Tarea(int tareaId, string descripcion, int duracion)
        {
            this.tareaId = tareaId;
            this.descripcion = descripcion;
            this.duracion = duracion;
        }

        public int TareaId { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public int GetTarea()
        {
            return tareaId;
        }
         public int GetDuracion()
        {
            return duracion;
        }
        public string GetDescripcion()
        {
            return descripcion;
        }
    }
    
}