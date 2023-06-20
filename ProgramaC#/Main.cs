using ProgramaC_;
using Serilog;

namespace Pap_Vitor_PC {
    public partial class Main : Form {
        Dictionary<int, Mesa> Mesas = new Dictionary<int, Mesa>() { { 1, new Mesa(1) }, { 2, new Mesa(2) }, { 3, new Mesa(3) } };
        int ID_mesa_selecionada = 0;

        public Main()
        {
            InitializeComponent();
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Servidor_WS.Start();

        }
        void Cliente_entrou(int ID_mesa)
        {
            Mesas[ID_mesa].estado = Estado_mesa.A_receber_pedidos;
            Com_MC.Adicionar_ir_mesa(ID_mesa, false);
            Update_estados_mesas();

        }
        void Update_estados_mesas()
        {
            Mesa1_btn.BackColor = (Mesas[1].Ocupada ? Color.IndianRed : Color.GreenYellow);
            Mesa2_btn.BackColor = (Mesas[2].Ocupada ? Color.IndianRed : Color.GreenYellow);
            Mesa3_btn.BackColor = (Mesas[3].Ocupada ? Color.IndianRed : Color.GreenYellow);
            if (ID_mesa_selecionada == 1 || ID_mesa_selecionada == 2 || ID_mesa_selecionada == 3)
            {
                Box_config_mesas.Enabled = true;
                Mesa Mesa_selec = Mesas[ID_mesa_selecionada];
                Id_mesa_selec_lbl.Text = "ID: " + Mesa_selec.ID_mesa.ToString();
                Estado_mesa_lbl.Text = "Estado: " + Mesa_selec.estado.ToString();

                entrou_mesa_btn.Enabled = !Mesa_selec.Ocupada;
                    
                

            }
            else
            {
                Box_config_mesas.Enabled = false;
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Timer_update_Estados_mesas_Tick(object sender, EventArgs e)
        {
            Update_estados_mesas();
        }
        #region Parte btns mesas
        private void entrou_mesa_btn_Click(object sender, EventArgs e)
        {
            Cliente_entrou(ID_mesa_selecionada);
        }

        void Reset_cores_selec_btns()
        {
            Mesa1_btn.ForeColor = Color.Black;
            Mesa2_btn.ForeColor = Color.Black;
            Mesa3_btn.ForeColor = Color.Black;

        }

        private void Mesa1_btn_Click(object sender, EventArgs e)
        {
            Reset_cores_selec_btns();
            Mesa1_btn.ForeColor = Color.SlateGray;
            ID_mesa_selecionada = 1;
            Update_estados_mesas();
        }

        private void Mesa2_btn_Click(object sender, EventArgs e)
        {
            Reset_cores_selec_btns();
            Mesa2_btn.ForeColor = Color.SlateGray;
            ID_mesa_selecionada = 2;
            Update_estados_mesas();

        }

        private void Mesa3_btn_Click(object sender, EventArgs e)
        {
            Reset_cores_selec_btns();
            Mesa3_btn.ForeColor = Color.SlateGray;
            ID_mesa_selecionada = 3;
            Update_estados_mesas();

        }
        #endregion


    }
}