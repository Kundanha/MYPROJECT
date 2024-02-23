namespace WealthForgePro.Models;
public class MarketData
{
    public int MarketDataID { get; set; }
    public string Symbol { get; set; }
    public decimal Price { get; set; }
    public int Volume { get; set; }
    public decimal MarketCap { get; set; }
    public DateTime Date { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }
}
