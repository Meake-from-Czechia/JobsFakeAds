using System.Text.RegularExpressions;
using JobsFakeAds.WinForms.Entities;

namespace JobsFakeAds.WinForms.Forms;

public partial class JobOfferDemandEditForm : Form
{
    private JobOfferDemand _jobOfferDemand;
    public JobOfferDemandEditForm(JobOfferDemand? jobOfferDemand = null)
    {
        _jobOfferDemand = jobOfferDemand ?? new JobOfferDemand();
        InitializeComponent();
    }

    private void button_Ok_Click(object sender, EventArgs e)
    {
        if (IsFormValid())
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

    private void button_Cancel_Click(object sender, EventArgs e)
    {
        this.DialogResult = DialogResult.Cancel;
        this.Close();
    }

    private bool IsFormValid()
    {
        return IsMailValid() && IsPhoneNumberValid() && IsMessageValid();
    }

    private bool IsMailValid()
    {
        Regex mailRegex = new(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        if (string.IsNullOrWhiteSpace(textBox_Email.Text) || !mailRegex.IsMatch(textBox_Email.Text))
        {
            errorProvider.SetError(textBox_Email, "Email is required");
            return false;
        }
        else
        {
            errorProvider.SetError(textBox_Email, string.Empty);
            return true;
        }
    }

    private bool IsPhoneNumberValid()
    {
        Regex phoneRegex = new(@"^(+\d{3})?[ ]?\d{3}[ ]?\d{3}[ ]?\d{3}$");
        if (string.IsNullOrWhiteSpace(textBox_Phone.Text) || !phoneRegex.IsMatch(textBox_Phone.Text))
        {
            errorProvider.SetError(textBox_Phone, "Phone needs to be filled and valid");
            return false;
        }
        else
        {
            errorProvider.SetError(textBox_Phone, string.Empty);
            return true;
        }
    }

    private bool IsMessageValid()
    {
        if (string.IsNullOrWhiteSpace(richTextBox_Letter.Text) || richTextBox_Letter.Text.Length < 10)
        {
            errorProvider.SetError(richTextBox_Letter, "Message needs to be filled and at least 10 characters long");
            return false;
        }
        else
        {
            errorProvider.SetError(richTextBox_Letter, string.Empty);
            return true;
        }
    }
}