using System.ComponentModel.DataAnnotations;

namespace cp2_advanced_business_.net.Models
{
    public class Animal
    {
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Especie { get; set; }

        public string Raca { get; set; }

        public int Idade { get; set; }

        public double Peso { get; set; }

        [Required]
        public string NomeTutor { get; set; }

        [Required]
        public string TelefoneTutor { get; set; }

        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}