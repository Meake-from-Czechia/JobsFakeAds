using System.ComponentModel;

namespace JobsFakeAds.WinForms.Forms;

partial class JobOfferDemandForm
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
        dataGridView_JobOfferDemands = new System.Windows.Forms.DataGridView();
        ((System.ComponentModel.ISupportInitialize)dataGridView_JobOfferDemands).BeginInit();
        SuspendLayout();
        // 
        // dataGridView_JobOfferDemands
        // 
        dataGridView_JobOfferDemands.AllowUserToAddRows = false;
        dataGridView_JobOfferDemands.AllowUserToDeleteRows = false;
        dataGridView_JobOfferDemands.Location = new System.Drawing.Point(12, 12);
        dataGridView_JobOfferDemands.MultiSelect = false;
        dataGridView_JobOfferDemands.Name = "dataGridView_JobOfferDemands";
        dataGridView_JobOfferDemands.ReadOnly = true;
        dataGridView_JobOfferDemands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        dataGridView_JobOfferDemands.Size = new System.Drawing.Size(776, 426);
        dataGridView_JobOfferDemands.TabIndex = 0;
        // 
        // JobOfferDemandForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 468);
        Controls.Add(dataGridView_JobOfferDemands);
        Text = "JobOfferDemandForm";
        ((System.ComponentModel.ISupportInitialize)dataGridView_JobOfferDemands).EndInit();
        ResumeLayout(false);
    }

    private System.Windows.Forms.DataGridView dataGridView_JobOfferDemands;

    #endregion
}