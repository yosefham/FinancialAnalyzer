using AutoFixture;

namespace FinancialAnalyzer.StockApi;

public interface IStockApi
{
    Task<StockStats> GetStatsById(string stockId);
}


internal class StockApi : IStockApi
{
    public async Task<StockStats> GetStatsById(string stockId)
    {
        var fixture = new Fixture();
        return fixture.Build<StockStats>().Create();
    }
}