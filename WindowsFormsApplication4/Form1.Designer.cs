namespace LeCancerCompanySA
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridPacientesEnfermos;
        private System.Windows.Forms.DataGridView dataGridPacientesSaludables;
        private System.Windows.Forms.DataGridView dataGridViewFiltro;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtDeuda;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxAgeFilter;
        private System.Windows.Forms.CheckBox checkBoxEstaEnfermo;
        private System.Windows.Forms.Button btnAgregarPaciente;
        private System.Windows.Forms.Button btnBorrarGrilla;
        private System.Windows.Forms.TextBox txtEnfermosTotales;
        private System.Windows.Forms.TextBox txtSaludablesTotales;
        private System.Windows.Forms.TextBox txtDeudasTotales;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblDeuda;
        private System.Windows.Forms.Label lblGenero;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblCedula = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblDeuda = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtDeuda = new System.Windows.Forms.TextBox();
            this.dataGridPacientesEnfermos = new System.Windows.Forms.DataGridView();
            this.dataGridPacientesSaludables = new System.Windows.Forms.DataGridView();
            this.dataGridViewFiltro = new System.Windows.Forms.DataGridView();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxAgeFilter = new System.Windows.Forms.ComboBox();
            this.checkBoxEstaEnfermo = new System.Windows.Forms.CheckBox();
            this.btnAgregarPaciente = new System.Windows.Forms.Button();
            this.btnBorrarGrilla = new System.Windows.Forms.Button();
            this.txtEnfermosTotales = new System.Windows.Forms.TextBox();
            this.txtSaludablesTotales = new System.Windows.Forms.TextBox();
            this.txtDeudasTotales = new System.Windows.Forms.TextBox();
            this.comboBoxCondicion = new System.Windows.Forms.ComboBox();
            this.lblCondicion = new System.Windows.Forms.Label();
            this.comboBoxFiltroEdad = new System.Windows.Forms.ComboBox();
            this.comboBoxFiltrarGenero = new System.Windows.Forms.ComboBox();
            this.lblFiltroEdad = new System.Windows.Forms.Label();
            this.lblFiltrarGenero = new System.Windows.Forms.Label();
            this.lblEnfermosTotales = new System.Windows.Forms.Label();
            this.lblSaludablesTotales = new System.Windows.Forms.Label();
            this.lblDeudaTotal = new System.Windows.Forms.Label();
            this.labelFiltrarEnfermo = new System.Windows.Forms.Label();
            this.comboBoxFiltrarEnfermo = new System.Windows.Forms.ComboBox();
            this.checkBoxPacientesEnfermos = new System.Windows.Forms.CheckBox();
            this.checkBoxPacientesSaludables = new System.Windows.Forms.CheckBox();
            this.checkBoxFiltro = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientesEnfermos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientesSaludables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltro)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCedula
            // 
            this.lblCedula.Location = new System.Drawing.Point(20, 5);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(100, 15);
            this.lblCedula.TabIndex = 0;
            this.lblCedula.Text = "Cédula";
            // 
            // lblNombre
            // 
            this.lblNombre.Location = new System.Drawing.Point(130, 5);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(100, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblEdad
            // 
            this.lblEdad.Location = new System.Drawing.Point(290, 5);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(60, 15);
            this.lblEdad.TabIndex = 2;
            this.lblEdad.Text = "Edad";
            // 
            // lblDeuda
            // 
            this.lblDeuda.Location = new System.Drawing.Point(360, 5);
            this.lblDeuda.Name = "lblDeuda";
            this.lblDeuda.Size = new System.Drawing.Size(80, 15);
            this.lblDeuda.TabIndex = 3;
            this.lblDeuda.Text = "Deuda";
            // 
            // lblGenero
            // 
            this.lblGenero.Location = new System.Drawing.Point(450, 5);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(80, 15);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Género";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(20, 25);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(130, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(290, 25);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(60, 20);
            this.txtEdad.TabIndex = 2;
            // 
            // txtDeuda
            // 
            this.txtDeuda.Location = new System.Drawing.Point(360, 25);
            this.txtDeuda.Name = "txtDeuda";
            this.txtDeuda.Size = new System.Drawing.Size(80, 20);
            this.txtDeuda.TabIndex = 3;
            // 
            // dataGridPacientesEnfermos
            // 
            this.dataGridPacientesEnfermos.Location = new System.Drawing.Point(20, 68);
            this.dataGridPacientesEnfermos.Name = "dataGridPacientesEnfermos";
            this.dataGridPacientesEnfermos.Size = new System.Drawing.Size(410, 200);
            this.dataGridPacientesEnfermos.TabIndex = 7;
            // 
            // dataGridPacientesSaludables
            // 
            this.dataGridPacientesSaludables.Location = new System.Drawing.Point(436, 68);
            this.dataGridPacientesSaludables.Name = "dataGridPacientesSaludables";
            this.dataGridPacientesSaludables.Size = new System.Drawing.Size(410, 200);
            this.dataGridPacientesSaludables.TabIndex = 8;
            // 
            // dataGridViewFiltro
            // 
            this.dataGridViewFiltro.Location = new System.Drawing.Point(20, 287);
            this.dataGridViewFiltro.Name = "dataGridViewFiltro";
            this.dataGridViewFiltro.Size = new System.Drawing.Size(710, 150);
            this.dataGridViewFiltro.TabIndex = 9;
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenero.Location = new System.Drawing.Point(450, 25);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(80, 21);
            this.comboBoxGenero.TabIndex = 4;
            // 
            // comboBoxAgeFilter
            // 
            this.comboBoxAgeFilter.Location = new System.Drawing.Point(0, 0);
            this.comboBoxAgeFilter.Name = "comboBoxAgeFilter";
            this.comboBoxAgeFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgeFilter.TabIndex = 0;
            // 
            // checkBoxEstaEnfermo
            // 
            this.checkBoxEstaEnfermo.Location = new System.Drawing.Point(660, 25);
            this.checkBoxEstaEnfermo.Name = "checkBoxEstaEnfermo";
            this.checkBoxEstaEnfermo.Size = new System.Drawing.Size(70, 20);
            this.checkBoxEstaEnfermo.TabIndex = 5;
            this.checkBoxEstaEnfermo.Text = "Enfermo";
            // 
            // btnAgregarPaciente
            // 
            this.btnAgregarPaciente.Location = new System.Drawing.Point(736, 23);
            this.btnAgregarPaciente.Name = "btnAgregarPaciente";
            this.btnAgregarPaciente.Size = new System.Drawing.Size(120, 25);
            this.btnAgregarPaciente.TabIndex = 6;
            this.btnAgregarPaciente.Text = "Agregar Paciente";
            // 
            // btnBorrarGrilla
            // 
            this.btnBorrarGrilla.Location = new System.Drawing.Point(648, 457);
            this.btnBorrarGrilla.Name = "btnBorrarGrilla";
            this.btnBorrarGrilla.Size = new System.Drawing.Size(120, 25);
            this.btnBorrarGrilla.TabIndex = 10;
            this.btnBorrarGrilla.Text = "Limpiar Grilla";
            // 
            // txtEnfermosTotales
            // 
            this.txtEnfermosTotales.Location = new System.Drawing.Point(20, 485);
            this.txtEnfermosTotales.Name = "txtEnfermosTotales";
            this.txtEnfermosTotales.Size = new System.Drawing.Size(100, 20);
            this.txtEnfermosTotales.TabIndex = 11;
            // 
            // txtSaludablesTotales
            // 
            this.txtSaludablesTotales.Location = new System.Drawing.Point(224, 485);
            this.txtSaludablesTotales.Name = "txtSaludablesTotales";
            this.txtSaludablesTotales.Size = new System.Drawing.Size(100, 20);
            this.txtSaludablesTotales.TabIndex = 12;
            // 
            // txtDeudasTotales
            // 
            this.txtDeudasTotales.Location = new System.Drawing.Point(430, 485);
            this.txtDeudasTotales.Name = "txtDeudasTotales";
            this.txtDeudasTotales.Size = new System.Drawing.Size(100, 20);
            this.txtDeudasTotales.TabIndex = 13;
            // 
            // comboBoxCondicion
            // 
            this.comboBoxCondicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCondicion.Location = new System.Drawing.Point(548, 25);
            this.comboBoxCondicion.Name = "comboBoxCondicion";
            this.comboBoxCondicion.Size = new System.Drawing.Size(94, 21);
            this.comboBoxCondicion.TabIndex = 14;
            // 
            // lblCondicion
            // 
            this.lblCondicion.Location = new System.Drawing.Point(545, 5);
            this.lblCondicion.Name = "lblCondicion";
            this.lblCondicion.Size = new System.Drawing.Size(80, 15);
            this.lblCondicion.TabIndex = 15;
            this.lblCondicion.Text = "Condición";
            // 
            // comboBoxFiltroEdad
            // 
            this.comboBoxFiltroEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltroEdad.Location = new System.Drawing.Point(736, 309);
            this.comboBoxFiltroEdad.Name = "comboBoxFiltroEdad";
            this.comboBoxFiltroEdad.Size = new System.Drawing.Size(94, 21);
            this.comboBoxFiltroEdad.TabIndex = 16;
            // 
            // comboBoxFiltrarGenero
            // 
            this.comboBoxFiltrarGenero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrarGenero.Location = new System.Drawing.Point(736, 364);
            this.comboBoxFiltrarGenero.Name = "comboBoxFiltrarGenero";
            this.comboBoxFiltrarGenero.Size = new System.Drawing.Size(94, 21);
            this.comboBoxFiltrarGenero.TabIndex = 17;
            // 
            // lblFiltroEdad
            // 
            this.lblFiltroEdad.Location = new System.Drawing.Point(734, 291);
            this.lblFiltroEdad.Name = "lblFiltroEdad";
            this.lblFiltroEdad.Size = new System.Drawing.Size(80, 15);
            this.lblFiltroEdad.TabIndex = 19;
            this.lblFiltroEdad.Text = "Filtrar Edad:";
            // 
            // lblFiltrarGenero
            // 
            this.lblFiltrarGenero.Location = new System.Drawing.Point(736, 346);
            this.lblFiltrarGenero.Name = "lblFiltrarGenero";
            this.lblFiltrarGenero.Size = new System.Drawing.Size(80, 15);
            this.lblFiltrarGenero.TabIndex = 20;
            this.lblFiltrarGenero.Text = "Filtrar Género:";
            // 
            // lblEnfermosTotales
            // 
            this.lblEnfermosTotales.Location = new System.Drawing.Point(20, 467);
            this.lblEnfermosTotales.Name = "lblEnfermosTotales";
            this.lblEnfermosTotales.Size = new System.Drawing.Size(100, 15);
            this.lblEnfermosTotales.TabIndex = 21;
            this.lblEnfermosTotales.Text = "Enfermos Totales";
            // 
            // lblSaludablesTotales
            // 
            this.lblSaludablesTotales.Location = new System.Drawing.Point(221, 467);
            this.lblSaludablesTotales.Name = "lblSaludablesTotales";
            this.lblSaludablesTotales.Size = new System.Drawing.Size(100, 15);
            this.lblSaludablesTotales.TabIndex = 22;
            this.lblSaludablesTotales.Text = "Saludables Totales";
            // 
            // lblDeudaTotal
            // 
            this.lblDeudaTotal.Location = new System.Drawing.Point(427, 467);
            this.lblDeudaTotal.Name = "lblDeudaTotal";
            this.lblDeudaTotal.Size = new System.Drawing.Size(100, 15);
            this.lblDeudaTotal.TabIndex = 23;
            this.lblDeudaTotal.Text = "Deuda Total";
            // 
            // labelFiltrarEnfermo
            // 
            this.labelFiltrarEnfermo.Location = new System.Drawing.Point(736, 402);
            this.labelFiltrarEnfermo.Name = "labelFiltrarEnfermo";
            this.labelFiltrarEnfermo.Size = new System.Drawing.Size(80, 15);
            this.labelFiltrarEnfermo.TabIndex = 25;
            this.labelFiltrarEnfermo.Text = "Filtrar Enfermo:";
            // 
            // comboBoxFiltrarEnfermo
            // 
            this.comboBoxFiltrarEnfermo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFiltrarEnfermo.Location = new System.Drawing.Point(736, 420);
            this.comboBoxFiltrarEnfermo.Name = "comboBoxFiltrarEnfermo";
            this.comboBoxFiltrarEnfermo.Size = new System.Drawing.Size(94, 21);
            this.comboBoxFiltrarEnfermo.TabIndex = 24;
            // 
            // checkBoxPacientesEnfermos
            // 
            this.checkBoxPacientesEnfermos.Location = new System.Drawing.Point(597, 485);
            this.checkBoxPacientesEnfermos.Name = "checkBoxPacientesEnfermos";
            this.checkBoxPacientesEnfermos.Size = new System.Drawing.Size(70, 20);
            this.checkBoxPacientesEnfermos.TabIndex = 26;
            this.checkBoxPacientesEnfermos.Text = "Enfermos";
            // 
            // checkBoxPacientesSaludables
            // 
            this.checkBoxPacientesSaludables.Location = new System.Drawing.Point(673, 485);
            this.checkBoxPacientesSaludables.Name = "checkBoxPacientesSaludables";
            this.checkBoxPacientesSaludables.Size = new System.Drawing.Size(78, 20);
            this.checkBoxPacientesSaludables.TabIndex = 27;
            this.checkBoxPacientesSaludables.Text = "Saludables";
            // 
            // checkBoxFiltro
            // 
            this.checkBoxFiltro.Location = new System.Drawing.Point(751, 485);
            this.checkBoxFiltro.Name = "checkBoxFiltro";
            this.checkBoxFiltro.Size = new System.Drawing.Size(70, 20);
            this.checkBoxFiltro.TabIndex = 28;
            this.checkBoxFiltro.Text = "Filtro";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(860, 521);
            this.Controls.Add(this.checkBoxFiltro);
            this.Controls.Add(this.checkBoxPacientesSaludables);
            this.Controls.Add(this.checkBoxPacientesEnfermos);
            this.Controls.Add(this.labelFiltrarEnfermo);
            this.Controls.Add(this.comboBoxFiltrarEnfermo);
            this.Controls.Add(this.lblDeudaTotal);
            this.Controls.Add(this.lblSaludablesTotales);
            this.Controls.Add(this.lblEnfermosTotales);
            this.Controls.Add(this.lblFiltrarGenero);
            this.Controls.Add(this.lblFiltroEdad);
            this.Controls.Add(this.comboBoxFiltrarGenero);
            this.Controls.Add(this.comboBoxFiltroEdad);
            this.Controls.Add(this.lblCondicion);
            this.Controls.Add(this.comboBoxCondicion);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblEdad);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.lblDeuda);
            this.Controls.Add(this.txtDeuda);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.comboBoxGenero);
            this.Controls.Add(this.checkBoxEstaEnfermo);
            this.Controls.Add(this.btnAgregarPaciente);
            this.Controls.Add(this.dataGridPacientesEnfermos);
            this.Controls.Add(this.dataGridPacientesSaludables);
            this.Controls.Add(this.dataGridViewFiltro);
            this.Controls.Add(this.btnBorrarGrilla);
            this.Controls.Add(this.txtEnfermosTotales);
            this.Controls.Add(this.txtSaludablesTotales);
            this.Controls.Add(this.txtDeudasTotales);
            this.Name = "MainForm";
            this.Text = "Registro de Pacientes - Le Cancer Company S.A.";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientesEnfermos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPacientesSaludables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiltro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ComboBox comboBoxCondicion;
        private System.Windows.Forms.Label lblCondicion;
        private System.Windows.Forms.ComboBox comboBoxFiltroEdad;
        private System.Windows.Forms.ComboBox comboBoxFiltrarGenero;
        private System.Windows.Forms.Label lblFiltroEdad;
        private System.Windows.Forms.Label lblFiltrarGenero;
        private System.Windows.Forms.Label lblEnfermosTotales;
        private System.Windows.Forms.Label lblSaludablesTotales;
        private System.Windows.Forms.Label lblDeudaTotal;
        private System.Windows.Forms.Label labelFiltrarEnfermo;
        private System.Windows.Forms.ComboBox comboBoxFiltrarEnfermo;
        private System.Windows.Forms.CheckBox checkBoxPacientesEnfermos;
        private System.Windows.Forms.CheckBox checkBoxPacientesSaludables;
        private System.Windows.Forms.CheckBox checkBoxFiltro;
    }
}
