using System.ComponentModel;

namespace JobsFakeAds.WinForms.Forms;

partial class JobOfferGridForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dataGridView_JobOffers = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView_JobOffers).BeginInit();
        SuspendLayout();
        //
        // dataGridView_JobOffers
        //
        dataGridView_JobOffers.Location = new System.Drawing.Point(12, 12);
        dataGridView_JobOffers.Name = "dataGridView_JobOffers";
        dataGridView_JobOffers.Size = new System.Drawing.Size(776, 426);
        dataGridView_JobOffers.TabIndex = 0;
        //
        // JobOfferGridForm
        //
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(dataGridView_JobOffers);
        Text = "JobOfferGridForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView_JobOffers).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridView_JobOffers;

    #endregion
}