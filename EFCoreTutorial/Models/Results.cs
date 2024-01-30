using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTutorial.Models;

public class Results : BaseEntity<Guid>
{
    public Guid TestId { get; set; }
    public bool IsBad { get; set; }
    
}