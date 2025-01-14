﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SwarmSight.UserControls
{
    /// <summary>
    /// Interaction logic for ComparisonTable.xaml
    /// </summary>
    public partial class ComparisonTable : UserControl
    {
        public ComparisonTable()
        {
            InitializeComponent();
        }

        internal void Clear()
        {
            lblAvgA.Content =
            lblStDevA.Content =
            lblNA.Content =
            lblAvgB.Content =
            lblStDevB.Content =
            lblNB.Content =
            lblAvgDiff.Content =
            lblAvgPercent.Content = "-";
        }
    }
}