using System;
using System.Linq;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.LinkLabel;


namespace data_to_exel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LstvContentData.FullRowSelect = true;

        }

        private void SaveArrayBtn_Click(object sender, EventArgs e)
        {
            ItemForContainer x;

            string Name = NamePdrocutTxt.Text;

            int Quantity = Convert.ToInt32(QuantityNud.Value);
            int Price = Convert.ToInt32(PriseNud.Value);
            Price = Price * Quantity;

            x = new ItemForContainer(Name, Quantity, Price);


            ListViewItem row = new ListViewItem(x.Name.ToString());
            row.SubItems.Add(x.Quantity.ToString());
            row.SubItems.Add(x.Price.ToString());
            LstvContentData.Items.Add(row);

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Text Files|*.txt";
            dialog.Title = "Guardar en archivo de Texto";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(dialog.FileName))
                    {
                        // Agregar nombres de columna
                        string headerRow = "";
                        foreach (ColumnHeader columnHeader in LstvContentData.Columns)
                        {
                            headerRow += columnHeader.Text + "\t";
                        }
                        writer.WriteLine(headerRow.TrimEnd('\t'));

                        // Agregar datos del ListView
                        foreach (ListViewItem item in LstvContentData.Items)
                        {
                            string row = "";
                            foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                            {
                                row += subItem.Text + "\t";
                            }
                            writer.WriteLine(row.TrimEnd('\t'));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el archivo de texto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LstvContentData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
