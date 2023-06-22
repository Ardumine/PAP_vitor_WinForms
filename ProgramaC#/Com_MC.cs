using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap_Vitor_PC {
    public enum Lugares {
        Desconhecido,

        Zona_chefe,

        Mesa_1_Obter_pedido,
        Mesa_1_entrega,

        Mesa_2_Obter_pedido,
        Mesa_2_entrega,

        Mesa_3_Obter_pedido,
        Mesa_3_entrega,

        Andar
    };
    class Com_MC {
        public static string cmd_obter_linhas = "obt_l";
        public static string cmd_set_linhas = "set_l";
        public static string cmd_obter_stats = "st";
        public static string cmd_adi_ir_mesa = "aim";
        public static string cmd_rec_Pedidos = "rp";


        public static string nome_var_tipo = "t";

        public static string nome_var_calibrado = "c";

        public static string nome_var_linha1 = "l1";
        public static string nome_var_linha2 = "l2";

        public static string nome_var_Lugar_crrt = "lc";
        public static string nome_var_Lugar_obj = "lo";

        public static string nome_var_tipo_ir_mesa = "tim";
        public static string nome_var_ID_mesa = "idm";

        public static void Adicionar_ir_mesa(int id_mesa, bool entrega)//se entrega = true ent ele vai para entrega, se n ent vai para recolha pedidos
        {
            Log.Information($"Mesa {id_mesa} adicionada para ir| entrega = {entrega}");
            var dados = Servidor_WS.Criar_json();
            dados[nome_var_tipo] = cmd_adi_ir_mesa;
            dados[nome_var_ID_mesa] = id_mesa;
            dados[nome_var_tipo_ir_mesa] = entrega ? 0 : 1;


            Servidor_WS.Mandar_string(Servidor_WS.Json_p_string(dados));
        }
    }
}
