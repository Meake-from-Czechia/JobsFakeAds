using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobsFakeAds.WinForms.Entities;
[Table("Companies")]
public class Company
{
    [Key]
    [Column("Id")]
    public int Id { get; set; }
    [Column("CompanyName")]
    public string Name { get; set; }
    [Column("CompanyLocation")]
    public string Location { get; set; }

    public List<JobOffer> JobOffers { get; set; }
}