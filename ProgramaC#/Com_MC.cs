using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaC_ {
     class Com_MC {
        public static void Adicionar_ir_mesa(int id_mesa, bool entrega)//se entrega = true ent ele vai para entrega, se n ent vai para recolha pedidos
        {
            Log.Information($"Mesa {id_mesa} adi p ir, entrega = {entrega}");
        }
    }
}
