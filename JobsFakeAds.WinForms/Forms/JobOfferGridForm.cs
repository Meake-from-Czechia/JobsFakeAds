using JobsFakeAds.WinForms.Data;

namespace JobsFakeAds.WinForms.Forms;

public partial class JobOfferGridForm : Form
{
    private AppDbContext _context;
    public JobOfferGridForm()
    {
        _context = new AppDbContext();
        InitializeComponent();
        dataGridView_JobOffers.DataSource = _context.JobOffers.Local.ToBindingList();
    }
}