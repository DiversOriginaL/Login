﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain.Domain;
using Presentacion.FormsButton.Paciente.FormHijos.FormEstadoSalud;
using System.Runtime.InteropServices;
using Presentacion.FormsButton.Paciente;

namespace Presentacion.FormsButton.Paciente.FormHijos
{
    public partial class CrudPaciente : Form
    {
        public CrudPaciente()
        {
            InitializeComponent();
        }
        public Pacientes pacienteForm;
        public CrudPaciente(Pacientes pacienteForm) : this()
        {
            this.pacienteForm = pacienteForm;
        }

        #region MoverFormulario.
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private static extern void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, IntPtr wParam, IntPtr lParam);

        private void CrudPaciente_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, (IntPtr)0xf012, (IntPtr)0);
        }
        #endregion

        #region EfectoPlaceHolder y Configuracion de controles
        
        private void txtPnombre_Enter(object sender, EventArgs e)
        {
            if(txtPnombre.Text == "PRIMER NOMBRE:")
            {
                txtPnombre.Text = "";
                txtPnombre.ForeColor = Color.Black;
            }
        }

        private void txtPnombre_Leave(object sender, EventArgs e)
        {
            if (txtPnombre.Text == "")
            {
                txtPnombre.Text = "PRIMER NOMBRE:";
                txtPnombre.ForeColor = Color.Silver;
            }

        }

        private void txtSnombre_Enter(object sender, EventArgs e)
        {
            if (txtSnombre.Text == "SEGUNDO NOMBRE:")
            {
                txtSnombre.Text = "";
                txtSnombre.ForeColor = Color.Black;
            }

        }

        private void txtSnombre_Leave(object sender, EventArgs e)
        {
            if (txtSnombre.Text == "")
            {
                txtSnombre.Text = "SEGUNDO NOMBRE:";
                txtSnombre.ForeColor = Color.Silver;
            }

        }

        private void txtPapellido_Enter(object sender, EventArgs e)
        {
            if (txtPapellido.Text == "PRIMER APELLIDO:")
            {
                txtPapellido.Text = "";
                txtPapellido.ForeColor = Color.Black;
            }

        }

        private void txtPapellido_Leave(object sender, EventArgs e)
        {
            if (txtPapellido.Text == "")
            {
                txtPapellido.Text = "PRIMER APELLIDO:";
                txtPapellido.ForeColor = Color.Silver;
            }

        }

        private void txtSapellido_Enter(object sender, EventArgs e)
        {
            if (txtSapellido.Text == "SEGUNDO APELLIDO:")
            {
                txtSapellido.Text = "";
                txtSapellido.ForeColor = Color.Black;
            }

        }

        private void txtSapellido_Leave(object sender, EventArgs e)
        {
            if (txtSapellido.Text == "")
            {
                txtSapellido.Text = "SEGUNDO APELLIDO:";
                txtSapellido.ForeColor = Color.Silver;
            }

        }
        private void txtCedula_Enter(object sender, EventArgs e)
        {
            if(txtCedula.Text == "CEDULA:")
            {
                txtCedula.Text = "";
                txtCedula.ForeColor = Color.Black;
            }
        }
        private void txtCedula_Leave(object sender, EventArgs e)
        {
            if(txtCedula.Text == "")
            {
                txtCedula.Text = "CEDULA:";
                txtCedula.ForeColor = Color.Silver;
            }
        }

        private void txtEdad_Enter(object sender, EventArgs e)
        {
            if (txtEdad.Text == "EDAD:")
            {
                txtEdad.Text = "";
                txtEdad.ForeColor = Color.Black;
            }

        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            if (txtEdad.Text == "")
            {
                txtEdad.Text = "EDAD:";
                txtEdad.ForeColor = Color.Silver;
            }
        }
        private void cbSexo_Leave(object sender, EventArgs e)
        {
            if (cbSexo.SelectedIndex >= 0)
                cbSexo.ForeColor = Color.Black;

            if (string.IsNullOrWhiteSpace(cbSexo.Text) || cbSexo.Text == "SEXO:")
            {
                MessageBox.Show("Por favor, Seleccione 1 valor.");
                cbSexo.Focus();
                return;
            }
        }

        private void txtCelular_Enter(object sender, EventArgs e)
        {
            if (txtCelular.Text == "CELULAR:")
            {
                txtCelular.Text = "";
                txtCelular.ForeColor = Color.Black;
            }

        }

        private void txtCelular_Leave(object sender, EventArgs e)
        {
            if (txtCelular.Text == "")
            {
                txtCelular.Text = "CELULAR:";
                txtCelular.ForeColor = Color.Silver;
            }

        }

        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "TELEFONO:")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }

        }

        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "TELEFONO:";
                txtTelefono.ForeColor = Color.Silver;
            }
        }
        private void cbProvincia_Enter(object sender, EventArgs e)
        {
            if (cbProvincia.Text == "PROVINCIA/MUNICIPIO:")
            {
                cbProvincia.Text = "";
                cbProvincia.ForeColor = Color.Black;
            }
        }

        private void cbProvincia_Leave(object sender, EventArgs e)
        {
            if (cbProvincia.Text == "")
            {
                cbProvincia.Text = "PROVINCIA/MUNICIPIO:";
                cbProvincia.ForeColor = Color.Silver;
            }

            if (string.IsNullOrWhiteSpace(cbProvincia.Text) || cbProvincia.Text == "PROVINCIA/MUNICIPIO:")
            {
                MessageBox.Show("Por favor, Seleccione donde vive.");
                cbProvincia.Focus();
                return;
            }

        }

        private void txtSector_Enter(object sender, EventArgs e)
        {
            if (txtSector.Text == "SECTOR:")
            {
                txtSector.Text = "";
                txtSector.ForeColor = Color.Black;
            }
        }

        private void txtSector_Leave(object sender, EventArgs e)
        {
            if (txtSector.Text == "")
            {
                txtSector.Text = "SECTOR:";
                txtSector.ForeColor = Color.Silver;
            }

        }

        private void txtCalle_Enter(object sender, EventArgs e)
        {
            if (txtCalle.Text == "CALLE:")
            {
                txtCalle.Text = "";
                txtCalle.ForeColor = Color.Black;
            }
        }

        private void txtCalle_Leave(object sender, EventArgs e)
        {
            if(txtCalle.Text == "")
            {
                txtCalle.Text = "CALLE:";
                txtCalle.ForeColor = Color.Silver;
            }

        }

        private void txtNumCasa_Enter(object sender, EventArgs e)
        {
            if (txtNumCasa.Text == "NUMERO DE CASA:")
            {
                txtNumCasa.Text = "";
                txtNumCasa.ForeColor = Color.Black;
            }
        }

        private void txtNumCasa_Leave(object sender, EventArgs e)
        {
            if (txtNumCasa.Text == "")
            {
                txtNumCasa.Text = "NUMERO DE CASA:";
                txtNumCasa.ForeColor = Color.Silver;
            }

        }
        //Cerra, maximizar y minimizar.
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            txtPnombre.Text = "PRIMER NOMBRE:";
            txtSnombre.Text = "SEGUNDO NOMBRE:";
            txtPapellido.Text = "PRIMER APELLIDO";
            txtSapellido.Text = "SEGUNDO APELLIDO:";
            txtEdad.Text = "EDAD:";
            cbSexo.Text = "SEXO:";
            txtCelular.Text = "CELULAR:";
            txtTelefono.Text = "TELEFONO:";
            txtSector.Text = "SECTOR:";
            txtCalle.Text = "CALLE:";
            txtNumCasa.Text = "NUMERO DE CASA:";
            this.Close();

        }

        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else WindowState = FormWindowState.Maximized;

        }

        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        //ABRIR FORMULARIO HIJO
        private void AbrirFormulario<MiForm>(CrudPaciente crudPacienteForm) where MiForm : Form, new()
        {
            EstadoSalud formulario;
            formulario = Application.OpenForms.OfType<EstadoSalud>().FirstOrDefault();

            if(formulario == null)
            {
                formulario = new EstadoSalud(crudPacienteForm);
                formulario.TopLevel = true;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.StartPosition = FormStartPosition.CenterParent;
                formulario.ShowDialog();
                formulario.BringToFront();
            }
            else formulario.BringToFront();

        }

        private void AbrirFormularioEditar<MiForm>(CrudPaciente crudPaciente) where MiForm : Form
        {
            EstadoSalud estadoSaludForm = Application.OpenForms.OfType<EstadoSalud>().FirstOrDefault();

            if(estadoSaludForm == null)
            {
                estadoSaludForm = new EstadoSalud(crudPaciente);
                estadoSaludForm.TopLevel = true;
                estadoSaludForm.FormBorderStyle = FormBorderStyle.None;
                estadoSaludForm.StartPosition = FormStartPosition.CenterScreen;
                estadoSaludForm.cargarValoresSalud(enfermedad, medicamento, alergia, embarazo);
                estadoSaludForm.ShowDialog();
                estadoSaludForm.BringToFront();
            }

        }
        private void btnEstadoSalud_Click(object sender, EventArgs e)
        {
            if (operacion == "Insertar")
            {
                AbrirFormulario<EstadoSalud>(this);
            }else if(operacion == "Editar")
            {
                AbrirFormularioEditar<EstadoSalud>(this);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPnombre.Text = "PRIMER NOMBRE:";
            txtSnombre.Text = "SEGUNDO NOMBRE:";
            txtPapellido.Text = "PRIMER APELLIDO";
            txtSapellido.Text = "SEGUNDO APELLIDO:";
            txtEdad.Text = "EDAD:";
            cbSexo.Text = "SEXO:";
            txtCelular.Text = "CELULAR:";
            txtTelefono.Text = "TELEFONO:";
            txtSector.Text = "SECTOR:";
            txtNumCasa.Text = "NUMERO DE CASA:";
            this.Close();

        }

        CnPaciente cnPaciente = new CnPaciente();

        private string idPaciente;
        public string operacion = "Insertar";

        string enfermedad;
        string medicamento;
        string alergia;
        string embarazo;
        

        public void GetDatosSalud(string enfermedad, string medicamento, string alergia, string embarazo)
        {
            this.enfermedad = enfermedad;
            this.medicamento = medicamento;
            this.alergia = alergia;
            this.embarazo = embarazo;
        }
        
        // Estas dos funciones EnviarDatosSalud y CargarValores es cuando se va editar alguna fila de dtgvPacientes
        public void EnviarDatosSalud(string enfermedad, string medicamento, string alergia, string embarazo)
        {
            this.enfermedad = enfermedad;
            this.medicamento = medicamento;
            this.alergia = alergia;
            this.embarazo = embarazo;
        }

        public void CargarValores
        (
            string id, string pnombre, string snombre, string papellido, string sapellido, string cedula, string edad, string sexo,
            string celular, string telefono, string provincia, string sector, string calle, string numcasa
        )
        {
            idPaciente = id;
            txtPnombre.Text = pnombre;
            txtSnombre.Text = snombre;
            txtPapellido.Text = papellido;
            txtSapellido.Text = sapellido;
            txtCedula.Text = cedula;
            txtEdad.Text = edad;
            cbSexo.Text = sexo;
            txtCelular.Text = celular;
            txtTelefono.Text = telefono;
            cbProvincia.Text = provincia;
            txtSector.Text = sector;
            txtCalle.Text = calle;
            txtNumCasa.Text = numcasa;

            #region Diseño
            txtPnombre.ForeColor = Color.Black;
            txtSnombre.ForeColor = Color.Black;
            txtPapellido.ForeColor = Color.Black;
            txtSapellido.ForeColor = Color.Black;
            txtCedula.ForeColor = Color.Silver;
            txtEdad.ForeColor = Color.Black;
            cbSexo.ForeColor = Color.Black;
            txtCelular.ForeColor = Color.Black;
            txtTelefono.ForeColor = Color.Black;
            cbProvincia.ForeColor = Color.Black;
            txtSector.ForeColor = Color.Black;
            txtCalle.ForeColor = Color.Black;
            txtNumCasa.ForeColor = Color.Black;
            #endregion
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (
                !rellenarCampo(txtPnombre, "PRIMER NOMBRE:") || !rellenarCampo(txtSnombre, "SEGUNDO NOMBRE:") ||
                !rellenarCampo(txtPapellido, "PRIMER APELLIDO:") || !rellenarCampo(txtSapellido, "SEGUNDO APELLIDO:") ||
                !rellenarCampo(txtCedula, "CEDULA:") || !rellenarCampo(txtEdad, "EDAD:") || !rellenarCampo(cbSexo, "SEXO:") || !rellenarCampo(txtCelular, "CELULAR:") ||
                !rellenarCampo(cbProvincia, "PROVINCIA / MUNICIPIO:") || !rellenarCampo(txtSector, "SECTOR:") ||
                !rellenarCampo(txtCalle, "CALLE:") || !rellenarCampo(txtNumCasa, "NUMERO DE CASA:")
                )
            {
                return; // Si la validación de campos falla, salimos del método
            }

            string pnombre = txtPnombre.Text;
            string snombre = txtSnombre.Text;
            string papellido = txtPapellido.Text;
            string sapellido = txtSapellido.Text;
            string cedula = txtCedula.Text;
            string edad = txtEdad.Text;
            object sexo = cbSexo.SelectedItem;
            string celular = txtCelular.Text;
            string telefono = txtTelefono.Text;
            object provincia = cbProvincia.SelectedItem;
            string sector = txtSector.Text;
            string calle = txtCalle.Text;
            string numcasa = txtNumCasa.Text;

            try
            {
                if (operacion == "Insertar")
                {
                    cnPaciente.insertarPaciente
                    (
                        pnombre, snombre, papellido, sapellido, cedula, edad, sexo,
                        celular, telefono, provincia, sector, calle, numcasa,
                        enfermedad, medicamento, alergia, embarazo
                    );
                    MessageBox.Show("PACIENTE INSERTADO CORRECTAMENTE.");
                    
                }
                else if(operacion == "Editar")
                {
                    if (string.IsNullOrEmpty(idPaciente))
                    {
                        MessageBox.Show("NO SE HA SELECCIONADO NINGUN PACIENTE PARA EDITAR.");
                        return;
                    }

                    cnPaciente.editarPaciente
                    (
                        idPaciente, pnombre, snombre, papellido, sapellido, cedula, edad, sexo, 
                        celular, telefono, provincia, sector, calle, numcasa,
                        enfermedad, medicamento, alergia, embarazo
                    );
                    operacion = "Insertar";
                }

                if(pacienteForm != null)
                {
                    pacienteForm.Actualizardtgv();
                }

                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }


        #region Cofiguracion de campos (texto o numero)

        #region Configuraciones de Funciones del textbox
        private bool rellenarCampo(TextBox txtBox, string texto)
        {
            if (string.IsNullOrWhiteSpace(txtBox.Text) || txtBox.Text == texto)
            {
                MessageBox.Show($"POR FAVOR, RELLENE EL CAMPO {texto} CON LA INFORMACION CORRECTA!");
                txtBox.Focus();
                return false;
            }
            return true;
        }

        private bool rellenarCampo(ComboBox cbBox, string texto)
        {
            if (string.IsNullOrWhiteSpace(cbBox.Text) || cbBox.Text == texto)
            {
                MessageBox.Show($"POR FAVOR, RELLENE EL CAMPO {texto} CON LA INFORMACION CORRECTA!");
                cbBox.Focus();
                return false;
            }
            return true;
        }

        private void soloNumero(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void soloTexto(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }

        private void mayusculaFirst(TextBox txtBox, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && (txtBox.Text.Length == 0 || txtBox.SelectionStart == 0))
            {
                // Convierte la letra a mayúscula
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        #endregion

        private void txtPnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender, e);
            mayusculaFirst(txtPnombre, e);
        }

        private void txtSnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender, e);
            mayusculaFirst(txtSnombre, e);
        }

        private void txtPapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender, e);
            mayusculaFirst(txtPapellido, e);
        }

        private void txtSapellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender, e);
            mayusculaFirst(txtSapellido, e);
        }
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
            mayusculaFirst(txtEdad, e);
        }
        private void cbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender, e);
        }

        private void txtCelular_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumero(sender, e);
        }

        private void txtSector_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloTexto(sender, e);
            mayusculaFirst(txtSector, e);
        }

        private void txtCalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            mayusculaFirst(txtCalle, e);
        }

        private void txtNumCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumCasa.Text) && e.KeyChar != '#')
            {
                // Se establece el carácter deseado
                txtNumCasa.Text = "#";
                // Se coloca el cursor al final del TextBox
                txtNumCasa.SelectionStart = txtNumCasa.Text.Length;
                // Se indica que se ha manejado el evento
                e.Handled = true;
            }
        }

        #endregion

    }
}
