using System;

namespace SelectMonth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtMes.Enabled = false;
        }

        private void bntProcesar_Click(object sender, EventArgs e)
        {
            String numeroSelected = (string)cmbNumero.SelectedItem;
            String mes = "";

            if (string.IsNullOrWhiteSpace(numeroSelected))
            {
                MessageBox.Show("Seleccione un número para continuar.", "Campa no seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int numero = 0;
                bool esNumero = int.TryParse(numeroSelected, out numero);

                if (esNumero)
                {
                    switch (numero)
                    {
                        case 1:
                            {
                                mes = "Enero";
                                break;
                            }
                        case 2:
                            {
                                mes = "Febrero";
                                break;
                            }
                        case 3:
                            {
                                mes = "Marzo";
                                break;
                            }
                        case 4:
                            {
                                mes = "Abril";
                                break;
                            }
                        case 5:
                            {
                                mes = "Mayo";
                                break;
                            }
                        case 6:
                            {
                                mes = "Junio";
                                break;
                            }
                        case 7:
                            {
                                mes = "Julio";
                                break;
                            }
                        case 8:
                            {
                                mes = "Agosto";
                                break;
                            }
                        case 9:
                            {
                                mes = "Septiembre";
                                break;
                            }
                        case 10:
                            {
                                mes = "Octubre";
                                break;
                            }
                        case 11:
                            {
                                mes = "Noviembre";
                                break;
                            }
                        case 12:
                            {
                                mes = "Diciembre";
                                break;
                            }
                    }
                }
                else
                {
                    MessageBox.Show("Has seleccionado un valor inválido.", "Valor inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                txtMes.Text = mes;
            }
        }
    }
}
