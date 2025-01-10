using API_rest.Data; // Agregar punto y coma

namespace API_rest.Services// Corregir el namespace
{
    public class CrewDataStore
    {
        // Propiedad para almacenar los Crews
        public List<ClCrew> Crews { get; set; }

        // Instancia estática para el patrón singleton
        public static CrewDataStore Current { get; } = new CrewDataStore();

        // Constructor
        public CrewDataStore()
        {
            // Inicializar la lista de ClCrew con datos de ejemplo
            Crews = new List<ClCrew>()
            {
                new ClCrew
                {
                    IdCrew_prop = 666,
                    Nickname_prop = "KIDULT",
                    IdWriter_prop ="8"
                },
                new ClCrew
                {
                    IdCrew_prop = 888,
                    Nickname_prop = "OneUpCrew",
                    IdWriter_prop = "710"                
                },
                new ClCrew
                {
                    IdCrew_prop = 999,
                    Nickname_prop = "CMS",
                    IdWriter_prop = "16" 
                }
            };
        }
    }
}
