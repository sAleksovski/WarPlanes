﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CarrierAirWing
{
    public partial class FormGetName : Form
    {
        public string Name { get; set; }
        public FormGetName()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Name = tbName.Text;
            this.DialogResult = DialogResult.OK;
        }
    }
}
