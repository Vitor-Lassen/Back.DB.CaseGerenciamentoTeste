namespace Back.DB.CaseGerenciamentoTeste.Models
{
    public class Caso
    {
        public string nome_caso { get; set; }
        public string precond_caso { get; set; }
        public string massadados_caso { get; set; }
        public string resultadoesp_caso { get; set; }
        public string resultadoobt_caso { get; set; }
        public int cod_cen_caso { get; set; }
        public int cod_def_caso { get; set; }
        public int cod_status_caso { get; set; }
        public int cod_usu_caso { get; set; }
        public string motivo_bloq { get; set; }
        public int cod_caso { get; set; }

    }
}