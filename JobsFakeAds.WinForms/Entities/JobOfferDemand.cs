using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobsFakeAds.WinForms.Entities;

[Table("JobOfferDemand")]
public class JobOfferDemand
{
    [Key] [Column("Id")] public int Id { get; set; }
    [Column("JobOfferId")] public int JobOfferId { get; set; }
    [Column("Email")] public string Email { get; set; }
    [Column("Message")] public string Message { get; set; }
    [ForeignKey(nameof(JobOfferId))] public JobOffer JobOffer { get; set; }
}