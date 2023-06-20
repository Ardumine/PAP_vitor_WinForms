using Serilog;

namespace Pap_Vitor_PC {
    public partial class Main : Form {
        public Main()
        {
            InitializeComponent();
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Servidor_WS.Start();
            
        }
    }
}