namespace ManejoPresupuesto.Models {
    public class PaginacionRespuestaModel {
        public int Pagina { get; set; } = 1;
        public int RegistrosPorPagina { get; set; } = 5;
        public int CantidadTotalRegistros { get; set; }
        public int CantidadTotalPaginas => (int)Math.Ceiling((double)CantidadTotalRegistros / RegistrosPorPagina);
        public string BaseURL { get; set; }
    }

    /* Génerico */
    public class PaginacionRespuesta<T> : PaginacionRespuestaModel {
        public IEnumerable<T> Elementos { get; set; }
    }
}
