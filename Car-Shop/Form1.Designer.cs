namespace Car_Shop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbTelaDeConsultas = new Label();
            btnClientes = new Button();
            btnVeiculos = new Button();
            btnVendedor = new Button();
            btnFechar = new Button();
            lbCarShop = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbTelaDeConsultas
            // 
            lbTelaDeConsultas.AutoSize = true;
            lbTelaDeConsultas.Font = new Font("Yu Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTelaDeConsultas.ForeColor = Color.Red;
            lbTelaDeConsultas.Location = new Point(68, 107);
            lbTelaDeConsultas.Name = "lbTelaDeConsultas";
            lbTelaDeConsultas.Size = new Size(224, 31);
            lbTelaDeConsultas.TabIndex = 1;
            lbTelaDeConsultas.Text = "Tela de Consultas";
            // 
            // btnClientes
            // 
            btnClientes.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClientes.Location = new Point(12, 207);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(128, 74);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Tela de Gerenciamento de Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVeiculos
            // 
            btnVeiculos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVeiculos.Location = new Point(209, 207);
            btnVeiculos.Name = "btnVeiculos";
            btnVeiculos.Size = new Size(128, 74);
            btnVeiculos.TabIndex = 3;
            btnVeiculos.Text = "Tela de Gerenciamento de Veiculos";
            btnVeiculos.UseVisualStyleBackColor = true;
            btnVeiculos.Click += btnVeiculos_Click;
            // 
            // btnVendedor
            // 
            btnVendedor.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVendedor.Location = new Point(12, 318);
            btnVendedor.Name = "btnVendedor";
            btnVendedor.Size = new Size(128, 78);
            btnVendedor.TabIndex = 4;
            btnVendedor.Text = "Tela de Gerenciamento de Vendedor";
            btnVendedor.UseVisualStyleBackColor = true;
            btnVendedor.Click += btnVendedor_Click;
            // 
            // btnFechar
            // 
            btnFechar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.Location = new Point(209, 318);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(128, 78);
            btnFechar.TabIndex = 5;
            btnFechar.Text = "Fechar o Programa";
            btnFechar.UseVisualStyleBackColor = true;
            btnFechar.Click += btnFechar_Click;
            // 
            // lbCarShop
            // 
            lbCarShop.AutoSize = true;
            lbCarShop.Location = new Point(114, 55);
            lbCarShop.Name = "lbCarShop";
            lbCarShop.Size = new Size(0, 15);
            lbCarShop.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Desktop;
            label1.Location = new Point(48, 47);
            label1.Name = "label1";
            label1.Size = new Size(266, 25);
            label1.TabIndex = 7;
            label1.Text = "Tela Administrativa Car Shop";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(349, 460);
            Controls.Add(label1);
            Controls.Add(lbCarShop);
            Controls.Add(btnFechar);
            Controls.Add(btnVendedor);
            Controls.Add(btnVeiculos);
            Controls.Add(btnClientes);
            Controls.Add(lbTelaDeConsultas);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Tela Administrativa do Car Shop";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbTelaDeConsultas;
        private Button btnClientes;
        private Button btnVeiculos;
        private Button btnVendedor;
        private Button btnFechar;
        private Label lbCarShop;
        private Label label1;
    }
}