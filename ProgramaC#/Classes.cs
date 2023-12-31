﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pap_Vitor_PC {
    class Mesa {

        public Mesa(int id)
        {
            ID_mesa = id;
        }

        public int ID_mesa = 0; // Pode ser mesa 1, 2 ou 3
        public List<Pedido> Pedidos = new List<Pedido>();
        public Estado_mesa estado = Estado_mesa.Livre;
        public bool Ocupada
        {
            get
            {
                return estado != Estado_mesa.Livre;
            }
        }
    }
    enum Estado_mesa {
        Livre,
        A_receber_pedidos,
        A_espera_prep,
        A_comer
    }
    enum Estados_prep {
        A_preparar,
        Pronto
    }
    
    
    class Pedido {
        public static Dictionary<int, string> Nomes_pedidos = new Dictionary<int, string>() //Pedidos
        {
            {
                1,"Frango com batata"
            },
            {
                2,"Bife com arroz"
            },
            {
                3,"Pescada cozida"
            },
            {
                4,"Francezinha"
            },
            {
                5,"Hamburger"
            },


            {
                6,"Água"
            },
            {
                7,"Sumo"
            },
            {
                8,"Coca-cola"
            },
            {
                9,"Água com gás"
            },
            {
                10,"Cerveja"
            },
        };


        public int ID_tipo_pedido;
        public string Nome_pedido
        {
            get
            {
                return Nomes_pedidos[ID_tipo_pedido];
            }
        }
        public Estados_prep Estado = Estados_prep.A_preparar;
    }
}
