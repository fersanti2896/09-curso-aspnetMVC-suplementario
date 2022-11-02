namespace ManejoPresupuesto.Models {
    public class PaginacionModel {
        public int Pagina { get; set; } = 1;

        public int DatosPaginas = 5;

        private readonly int cantidadMaxDatosPagina = 50;

        public int RegistrosPorPagina {
            get { return DatosPaginas; }
            set { DatosPaginas = (value > cantidadMaxDatosPagina) ? cantidadMaxDatosPagina : value;  } 
        }

        public int RegistrosASaltar => DatosPaginas * (Pagina - 1);
    }
}
