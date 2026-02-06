using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace workshop.Pages;

public class ContactModel : PageModel
{
    [BindProperty]
    public ContactForm Input { get; set; } = new();

    public bool IsSubmitted { get; private set; }

    public List<SelectListItem> Interests { get; } = new()
    {
        new SelectListItem("Discovery e estrategia", "Discovery"),
        new SelectListItem("Squad dedicado", "Squad"),
        new SelectListItem("Modernizacao de sistemas", "Modernizacao"),
        new SelectListItem("Sustentacao e evolucao", "Sustentacao")
    };

    public void OnGet()
    {
        IsSubmitted = false;
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        IsSubmitted = true;
        ModelState.Clear();
        Input = new ContactForm();

        return Page();
    }

    public class ContactForm
    {
        [Required(ErrorMessage = "Informe seu nome.")]
        [StringLength(80, ErrorMessage = "Use ate 80 caracteres.")]
        [Display(Name = "Nome completo")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe seu email.")]
        [EmailAddress(ErrorMessage = "Use um email valido.")]
        [Display(Name = "Email corporativo")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Informe a empresa.")]
        [StringLength(80, ErrorMessage = "Use ate 80 caracteres.")]
        [Display(Name = "Empresa")]
        public string Company { get; set; } = string.Empty;

        [StringLength(80, ErrorMessage = "Use ate 80 caracteres.")]
        [Display(Name = "Cargo")]
        public string? Role { get; set; }

        [Phone(ErrorMessage = "Informe um telefone valido.")]
        [Display(Name = "Telefone")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Selecione o tipo de demanda.")]
        [Display(Name = "Interesse")]
        public string Interest { get; set; } = string.Empty;

        [Required(ErrorMessage = "Descreva o desafio.")]
        [StringLength(1000, ErrorMessage = "Use ate 1000 caracteres.")]
        [Display(Name = "Mensagem")]
        public string Message { get; set; } = string.Empty;
    }
}
