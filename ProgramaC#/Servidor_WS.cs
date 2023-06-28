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
    class servidor_ws_int : WebSocketBehavior {//
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
            var dados_rec_json = JsonConvert.DeserializeObject<Dictionary<string, object>>(dados_recebidos_raw.Replace("p{", "{"));

            if (dados_recebidos_raw.StartsWith("p{"))
            {
                bool conectado = (bool)dados_rec_json["conectado"];

                Servidor_WS.Conectado_microbit = conectado;

                if (!conectado)
                {
                    Serilog.Log.Warning("Microbit não está conectado! Por favor conecte!");

                }
                else
                {
                    Serilog.Log.Information("Conectado ao mcirobit!");
                    //Send("oi");
                }
            }
            else//Recebeu do microbit
            {
                //Serilog.Log.Information(dados_recebidos_raw);
                Main.evento_dados_red___(dados_rec_json);
                //var dados_rec_json = JsonConvert.DeserializeObject<Dictionary<string, object>>(dados_recebidos_raw);
            }
        }
    }
    public class Servidor_WS {
        public static bool Conectado_microbit = false;
        public static WebSocketServer servidor = new WebSocketServer();

        #region Parte json
        public static string Json_p_string(Dictionary<string, object> dados)
        {
            return JsonConvert.SerializeObject(dados);
        }
        public static Dictionary<string, object> Criar_json()
        {
            return new Dictionary<string, object>();
        }
        public static Dictionary<string, object> String_p_json(string dados)
        {
            return JsonConvert.DeserializeObject<Dictionary<string, object>>(dados);
        }
        #endregion
       
        
        public static void Mandar_string(string dados)
        {
            if (!Conectado_microbit) return;
            servidor.WebSocketServices.Broadcast(dados.Replace(" ", ""));// Tirar espacos para ser mais rapido para mandar.

        }


        public static void Start()
        {
            string caminho_ws = "ws://localhost:8090";
            Log.Information($"A inicializar WS... ({caminho_ws})");
            servidor = new WebSocketServer(caminho_ws);

            servidor.AddWebSocketService<servidor_ws_int>("/ws_mc");
            servidor.Start();

            Log.Information("Servidor ws OK!");
        }
    }
}
