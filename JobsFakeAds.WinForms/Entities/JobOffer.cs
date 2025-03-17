using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobsFakeAds.WinForms.Entities;

[Table("JobOffers")]
public class JobOffer
{
    [Key] [Column("Id")] public int Id { get; set; }
    [Column("CompanyId")] public int CompanyId { get; set; }
    [Column("PositionName")] public string PositionName { get; set; }
    [Column("SalaryMin")] public decimal SalaryMin { get; set; }
    [Column("SalaryMax")] public decimal SalaryMax { get; set; }
    [Column("CreatedOn")] public DateTime CreatedOn { get; set; }
    [ForeignKey(nameof(CompanyId))] public Company Company { get; set; }
    public List<JobOfferDemand> JobOfferDemands { get; set; }
}