﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Presentation
{
    public partial class MonitorVentasAdmin : Form
    {
        public MonitorVentasAdmin()
        {
            InitializeComponent();
            EditMonitorVentasTable();
        }
        private void EditMonitorVentasTable()
        {
            dataGridView1.Rows.Add();
            dataGridView1.Rows.Add();
            dataGridView1[0, 0].Value = "GASTOS";
            dataGridView1[1, 0].Value = "0";
            dataGridView1[2, 0].Value = "GASTOS";

            dataGridView1[0, 1].Value = "GASTOS";
            dataGridView1[1, 1].Value = "0";
            dataGridView1[2, 1].Value = "GASTOS";
        }
    }
}
