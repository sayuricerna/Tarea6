﻿namespace Tarea6
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.emailAddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2017DataSet = new Tarea6.AdventureWorks2017DataSet();
            this.emailAddressTableAdapter = new Tarea6.AdventureWorks2017DataSetTableAdapters.EmailAddressTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.emailAddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.emailAddressBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Tarea6.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(992, 581);
            this.reportViewer1.TabIndex = 0;
            // 
            // emailAddressBindingSource
            // 
            this.emailAddressBindingSource.DataMember = "EmailAddress";
            this.emailAddressBindingSource.DataSource = this.adventureWorks2017DataSet;
            // 
            // adventureWorks2017DataSet
            // 
            this.adventureWorks2017DataSet.DataSetName = "AdventureWorks2017DataSet";
            this.adventureWorks2017DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // emailAddressTableAdapter
            // 
            this.emailAddressTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 605);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.emailAddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2017DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private AdventureWorks2017DataSet adventureWorks2017DataSet;
        private System.Windows.Forms.BindingSource emailAddressBindingSource;
        private AdventureWorks2017DataSetTableAdapters.EmailAddressTableAdapter emailAddressTableAdapter;
    }
}

