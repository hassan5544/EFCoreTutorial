using System.ComponentModel.DataAnnotations;

namespace EFCoreTutorial.Models;

public class Patients : BaseEntity<Guid>
{
    public string Name { get; set; }
    public DateTime BirthDate { get; set; }
    public List<Tests> TestsList { get; set; }
}