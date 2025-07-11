using System.ComponentModel.Design.Serialization;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _11_2_1_vectores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Servicio _servicio = new Servicio();
        //private int _contadorIngresados = 0;

        int contador = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tbx_numero_ingresado_procesar_nro_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt_registrar_numero_procesar__Click(object sender, EventArgs e)
        {
           int numero = Convert.ToInt32(tbx_numero_ingresado_procesar_nro.Text);
            _servicio.RegistrarValor(numero);
            contador++;
            tbx_numero_ingresado_procesar_nro.Clear();
           
        }

        private void lbx_maximo__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_minimo__SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_actualizar_procesar_maxmin_Click(object sender, EventArgs e)
        {
            double max = _servicio.CalcularMaximo();
            lbx_maximo_.Items.Clear();
            lbx_maximo_.Items.Add(max);

            double min = _servicio.CalcularMinimo();
            lbl_minimo_.Items.Clear();
            lbl_minimo_.Items.Add(min);

        }

        private void bt_promedio_actualizar_Click(object sender, EventArgs e)
        {
            double promedio = _servicio.CalcularPromedio();
            lbx_promedio_.Items.Clear();
            lbx_promedio_.Items.Add(promedio);
        }

        private void bt_cant_ingresados_actualizar_Click(object sender, EventArgs e)
        {
            // int ingresados = _contadorIngresados;
            lbx_cantidad_ingresados__.Items.Clear();
            lbx_cantidad_ingresados__.Items.Add(contador);
        }

        private void tbx_valor_buscado__TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_buscar_valor__Click(object sender, EventArgs e)
        {
            int valorBuscado = Convert.ToInt32(tbx_valor_buscado_.Text);
            int pos = _servicio.BuscarValor(valorBuscado);

            lbx_valor_a_buscar_.Items.Clear();

            if (pos != -1)
                lbx_valor_a_buscar_.Items.Add("Valor encontrado en la posición: " + pos);
            else
                lbx_valor_a_buscar_.Items.Add("Valor no encontrado.");
        }

        private void bt_mostrar_lista_ordenada__Click(object sender, EventArgs e)
        {
            _servicio.OrdenarLista();
            lbx_cant_ingresados_lista.Items.Clear();

            for (int i = 0; i < contador; i++)  
                lbx_cant_ingresados_lista.Items.Add(_servicio.lista[i]);
        }

        private void bt_lista_superioral_promedio_Click(object sender, EventArgs e)
        {
            int promedio;
            int[] listaFiltrada = _servicio.ListaSuperioresAlPromedio(out promedio);

            if (listaFiltrada.Length > 0)
            {

                lbx_cant_ingresados_lista.Items.Clear();

                foreach (int n in listaFiltrada)
                    lbx_cant_ingresados_lista.Items.Add(n);
            }

            else MessageBox.Show("No hay números superiores al Promedio");
        }

       
    }
}
    