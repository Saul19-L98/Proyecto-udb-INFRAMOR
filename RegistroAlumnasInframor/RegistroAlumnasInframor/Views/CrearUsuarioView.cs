﻿using RegistroAlumnasInframor.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroAlumnasInframor.Views
{
    public partial class CrearUsuarioView : Form
    {
        private static bool selfClosing;
        public static bool SelfClosing { get => selfClosing; set => selfClosing = value; }
        public CrearUsuarioView()
        {
            SelfClosing = false;
            InitializeComponent();
            CrearUsuarioController ctrl = new CrearUsuarioController(this);
        }
    }
}
