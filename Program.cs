class program{ 
    
    static void Main(string[] args){
        Show_Menu show_Menu = new Show_Menu();
        int input = 0;
        Console.WriteLine("1.Food Menu");
        Console.WriteLine("2.Promotion Menu");
        InputSelectedMenuFromKeyboard();
    }
        static void InputSelectedMenuFromKeyboard() {
        Show_Menu show_Menu = new Show_Menu();
        Console.Write("Input Menu: ");
        int input = int.Parse(Console.ReadLine());
        int FoodMenu = 1;
        int PromotionMenu = 2;

        if (input == FoodMenu) {
            Console.Clear();
            show_Menu.Show_Menu_normal_order();
        }
        else if(input == PromotionMenu){
            Console.Clear();
            show_Menu.Show_Menu_Promo_order();
        }
    }
}