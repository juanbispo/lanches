using System.ComponentModel.DataAnnotations;

namespace LanchesMac.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="Informe o Nome")]
        [Display(Name ="Usuário")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Informe a Senha")]
        [Display(Name ="Senha")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
    }
}
