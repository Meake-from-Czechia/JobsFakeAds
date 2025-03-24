using System.ComponentModel;
using JobsFakeAds.WinForms.Data;
using JobsFakeAds.WinForms.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobsFakeAds.WinForms.Forms;

public partial class JobOfferGridForm : Form
{
    private AppDbContext _context;
    private BindingList<JobOffer> _jobOffers;

    public JobOfferGridForm()
    {
        _context = new AppDbContext();
        InitializeComponent();
        _jobOffers = new BindingList<JobOffer>(_context.JobOffers.Include(x => x.Company).ToList());
        dataGridView_JobOffers.DataSource = _jobOffers;
    }

    private void button_ViewDemands_Click(object sender, EventArgs e)
    {
        var selectedJobOffer = (JobOffer)dataGridView_JobOffers.CurrentRow.DataBoundItem;
        if (selectedJobOffer == null) return;
        var demandsForm = new JobOfferDemandForm(selectedJobOffer.Id);
        demandsForm.ShowDialog();
    }
}