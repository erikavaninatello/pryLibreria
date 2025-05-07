using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Guna.UI2.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using PDF = iTextSharp.text;

namespace pryFinal
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pbProductos_Click(object sender, EventArgs e)
        {
            frmProductos v = new frmProductos();
            v.ShowDialog();
        }

        private void pbStock_Click(object sender, EventArgs e)
        {
            frmStock v = new frmStock();
            v.ShowDialog();
        }

        private void pbAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda v = new frmAgenda();
            v.ShowDialog();
        }

        private void pbReporte_Click(object sender, EventArgs e)
        {
            try
            {
                string escritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string rutaPDF = Path.Combine(escritorio, "ReporteStock.pdf");

                PDF.Document doc = new PDF.Document();
                PdfWriter.GetInstance(doc, new FileStream(rutaPDF, FileMode.Create));
                doc.Open();

            
                var titulo = new PDF.Paragraph("REPORTE DE STOCK", PDF.FontFactory.GetFont(PDF.FontFactory.HELVETICA_BOLD, 18));
                titulo.Alignment = PDF.Element.ALIGN_CENTER;
                doc.Add(titulo);
                doc.Add(new PDF.Paragraph(" "));

            
                PdfPTable tabla = new PdfPTable(6);
                tabla.WidthPercentage = 100;
                tabla.AddCell("ID");
                tabla.AddCell("Nombre");
                tabla.AddCell("Categoría");
                tabla.AddCell("Precio");
                tabla.AddCell("Stock");
                tabla.AddCell("Descripción");

                foreach (var p in clsData.ListaProductos)
                {
                    tabla.AddCell(p.ID.ToString());
                    tabla.AddCell(p.Nombre);
                    tabla.AddCell(p.Categoria);
                    tabla.AddCell(p.Precio.ToString("C"));
                    tabla.AddCell(p.Stock.ToString());
                    tabla.AddCell(p.Descripcion);
                }

                doc.Add(new PDF.Paragraph("Todos los productos:"));
                doc.Add(tabla);
                doc.Add(new PDF.Paragraph(" "));

               
                var fontRojo = PDF.FontFactory.GetFont(PDF.FontFactory.HELVETICA_BOLD, 11, new PDF.BaseColor(178, 34, 34)); // Rojo oscuro
                var fontVerde = PDF.FontFactory.GetFont(PDF.FontFactory.HELVETICA, 11, new PDF.BaseColor(34, 139, 34)); // Verde bosque

                var stockBajo = clsData.ListaProductos.Where(p => p.Stock <= 5).ToList();
                if (stockBajo.Any())
                {
                    doc.Add(new PDF.Paragraph("Productos con STOCK BAJO (≤5):", fontRojo));
                    foreach (var p in stockBajo)
                    {
                        doc.Add(new PDF.Paragraph($"- {p.Nombre} (Stock: {p.Stock})", fontRojo));
                    }
                }
                else
                {
                    doc.Add(new PDF.Paragraph("Todos los productos tienen stock suficiente.", fontVerde));
                }

                doc.Add(new PDF.Paragraph(" "));

           
                var productos = clsData.ListaProductos;
                var masVendido = productos.OrderByDescending(p => p.Vendido).FirstOrDefault();
                var menosVendido = productos.OrderBy(p => p.Vendido).FirstOrDefault();

                if (masVendido != null && menosVendido != null)
                {
                    doc.Add(new PDF.Paragraph("Producto más vendido: " + masVendido.Nombre + " (" + masVendido.Vendido + " unidades)"));
                    doc.Add(new PDF.Paragraph("Producto menos vendido: " + menosVendido.Nombre + " (" + menosVendido.Vendido + " unidades)"));
                }

                doc.Add(new PDF.Paragraph(" "));

            
                doc.Add(new PDF.Paragraph("Reporte mensual de stock vendido:"));
                doc.Add(new PDF.Paragraph("- Enero: 120 unidades"));
                doc.Add(new PDF.Paragraph("- Febrero: 98 unidades"));
                doc.Add(new PDF.Paragraph("- Marzo: 135 unidades"));

                doc.Close();

                MessageBox.Show("Reporte PDF generado correctamente en el escritorio.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(rutaPDF);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el reporte: " + ex.Message);

            }
        }

    }

}
    

