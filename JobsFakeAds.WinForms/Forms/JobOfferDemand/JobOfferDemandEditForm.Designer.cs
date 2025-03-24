using System.ComponentModel;

namespace JobsFakeAds.WinForms.Forms;

partial class JobOfferDemandEditForm
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
        components = new System.ComponentModel.Container();
        textBox_Email = new System.Windows.Forms.TextBox();
        textBox_Phone = new System.Windows.Forms.TextBox();
        richTextBox_Letter = new System.Windows.Forms.RichTextBox();
        label1 = new System.Windows.Forms.Label();
        label_Phone = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        button_Ok = new System.Windows.Forms.Button();
        button_Cancel = new System.Windows.Forms.Button();
        errorProvider = new System.Windows.Forms.ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
        SuspendLayout();
        // 
        // textBox_Email
        // 
        textBox_Email.Location = new System.Drawing.Point(90, 9);
        textBox_Email.Name = "textBox_Email";
        textBox_Email.Size = new System.Drawing.Size(289, 23);
        textBox_Email.TabIndex = 0;
        // 
        // textBox_Phone
        // 
        textBox_Phone.Location = new System.Drawing.Point(90, 38);
        textBox_Phone.Name = "textBox_Phone";
        textBox_Phone.Size = new System.Drawing.Size(289, 23);
        textBox_Phone.TabIndex = 0;
        // 
        // richTextBox_Letter
        // 
        richTextBox_Letter.Location = new System.Drawing.Point(90, 67);
        richTextBox_Letter.Name = "richTextBox_Letter";
        richTextBox_Letter.Size = new System.Drawing.Size(289, 178);
        richTextBox_Letter.TabIndex = 1;
        richTextBox_Letter.Text = "";
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 9);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(72, 23);
        label1.TabIndex = 2;
        label1.Text = "Email";
        // 
        // label_Phone
        // 
        label_Phone.Location = new System.Drawing.Point(12, 38);
        label_Phone.Name = "label_Phone";
        label_Phone.Size = new System.Drawing.Size(72, 23);
        label_Phone.TabIndex = 2;
        label_Phone.Text = "Phone num";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(12, 70);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(72, 23);
        label3.TabIndex = 2;
        label3.Text = "Cover letter";
        // 
        // button_Ok
        // 
        button_Ok.Location = new System.Drawing.Point(12, 285);
        button_Ok.Name = "button_Ok";
        button_Ok.Size = new System.Drawing.Size(75, 23);
        button_Ok.TabIndex = 3;
        button_Ok.Text = "Ok";
        button_Ok.UseVisualStyleBackColor = true;
        button_Ok.Click += button_Ok_Click;
        // 
        // button_Cancel
        // 
        button_Cancel.Location = new System.Drawing.Point(304, 285);
        button_Cancel.Name = "button_Cancel";
        button_Cancel.Size = new System.Drawing.Size(75, 23);
        button_Cancel.TabIndex = 3;
        button_Cancel.Text = "Cancel";
        button_Cancel.UseVisualStyleBackColor = true;
        button_Cancel.Click += button_Cancel_Click;
        // 
        // errorProvider
        // 
        errorProvider.ContainerControl = this;
        // 
        // JobOfferDemandEditForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(391, 320);
        Controls.Add(button_Cancel);
        Controls.Add(button_Ok);
        Controls.Add(label3);
        Controls.Add(label_Phone);
        Controls.Add(label1);
        Controls.Add(richTextBox_Letter);
        Controls.Add(textBox_Phone);
        Controls.Add(textBox_Email);
        Text = "JobOfferDemandEditForm";
        ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.ErrorProvider errorProvider;

    private System.Windows.Forms.TextBox textBox_Phone;
    private System.Windows.Forms.RichTextBox richTextBox_Letter;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label_Phone;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button button_Ok;
    private System.Windows.Forms.Button button_Cancel;

    private System.Windows.Forms.TextBox textBox_Email;

    #endregion
}