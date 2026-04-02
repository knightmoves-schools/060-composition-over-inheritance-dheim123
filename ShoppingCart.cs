namespace knightmoves;

public class ShoppingCart : Logger{
    public List<string> items {get;}

    public ShoppingCart(){
        items = new List<string>();
    }
    public void AddItem(string item){
        items.Add(item);
        Log($"Added item '{item}' to cart");
    }
}