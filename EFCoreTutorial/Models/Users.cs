using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models;

public class Users : BaseEntity<int>
{
    public string UserName { get; set; } = "";
    public string Password { get; set; } = "";
}