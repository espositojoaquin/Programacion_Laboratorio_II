﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_06
{
    public partial class frmPantalla2 : Form
    {
        public string atributoString = "Pantalla dos jose";

        public frmPantalla2()
        {
            InitializeComponent();
        }

        private void frmPantalla2_Load(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}