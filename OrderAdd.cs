class order_add{
    static order order;
    public List<order> orders = new List<order>();
    public void add_order(){
        orders.Add(new order(001,"French fried", 40));
        orders.Add(new order(002,"Garlic bread", 40));
        orders.Add(new order(003,"Chicken fried", 60));
        orders.Add(new order(004,"Spicy chicken fried",65));
        orders.Add(new order(005,"Green Curry with Fried Chicken",60));
        orders.Add(new order(006,"Ramen", 80));
        orders.Add(new order(007,"Pizza", 120));
        /////////////////////
        orders.Add(new order(008,"French fried & Chicken fried & Ramen",160));
        orders.Add(new order(009,"Pizza & Garlic bread & Chicken fried",200));
        orders.Add(new order(010,"French fried & Chicken fried",80));
        orders.Add(new order(011,"Two Pizza & Garlic bread & French fried",300));
        orders.Add(new order(012,"Two Pizza & Ramen",280));
        orders.Add(new order(013,"Two Ramen & Two Chicken fried , French fried",333));
        orders.Add(new order(014,"Ten Chicken fried",229));
        orders.Add(new order(015,"Ten Spicy chicken fried",300));
    }
}