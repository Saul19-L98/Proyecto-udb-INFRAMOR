﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroAlumnasInframor.Controllers;

namespace RegistroAlumnasInframor.Views
{
    public partial class ModificarUsuarioView : Form
    {
        public ModificarUsuarioView(string usuario)
        {
            InitializeComponent();
            ModificarUsuarioController ctrl = new ModificarUsuarioController(this, usuario);
        }
    }
}
