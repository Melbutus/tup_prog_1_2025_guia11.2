namespace _11_2_1_vectores
{
    partial class Form1
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
            tbx_numero_ingresado_procesar_nro = new TextBox();
            tbx_valor_buscado_ = new TextBox();
            gb_procesar_numero = new GroupBox();
            bt_registrar_numero_procesar_ = new Button();
            lbl_ingresar_numero = new Label();
            gbx_procesar_max_min = new GroupBox();
            lbl_minimo_ = new ListBox();
            bt_actualizar_procesar_maxmin = new Button();
            lbx_maximo_ = new ListBox();
            lbl_valor_minimo_procesar_nro = new Label();
            lbl_valor_maximo_procesar_nro = new Label();
            gbx_procesar_promedio = new GroupBox();
            bt_promedio_actualizar = new Button();
            lbx_promedio_ = new ListBox();
            lbl_promedio = new Label();
            gbx_mostrar_cantidad_ingresados = new GroupBox();
            bt_cant_ingresados_actualizar = new Button();
            lbx_cantidad_ingresados__ = new ListBox();
            lbl_cantidad_ingresados_ = new Label();
            gbx_valores = new GroupBox();
            lbx_valor_a_buscar_ = new ListBox();
            bt_buscar_valor_ = new Button();
            lbl_valor_a_buscar = new Label();
            gbx_mostrar_ingresados_cant = new GroupBox();
            lbx_cant_ingresados_lista = new ListBox();
            bt_mostrar_lista_ordenada_ = new Button();
            bt_lista_superioral_promedio = new Button();
            gb_procesar_numero.SuspendLayout();
            gbx_procesar_max_min.SuspendLayout();
            gbx_procesar_promedio.SuspendLayout();
            gbx_mostrar_cantidad_ingresados.SuspendLayout();
            gbx_valores.SuspendLayout();
            gbx_mostrar_ingresados_cant.SuspendLayout();
            SuspendLayout();
            // 
            // tbx_numero_ingresado_procesar_nro
            // 
            tbx_numero_ingresado_procesar_nro.Location = new Point(15, 61);
            tbx_numero_ingresado_procesar_nro.Name = "tbx_numero_ingresado_procesar_nro";
            tbx_numero_ingresado_procesar_nro.Size = new Size(100, 23);
            tbx_numero_ingresado_procesar_nro.TabIndex = 0;
            tbx_numero_ingresado_procesar_nro.TextChanged += tbx_numero_ingresado_procesar_nro_TextChanged;
            // 
            // tbx_valor_buscado_
            // 
            tbx_valor_buscado_.Location = new Point(6, 47);
            tbx_valor_buscado_.Name = "tbx_valor_buscado_";
            tbx_valor_buscado_.Size = new Size(80, 23);
            tbx_valor_buscado_.TabIndex = 1;
            tbx_valor_buscado_.TextChanged += tbx_valor_buscado__TextChanged;
            // 
            // gb_procesar_numero
            // 
            gb_procesar_numero.Controls.Add(bt_registrar_numero_procesar_);
            gb_procesar_numero.Controls.Add(lbl_ingresar_numero);
            gb_procesar_numero.Controls.Add(tbx_numero_ingresado_procesar_nro);
            gb_procesar_numero.Location = new Point(7, 12);
            gb_procesar_numero.Name = "gb_procesar_numero";
            gb_procesar_numero.Size = new Size(251, 100);
            gb_procesar_numero.TabIndex = 2;
            gb_procesar_numero.TabStop = false;
            gb_procesar_numero.Text = "Procesar un Número";
            gb_procesar_numero.Enter += groupBox1_Enter;
            // 
            // bt_registrar_numero_procesar_
            // 
            bt_registrar_numero_procesar_.DialogResult = DialogResult.OK;
            bt_registrar_numero_procesar_.Location = new Point(147, 60);
            bt_registrar_numero_procesar_.Name = "bt_registrar_numero_procesar_";
            bt_registrar_numero_procesar_.Size = new Size(89, 23);
            bt_registrar_numero_procesar_.TabIndex = 10;
            bt_registrar_numero_procesar_.Text = "Registrar";
            bt_registrar_numero_procesar_.UseVisualStyleBackColor = true;
            bt_registrar_numero_procesar_.Click += bt_registrar_numero_procesar__Click;
            // 
            // lbl_ingresar_numero
            // 
            lbl_ingresar_numero.AutoSize = true;
            lbl_ingresar_numero.Location = new Point(6, 29);
            lbl_ingresar_numero.Name = "lbl_ingresar_numero";
            lbl_ingresar_numero.Size = new Size(109, 15);
            lbl_ingresar_numero.TabIndex = 3;
            lbl_ingresar_numero.Text = "Ingrese un Número";
            // 
            // gbx_procesar_max_min
            // 
            gbx_procesar_max_min.Controls.Add(lbl_minimo_);
            gbx_procesar_max_min.Controls.Add(bt_actualizar_procesar_maxmin);
            gbx_procesar_max_min.Controls.Add(lbx_maximo_);
            gbx_procesar_max_min.Controls.Add(lbl_valor_minimo_procesar_nro);
            gbx_procesar_max_min.Controls.Add(lbl_valor_maximo_procesar_nro);
            gbx_procesar_max_min.Location = new Point(7, 118);
            gbx_procesar_max_min.Name = "gbx_procesar_max_min";
            gbx_procesar_max_min.Size = new Size(301, 109);
            gbx_procesar_max_min.TabIndex = 3;
            gbx_procesar_max_min.TabStop = false;
            gbx_procesar_max_min.Text = "Procesar Máximo y Mínimo";
            // 
            // lbl_minimo_
            // 
            lbl_minimo_.BackColor = SystemColors.ActiveCaption;
            lbl_minimo_.FormattingEnabled = true;
            lbl_minimo_.ItemHeight = 15;
            lbl_minimo_.Location = new Point(115, 68);
            lbl_minimo_.Name = "lbl_minimo_";
            lbl_minimo_.Size = new Size(69, 19);
            lbl_minimo_.TabIndex = 5;
            lbl_minimo_.SelectedIndexChanged += lbl_minimo__SelectedIndexChanged;
            // 
            // bt_actualizar_procesar_maxmin
            // 
            bt_actualizar_procesar_maxmin.DialogResult = DialogResult.OK;
            bt_actualizar_procesar_maxmin.Location = new Point(208, 49);
            bt_actualizar_procesar_maxmin.Name = "bt_actualizar_procesar_maxmin";
            bt_actualizar_procesar_maxmin.Size = new Size(75, 23);
            bt_actualizar_procesar_maxmin.TabIndex = 4;
            bt_actualizar_procesar_maxmin.Text = "Actualizar";
            bt_actualizar_procesar_maxmin.UseVisualStyleBackColor = true;
            bt_actualizar_procesar_maxmin.Click += bt_actualizar_procesar_maxmin_Click;
            // 
            // lbx_maximo_
            // 
            lbx_maximo_.BackColor = SystemColors.ActiveCaption;
            lbx_maximo_.FormattingEnabled = true;
            lbx_maximo_.ItemHeight = 15;
            lbx_maximo_.Location = new Point(115, 33);
            lbx_maximo_.Name = "lbx_maximo_";
            lbx_maximo_.Size = new Size(69, 19);
            lbx_maximo_.TabIndex = 4;
            lbx_maximo_.SelectedIndexChanged += lbx_maximo__SelectedIndexChanged;
            // 
            // lbl_valor_minimo_procesar_nro
            // 
            lbl_valor_minimo_procesar_nro.AutoSize = true;
            lbl_valor_minimo_procesar_nro.Location = new Point(18, 72);
            lbl_valor_minimo_procesar_nro.Name = "lbl_valor_minimo_procesar_nro";
            lbl_valor_minimo_procesar_nro.Size = new Size(78, 15);
            lbl_valor_minimo_procesar_nro.TabIndex = 5;
            lbl_valor_minimo_procesar_nro.Text = "Valor Mínimo";
            // 
            // lbl_valor_maximo_procesar_nro
            // 
            lbl_valor_maximo_procesar_nro.AutoSize = true;
            lbl_valor_maximo_procesar_nro.Location = new Point(18, 33);
            lbl_valor_maximo_procesar_nro.Name = "lbl_valor_maximo_procesar_nro";
            lbl_valor_maximo_procesar_nro.Size = new Size(80, 15);
            lbl_valor_maximo_procesar_nro.TabIndex = 4;
            lbl_valor_maximo_procesar_nro.Text = "Valor Máximo";
            // 
            // gbx_procesar_promedio
            // 
            gbx_procesar_promedio.Controls.Add(bt_promedio_actualizar);
            gbx_procesar_promedio.Controls.Add(lbx_promedio_);
            gbx_procesar_promedio.Controls.Add(lbl_promedio);
            gbx_procesar_promedio.Location = new Point(7, 233);
            gbx_procesar_promedio.Name = "gbx_procesar_promedio";
            gbx_procesar_promedio.Size = new Size(301, 62);
            gbx_procesar_promedio.TabIndex = 4;
            gbx_procesar_promedio.TabStop = false;
            gbx_procesar_promedio.Text = "Procesar Promedio";
            // 
            // bt_promedio_actualizar
            // 
            bt_promedio_actualizar.DialogResult = DialogResult.OK;
            bt_promedio_actualizar.Location = new Point(208, 22);
            bt_promedio_actualizar.Name = "bt_promedio_actualizar";
            bt_promedio_actualizar.Size = new Size(75, 23);
            bt_promedio_actualizar.TabIndex = 5;
            bt_promedio_actualizar.Text = "Actualizar";
            bt_promedio_actualizar.UseVisualStyleBackColor = true;
            bt_promedio_actualizar.Click += bt_promedio_actualizar_Click;
            // 
            // lbx_promedio_
            // 
            lbx_promedio_.BackColor = SystemColors.ActiveCaption;
            lbx_promedio_.FormattingEnabled = true;
            lbx_promedio_.ItemHeight = 15;
            lbx_promedio_.Location = new Point(115, 26);
            lbx_promedio_.Name = "lbx_promedio_";
            lbx_promedio_.Size = new Size(69, 19);
            lbx_promedio_.TabIndex = 5;
            // 
            // lbl_promedio
            // 
            lbl_promedio.AutoSize = true;
            lbl_promedio.Location = new Point(18, 30);
            lbl_promedio.Name = "lbl_promedio";
            lbl_promedio.Size = new Size(59, 15);
            lbl_promedio.TabIndex = 5;
            lbl_promedio.Text = "Promedio";
            // 
            // gbx_mostrar_cantidad_ingresados
            // 
            gbx_mostrar_cantidad_ingresados.Controls.Add(bt_cant_ingresados_actualizar);
            gbx_mostrar_cantidad_ingresados.Controls.Add(lbx_cantidad_ingresados__);
            gbx_mostrar_cantidad_ingresados.Controls.Add(lbl_cantidad_ingresados_);
            gbx_mostrar_cantidad_ingresados.Location = new Point(7, 301);
            gbx_mostrar_cantidad_ingresados.Name = "gbx_mostrar_cantidad_ingresados";
            gbx_mostrar_cantidad_ingresados.Size = new Size(301, 64);
            gbx_mostrar_cantidad_ingresados.TabIndex = 5;
            gbx_mostrar_cantidad_ingresados.TabStop = false;
            gbx_mostrar_cantidad_ingresados.Text = "Mostrar cantidad de Ingresados";
            // 
            // bt_cant_ingresados_actualizar
            // 
            bt_cant_ingresados_actualizar.DialogResult = DialogResult.OK;
            bt_cant_ingresados_actualizar.Location = new Point(208, 28);
            bt_cant_ingresados_actualizar.Name = "bt_cant_ingresados_actualizar";
            bt_cant_ingresados_actualizar.Size = new Size(75, 23);
            bt_cant_ingresados_actualizar.TabIndex = 6;
            bt_cant_ingresados_actualizar.Text = "Actualizar";
            bt_cant_ingresados_actualizar.UseVisualStyleBackColor = true;
            bt_cant_ingresados_actualizar.Click += bt_cant_ingresados_actualizar_Click;
            // 
            // lbx_cantidad_ingresados__
            // 
            lbx_cantidad_ingresados__.BackColor = SystemColors.ActiveCaption;
            lbx_cantidad_ingresados__.FormattingEnabled = true;
            lbx_cantidad_ingresados__.ItemHeight = 15;
            lbx_cantidad_ingresados__.Location = new Point(115, 28);
            lbx_cantidad_ingresados__.Name = "lbx_cantidad_ingresados__";
            lbx_cantidad_ingresados__.Size = new Size(69, 19);
            lbx_cantidad_ingresados__.TabIndex = 6;
            // 
            // lbl_cantidad_ingresados_
            // 
            lbl_cantidad_ingresados_.AutoSize = true;
            lbl_cantidad_ingresados_.Location = new Point(22, 28);
            lbl_cantidad_ingresados_.Name = "lbl_cantidad_ingresados_";
            lbl_cantidad_ingresados_.Size = new Size(55, 15);
            lbl_cantidad_ingresados_.TabIndex = 6;
            lbl_cantidad_ingresados_.Text = "Cantidad";
            // 
            // gbx_valores
            // 
            gbx_valores.Controls.Add(lbx_valor_a_buscar_);
            gbx_valores.Controls.Add(bt_buscar_valor_);
            gbx_valores.Controls.Add(lbl_valor_a_buscar);
            gbx_valores.Controls.Add(tbx_valor_buscado_);
            gbx_valores.Location = new Point(357, 12);
            gbx_valores.Name = "gbx_valores";
            gbx_valores.Size = new Size(200, 100);
            gbx_valores.TabIndex = 6;
            gbx_valores.TabStop = false;
            gbx_valores.Text = "Valores";
            // 
            // lbx_valor_a_buscar_
            // 
            lbx_valor_a_buscar_.BackColor = SystemColors.ActiveCaption;
            lbx_valor_a_buscar_.FormattingEnabled = true;
            lbx_valor_a_buscar_.ItemHeight = 15;
            lbx_valor_a_buscar_.Location = new Point(6, 75);
            lbx_valor_a_buscar_.Name = "lbx_valor_a_buscar_";
            lbx_valor_a_buscar_.Size = new Size(193, 19);
            lbx_valor_a_buscar_.TabIndex = 9;
            // 
            // bt_buscar_valor_
            // 
            bt_buscar_valor_.DialogResult = DialogResult.OK;
            bt_buscar_valor_.Location = new Point(103, 47);
            bt_buscar_valor_.Name = "bt_buscar_valor_";
            bt_buscar_valor_.Size = new Size(75, 23);
            bt_buscar_valor_.TabIndex = 8;
            bt_buscar_valor_.Text = "Buscar";
            bt_buscar_valor_.UseVisualStyleBackColor = true;
            bt_buscar_valor_.Click += bt_buscar_valor__Click;
            // 
            // lbl_valor_a_buscar
            // 
            lbl_valor_a_buscar.AutoSize = true;
            lbl_valor_a_buscar.Location = new Point(6, 29);
            lbl_valor_a_buscar.Name = "lbl_valor_a_buscar";
            lbl_valor_a_buscar.Size = new Size(80, 15);
            lbl_valor_a_buscar.TabIndex = 7;
            lbl_valor_a_buscar.Text = "Valor a Buscar";
            // 
            // gbx_mostrar_ingresados_cant
            // 
            gbx_mostrar_ingresados_cant.Controls.Add(lbx_cant_ingresados_lista);
            gbx_mostrar_ingresados_cant.Location = new Point(357, 130);
            gbx_mostrar_ingresados_cant.Name = "gbx_mostrar_ingresados_cant";
            gbx_mostrar_ingresados_cant.Size = new Size(199, 214);
            gbx_mostrar_ingresados_cant.TabIndex = 7;
            gbx_mostrar_ingresados_cant.TabStop = false;
            gbx_mostrar_ingresados_cant.Text = "Mostrar Cantidad de Ingresados";
            // 
            // lbx_cant_ingresados_lista
            // 
            lbx_cant_ingresados_lista.FormattingEnabled = true;
            lbx_cant_ingresados_lista.ItemHeight = 15;
            lbx_cant_ingresados_lista.Location = new Point(17, 55);
            lbx_cant_ingresados_lista.Name = "lbx_cant_ingresados_lista";
            lbx_cant_ingresados_lista.Size = new Size(120, 154);
            lbx_cant_ingresados_lista.TabIndex = 0;
            // 
            // bt_mostrar_lista_ordenada_
            // 
            bt_mostrar_lista_ordenada_.DialogResult = DialogResult.OK;
            bt_mostrar_lista_ordenada_.Location = new Point(573, 151);
            bt_mostrar_lista_ordenada_.Name = "bt_mostrar_lista_ordenada_";
            bt_mostrar_lista_ordenada_.Size = new Size(75, 62);
            bt_mostrar_lista_ordenada_.TabIndex = 8;
            bt_mostrar_lista_ordenada_.Text = "Mostrar Lista Ordenada";
            bt_mostrar_lista_ordenada_.UseVisualStyleBackColor = true;
            bt_mostrar_lista_ordenada_.Click += bt_mostrar_lista_ordenada__Click;
            // 
            // bt_lista_superioral_promedio
            // 
            bt_lista_superioral_promedio.DialogResult = DialogResult.OK;
            bt_lista_superioral_promedio.Location = new Point(573, 233);
            bt_lista_superioral_promedio.Name = "bt_lista_superioral_promedio";
            bt_lista_superioral_promedio.Size = new Size(75, 80);
            bt_lista_superioral_promedio.TabIndex = 9;
            bt_lista_superioral_promedio.Text = "Mostrar Lista Superior al Promedio";
            bt_lista_superioral_promedio.UseVisualStyleBackColor = true;
            bt_lista_superioral_promedio.Click += bt_lista_superioral_promedio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 382);
            Controls.Add(bt_lista_superioral_promedio);
            Controls.Add(bt_mostrar_lista_ordenada_);
            Controls.Add(gbx_valores);
            Controls.Add(gbx_mostrar_cantidad_ingresados);
            Controls.Add(gbx_procesar_promedio);
            Controls.Add(gbx_procesar_max_min);
            Controls.Add(gb_procesar_numero);
            Controls.Add(gbx_mostrar_ingresados_cant);
            Name = "Form1";
            Text = "Form1";
            gb_procesar_numero.ResumeLayout(false);
            gb_procesar_numero.PerformLayout();
            gbx_procesar_max_min.ResumeLayout(false);
            gbx_procesar_max_min.PerformLayout();
            gbx_procesar_promedio.ResumeLayout(false);
            gbx_procesar_promedio.PerformLayout();
            gbx_mostrar_cantidad_ingresados.ResumeLayout(false);
            gbx_mostrar_cantidad_ingresados.PerformLayout();
            gbx_valores.ResumeLayout(false);
            gbx_valores.PerformLayout();
            gbx_mostrar_ingresados_cant.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox tbx_numero_ingresado_procesar_nro;
        private TextBox tbx_valor_buscado_;
        private GroupBox gb_procesar_numero;
        private Label lbl_ingresar_numero;
        private GroupBox gbx_procesar_max_min;
        private Button bt_actualizar_procesar_maxmin;
        private Label lbl_valor_minimo_procesar_nro;
        private Label lbl_valor_maximo_procesar_nro;
        private ListBox lbx_maximo_;
        private ListBox lbl_minimo_;
        private GroupBox gbx_procesar_promedio;
        private Button bt_promedio_actualizar;
        private ListBox lbx_promedio_;
        private Label lbl_promedio;
        private GroupBox gbx_mostrar_cantidad_ingresados;
        private Button bt_cant_ingresados_actualizar;
        private ListBox lbx_cantidad_ingresados__;
        private Label lbl_cantidad_ingresados_;
        private GroupBox gbx_valores;
        private ListBox lbx_valor_a_buscar_;
        private Button bt_buscar_valor_;
        private Label lbl_valor_a_buscar;
        private GroupBox gbx_mostrar_ingresados_cant;
        private Button bt_mostrar_lista_ordenada_;
        private Button bt_lista_superioral_promedio;
        private ListBox lbx_cant_ingresados_lista;
        private Button bt_registrar_numero_procesar_;
    }
}
