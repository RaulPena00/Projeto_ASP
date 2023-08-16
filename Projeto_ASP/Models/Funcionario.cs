namespace Projeto_ASP.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Foto { get; set; } // REVISAR
        public int RG { get; set; }
        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }

    }
}
