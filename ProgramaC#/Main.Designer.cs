namespace Pap_Vitor_PC {
    partial class Main {
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
            components = new System.ComponentModel.Container();
            Mesa1_btn = new Button();
            groupBox1 = new GroupBox();
            Mesa3_btn = new Button();
            Mesa2_btn = new Button();
            Timer_update_Estados_mesas = new System.Windows.Forms.Timer(components);
            Box_config_mesas = new GroupBox();
            Saiu_mesa_btn = new Button();
            Pedidos_box = new GroupBox();
            Entregar_pedidos_btn = new Button();
            Pronto_pedido_btn = new Button();
            Lista_pedidos = new ListBox();
            entrou_mesa_btn = new Button();
            Estado_mesa_lbl = new Label();
            Id_mesa_selec_lbl = new Label();
            button1 = new Button();
            Label_Estado = new Label();
            groupBox1.SuspendLayout();
            Box_config_mesas.SuspendLayout();
            Pedidos_box.SuspendLayout();
            SuspendLayout();
            // 
            // Mesa1_btn
            // 
            Mesa1_btn.Location = new Point(6, 30);
            Mesa1_btn.Name = "Mesa1_btn";
            Mesa1_btn.Size = new Size(103, 79);
            Mesa1_btn.TabIndex = 0;
            Mesa1_btn.Text = "Mesa 1";
            Mesa1_btn.UseVisualStyleBackColor = true;
            Mesa1_btn.Click += Mesa1_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Mesa3_btn);
            groupBox1.Controls.Add(Mesa2_btn);
            groupBox1.Controls.Add(Mesa1_btn);
            groupBox1.Location = new Point(332, 185);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(228, 218);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesas";
            // 
            // Mesa3_btn
            // 
            Mesa3_btn.Location = new Point(115, 115);
            Mesa3_btn.Name = "Mesa3_btn";
            Mesa3_btn.Size = new Size(103, 79);
            Mesa3_btn.TabIndex = 2;
            Mesa3_btn.Text = "Mesa 3";
            Mesa3_btn.UseVisualStyleBackColor = true;
            Mesa3_btn.Click += Mesa3_btn_Click;
            // 
            // Mesa2_btn
            // 
            Mesa2_btn.Location = new Point(115, 30);
            Mesa2_btn.Name = "Mesa2_btn";
            Mesa2_btn.Size = new Size(103, 79);
            Mesa2_btn.TabIndex = 1;
            Mesa2_btn.Text = "Mesa 2";
            Mesa2_btn.UseVisualStyleBackColor = true;
            Mesa2_btn.Click += Mesa2_btn_Click;
            // 
            // Timer_update_Estados_mesas
            // 
            Timer_update_Estados_mesas.Enabled = true;
            Timer_update_Estados_mesas.Interval = 200;
            Timer_update_Estados_mesas.Tick += Timer_update_Estados_mesas_Tick;
            // 
            // Box_config_mesas
            // 
            Box_config_mesas.Controls.Add(Saiu_mesa_btn);
            Box_config_mesas.Controls.Add(Pedidos_box);
            Box_config_mesas.Controls.Add(entrou_mesa_btn);
            Box_config_mesas.Controls.Add(Estado_mesa_lbl);
            Box_config_mesas.Controls.Add(Id_mesa_selec_lbl);
            Box_config_mesas.Location = new Point(636, 185);
            Box_config_mesas.Name = "Box_config_mesas";
            Box_config_mesas.Size = new Size(479, 652);
            Box_config_mesas.TabIndex = 2;
            Box_config_mesas.TabStop = false;
            Box_config_mesas.Text = "Box_config_mesas";
            // 
            // Saiu_mesa_btn
            // 
            Saiu_mesa_btn.Location = new Point(124, 618);
            Saiu_mesa_btn.Name = "Saiu_mesa_btn";
            Saiu_mesa_btn.Size = new Size(112, 34);
            Saiu_mesa_btn.TabIndex = 4;
            Saiu_mesa_btn.Text = "Saiu";
            Saiu_mesa_btn.UseVisualStyleBackColor = true;
            Saiu_mesa_btn.Click += Saiu_mesa_btn_Click;
            // 
            // Pedidos_box
            // 
            Pedidos_box.Controls.Add(Entregar_pedidos_btn);
            Pedidos_box.Controls.Add(Pronto_pedido_btn);
            Pedidos_box.Controls.Add(Lista_pedidos);
            Pedidos_box.Location = new Point(65, 107);
            Pedidos_box.Name = "Pedidos_box";
            Pedidos_box.Size = new Size(408, 505);
            Pedidos_box.TabIndex = 3;
            Pedidos_box.TabStop = false;
            Pedidos_box.Text = "Pedidos";
            // 
            // Entregar_pedidos_btn
            // 
            Entregar_pedidos_btn.Location = new Point(124, 471);
            Entregar_pedidos_btn.Name = "Entregar_pedidos_btn";
            Entregar_pedidos_btn.Size = new Size(112, 34);
            Entregar_pedidos_btn.TabIndex = 2;
            Entregar_pedidos_btn.Text = "Entregar";
            Entregar_pedidos_btn.UseVisualStyleBackColor = true;
            Entregar_pedidos_btn.Click += Entregar_pedidos_btn_Click;
            // 
            // Pronto_pedido_btn
            // 
            Pronto_pedido_btn.Location = new Point(6, 471);
            Pronto_pedido_btn.Name = "Pronto_pedido_btn";
            Pronto_pedido_btn.Size = new Size(112, 34);
            Pronto_pedido_btn.TabIndex = 1;
            Pronto_pedido_btn.Text = "Pronto";
            Pronto_pedido_btn.UseVisualStyleBackColor = true;
            Pronto_pedido_btn.Click += Pronto_pedido_btn_Click;
            // 
            // Lista_pedidos
            // 
            Lista_pedidos.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            Lista_pedidos.FormattingEnabled = true;
            Lista_pedidos.ItemHeight = 38;
            Lista_pedidos.Location = new Point(15, 39);
            Lista_pedidos.Name = "Lista_pedidos";
            Lista_pedidos.Size = new Size(387, 384);
            Lista_pedidos.TabIndex = 0;
            Lista_pedidos.DrawItem += Lista_pedidos_DrawItem;
            // 
            // entrou_mesa_btn
            // 
            entrou_mesa_btn.Location = new Point(6, 618);
            entrou_mesa_btn.Name = "entrou_mesa_btn";
            entrou_mesa_btn.Size = new Size(112, 34);
            entrou_mesa_btn.TabIndex = 2;
            entrou_mesa_btn.Text = "Entrou";
            entrou_mesa_btn.UseVisualStyleBackColor = true;
            entrou_mesa_btn.Click += entrou_mesa_btn_Click;
            // 
            // Estado_mesa_lbl
            // 
            Estado_mesa_lbl.AutoSize = true;
            Estado_mesa_lbl.Location = new Point(23, 52);
            Estado_mesa_lbl.Name = "Estado_mesa_lbl";
            Estado_mesa_lbl.Size = new Size(70, 25);
            Estado_mesa_lbl.TabIndex = 1;
            Estado_mesa_lbl.Text = "Estado:";
            // 
            // Id_mesa_selec_lbl
            // 
            Id_mesa_selec_lbl.AutoSize = true;
            Id_mesa_selec_lbl.Location = new Point(23, 27);
            Id_mesa_selec_lbl.Name = "Id_mesa_selec_lbl";
            Id_mesa_selec_lbl.Size = new Size(34, 25);
            Id_mesa_selec_lbl.TabIndex = 0;
            Id_mesa_selec_lbl.Text = "ID:";
            // 
            // button1
            // 
            button1.Location = new Point(144, 681);
            button1.Name = "button1";
            button1.Size = new Size(178, 34);
            button1.TabIndex = 3;
            button1.Text = "Criar pedidos falsos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Label_Estado
            // 
            Label_Estado.AutoSize = true;
            Label_Estado.Location = new Point(23, 760);
            Label_Estado.Name = "Label_Estado";
            Label_Estado.Size = new Size(21, 25);
            Label_Estado.TabIndex = 4;
            Label_Estado.Text = "E";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 849);
            Controls.Add(Label_Estado);
            Controls.Add(button1);
            Controls.Add(Box_config_mesas);
            Controls.Add(groupBox1);
            Name = "Main";
            Text = "App principal";
            Load += Main_Load;
            groupBox1.ResumeLayout(false);
            Box_config_mesas.ResumeLayout(false);
            Box_config_mesas.PerformLayout();
            Pedidos_box.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Mesa1_btn;
        private GroupBox groupBox1;
        private Button Mesa3_btn;
        private Button Mesa2_btn;
        private System.Windows.Forms.Timer Timer_update_Estados_mesas;
        private GroupBox Box_config_mesas;
        private Label Id_mesa_selec_lbl;
        private Label Estado_mesa_lbl;
        private Button entrou_mesa_btn;
        private GroupBox Pedidos_box;
        private ListBox Lista_pedidos;
        private Button Pronto_pedido_btn;
        private Button Entregar_pedidos_btn;
        private Button Saiu_mesa_btn;
        private Button button1;
        private Label Label_Estado;
    }
}