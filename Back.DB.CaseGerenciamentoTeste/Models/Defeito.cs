namespace Back.DB.CaseGerenciamentoTeste.Models
{
    public class Defeito
    {
        public int cod_def { get; set; }
        public string assunto_def { get; set; }
        public string descri_def { get; set; }
        public string titulo_def { get; set; }
        public int gravidade_def { get; set; }
        public int cod_status_def { get; set; }
    }
}