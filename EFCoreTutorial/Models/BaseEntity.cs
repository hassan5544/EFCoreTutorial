using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreTutorial.Models;

public class BaseEntity<T>
{
    [Key] 
    public T Id { get; set; }
    public DateTime CreateDate { get; set; } = DateTime.Now;
    public int InsertUserId { get; set; }

    public DateTime UpdateDate { get; set; } = DateTime.Now;
    public int UpdateUserId { get; set; }
}