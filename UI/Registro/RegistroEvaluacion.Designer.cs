namespace Parcial1_Ap1.UI.Registro
{
    partial class RegistroEvaluacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PronosticoComboBox = new System.Windows.Forms.ComboBox();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.IDNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EstudianteTextBox = new System.Windows.Forms.TextBox();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.CalificacionPanel = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PerdidoTextBox = new System.Windows.Forms.TextBox();
            this.ValorTextBox = new System.Windows.Forms.TextBox();
            this.LogradoTextBox = new System.Windows.Forms.TextBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).BeginInit();
            this.CalificacionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Estudiante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(180, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Calificacion, Tareas y parcial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(201, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Por como vas deberias :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Pronostico";
            // 
            // PronosticoComboBox
            // 
            this.PronosticoComboBox.FormattingEnabled = true;
            this.PronosticoComboBox.Items.AddRange(new object[] {
            "Continuar",
            "Suspenso",
            "Retirar"});
            this.PronosticoComboBox.Location = new System.Drawing.Point(80, 203);
            this.PronosticoComboBox.Name = "PronosticoComboBox";
            this.PronosticoComboBox.Size = new System.Drawing.Size(370, 21);
            this.PronosticoComboBox.TabIndex = 6;
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.Location = new System.Drawing.Point(250, 11);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.FechaDateTimePicker.TabIndex = 7;
            // 
            // IDNumericUpDown
            // 
            this.IDNumericUpDown.Location = new System.Drawing.Point(37, 11);
            this.IDNumericUpDown.Name = "IDNumericUpDown";
            this.IDNumericUpDown.Size = new System.Drawing.Size(164, 20);
            this.IDNumericUpDown.TabIndex = 8;
            // 
            // EstudianteTextBox
            // 
            this.EstudianteTextBox.Location = new System.Drawing.Point(80, 62);
            this.EstudianteTextBox.Name = "EstudianteTextBox";
            this.EstudianteTextBox.Size = new System.Drawing.Size(370, 20);
            this.EstudianteTextBox.TabIndex = 9;
            // 
            // NuevoButton
            // 
            this.NuevoButton.Location = new System.Drawing.Point(126, 260);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(104, 57);
            this.NuevoButton.TabIndex = 10;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(236, 260);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(104, 57);
            this.GuardarButton.TabIndex = 11;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Location = new System.Drawing.Point(346, 260);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(104, 57);
            this.EliminarButton.TabIndex = 12;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(456, 8);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(104, 40);
            this.BuscarButton.TabIndex = 13;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // CalificacionPanel
            // 
            this.CalificacionPanel.Controls.Add(this.label9);
            this.CalificacionPanel.Controls.Add(this.label8);
            this.CalificacionPanel.Controls.Add(this.label7);
            this.CalificacionPanel.Controls.Add(this.PerdidoTextBox);
            this.CalificacionPanel.Controls.Add(this.ValorTextBox);
            this.CalificacionPanel.Controls.Add(this.LogradoTextBox);
            this.CalificacionPanel.Location = new System.Drawing.Point(12, 112);
            this.CalificacionPanel.Name = "CalificacionPanel";
            this.CalificacionPanel.Size = new System.Drawing.Size(546, 46);
            this.CalificacionPanel.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(376, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Perdido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(210, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Logrado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Valor";
            // 
            // PerdidoTextBox
            // 
            this.PerdidoTextBox.Location = new System.Drawing.Point(425, 13);
            this.PerdidoTextBox.Name = "PerdidoTextBox";
            this.PerdidoTextBox.Size = new System.Drawing.Size(74, 20);
            this.PerdidoTextBox.TabIndex = 17;
            // 
            // ValorTextBox
            // 
            this.ValorTextBox.Location = new System.Drawing.Point(114, 13);
            this.ValorTextBox.Name = "ValorTextBox";
            this.ValorTextBox.Size = new System.Drawing.Size(74, 20);
            this.ValorTextBox.TabIndex = 16;
            // 
            // LogradoTextBox
            // 
            this.LogradoTextBox.Location = new System.Drawing.Point(262, 13);
            this.LogradoTextBox.Name = "LogradoTextBox";
            this.LogradoTextBox.Size = new System.Drawing.Size(74, 20);
            this.LogradoTextBox.TabIndex = 15;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // RegistroEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 330);
            this.Controls.Add(this.CalificacionPanel);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.EstudianteTextBox);
            this.Controls.Add(this.IDNumericUpDown);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.PronosticoComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegistroEvaluacion";
            this.Text = "RegistroEvaluacion";
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDown)).EndInit();
            this.CalificacionPanel.ResumeLayout(false);
            this.CalificacionPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox PronosticoComboBox;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.NumericUpDown IDNumericUpDown;
        private System.Windows.Forms.TextBox EstudianteTextBox;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Panel CalificacionPanel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PerdidoTextBox;
        private System.Windows.Forms.TextBox ValorTextBox;
        private System.Windows.Forms.TextBox LogradoTextBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}