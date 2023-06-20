using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSocketSharp;
using WebSocketSharp.Server;
using Serilog;
using Newtonsoft.Json;

namespace Pap_Vitor_PC {
    public class servidor_ws_int : WebSocketBehavior {
        protected override void OnOpen()
        {
            Serilog.Log.Information("WS conectado! A obter estado...");
            //Parte obter estado cnt
            var dados_mandar = new Dictionary<string, object>();
            dados_mandar["tipo"] = "stat";
            var dados_mandar_str = "p" + JsonConvert.SerializeObject(dados_mandar);
            Send(dados_mandar_str);
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            var dados_recebidos_raw = e.Data;
            if (dados_recebidos_raw.StartsWith("p{"))
            {
                var dados_rec_json = JsonConvert.DeserializeObject<Dictionary<string, object>>(dados_recebidos_raw.Replace("p{", "{"));
                bool conectado = (bool)dados_rec_json["conectado"];

                Servidor_WS.Conectado_microbit = conectado;

                if (!conectado)
                {
                    Serilog.Log.Warning("Microbit não está conectado! Por favor conecte!");

                }
                else
                {
                    Serilog.Log.Information("Conectado ao mcirobit!");
                    Send("oi");
                }
            }
            else//Recebeu do microbit
            {
                Serilog.Log.Information(dados_recebidos_raw);
                //var dados_rec_json = JsonConvert.DeserializeObject<Dictionary<string, object>>(dados_recebidos_raw);
            }
        }
    }
    internal class Servidor_WS {
        public static bool Conectado_microbit = false;
        public static void Start()
        {
            string caminho_ws = "ws://localhost:8090";
            Log.Information($"A inicializar WS... ({caminho_ws})");
            var wssv = new WebSocketServer(caminho_ws);

            wssv.AddWebSocketService<servidor_ws_int>("/ws_mc");
            wssv.Start();

            Log.Information("Servidor ws OK!");
        }
    }
}
