using System;
using System.ComponentModel.DataAnnotations;

namespace do0.Models
{
    public class do0Evento
    {
        [Key]
        [Display(Name="ID")]
        public int do0EventoId { get; set; }
        [Display(Name="RASCUNHO")]
        public bool Rascunho { get; set; }
        [Display(Name="DATA DO CADASTRO")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")] // Para não solicitar hora ..
        // [Displayformat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}" )] // Para o template definido . .
        public DateTime? DataCadastro { get; set; }
        [Display(Name="MEMBRO")]
        public string do0Avatar { get; set; }
        [Display(Name="NOME DO USUÁRIO")]
        public string do0User { get; set; }

        // Relacionamento um para vários . . ( Vários Eventos para cada tipo de homenagem . . )
        //public int do0EventoTipo { get; set; }
        //public virtual do0EventoTipo do0EventoTipos { get; set; }
        public string TipoEvento { get; set; }

        [Display(Name="DATA DO EVENTO")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        // [Displayformat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}" )]
        public DateTime? DataEvento { get; set; }
        [Display(Name="DATA DE NASCIMENTO")]
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        // [Displayformat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}" )]
        public DateTime? DataNascimento { get; set; }
        [Display(Name="NOME COMPLETO")]
        public string NomeCompleto { get; set; }
        [Display(Name="RESPONSÁVEL PELO EVENTO")]
        public string ResponsavelEvento { get; set; }
        [Display(Name="NOME DO HOMENAGEADO")]
        public string NomeHomenageado { get; set; }
        [Display(Name="CPF")]
        //[StringLength(12, ErrorMessage = "Confira os dados !")]
        public string CPF { get; set; }
        //[StringLength(15, ErrorMessage = "Confira os dados !")]
        [Display(Name="IDENTIDADE")]
        public string Identidade { get; set; }
        [Display(Name="ENDEREÇO COMPLETO")]
        public string EnderecoCompleto { get; set; }
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Informe um email válido !")]
        [Display(Name="E-MAIL")]
        public string Email { get; set; }
        [Display(Name="TELEFONE WHATSAPP")]
        public string Telefone { get; set; }
        [Display(Name="TELEFONE2")]
        public string Telefone2 { get; set; }
        [Display(Name="TELEFONE3")]
        public string Telefone3 { get; set; }
        [Display(Name="NOTAS")]
        public string Notas { get; set; }
    }
}