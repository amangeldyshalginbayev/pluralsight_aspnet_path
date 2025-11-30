namespace BethanysPieShop.Models;

public class ShoppingCart : IShoppingCart
{
    
    private readonly BethanysPieShopDbContext _bethanysPieShopDbContext;

    public string? ShoppingCartId { get; set; }
    
    public List<ShoppingCartItem> ShoppingCartItems { get; set; }

    public ShoppingCart(BethanysPieShopDbContext bethanysPieShopDbContext)
    {
        _bethanysPieShopDbContext = bethanysPieShopDbContext;
    }

    public static ShoppingCart GetCart(IServiceProvider services)
    {
        ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
        
        BethanysPieShopDbContext context = 
    }

    public void AddToCart(Pie pie)
    {
        throw new NotImplementedException();
    }

    public int RemoveFromCart(Pie pie)
    {
        throw new NotImplementedException();
    }

    public List<ShoppingCartItem> GetShoppingCartItems()
    {
        throw new NotImplementedException();
    }

    public void ClearCart()
    {
        throw new NotImplementedException();
    }

    public decimal GetShoppingCartTotal()
    {
        throw new NotImplementedException();
    }
    
}