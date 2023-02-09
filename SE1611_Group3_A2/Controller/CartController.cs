using SE1611_Group3_A2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE1611_Group3_A2.Controller
{
    internal class CartController
    {
        MusicStoreContext context = new MusicStoreContext();
        public void addCart(Cart cart)
        {
            context.Carts.Add(cart);
            context.SaveChanges();
        }


    }
}
