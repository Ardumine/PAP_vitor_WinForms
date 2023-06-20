using ProgramaC_;
using Serilog;

namespace Pap_Vitor_PC {
    public partial class Main : Form {
        List<Mesa> Mesas = new List<Mesa>() { new Mesa(1), new Mesa(2), new Mesa(3) };


        public Main()
        {
            InitializeComponent();
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Servidor_WS.Start();

        }
        void Update_estados_mesas()
        {
            Mesa1_btn.BackColor = (Mesas[0].Ocupada ? Color.IndianRed : Color.GreenYellow);
            Mesa2_btn.BackColor = (Mesas[1].Ocupada ? Color.IndianRed : Color.GreenYellow);
            Mesa3_btn.BackColor = (Mesas[2].Ocupada ? Color.IndianRed : Color.GreenYellow);

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void Timer_update_Estados_mesas_Tick(object sender, EventArgs e)
        {
            Update_estados_mesas();
        }

        private void Mesa1_btn_Click(object sender, EventArgs e)
        {

        }
    }
}