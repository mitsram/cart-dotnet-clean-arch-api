namespace Cart.Domain.Entities;

public class Cart {
    
    public Guid Id { get; set; } = Guid.NewGuid();  
    public int Userid { get; set; }
    public int ProductId { get; set; }
    public DateTime CreatedDate { get; set; } = DateTime.Now;
}