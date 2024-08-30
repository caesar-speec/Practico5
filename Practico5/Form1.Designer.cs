namespace Practico5
{
    partial class Form1F
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1F));
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            button1 = new Button();
            label1 = new Label();
            textBoxApellido = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxNombre = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button2 = new Button();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            EliminarColumn = new DataGridViewButtonColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewImageColumn();
            Column8 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(19, 197);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Foto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 3);
            label1.Name = "label1";
            label1.Size = new Size(94, 28);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(111, 44);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(199, 23);
            textBoxApellido.TabIndex = 2;
            textBoxApellido.TextChanged += textBox1_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(247, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(139, 23);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(0, 44);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 4;
            label2.Text = "Apellido";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(0, 85);
            label4.Name = "label4";
            label4.Size = new Size(233, 28);
            label4.TabIndex = 6;
            label4.Text = "Fecha de Nacimiento";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(10, 118);
            label5.Name = "label5";
            label5.Size = new Size(60, 28);
            label5.TabIndex = 7;
            label5.Text = "Sexo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MV Boli", 15.75F, FontStyle.Bold | FontStyle.Italic);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(10, 158);
            label6.Name = "label6";
            label6.Size = new Size(67, 28);
            label6.TabIndex = 8;
            label6.Text = "Saldo";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(111, 3);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(199, 23);
            textBoxNombre.TabIndex = 2;
            textBoxNombre.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(111, 158);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(111, 197);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(180, 23);
            textBox4.TabIndex = 10;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.D;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(68, 237);
            button2.Name = "button2";
            button2.Size = new Size(130, 67);
            button2.TabIndex = 0;
            button2.Text = "Agregar";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.TextImageRelation = TextImageRelation.ImageBeforeText;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("MV Boli", 9F, FontStyle.Bold | FontStyle.Italic);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(246, 118);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(64, 21);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Mujer";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Font = new Font("MV Boli", 9F, FontStyle.Bold | FontStyle.Italic);
            checkBox2.ForeColor = SystemColors.ButtonHighlight;
            checkBox2.Location = new Point(145, 116);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(75, 21);
            checkBox2.TabIndex = 12;
            checkBox2.Text = "Hombre";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(textBoxNombre);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(textBoxApellido);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(64, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(389, 313);
            panel1.TabIndex = 13;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.Captussssssssssssssa;
            pictureBox1.Location = new Point(459, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(254, 313);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(784, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(8, 8);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, EliminarColumn, Column4, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(26, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(865, 150);
            dataGridView1.TabIndex = 16;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Apellido";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Fecha Nacimiento";
            Column3.Name = "Column3";
            // 
            // EliminarColumn
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            EliminarColumn.DefaultCellStyle = dataGridViewCellStyle3;
            EliminarColumn.HeaderText = "Eliminar";
            EliminarColumn.Name = "EliminarColumn";
            EliminarColumn.Text = "Eliminar";
            EliminarColumn.ToolTipText = "Eliminar";
            EliminarColumn.UseColumnTextForButtonValue = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Sexo";
            Column4.Name = "Column4";
            // 
            // Column6
            // 
            Column6.HeaderText = "Saldo";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Foto";
            Column7.Name = "Column7";
            Column7.Resizable = DataGridViewTriState.True;
            Column7.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Column8
            // 
            Column8.HeaderText = "Ruta";
            Column8.Name = "Column8";
            // 
            // Form1F
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.images;
            ClientSize = new Size(903, 450);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1F";
            Text = "Formulario con Data Grid";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxApellido;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBoxNombre;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button2;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewButtonColumn EliminarColumn;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewImageColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}
