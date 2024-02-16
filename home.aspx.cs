using lezione60z.lezione60z;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace lezione60z
{
    namespace lezione60z
    {
        public class Product
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public double Price { get; set; }
            public string Image { get; set; }
            public int Quantity { get; set; }

        }
    }

    public partial class home : System.Web.UI.Page
    {
        private static List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Invincible", Description = "Mark Greyson", Price = 20.99, Image = "https://www.writeups.org/wp-content/uploads/Invincible-Image-Comics-Mark-Grayson-Kirkman.jpg" },
            new Product { ID = 2, Name = "Omniman", Description = "Mark dad", Price = 15.49, Image = "https://i.pinimg.com/originals/74/c7/e4/74c7e44be9ccd479ca7ca4589f1c293b.png" },
            new Product { ID = 3, Name = "Thragg", Description = "The fallen king", Price = 29.99, Image = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/56102545-dd0e-41a0-a37b-b84b87e28d48/der7vq5-f743f009-dcfc-49df-9d27-70c9afc6ebd0.png?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7InBhdGgiOiJcL2ZcLzU2MTAyNTQ1LWRkMGUtNDFhMC1hMzdiLWI4NGI4N2UyOGQ0OFwvZGVyN3ZxNS1mNzQzZjAwOS1kY2ZjLTQ5ZGYtOWQyNy03MGM5YWZjNmViZDAucG5nIn1dXSwiYXVkIjpbInVybjpzZXJ2aWNlOmZpbGUuZG93bmxvYWQiXX0.SM6FuX7agPbDB0cuVNPfpfyYOhSCmg3tOUqv0htK0ig" },
            new Product { ID = 4, Name = "Battle Beast", Description = "He just wants a worthy opponent", Price = 100.00, Image = "https://images-wixmp-ed30a86b8c4ca887773594c2.wixmp.com/f/86685c3f-e1b8-474e-97ce-101a6b307994/derhl37-a0701d24-adf8-42a4-b7ce-1f7b55c544aa.jpg/v1/fill/w_1280,h_1979,q_75,strp/battle_beast_invincible_fanart_by_artofmikew_derhl37-fullview.jpg?token=eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJzdWIiOiJ1cm46YXBwOjdlMGQxODg5ODIyNjQzNzNhNWYwZDQxNWVhMGQyNmUwIiwiaXNzIjoidXJuOmFwcDo3ZTBkMTg4OTgyMjY0MzczYTVmMGQ0MTVlYTBkMjZlMCIsIm9iaiI6W1t7ImhlaWdodCI6Ijw9MTk3OSIsInBhdGgiOiJcL2ZcLzg2Njg1YzNmLWUxYjgtNDc0ZS05N2NlLTEwMWE2YjMwNzk5NFwvZGVyaGwzNy1hMDcwMWQyNC1hZGY4LTQyYTQtYjdjZS0xZjdiNTVjNTQ0YWEuanBnIiwid2lkdGgiOiI8PTEyODAifV1dLCJhdWQiOlsidXJuOnNlcnZpY2U6aW1hZ2Uub3BlcmF0aW9ucyJdfQ.JemK2iHh90rxv-fl2k-tSS_GmQbTs8c5WPBnmV0nBP0" },
            new Product { ID = 5, Name = "Allen the alien", Description = "Approaching death to be reborn stronger", Price = 70.00, Image = "https://www.panelsonpages.com/wp-content/uploads/2011/01/allen.jpg" },
            new Product { ID = 6, Name = "Conquest", Description = "The oldest Viltrumite", Price = 10.00, Image = "https://www.writeups.org/wp-content/uploads/Conquest-Invincible-Comics-c.jpg" },

        };

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                rptProducts.DataSource = products;
                rptProducts.DataBind();
            }
        }

        protected void ViewDetails_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int productId = Convert.ToInt32(btn.CommandArgument);
            Response.Redirect($"ProductDetails.aspx?ID={productId}");
        }

        protected void ViewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }

        public static Product GetProductById(int productId)
        {
            return products.FirstOrDefault(p => p.ID == productId);
        }

    }
}

