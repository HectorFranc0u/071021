﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class frmtest : Form
    {
        public frmtest()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string connectionString = "";
            MySqlConnection conn;
            try
            {
                connectionString = @"Server=localhost;Database=recetas;Uid=root;Pwd=usbw";
                conn = new MySqlConnection(connectionString);
                conn.Open();

                MetroFramework.MetroMessageBox.Show(this,
                    "CONEXION EXISTOSA!", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information
                    );
                conn.Close();
            }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this,
                    Ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
        }
    }
}
