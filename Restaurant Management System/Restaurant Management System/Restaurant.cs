using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaurant_Management_System
{
    class Restaurant
    {
        private int C_Burger1, C_Burger2, C_Burger3, C_Burger4, C_Burger5;
        private int B_Burger1, B_Burger2, B_Burger3, B_Burger4, B_Burger5;
        private int C_Mania1, C_Mania2, C_Mania3;
        private int Beverages1, Beverages2;
        private int Extras1, Extras2, Extras3;

        public Restaurant()
        {
            C_Burger1 = 0; C_Burger2 = 0; C_Burger3 = 0; C_Burger4 = 0; C_Burger5 = 0;
            B_Burger1 = 0; B_Burger2 = 0; B_Burger3 = 0; B_Burger4 = 0; B_Burger5 = 0;
            C_Mania1 = 0; C_Mania2 = 0; C_Mania3 = 0;
            Beverages1 = 0; Beverages2 = 0;
            Extras1 = 0; Extras2 = 0; Extras3 = 0;
        }

        public Restaurant(int c_Burger1, int c_Burger2, int c_Burger3, int c_Burger4, int c_Burger5, int b_Burger1, int b_Burger2, int b_Burger3, int b_Burger4, int b_Burger5, int c_Mania1, int c_Mania2, int c_Mania3, int beverages1, int beverages2, int extras1, int extras2, int extras3)
        {
            //Chicken Burgers
            C_Burger1 = c_Burger1;
            C_Burger2 = c_Burger2;
            C_Burger3 = c_Burger3;
            C_Burger4 = c_Burger4;
            C_Burger5 = c_Burger5;

            //Beef Burgers
            B_Burger1 = b_Burger1;
            B_Burger2 = b_Burger2;
            B_Burger3 = b_Burger3;
            B_Burger4 = b_Burger4;
            B_Burger5 = b_Burger5;

            //Chicken Mania
            C_Mania1 = c_Mania1;
            C_Mania2 = c_Mania2;
            C_Mania3 = c_Mania3;

            //Beverages
            Beverages1 = beverages1;
            Beverages2 = beverages2;

            //Extras
            Extras1 = extras1;
            Extras2 = extras2;
            Extras3 = extras3;
        }

        public int orderc_Burger1()
        {
            return C_Burger1;
        }

        public int orderc_Burger2()
        {
            return C_Burger2;
        }

        public int orderc_Burger3()
        {
            return C_Burger3;
        }

        public int orderc_Burger4()
        {
            return C_Burger4;
        }

        public int orderc_Burger5()
        {
            return C_Burger5;
        }

        public int orderb_Burger1()
        {
            return B_Burger1;
        }

        public int orderb_Burger2()
        {
            return B_Burger2;
        }

        public int orderb_Burger3()
        {
            return B_Burger3;
        }

        public int orderb_Burger4()
        {
            return B_Burger4;
        }

        public int orderb_Burger5()
        {
            return B_Burger5;
        }

        public int orderc_Mania1()
        {
            return C_Mania1;
        }

        public int orderc_Mania2()
        {
            return C_Mania2;
        }

        public int orderc_Mania3()
        {
            return C_Mania3;
        }

        public int order_beverages1()
        {
            return Beverages1;
        }

        public int order_beverages2()
        {
            return Beverages2;
        }

        public int order_extras1()
        {
            return Extras1;
        }

        public int order_extras2()
        {
            return Extras2;
        }

        public int order_extras3()
        {
            return Extras3;
        }
    }
}
