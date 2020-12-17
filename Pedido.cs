using System.Collections.Generic;

namespace project
{

    public class Pedido
    {
        private List<ItemPedido> lista = new List<ItemPedido>();
        
        public void adicionar(ItemPedido itemPedido)
        {
            lista.Add(itemPedido);
        }

        public double totalizar ()
        {
            double total = 0;
            for(int i=0; i < lista.Count; i++)
            {
                total = total + lista[i].quantidade;
            }

            return total;
        }
    }
}