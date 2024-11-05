using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Globalization;

namespace LeCancerCompanySA
{
    public partial class MainForm : Form
    {
        private List<Pacientes> pacientes = new List<Pacientes>();

        public MainForm()
        {
            InitializeComponent();
            ConfigurarCombos();
            ConfigurarDataGrids();
            PrecargarPacientes();

            comboBoxFiltroEdad.SelectedIndexChanged += (s, e) => AplicarFiltros();
            comboBoxFiltrarGenero.SelectedIndexChanged += (s, e) => AplicarFiltros();
            comboBoxFiltrarEnfermo.SelectedIndexChanged += (s, e) => AplicarFiltros(); 

            txtCedula.KeyPress += txtID_KeyPress;
            txtNombre.KeyPress += txtName_KeyPress;
            txtEdad.KeyPress += txtAge_KeyPress;
            txtDeuda.KeyPress += txtDebt_KeyPress;
            btnAgregarPaciente.Click += btnAddPatient_Click;
            btnBorrarGrilla.Click += btnClearDataGridView_Click;
        }



        private void ConfigurarCombos()
        {
            // Opciones para el género en filtros y entrada de datos
            comboBoxGenero.Items.AddRange(new string[] { "Masculino", "Femenino" });
            comboBoxGenero.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxFiltrarGenero.Items.AddRange(new string[] { "Cualquiera", "Masculino", "Femenino" });
            comboBoxFiltrarGenero.SelectedIndex = 0; // Por defecto en "Cualquiera"
            comboBoxFiltrarGenero.DropDownStyle = ComboBoxStyle.DropDownList;

            // Opciones para el estado de salud (Enfermo, Sano, Cualquiera)
            comboBoxFiltrarEnfermo.Items.AddRange(new string[] { "Cualquiera", "Enfermo", "Sano" });
            comboBoxFiltrarEnfermo.SelectedIndex = 0;
            comboBoxFiltrarEnfermo.DropDownStyle = ComboBoxStyle.DropDownList;

            // Opciones de edad en intervalos desde 5 hasta 50, y agregar menores de 5 y mayores de 50
            comboBoxFiltroEdad.Items.Add("Cualquiera");
            comboBoxFiltroEdad.Items.Add("Menor a 5");
            for (int i = 5; i < 50; i += 5)
            {
                comboBoxFiltroEdad.Items.Add($"{i} - {i + 4}");
            }
            comboBoxFiltroEdad.Items.Add("50+");
            comboBoxFiltroEdad.SelectedIndex = 0;
            comboBoxFiltroEdad.DropDownStyle = ComboBoxStyle.DropDownList;

            // Configuración del ComboBox de condición para permitir ingreso personalizado
            comboBoxCondicion.Items.AddRange(new string[]
            {
        "Gripe", "Fractura", "Alergia", "COVID-19", "Diabetes", "Hipertensión",
        "Artritis", "Asma", "Insuficiencia Cardíaca", "Neumonía", "Gastroenteritis",
        "Enfermedad Renal", "Epilepsia", "Migraña", "Obesidad", "Ansiedad", "Depresión", "Otro"
            });

            // Permitir al usuario escribir su propio diagnóstico
            comboBoxCondicion.DropDownStyle = ComboBoxStyle.DropDown;
            comboBoxCondicion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBoxCondicion.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void PrecargarPacientes()
        {
            var precargarPacientes = new List<Pacientes>
    {
        new Pacientes("001", "Juan Perez", 25, "Masculino", true, 1000m, "Diabetes"),
        new Pacientes("002", "Maria Lopez", 40, "Femenino", false, 500m, "Alergia"),
        new Pacientes("003", "Luis Garcia", 12, "Masculino", true, 200m, "Gripe"),
        new Pacientes("004", "Ana Gomez", 30, "Femenino", false, 0m, "Fractura"),
        new Pacientes("005", "Carlos Ruiz", 52, "Masculino", true, 1500m, "Hipertensión"),
        new Pacientes("006", "Elena Diaz", 18, "Femenino", false, 300m, "COVID-19"),
        new Pacientes("007", "Jorge Martinez", 5, "Masculino", true, 700m, "Alergia"),
        new Pacientes("008", "Marta Fernandez", 48, "Femenino", false, 0m, "Otro"),
        new Pacientes("009", "Pedro Sanchez", 34, "Masculino", true, 1000m, "Diabetes"),
        new Pacientes("010", "Laura Castro", 27, "Femenino", true, 800m, "COVID-19"),
        new Pacientes("011", "Raul Torres", 60, "Masculino", false, 400m, "Artritis"),
        new Pacientes("012", "Sofia Ortiz", 7, "Femenino", false, 0m, "Fractura"),
        new Pacientes("013", "Alberto Rios", 21, "Masculino", true, 900m, "Alergia"),
        new Pacientes("014", "Valeria Morales", 50, "Femenino", true, 2000m, "Hipertensión"),
        new Pacientes("015", "Daniel Vega", 16, "Masculino", false, 100m, "Gripe"),
        new Pacientes("016", "Patricia Solis", 36, "Femenino", true, 150m, "Diabetes"),
        new Pacientes("017", "Gonzalo Romero", 45, "Masculino", false, 600m, "COVID-19"),
        new Pacientes("018", "Andrea Ortiz", 39, "Femenino", false, 400m, "Fractura"),
        new Pacientes("019", "Ricardo Hernandez", 15, "Masculino", true, 200m, "Alergia"),
        new Pacientes("020", "Sandra Blanco", 24, "Femenino", false, 0m, "Gripe"),
        new Pacientes("021", "Jose Castillo", 29, "Masculino", true, 1100m, "Artritis"),
        new Pacientes("022", "Paula Estrada", 9, "Femenino", false, 250m, "Otro"),
        new Pacientes("023", "Fernando Navarro", 65, "Masculino", true, 1700m, "Hipertensión"),
        new Pacientes("024", "Beatriz Mendez", 33, "Femenino", true, 800m, "Diabetes"),
        new Pacientes("025", "Lucas Medina", 10, "Masculino", false, 150m, "Fractura"),
        new Pacientes("026", "Carla Soto", 41, "Femenino", true, 600m, "COVID-19"),
        new Pacientes("027", "Pablo Reyes", 8, "Masculino", false, 0m, "Alergia"),
        new Pacientes("028", "Lucia Jimenez", 26, "Femenino", true, 750m, "Hipertensión"),
        new Pacientes("029", "Ramon Silva", 19, "Masculino", false, 300m, "Otro"),
        new Pacientes("030", "Camila Vargas", 38, "Femenino", true, 500m, "Artritis")
    };

            pacientes.AddRange(precargarPacientes);
            ActualizarDataGridViews(); // Actualizar DataGridViews con los pacientes precargados
        }


        private void ConfigurarDataGrids()
        {
            // Configuración de columnas en DataGridViews para pacientes enfermos y sanos
            var columnas = new string[] { "ID", "Nombre", "Edad", "Sexo", "Condición", "Monto de Deuda", "Enfermo" };
            foreach (var column in columnas)
            {
                dataGridPacientesEnfermos?.Columns.Add(column, column);
                dataGridPacientesSaludables?.Columns.Add(column, column);
            }

            // Configuración de columnas en el DataGridView del filtro con un contador
            dataGridViewFiltro?.Columns.Add("Counter", "#");
            dataGridViewFiltro?.Columns.Add("ID", "Cedula");
            dataGridViewFiltro?.Columns.Add("Name", "Nombre");
            dataGridViewFiltro?.Columns.Add("Age", "Edad");
            dataGridViewFiltro?.Columns.Add("Gender", "Sexo");
            dataGridViewFiltro?.Columns.Add("Condition", "Condición");
            dataGridViewFiltro?.Columns.Add("Debt", "Monto de Deuda");
            dataGridViewFiltro?.Columns.Add("IsSick", "Enfermo");
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            int edad;
            decimal deuda;
            string condicion = comboBoxCondicion.Text.Trim(); // Usar el texto actual, ya sea selección o personalizado

            if (!int.TryParse(txtEdad.Text, out edad) || !decimal.TryParse(txtDeuda.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out deuda))
            {
                MessageBox.Show("Edad o Monto de Deuda inválidos.");
                return;
            }

            bool esEnfermo = checkBoxEstaEnfermo.Checked;
            string genero = comboBoxGenero.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(cedula) || string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(genero) || string.IsNullOrWhiteSpace(condicion))
            {
                MessageBox.Show("Por favor llena todos los campos requeridos.");
                return;
            }

            if (pacientes.Any(p => p.Cedula == cedula))
            {
                MessageBox.Show("ID duplicado no permitido.");
                return;
            }

            var paciente = new Pacientes(cedula, nombre, edad, genero, esEnfermo, deuda, condicion);
            pacientes.Add(paciente);

            MessageBox.Show("Paciente añadido. Actualizando DataGridViews...");
            ActualizarDataGridViews();
            ClearInputFields();
        }

        private void ActualizarDataGridViews()
        {
            dataGridPacientesEnfermos.Rows.Clear();
            dataGridPacientesSaludables.Rows.Clear();

            foreach (var paciente in pacientes)
            {
                var targetGrid = paciente.EstaEnfermo ? dataGridPacientesEnfermos : dataGridPacientesSaludables;
                if (targetGrid != null)
                {
                    targetGrid.Rows.Add(
                        paciente.Cedula,
                        paciente.Nombre,
                        paciente.Edad,
                        paciente.Genero,
                        paciente.Condicion,
                        paciente.Deuda.ToString("F2"),  
                        paciente.EstaEnfermo ? "Sí" : "No"
                    );
                }
            }

            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            dataGridViewFiltro.Rows.Clear();

            string filtroGenero = comboBoxFiltrarGenero.SelectedItem?.ToString();
            string estaEnfermoFiltro = comboBoxFiltrarEnfermo.SelectedItem?.ToString();
            string filtroEdad = comboBoxFiltroEdad.SelectedItem?.ToString();

            var pacientesFiltrados = pacientes.Where(p =>
            {
                bool matchGenero = filtroGenero == "Cualquiera" || p.Genero == filtroGenero;
                bool matchEstaEnfermo = estaEnfermoFiltro == "Cualquiera" ||
                                       (estaEnfermoFiltro == "Enfermo" && p.EstaEnfermo) ||
                                       (estaEnfermoFiltro == "Sano" && !p.EstaEnfermo);
                bool edadMatch = filtroEdad == "Cualquiera" || RangoDeEdad(p.Edad, filtroEdad);

                return matchGenero && matchEstaEnfermo && edadMatch;
            });

            int contador = 1;
            decimal totalDeuda = 0;

            foreach (var paciente in pacientesFiltrados)
            {
                dataGridViewFiltro.Rows.Add(
                    contador++,
                    paciente.Cedula,
                    paciente.Nombre,
                    paciente.Edad,
                    paciente.Genero,
                    paciente.Condicion,
                    paciente.Deuda.ToString("F2"),
                    paciente.EstaEnfermo ? "Sí" : "No"
                );
                totalDeuda += paciente.Deuda;
            }

            // Actualizar el TextBox con el monto total de deudas
            txtDeudasTotales.Text = totalDeuda.ToString("F2");

            ActualizarFiltro(pacientesFiltrados);
        }

        private bool RangoDeEdad(int edad, string filtroEdad)
        {
            if (filtroEdad == "Menor a 5")
            {
                return edad < 5;
            }
            else if (filtroEdad == "50+")
            {
                return edad > 50;
            }
            else if (filtroEdad.Contains('-'))
            {
                int min, max;

                var parts = filtroEdad.Split('-');
                if (parts.Length == 2 && int.TryParse(parts[0].Trim(), out min) && int.TryParse(parts[1].Trim(), out max))
                {
                    return edad >= min && edad <= max;
                }
            }
            return false;
        }

        private void ActualizarFiltro(IEnumerable<Pacientes> filteredPatients)
        {
            int totalSick = filteredPatients.Count(p => p.EstaEnfermo);
            int totalHealthy = filteredPatients.Count(p => !p.EstaEnfermo);
            decimal totalDebt = filteredPatients.Sum(p => p.Deuda);

            txtEnfermosTotales.Text = totalSick.ToString();
            txtSaludablesTotales.Text = totalHealthy.ToString();
            txtDeudasTotales.Text = totalDebt.ToString("F2");
        }

        private void ClearInputFields()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtEdad.Clear();
            txtDeuda.Clear();
            comboBoxGenero.SelectedIndex = -1;
            comboBoxCondicion.SelectedIndex = -1;
            checkBoxEstaEnfermo.Checked = false;
        }

        private void btnClearDataGridView_Click(object sender, EventArgs e)
        {
            if (checkBoxPacientesEnfermos.Checked)
                dataGridPacientesEnfermos.Rows.Clear();

            if (checkBoxPacientesSaludables.Checked)
                dataGridPacientesSaludables.Rows.Clear();

            if (checkBoxFiltro.Checked)
            {
                // Recolectar las cédulas de los pacientes que están en el filtro
                List<string> cedulasAEliminar = new List<string>();
                foreach (DataGridViewRow row in dataGridViewFiltro.Rows)
                {
                    if (row.Cells["ID"].Value != null)
                        cedulasAEliminar.Add(row.Cells["ID"].Value.ToString());
                }

                // Limpiar el DataGridView del filtro
                dataGridViewFiltro.Rows.Clear();

                // Eliminar de la lista de pacientes las cédulas recolectadas
                pacientes = pacientes.Where(p => !cedulasAEliminar.Contains(p.Cedula)).ToList();

                // Actualizar los DataGridViews de pacientes enfermos y sanos
                ActualizarDataGridViews();
            }
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar);
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtDebt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar);
        }
    }
}
