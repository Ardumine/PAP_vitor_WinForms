using Newtonsoft.Json;
using Serilog;
using System.Windows.Forms;

namespace Pap_Vitor_PC {
    public partial class Main : Form {
        Dictionary<int, Mesa> Mesas = new Dictionary<int, Mesa>() { { 1, new Mesa(1) }, { 2, new Mesa(2) }, { 3, new Mesa(3) } };
        int ID_mesa_selecionada = 0;
        int ID_mesa_selec_ant = 0;

        public static Action<Dictionary<string, object>> evento_dados_red___;


        public Main()
        {
            InitializeComponent();
            Log.Logger = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            Servidor_WS.Start();
            evento_dados_red___ = Evento_dados_rec;
        }






        void Evento_dados_rec(Dictionary<string, object> dados)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                //Console.WriteLine(dados[Com_MC.nome_var_tipo].ToString());
                string Tipo_dado_Rec = dados[Com_MC.nome_var_tipo].ToString();
                if (Tipo_dado_Rec.StartsWith(Com_MC.cmd_obter_stats))
                {
                    if (Servidor_WS.Conectado_microbit)
                    {
                        Label_Estado.Text = $"Localização currente: {Enum.GetName(typeof(Lugares), dados[Com_MC.nome_var_Lugar_crrt])}; Obj: {Enum.GetName(typeof(Lugares), dados[Com_MC.nome_var_Lugar_obj])}";

                    }
                    else
                    {
                        Label_Estado.Text = "Microbit não conectado!";
                    }
                }
                if (Tipo_dado_Rec.StartsWith(Com_MC.cmd_rec_Pedidos))
                {
                    //Console.WriteLine("PEDIDOS RECS");
                    var pedidos = new List<Pedido>();

                    var ids_pedidos = (Newtonsoft.Json.Linq.JArray)dados[Com_MC.nome_var_pedidos];

                    foreach (var id_pedido in ids_pedidos.ToList())
                    {
                        int id_ped_trans = int.Parse(id_pedido.ToString());

                        if (id_ped_trans != 0)
                        {
                            pedidos.Add(new Pedido() { ID_tipo_pedido = id_ped_trans });
                        }
                    }

                    int id_mesa = int.Parse(dados[Com_MC.nome_var_ID_mesa].ToString());

<<<<<<< HEAD
                    Evento_mesa_recebeu_pedidos(id_mesa, pedidos);
=======
                    Evento_mesa_recebeu_pedidos(id_mesa,pedidos);
>>>>>>> 463845c2c3729c87a4106ab46da68a11a32f55f7
                }


            }
            ));
        }


        void Evento_mesa_recebeu_pedidos(int ID_mesa, List<Pedido> pedidos)
        {
            Mesas[ID_mesa].Pedidos = pedidos;

            Mesas[ID_mesa].estado = Estado_mesa.A_espera_prep;
            Update_estados_mesas();

        }
        void Cliente_entrou(int ID_mesa)
        {
            Mesas[ID_mesa].estado = Estado_mesa.A_receber_pedidos;
            Com_MC.Adicionar_ir_mesa(ID_mesa, false);
            Update_estados_mesas();



        }
        void Mesa_Comida_pronta(int ID_mesa)
        {
            Com_MC.Adicionar_ir_mesa(ID_mesa, true);
            Mesas[ID_mesa].estado = Estado_mesa.A_comer;
        }
        void Cliente_saiu(int ID_mesa)
        {
            Mesas[ID_mesa].estado = Estado_mesa.Livre;
            Mesas[ID_mesa].Pedidos = new List<Pedido>(); //Pedidos limpos
            Update_pedidos();
            Update_estados_mesas();

        }






        void Update_pedidos()
        {
            Lista_pedidos.Items.Clear();

        }
        void Update_estados_mesas()
        {
            if (ID_mesa_selec_ant != ID_mesa_selecionada)
            {
                Update_pedidos();
                ID_mesa_selec_ant = ID_mesa_selecionada;
            }
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

                bool Pedidos_todos_prontos = true;


                if (Mesa_selec.Ocupada)
                {

                    for (int i = 0; i < Mesa_selec.Pedidos.Count(); i++)
                    {

                        var pedido = Mesa_selec.Pedidos[i];
                        string Ja_feito = (pedido.Estado == Estados_prep.Pronto) ? "|" : "";
                        if (pedido.Estado != Estados_prep.Pronto)
                        {
                            Pedidos_todos_prontos = false;
                        }
                        string Nome_pedido = Ja_feito + i.ToString() + ": " + pedido.Nome_pedido;
                        if (!Lista_pedidos.Items.Contains(Nome_pedido))
                        {
                            Lista_pedidos.Items.Add(Nome_pedido);

                        }

                    }

                }



                Pronto_pedido_btn.Enabled = Lista_pedidos.SelectedIndex != -1 && Mesas[ID_mesa_selecionada].Pedidos[Lista_pedidos.SelectedIndex].Estado == Estados_prep.A_preparar;

                Entregar_pedidos_btn.Enabled = Pedidos_todos_prontos && Mesa_selec.estado == Estado_mesa.A_espera_prep;

                Saiu_mesa_btn.Enabled = Mesa_selec.estado == Estado_mesa.A_comer;


            }
            else
            {
                Box_config_mesas.Enabled = false;
            }

        }
        private void Main_Load(object sender, EventArgs e)
        {
            Lista_pedidos.DrawMode = DrawMode.OwnerDrawFixed;

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


        private void Lista_pedidos_DrawItem(object sender,
    System.Windows.Forms.DrawItemEventArgs e) //Para por cores catitas
        {
            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Define the default color of the brush as black.
            Brush myBrush = Brushes.IndianRed;

            // Determine the color of the brush to draw each item based  
            // on the index of the item to draw. 


            try
            {
                string Texto = Lista_pedidos.Items[e.Index].ToString();
                if (Texto.StartsWith("|"))
                {
                    Texto = Texto.Replace("|", "");
                    myBrush = Brushes.GreenYellow;
                }

                // Draw the current item text based on the current Font  
                // and the custom brush settings.
                e.Graphics.DrawString(Texto,
                    e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);
                // If the ListBox has focus, draw a focus rectangle around the selected item.
                e.DrawFocusRectangle();
            }
            catch
            {

            }

        }

        private void Pronto_pedido_btn_Click(object sender, EventArgs e)//Btn click Pedido pronto
        {
            Mesas[ID_mesa_selecionada].Pedidos[Lista_pedidos.SelectedIndex].Estado = Estados_prep.Pronto;
            Update_pedidos();

        }

        private void Entregar_pedidos_btn_Click(object sender, EventArgs e)
        {
            Mesa_Comida_pronta(ID_mesa_selecionada);
        }



        private void Saiu_mesa_btn_Click(object sender, EventArgs e)
        {
            Cliente_saiu(ID_mesa_selecionada);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Evento_mesa_recebeu_pedidos(ID_mesa_selecionada, new List<Pedido>() {//Serve para criar pedidos aleatórios
            //     new Pedido(){ID_tipo_pedido = 1},
            //     new Pedido(){ID_tipo_pedido = 2},
            //     new Pedido(){ID_tipo_pedido = 8},
            //     new Pedido(){ID_tipo_pedido = 6},
            // });

            var dados_rec_json = JsonConvert.DeserializeObject<Dictionary<string, object>>("{\"t\":\"rp\",\"idm\":1,\"ped\":[2,6,5]}");
            Evento_dados_rec(dados_rec_json);
        }
    }
}