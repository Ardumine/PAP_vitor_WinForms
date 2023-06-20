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
            Mesa1_btn = new Button();
            groupBox1 = new GroupBox();
            Mesa2_btn = new Button();
            Mesa3_btn = new Button();
            groupBox1.SuspendLayout();
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
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Mesa3_btn);
            groupBox1.Controls.Add(Mesa2_btn);
            groupBox1.Controls.Add(Mesa1_btn);
            groupBox1.Location = new Point(297, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(374, 302);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mesas";
            // 
            // Mesa2_btn
            // 
            Mesa2_btn.Location = new Point(115, 30);
            Mesa2_btn.Name = "Mesa2_btn";
            Mesa2_btn.Size = new Size(103, 79);
            Mesa2_btn.TabIndex = 1;
            Mesa2_btn.Text = "Mesa 2";
            Mesa2_btn.UseVisualStyleBackColor = true;
            // 
            // Mesa3_btn
            // 
            Mesa3_btn.Location = new Point(115, 115);
            Mesa3_btn.Name = "Mesa3_btn";
            Mesa3_btn.Size = new Size(103, 79);
            Mesa3_btn.TabIndex = 2;
            Mesa3_btn.Text = "Mesa 3";
            Mesa3_btn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 632);
            Controls.Add(groupBox1);
            Name = "Main";
            Text = "App principal";
            Load += Main_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button Mesa1_btn;
        private GroupBox groupBox1;
        private Button Mesa3_btn;
        private Button Mesa2_btn;
    }
}