using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TodoListAsp.Models
{
    public class Todo
    {
        public int Id { get; set; }

        [DisplayName("Título")]
        [Required(ErrorMessage = "Campo obrigatório")]
        public string Titulo { get; set; }

        [DisplayName("Status")]
        public bool Concluido { get; set; }

        [DisplayName("Data de criação")]
        public DateTime CriadoEm { get; set; } = DateTime.Now;

        [DisplayName("Última atualização")]
        public DateTime UltimaAtualizacao { get; set; } = DateTime.Now;

        [DisplayName("Usuário")]
        public int Usuario { get; set; }
    }
}