using System.ComponentModel.DataAnnotations;

namespace T1_Roman_Oscar.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public string Tema { get; set; }
        public string Editorial { get; set; }
        public int AnioPublicacion { get; set; }
        public int Paginas {  get; set; }
        public string Categoria { get; set; }
        public string Material {  get; set; }
        public int Copias { get; set; }
    }
}
