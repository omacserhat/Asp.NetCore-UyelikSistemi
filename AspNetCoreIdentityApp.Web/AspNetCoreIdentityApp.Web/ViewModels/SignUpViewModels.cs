using System.ComponentModel.DataAnnotations;

namespace AspNetCoreIdentityApp.Web.ViewModels;

public class SignUpViewModels
{
    [Display(Name = "Kullanıcı Adı :")]
    public string UserName { get; set; }

    [Display(Name = "Email :")]
    public string Email { get; set; }

    [Display(Name = "Telefon :")]
    public string Phone { get; set; }

    [Display(Name = "Şifre :")]
    public string Password { get; set; }

    [Display(Name = "Şifre Tekrar :")]
    public string PasswordConfirm { get; set; }

    public SignUpViewModels(string userName, string email, string phone, string password, string passwordConfirm)
    {
        UserName = userName;
        Email = email;
        Phone = phone;
        Password = password;
        PasswordConfirm = passwordConfirm;
    }
}