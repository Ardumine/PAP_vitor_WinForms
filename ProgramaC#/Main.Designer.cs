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
            entrou_mesa_btn = new Button();
            Estado_mesa_lbl = new Label();
            Id_mesa_selec_lbl = new Label();
            Pedidos_box = new GroupBox();
            Lista_pedidos = new ListBox();
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
            Timer_update_Estados_mesas.Interval = 500;
            Timer_update_Estados_mesas.Tick += Timer_update_Estados_mesas_Tick;
            // 
            // Box_config_mesas
            // 
            Box_config_mesas.Controls.Add(Pedidos_box);
            Box_config_mesas.Controls.Add(entrou_mesa_btn);
            Box_config_mesas.Controls.Add(Estado_mesa_lbl);
            Box_config_mesas.Controls.Add(Id_mesa_selec_lbl);
            Box_config_mesas.Location = new Point(636, 185);
            Box_config_mesas.Name = "Box_config_mesas";
            Box_config_mesas.Size = new Size(479, 495);
            Box_config_mesas.TabIndex = 2;
            Box_config_mesas.TabStop = false;
            Box_config_mesas.Text = "Box_config_mesas";
            // 
            // entrou_mesa_btn
            // 
            entrou_mesa_btn.Location = new Point(6, 455);
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
            // Pedidos_box
            // 
            Pedidos_box.Controls.Add(Lista_pedidos);
            Pedidos_box.Location = new Point(65, 107);
            Pedidos_box.Name = "Pedidos_box";
            Pedidos_box.Size = new Size(408, 342);
            Pedidos_box.TabIndex = 3;
            Pedidos_box.TabStop = false;
            Pedidos_box.Text = "Pedidos";
            // 
            // Lista_pedidos
            // 
            Lista_pedidos.FormattingEnabled = true;
            Lista_pedidos.ItemHeight = 25;
            Lista_pedidos.Location = new Point(15, 39);
            Lista_pedidos.Name = "Lista_pedidos";
            Lista_pedidos.Size = new Size(180, 129);
            Lista_pedidos.TabIndex = 0;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 692);
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
    }
}