using System.ComponentModel;
using JobsFakeAds.WinForms.Data;
using JobsFakeAds.WinForms.Entities;

namespace JobsFakeAds.WinForms.Forms;

public partial class JobOfferDemandForm : Form
{
    private AppDbContext _context;
    private BindingList<JobOfferDemand> _jobOfferDemands;
    public JobOfferDemandForm(int jobOfferId)
    {
        _context = new AppDbContext();
        InitializeComponent();
        _jobOfferDemands = new BindingList<JobOfferDemand>(_context.JobOfferDemands.Where(x => x.JobOfferId == jobOfferId).ToList());
        dataGridView_JobOfferDemands.DataSource = _jobOfferDemands;
    }
}