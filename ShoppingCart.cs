namespace knightmoves;

public class ShoppingCart 
{
    public List<string> Items { get; }
    private readonly Logger _logger;

    public ShoppingCart(Logger logger)
    {
        Items = new List<string>();
        _logger = logger;
    }

    public void AddItem(string item)
    {
        Items.Add(item);
        _logger.Log($"Added item '{item}' to cart");
    }
}
