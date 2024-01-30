using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTutorial.Models;

public class Tests : BaseEntity<Guid>
{
    public string TestName { get; set; } = "";
    [ForeignKey("PatientId")]
    public Patients Patient { get; set; }

    public Guid PatientId { get; set; }
    public decimal Price { get; set; }
}