using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using EntityFramework.Datos; 

namespace EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Refrescar();
        }

        private void Refrescar()
        {
            try
            {
                using (Conexion db = new Conexion())
                {
                    dataGridView1.DataSource = db.Productos.ToList();
                }
            }
            catch (Exception ex)
            {
                lblNotification.Text = "Error: " + ex.Message;
            }
        }

        private void Limpiar()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            txtStock.Text = "";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                using (Conexion db = new Conexion())
                {
                    Producto oProducto = new Producto();
                    oProducto.id = int.Parse(txtId.Text);
                    oProducto.Nombre = txtName.Text;
                    oProducto.Precio = decimal.Parse(txtPrice.Text);
                    oProducto.Stop = int.Parse(txtStock.Text);

                    db.Productos.Add(oProducto);
                    db.SaveChanges();

                    lblNotification.Text = "Guardado con éxito.";
                    Refrescar();
                    Limpiar();
                }
            }
            catch (Exception ex) { lblNotification.Text = "Error: " + ex.Message; }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            Refrescar();
            lblNotification.Text = "Datos actualizados.";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                using (Conexion db = new Conexion())
                {
                    int id = int.Parse(txtId.Text);
                    Producto oProducto = db.Productos.Find(id);

                    if (oProducto != null)
                    {
                        oProducto.Nombre = txtName.Text;
                        oProducto.Precio = decimal.Parse(txtPrice.Text);
                        oProducto.Stop = int.Parse(txtStock.Text);

                        db.Entry(oProducto).State = EntityState.Modified;
                        db.SaveChanges();

                        lblNotification.Text = "Actualizado correctamente.";
                        Refrescar();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex) { lblNotification.Text = "Error: " + ex.Message; }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (Conexion db = new Conexion())
                {
                    int id = int.Parse(txtId.Text);
                    Producto oProducto = db.Productos.Find(id);
                    if (oProducto != null)
                    {
                        db.Productos.Remove(oProducto);
                        db.SaveChanges();
                        lblNotification.Text = "Eliminado.";
                        Refrescar();
                        Limpiar();
                    }
                }
            }
            catch (Exception ex) { lblNotification.Text = "Error: " + ex.Message; }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}