﻿
namespace Tanodi_DesafioFinal
{
    partial class frmCotipro
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
            this.lblSeparador1 = new System.Windows.Forms.Label();
            this.lblNombreTienda = new System.Windows.Forms.Label();
            this.lblDireccionTienda = new System.Windows.Forms.Label();
            this.lblSeparador2 = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblCodigoVendedor = new System.Windows.Forms.Label();
            this.btnHistorialCotizaciones = new System.Windows.Forms.Button();
            this.gboxPrenda = new System.Windows.Forms.GroupBox();
            this.rbtnPantalon = new System.Windows.Forms.RadioButton();
            this.rbtnCamisa = new System.Windows.Forms.RadioButton();
            this.cboxMangaCorta = new System.Windows.Forms.CheckBox();
            this.cboxChupin = new System.Windows.Forms.CheckBox();
            this.cboxCuelloMao = new System.Windows.Forms.CheckBox();
            this.lblStockDisponible = new System.Windows.Forms.Label();
            this.gboxCalidad = new System.Windows.Forms.GroupBox();
            this.rbtnCalidadPremium = new System.Windows.Forms.RadioButton();
            this.rbtnCalidadNormal = new System.Windows.Forms.RadioButton();
            this.btnConsultarStock = new System.Windows.Forms.Button();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnCotizar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gboxStock = new System.Windows.Forms.GroupBox();
            this.gboxCotizacion = new System.Windows.Forms.GroupBox();
            this.gboxPrenda.SuspendLayout();
            this.gboxCalidad.SuspendLayout();
            this.gboxStock.SuspendLayout();
            this.gboxCotizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSeparador1
            // 
            this.lblSeparador1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSeparador1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador1.Location = new System.Drawing.Point(0, 60);
            this.lblSeparador1.Name = "lblSeparador1";
            this.lblSeparador1.Size = new System.Drawing.Size(584, 2);
            this.lblSeparador1.TabIndex = 0;
            // 
            // lblNombreTienda
            // 
            this.lblNombreTienda.AutoSize = true;
            this.lblNombreTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreTienda.Location = new System.Drawing.Point(30, 20);
            this.lblNombreTienda.Name = "lblNombreTienda";
            this.lblNombreTienda.Size = new System.Drawing.Size(113, 20);
            this.lblNombreTienda.TabIndex = 1;
            this.lblNombreTienda.Text = "NombreTienda";
            // 
            // lblDireccionTienda
            // 
            this.lblDireccionTienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccionTienda.Location = new System.Drawing.Point(224, 20);
            this.lblDireccionTienda.Name = "lblDireccionTienda";
            this.lblDireccionTienda.Size = new System.Drawing.Size(330, 20);
            this.lblDireccionTienda.TabIndex = 2;
            this.lblDireccionTienda.Text = "DireccionTienda";
            this.lblDireccionTienda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSeparador2
            // 
            this.lblSeparador2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSeparador2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSeparador2.Location = new System.Drawing.Point(0, 120);
            this.lblSeparador2.Name = "lblSeparador2";
            this.lblSeparador2.Size = new System.Drawing.Size(584, 2);
            this.lblSeparador2.TabIndex = 3;
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVendedor.Location = new System.Drawing.Point(30, 80);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(135, 20);
            this.lblNombreVendedor.TabIndex = 4;
            this.lblNombreVendedor.Text = "NombreVendedor";
            // 
            // lblCodigoVendedor
            // 
            this.lblCodigoVendedor.AutoSize = true;
            this.lblCodigoVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVendedor.Location = new System.Drawing.Point(204, 80);
            this.lblCodigoVendedor.Name = "lblCodigoVendedor";
            this.lblCodigoVendedor.Size = new System.Drawing.Size(129, 20);
            this.lblCodigoVendedor.TabIndex = 5;
            this.lblCodigoVendedor.Text = "CodigoVendedor";
            // 
            // btnHistorialCotizaciones
            // 
            this.btnHistorialCotizaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialCotizaciones.Location = new System.Drawing.Point(354, 74);
            this.btnHistorialCotizaciones.Name = "btnHistorialCotizaciones";
            this.btnHistorialCotizaciones.Size = new System.Drawing.Size(200, 32);
            this.btnHistorialCotizaciones.TabIndex = 6;
            this.btnHistorialCotizaciones.Text = "Historial de cotizaciones";
            this.btnHistorialCotizaciones.UseVisualStyleBackColor = true;
            // 
            // gboxPrenda
            // 
            this.gboxPrenda.Controls.Add(this.rbtnPantalon);
            this.gboxPrenda.Controls.Add(this.rbtnCamisa);
            this.gboxPrenda.Controls.Add(this.cboxMangaCorta);
            this.gboxPrenda.Controls.Add(this.cboxChupin);
            this.gboxPrenda.Controls.Add(this.cboxCuelloMao);
            this.gboxPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxPrenda.Location = new System.Drawing.Point(30, 150);
            this.gboxPrenda.Name = "gboxPrenda";
            this.gboxPrenda.Size = new System.Drawing.Size(330, 180);
            this.gboxPrenda.TabIndex = 7;
            this.gboxPrenda.TabStop = false;
            this.gboxPrenda.Text = "Prenda";
            // 
            // rbtnPantalon
            // 
            this.rbtnPantalon.AutoSize = true;
            this.rbtnPantalon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPantalon.Location = new System.Drawing.Point(225, 44);
            this.rbtnPantalon.Name = "rbtnPantalon";
            this.rbtnPantalon.Size = new System.Drawing.Size(98, 24);
            this.rbtnPantalon.TabIndex = 6;
            this.rbtnPantalon.TabStop = true;
            this.rbtnPantalon.Text = "Pantalón";
            this.rbtnPantalon.UseVisualStyleBackColor = true;
            // 
            // rbtnCamisa
            // 
            this.rbtnCamisa.AutoSize = true;
            this.rbtnCamisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCamisa.Location = new System.Drawing.Point(22, 44);
            this.rbtnCamisa.Name = "rbtnCamisa";
            this.rbtnCamisa.Size = new System.Drawing.Size(86, 24);
            this.rbtnCamisa.TabIndex = 5;
            this.rbtnCamisa.TabStop = true;
            this.rbtnCamisa.Text = "Camisa";
            this.rbtnCamisa.UseVisualStyleBackColor = true;
            // 
            // cboxMangaCorta
            // 
            this.cboxMangaCorta.AutoSize = true;
            this.cboxMangaCorta.Location = new System.Drawing.Point(22, 129);
            this.cboxMangaCorta.Name = "cboxMangaCorta";
            this.cboxMangaCorta.Size = new System.Drawing.Size(120, 24);
            this.cboxMangaCorta.TabIndex = 4;
            this.cboxMangaCorta.Text = "Manga Corta";
            this.cboxMangaCorta.UseVisualStyleBackColor = true;
            // 
            // cboxChupin
            // 
            this.cboxChupin.AutoSize = true;
            this.cboxChupin.Location = new System.Drawing.Point(225, 88);
            this.cboxChupin.Name = "cboxChupin";
            this.cboxChupin.Size = new System.Drawing.Size(78, 24);
            this.cboxChupin.TabIndex = 3;
            this.cboxChupin.Text = "Chupín";
            this.cboxChupin.UseVisualStyleBackColor = true;
            // 
            // cboxCuelloMao
            // 
            this.cboxCuelloMao.AutoSize = true;
            this.cboxCuelloMao.Location = new System.Drawing.Point(22, 88);
            this.cboxCuelloMao.Name = "cboxCuelloMao";
            this.cboxCuelloMao.Size = new System.Drawing.Size(107, 24);
            this.cboxCuelloMao.TabIndex = 2;
            this.cboxCuelloMao.Text = "Cuello Mao";
            this.cboxCuelloMao.UseVisualStyleBackColor = true;
            // 
            // lblStockDisponible
            // 
            this.lblStockDisponible.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStockDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockDisponible.Location = new System.Drawing.Point(20, 35);
            this.lblStockDisponible.Name = "lblStockDisponible";
            this.lblStockDisponible.Size = new System.Drawing.Size(200, 32);
            this.lblStockDisponible.TabIndex = 7;
            this.lblStockDisponible.Text = "Stock Disponible: ";
            this.lblStockDisponible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gboxCalidad
            // 
            this.gboxCalidad.Controls.Add(this.rbtnCalidadPremium);
            this.gboxCalidad.Controls.Add(this.rbtnCalidadNormal);
            this.gboxCalidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCalidad.Location = new System.Drawing.Point(390, 150);
            this.gboxCalidad.Name = "gboxCalidad";
            this.gboxCalidad.Size = new System.Drawing.Size(164, 180);
            this.gboxCalidad.TabIndex = 8;
            this.gboxCalidad.TabStop = false;
            this.gboxCalidad.Text = "Calidad";
            // 
            // rbtnCalidadPremium
            // 
            this.rbtnCalidadPremium.AutoSize = true;
            this.rbtnCalidadPremium.Location = new System.Drawing.Point(21, 88);
            this.rbtnCalidadPremium.Name = "rbtnCalidadPremium";
            this.rbtnCalidadPremium.Size = new System.Drawing.Size(89, 24);
            this.rbtnCalidadPremium.TabIndex = 1;
            this.rbtnCalidadPremium.TabStop = true;
            this.rbtnCalidadPremium.Text = "Premium";
            this.rbtnCalidadPremium.UseVisualStyleBackColor = true;
            // 
            // rbtnCalidadNormal
            // 
            this.rbtnCalidadNormal.AutoSize = true;
            this.rbtnCalidadNormal.Location = new System.Drawing.Point(21, 44);
            this.rbtnCalidadNormal.Name = "rbtnCalidadNormal";
            this.rbtnCalidadNormal.Size = new System.Drawing.Size(77, 24);
            this.rbtnCalidadNormal.TabIndex = 0;
            this.rbtnCalidadNormal.TabStop = true;
            this.rbtnCalidadNormal.Text = "Normal";
            this.rbtnCalidadNormal.UseVisualStyleBackColor = true;
            // 
            // btnConsultarStock
            // 
            this.btnConsultarStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarStock.Location = new System.Drawing.Point(20, 150);
            this.btnConsultarStock.Name = "btnConsultarStock";
            this.btnConsultarStock.Size = new System.Drawing.Size(200, 32);
            this.btnConsultarStock.TabIndex = 9;
            this.btnConsultarStock.Text = "Consultar Stock";
            this.btnConsultarStock.UseVisualStyleBackColor = true;
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrecioUnitario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioUnitario.Location = new System.Drawing.Point(20, 92);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(200, 32);
            this.lblPrecioUnitario.TabIndex = 10;
            this.lblPrecioUnitario.Text = "Precio Unitario:";
            this.lblPrecioUnitario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(6, 41);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(141, 20);
            this.lblCantidad.TabIndex = 11;
            this.lblCantidad.Text = "Cantidad a cotizar:";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(153, 38);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(95, 26);
            this.txtCantidad.TabIndex = 12;
            // 
            // btnCotizar
            // 
            this.btnCotizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCotizar.Location = new System.Drawing.Point(77, 150);
            this.btnCotizar.Name = "btnCotizar";
            this.btnCotizar.Size = new System.Drawing.Size(100, 32);
            this.btnCotizar.TabIndex = 13;
            this.btnCotizar.Text = "Cotizar";
            this.btnCotizar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(27, 92);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(200, 32);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Monto Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gboxStock
            // 
            this.gboxStock.Controls.Add(this.btnConsultarStock);
            this.gboxStock.Controls.Add(this.lblStockDisponible);
            this.gboxStock.Controls.Add(this.lblPrecioUnitario);
            this.gboxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxStock.Location = new System.Drawing.Point(30, 360);
            this.gboxStock.Name = "gboxStock";
            this.gboxStock.Size = new System.Drawing.Size(240, 200);
            this.gboxStock.TabIndex = 15;
            this.gboxStock.TabStop = false;
            this.gboxStock.Text = "Stock";
            // 
            // gboxCotizacion
            // 
            this.gboxCotizacion.Controls.Add(this.lblTotal);
            this.gboxCotizacion.Controls.Add(this.btnCotizar);
            this.gboxCotizacion.Controls.Add(this.lblCantidad);
            this.gboxCotizacion.Controls.Add(this.txtCantidad);
            this.gboxCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxCotizacion.Location = new System.Drawing.Point(300, 360);
            this.gboxCotizacion.Name = "gboxCotizacion";
            this.gboxCotizacion.Size = new System.Drawing.Size(254, 200);
            this.gboxCotizacion.TabIndex = 16;
            this.gboxCotizacion.TabStop = false;
            this.gboxCotizacion.Text = "Cotización";
            // 
            // frmCotipro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 590);
            this.Controls.Add(this.gboxCotizacion);
            this.Controls.Add(this.gboxStock);
            this.Controls.Add(this.gboxCalidad);
            this.Controls.Add(this.gboxPrenda);
            this.Controls.Add(this.btnHistorialCotizaciones);
            this.Controls.Add(this.lblCodigoVendedor);
            this.Controls.Add(this.lblNombreVendedor);
            this.Controls.Add(this.lblSeparador2);
            this.Controls.Add(this.lblDireccionTienda);
            this.Controls.Add(this.lblNombreTienda);
            this.Controls.Add(this.lblSeparador1);
            this.MaximizeBox = false;
            this.Name = "frmCotipro";
            this.Text = "Cotipro";
            this.gboxPrenda.ResumeLayout(false);
            this.gboxPrenda.PerformLayout();
            this.gboxCalidad.ResumeLayout(false);
            this.gboxCalidad.PerformLayout();
            this.gboxStock.ResumeLayout(false);
            this.gboxCotizacion.ResumeLayout(false);
            this.gboxCotizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label lblSeparador1;
        private System.Windows.Forms.Label lblNombreTienda;
        private System.Windows.Forms.Label lblDireccionTienda;
        private System.Windows.Forms.Label lblSeparador2;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblCodigoVendedor;
        private System.Windows.Forms.Button btnHistorialCotizaciones;
        private System.Windows.Forms.GroupBox gboxPrenda;
        private System.Windows.Forms.RadioButton rbtnPantalon;
        private System.Windows.Forms.RadioButton rbtnCamisa;
        private System.Windows.Forms.CheckBox cboxMangaCorta;
        private System.Windows.Forms.CheckBox cboxChupin;
        private System.Windows.Forms.CheckBox cboxCuelloMao;
        private System.Windows.Forms.Label lblStockDisponible;
        private System.Windows.Forms.GroupBox gboxCalidad;
        private System.Windows.Forms.RadioButton rbtnCalidadPremium;
        private System.Windows.Forms.RadioButton rbtnCalidadNormal;
        private System.Windows.Forms.Button btnConsultarStock;
        private System.Windows.Forms.Label lblPrecioUnitario;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnCotizar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox gboxStock;
        private System.Windows.Forms.GroupBox gboxCotizacion;
    }
}

