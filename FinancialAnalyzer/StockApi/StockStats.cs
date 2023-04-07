namespace FinancialAnalyzer.StockApi;

public class StockStats
{
    public string Id { get; set; }
    public string Name { get; set; }
    public List<PriceMeasure> Prices { get; set; } = new List<PriceMeasure>();
}

public class PriceMeasure
{
    public DateTime DateTime { get; set; }
    public decimal Value { get; set; }
}