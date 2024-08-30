using System;
using System.Drawing;
using System.Windows.Forms;

namespace Practico5
{
    public partial class Form1F : Form
    {
        public Form1F()
        {
            InitializeComponent();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length > 0)
            {
                string text = textBox.Text;
                textBox.Text = char.ToUpper(text[0]) + text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string saldo = textBox3.Text;
            string fecha = dateTimePicker1.Value.ToShortDateString();
            string genero = "";

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(saldo))
            {
                MessageBox.Show("Todos los campos deben ser completados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El nombre no debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(apellido, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("El apellido no debe contener números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(saldo, out decimal saldoDecimal))
            {
                MessageBox.Show("El saldo debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkBox2.Checked && !checkBox1.Checked)
            {
                MessageBox.Show("Debe seleccionar un género (Hombre o Mujer).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkBox2.Checked)
            {
                genero = "Hombre";
            }
            else if (checkBox1.Checked)
            {
                genero = "Mujer"; 
            }

            if (pictureBox1.Image == null)
            {
                pictureBox1.Image = Image.FromFile("ruta_de_la_imagen_por_defecto.jpg");
            }

            Image foto = pictureBox1.Image;
            string rutaFoto = textBox4.Text;

            int rowIndex = dataGridView1.Rows.Add();

            dataGridView1.Rows[rowIndex].Cells["Column1"].Value = nombre;
            dataGridView1.Rows[rowIndex].Cells["Column2"].Value = apellido;
            dataGridView1.Rows[rowIndex].Cells["Column6"].Value = saldoDecimal.ToString("F2");
            dataGridView1.Rows[rowIndex].Cells["Column3"].Value = fecha;
            dataGridView1.Rows[rowIndex].Cells["Column4"].Value = genero;
            dataGridView1.Rows[rowIndex].Cells["Column7"].Value = foto;
            dataGridView1.Rows[rowIndex].Cells["Column8"].Value = rutaFoto;

         
            if (saldoDecimal < 50)
            {
                dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
            }

           
            textBoxNombre.Clear();
            textBoxApellido.Clear();
            textBox3.Clear();
            textBox4.Clear();
            pictureBox1.Image = null;
            dateTimePicker1.Value = DateTime.Now;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\Users\Pi\source\repos\Practico5\Practico5\bin\Debug";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                textBox4.Text = openFileDialog.FileName;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length > 0)
            {
                string text = textBox.Text;
                textBox.Text = char.ToUpper(text[0]) + text.Substring(1).ToLower();
                textBox.SelectionStart = textBox.Text.Length;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string genero = selectedRow.Cells["Column4"].Value.ToString();

                if (genero == "Hombre") 
                {
                    checkBox2.Checked = true;
                }
                else if (genero == "Mujer") 
                {
                    checkBox1.Checked = true;
                }
            }
        }

        private void Form1F_Load(object sender, EventArgs e)
        {
        
            if (dataGridView1.Columns["EliminarColumn"] == null)
            {
                DataGridViewButtonColumn eliminarColumn = new DataGridViewButtonColumn();
                eliminarColumn.Name = "EliminarColumn";
                eliminarColumn.HeaderText = "Eliminar";
                eliminarColumn.Text = "Eliminar";
                eliminarColumn.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(eliminarColumn);
            }

            dataGridView1.CellContentClick -= dataGridView1_CellContentClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["EliminarColumn"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}