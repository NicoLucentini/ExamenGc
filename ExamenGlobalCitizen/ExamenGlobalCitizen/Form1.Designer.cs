namespace ExamenGlobalCitizen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTienda = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelVendedor = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.radioButtonCamisas = new System.Windows.Forms.RadioButton();
            this.radioButtonPantalones = new System.Windows.Forms.RadioButton();
            this.radioPremium = new System.Windows.Forms.RadioButton();
            this.radioStandard = new System.Windows.Forms.RadioButton();
            this.checkBoxCuelloMao = new System.Windows.Forms.CheckBox();
            this.checkBoxMangaCorta = new System.Windows.Forms.CheckBox();
            this.checkBoxChupin = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textCantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCotizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelStock = new System.Windows.Forms.Label();
            this.errorStock = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelPrecioUnitario = new System.Windows.Forms.Label();
            this.errorCantidad = new System.Windows.Forms.Label();
            this.errorPrecio = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelCotizacion = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.textErrorCotizacion = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTienda
            // 
            this.labelTienda.AutoSize = true;
            this.labelTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTienda.Location = new System.Drawing.Point(37, 30);
            this.labelTienda.Name = "labelTienda";
            this.labelTienda.Size = new System.Drawing.Size(51, 16);
            this.labelTienda.TabIndex = 0;
            this.labelTienda.Text = "label1";
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.Location = new System.Drawing.Point(460, 30);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(47, 15);
            this.labelDireccion.TabIndex = 1;
            this.labelDireccion.Text = "label2";
            // 
            // labelVendedor
            // 
            this.labelVendedor.AutoSize = true;
            this.labelVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVendedor.Location = new System.Drawing.Point(84, 58);
            this.labelVendedor.Name = "labelVendedor";
            this.labelVendedor.Size = new System.Drawing.Size(45, 16);
            this.labelVendedor.TabIndex = 2;
            this.labelVendedor.Text = "label3";
            this.labelVendedor.Click += new System.EventHandler(this.labelVendedor_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(37, 59);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(41, 15);
            this.labelId.TabIndex = 3;
            this.labelId.Text = "label4";
            // 
            // radioButtonCamisas
            // 
            this.radioButtonCamisas.AutoSize = true;
            this.radioButtonCamisas.Location = new System.Drawing.Point(21, 47);
            this.radioButtonCamisas.Name = "radioButtonCamisas";
            this.radioButtonCamisas.Size = new System.Drawing.Size(73, 19);
            this.radioButtonCamisas.TabIndex = 4;
            this.radioButtonCamisas.TabStop = true;
            this.radioButtonCamisas.Text = "Camisas";
            this.radioButtonCamisas.UseVisualStyleBackColor = true;
            this.radioButtonCamisas.CheckedChanged += new System.EventHandler(this.radioButtonCamisas_CheckedChanged);
            // 
            // radioButtonPantalones
            // 
            this.radioButtonPantalones.AutoSize = true;
            this.radioButtonPantalones.Location = new System.Drawing.Point(21, 87);
            this.radioButtonPantalones.Name = "radioButtonPantalones";
            this.radioButtonPantalones.Size = new System.Drawing.Size(87, 19);
            this.radioButtonPantalones.TabIndex = 5;
            this.radioButtonPantalones.TabStop = true;
            this.radioButtonPantalones.Text = "Pantalones";
            this.radioButtonPantalones.UseVisualStyleBackColor = true;
            this.radioButtonPantalones.CheckedChanged += new System.EventHandler(this.radioButtonPantalones_CheckedChanged);
            // 
            // radioPremium
            // 
            this.radioPremium.AutoSize = true;
            this.radioPremium.Location = new System.Drawing.Point(23, 85);
            this.radioPremium.Name = "radioPremium";
            this.radioPremium.Size = new System.Drawing.Size(76, 19);
            this.radioPremium.TabIndex = 7;
            this.radioPremium.TabStop = true;
            this.radioPremium.Text = "Premium";
            this.radioPremium.UseVisualStyleBackColor = true;
            this.radioPremium.CheckedChanged += new System.EventHandler(this.radioPremium_CheckedChanged);
            // 
            // radioStandard
            // 
            this.radioStandard.AutoSize = true;
            this.radioStandard.Location = new System.Drawing.Point(23, 45);
            this.radioStandard.Name = "radioStandard";
            this.radioStandard.Size = new System.Drawing.Size(75, 19);
            this.radioStandard.TabIndex = 6;
            this.radioStandard.TabStop = true;
            this.radioStandard.Text = "Standard";
            this.radioStandard.UseVisualStyleBackColor = true;
            this.radioStandard.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // checkBoxCuelloMao
            // 
            this.checkBoxCuelloMao.AutoSize = true;
            this.checkBoxCuelloMao.Location = new System.Drawing.Point(192, 47);
            this.checkBoxCuelloMao.Name = "checkBoxCuelloMao";
            this.checkBoxCuelloMao.Size = new System.Drawing.Size(89, 19);
            this.checkBoxCuelloMao.TabIndex = 8;
            this.checkBoxCuelloMao.Text = "Cuello Mao";
            this.checkBoxCuelloMao.UseVisualStyleBackColor = true;
            this.checkBoxCuelloMao.CheckedChanged += new System.EventHandler(this.checkBoxCuelloMao_CheckedChanged);
            // 
            // checkBoxMangaCorta
            // 
            this.checkBoxMangaCorta.AutoSize = true;
            this.checkBoxMangaCorta.Location = new System.Drawing.Point(292, 47);
            this.checkBoxMangaCorta.Name = "checkBoxMangaCorta";
            this.checkBoxMangaCorta.Size = new System.Drawing.Size(97, 19);
            this.checkBoxMangaCorta.TabIndex = 9;
            this.checkBoxMangaCorta.Text = "Manga Corta";
            this.checkBoxMangaCorta.UseVisualStyleBackColor = true;
            this.checkBoxMangaCorta.CheckedChanged += new System.EventHandler(this.checkBoxMangaCorta_CheckedChanged);
            // 
            // checkBoxChupin
            // 
            this.checkBoxChupin.AutoSize = true;
            this.checkBoxChupin.Location = new System.Drawing.Point(192, 87);
            this.checkBoxChupin.Name = "checkBoxChupin";
            this.checkBoxChupin.Size = new System.Drawing.Size(65, 19);
            this.checkBoxChupin.TabIndex = 10;
            this.checkBoxChupin.Text = "Chupin";
            this.checkBoxChupin.UseVisualStyleBackColor = true;
            this.checkBoxChupin.CheckedChanged += new System.EventHandler(this.checkBoxChupin_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stock";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "$";
            // 
            // textCantidad
            // 
            this.textCantidad.Location = new System.Drawing.Point(70, 84);
            this.textCantidad.Name = "textCantidad";
            this.textCantidad.Size = new System.Drawing.Size(100, 21);
            this.textCantidad.TabIndex = 16;
            this.textCantidad.TextChanged += new System.EventHandler(this.textCantidad_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Cantidad";
            // 
            // buttonCotizar
            // 
            this.buttonCotizar.Location = new System.Drawing.Point(463, 19);
            this.buttonCotizar.Name = "buttonCotizar";
            this.buttonCotizar.Size = new System.Drawing.Size(190, 64);
            this.buttonCotizar.TabIndex = 17;
            this.buttonCotizar.Text = "Cotizar";
            this.buttonCotizar.UseVisualStyleBackColor = true;
            this.buttonCotizar.Click += new System.EventHandler(this.buttonCotizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxChupin);
            this.groupBox1.Controls.Add(this.checkBoxMangaCorta);
            this.groupBox1.Controls.Add(this.checkBoxCuelloMao);
            this.groupBox1.Controls.Add(this.radioButtonPantalones);
            this.groupBox1.Controls.Add(this.radioButtonCamisas);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(40, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 119);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioPremium);
            this.groupBox2.Controls.Add(this.radioStandard);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(478, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(228, 117);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad Prenda";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelStock);
            this.groupBox3.Controls.Add(this.errorStock);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(40, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(405, 52);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stock";
            // 
            // labelStock
            // 
            this.labelStock.AutoSize = true;
            this.labelStock.ForeColor = System.Drawing.Color.Green;
            this.labelStock.Location = new System.Drawing.Point(90, 22);
            this.labelStock.Name = "labelStock";
            this.labelStock.Size = new System.Drawing.Size(41, 15);
            this.labelStock.TabIndex = 26;
            this.labelStock.Text = "label1";
            // 
            // errorStock
            // 
            this.errorStock.AutoSize = true;
            this.errorStock.ForeColor = System.Drawing.Color.Red;
            this.errorStock.Location = new System.Drawing.Point(200, 24);
            this.errorStock.Name = "errorStock";
            this.errorStock.Size = new System.Drawing.Size(163, 15);
            this.errorStock.TabIndex = 25;
            this.errorStock.Text = "Mostrar un mensaje de error";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.labelPrecioUnitario);
            this.groupBox4.Controls.Add(this.errorCantidad);
            this.groupBox4.Controls.Add(this.errorPrecio);
            this.groupBox4.Controls.Add(this.textCantidad);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(478, 273);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(228, 138);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Precio y Cantidad";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // labelPrecioUnitario
            // 
            this.labelPrecioUnitario.AutoSize = true;
            this.labelPrecioUnitario.ForeColor = System.Drawing.Color.Green;
            this.labelPrecioUnitario.Location = new System.Drawing.Point(58, 34);
            this.labelPrecioUnitario.Name = "labelPrecioUnitario";
            this.labelPrecioUnitario.Size = new System.Drawing.Size(41, 15);
            this.labelPrecioUnitario.TabIndex = 27;
            this.labelPrecioUnitario.Text = "label1";
            // 
            // errorCantidad
            // 
            this.errorCantidad.AutoSize = true;
            this.errorCantidad.ForeColor = System.Drawing.Color.Red;
            this.errorCantidad.Location = new System.Drawing.Point(20, 108);
            this.errorCantidad.Name = "errorCantidad";
            this.errorCantidad.Size = new System.Drawing.Size(163, 15);
            this.errorCantidad.TabIndex = 27;
            this.errorCantidad.Text = "Mostrar un mensaje de error";
            // 
            // errorPrecio
            // 
            this.errorPrecio.AutoSize = true;
            this.errorPrecio.ForeColor = System.Drawing.Color.Red;
            this.errorPrecio.Location = new System.Drawing.Point(20, 54);
            this.errorPrecio.Name = "errorPrecio";
            this.errorPrecio.Size = new System.Drawing.Size(163, 15);
            this.errorPrecio.TabIndex = 26;
            this.errorPrecio.Text = "Mostrar un mensaje de error";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(219, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "$";
            // 
            // labelCotizacion
            // 
            this.labelCotizacion.AutoSize = true;
            this.labelCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCotizacion.Location = new System.Drawing.Point(257, 44);
            this.labelCotizacion.Name = "labelCotizacion";
            this.labelCotizacion.Size = new System.Drawing.Size(85, 20);
            this.labelCotizacion.TabIndex = 22;
            this.labelCotizacion.Text = "123123,33";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.labelCotizacion);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.buttonCotizar);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(38, 417);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(668, 93);
            this.groupBox5.TabIndex = 23;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cotizar";
            // 
            // textErrorCotizacion
            // 
            this.textErrorCotizacion.AutoSize = true;
            this.textErrorCotizacion.ForeColor = System.Drawing.Color.Red;
            this.textErrorCotizacion.Location = new System.Drawing.Point(568, 513);
            this.textErrorCotizacion.Name = "textErrorCotizacion";
            this.textErrorCotizacion.Size = new System.Drawing.Size(138, 13);
            this.textErrorCotizacion.TabIndex = 24;
            this.textErrorCotizacion.Text = "Mostrar un mensaje de error";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 22);
            this.button1.TabIndex = 25;
            this.button1.Text = "Historial de Cotizaciones";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(867, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textErrorCotizacion);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.labelVendedor);
            this.Controls.Add(this.labelDireccion);
            this.Controls.Add(this.labelTienda);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTienda;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelVendedor;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.RadioButton radioButtonCamisas;
        private System.Windows.Forms.RadioButton radioButtonPantalones;
        private System.Windows.Forms.RadioButton radioPremium;
        private System.Windows.Forms.RadioButton radioStandard;
        private System.Windows.Forms.CheckBox checkBoxCuelloMao;
        private System.Windows.Forms.CheckBox checkBoxMangaCorta;
        private System.Windows.Forms.CheckBox checkBoxChupin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textCantidad;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCotizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelCotizacion;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label textErrorCotizacion;
        private System.Windows.Forms.Label errorStock;
        private System.Windows.Forms.Label errorCantidad;
        private System.Windows.Forms.Label errorPrecio;
        private System.Windows.Forms.Label labelStock;
        private System.Windows.Forms.Label labelPrecioUnitario;
        private System.Windows.Forms.Button button1;
    }
}

