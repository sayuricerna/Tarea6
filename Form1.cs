﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adventureWorks2017DataSet.EmailAddress' table. You can move, or remove it, as needed.
            this.emailAddressTableAdapter.Fill(this.adventureWorks2017DataSet.EmailAddress);

            this.reportViewer1.RefreshReport();
        }
    }
}