using System.Data;

namespace GestionDeTareas.Controllers
{
    public class Tareas
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DataSetDateTime CreateDate { get; set; }

    }
}
