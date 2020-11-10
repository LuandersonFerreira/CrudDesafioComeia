namespace DesafioCrudMvcComeia.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Empresas
    {
        public int Id { get; set; }
        [Display(Name = "Nome Fantasia")]
        public string nome_fantasia { get; set; }
        public string cnpj { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        [Display(Name = "Data do Cadastro")]
        public Nullable<System.DateTime> data_do_cadastro { get; set; }
    }
}
