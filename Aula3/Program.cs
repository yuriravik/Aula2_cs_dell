using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {


        }
        public class Cliente
        {
            public String cpf;
        }
        public class Pedido
        {
            public String dataPedido;
            public String codigoPedido;
            public Cliente cliente;
            public ItemPedido item;

            
        }
        public class ItemPedido
        {
            public int codigoItem;
            public String descricaoItem;
            public float valorItem;
        }
    }
}

