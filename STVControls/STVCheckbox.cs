﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace STVControls
{
    public partial class STVCheckbox : Component
    {
        public STVCheckbox()
        {
            InitializeComponent();
        }

        public STVCheckbox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
