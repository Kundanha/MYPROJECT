namespace WealthForgePro.Models;
public class Transaction
{
    public int TransactionID { get; set; }
    public int PortfolioID { get; set; }
    public string AssetType { get; set; }
    public string Symbol { get; set; }
    public string TransactionType { get; set; }
    public DateTime Date { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
    public decimal Fees { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
