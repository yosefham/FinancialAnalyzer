using FinancialAnalyzer.StockApi;

namespace FinancialAnalyzer.Data;

public class StockAnalyzerService
{
    private IStockApi _stockApi;

    public StockAnalyzerService(IStockApi stockApi)
    {
        _stockApi = stockApi;
    }

    public async Task<StockStats> GetStockStatsById(string stockId)
    {
        return await _stockApi.GetStatsById(stockId);
    }
}
