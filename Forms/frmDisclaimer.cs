﻿/* PROJETO: FixMyPrinter
 * AUTOR  : William Silva (pontiffex)
 * DATA   : 05/02/2022
 * CONTATO: wbsilva@veso.dev.br
 */

using System;
using System.Windows.Forms;

namespace FixMyPrinter.Forms
{
    public partial class frmDisclaimer : Form
    {
        public frmDisclaimer()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}