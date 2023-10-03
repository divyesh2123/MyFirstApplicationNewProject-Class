using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplicationNewProject
{
    public class ShopingCart
    {
        public string CustomerName = "";

        public decimal totalPrice = 0.0M;



        public void Input()
        {
            Console.WriteLine("Please Enter CustomerName");

            CustomerName = Console.ReadLine();

            Console.WriteLine("Please Enter Total Price");

            totalPrice = Convert.ToDecimal(Console.ReadLine());



        }

        public void OutPut()
        {
            decimal discount = 0;
            Console.WriteLine("Customer Name" + CustomerName);

            if(totalPrice >=0 && totalPrice <=3000)
            {

                discount = totalPrice * 10 / 100;
            }
            else if(totalPrice>3000 && totalPrice<5000)
            {
                discount = totalPrice * 20/100;
            }
            else
            {
                discount = totalPrice * 30 / 100;
            }

            Console.WriteLine("Name" + CustomerName);
            Console.WriteLine("dis"+ discount);
            Console.WriteLine("totalprice" + totalPrice);
            Console.WriteLine("acutal price" + (totalPrice - discount));

          

        }




       
    }
}
