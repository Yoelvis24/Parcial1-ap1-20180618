﻿
namespace Parcial1_ap1_20180618
{
    partial class RegistroCiudades
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroCiudades));
            this.IdCiudadLabel = new System.Windows.Forms.Label();
            this.NombreLabel = new System.Windows.Forms.Label();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.IdCiudadNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdCiudadNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // IdCiudadLabel
            // 
            this.IdCiudadLabel.AutoSize = true;
            this.IdCiudadLabel.Location = new System.Drawing.Point(12, 18);
            this.IdCiudadLabel.Name = "IdCiudadLabel";
            this.IdCiudadLabel.Size = new System.Drawing.Size(58, 15);
            this.IdCiudadLabel.TabIndex = 0;
            this.IdCiudadLabel.Text = "Ciudad Id";
            // 
            // NombreLabel
            // 
            this.NombreLabel.AutoSize = true;
            this.NombreLabel.Location = new System.Drawing.Point(12, 77);
            this.NombreLabel.Name = "NombreLabel";
            this.NombreLabel.Size = new System.Drawing.Size(51, 15);
            this.NombreLabel.TabIndex = 1;
            this.NombreLabel.Text = "Nombre";
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(12, 95);
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(229, 23);
            this.NombreTextBox.TabIndex = 2;
            // 
            // IdCiudadNumericUpDown
            // 
            this.IdCiudadNumericUpDown.Location = new System.Drawing.Point(12, 36);
            this.IdCiudadNumericUpDown.Name = "IdCiudadNumericUpDown";
            this.IdCiudadNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.IdCiudadNumericUpDown.TabIndex = 3;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = ((System.Drawing.Image)(resources.GetObject("BuscarButton.Image")));
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(138, 34);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(75, 25);
            this.BuscarButton.TabIndex = 4;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = ((System.Drawing.Image)(resources.GetObject("NuevoButton.Image")));
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(12, 137);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(74, 39);
            this.NuevoButton.TabIndex = 5;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = ((System.Drawing.Image)(resources.GetObject("GuardarButton.Image")));
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(117, 137);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(74, 39);
            this.GuardarButton.TabIndex = 6;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(221, 137);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(74, 39);
            this.EliminarButton.TabIndex = 7;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // RegistroCiudades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 191);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.IdCiudadNumericUpDown);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.NombreLabel);
            this.Controls.Add(this.IdCiudadLabel);
            this.Name = "RegistroCiudades";
            this.Text = "Registro de Ciudades";
            ((System.ComponentModel.ISupportInitialize)(this.IdCiudadNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdCiudadLabel;
        private System.Windows.Forms.Label NombreLabel;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.NumericUpDown IdCiudadNumericUpDown;
        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

