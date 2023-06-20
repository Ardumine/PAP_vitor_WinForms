using Serilog;

namespace Pap_Vitor_PC {
    public partial class Main : Form {
        public Main()
        {
            InitializeComponent();
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Servidor_WS.Start();

        }
        void Update_estados_mesas()
        {

        }
        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}