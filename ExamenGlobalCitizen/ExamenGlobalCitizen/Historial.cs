﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenGlobalCitizen
{
    public partial class Historial : Form , IImprimible
    {
        private List<Cotizacion> cotizaciones;
        public Historial(List<Cotizacion> cotizaciones)
        {
            this.cotizaciones = cotizaciones;
            InitializeComponent();


            dataGridView1.DataSource = cotizaciones;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        //Metodo implementado de interfaz
        public void Imprimir()
        {
            foreach (var c in cotizaciones)
            {
                c.Imprimir();
            }
        }
    }
}
