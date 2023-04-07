using System.Text.Json;

namespace AlphaVantageClient;

public class AlphaVantageService
{
    private readonly HttpClient _client;

    public AlphaVantageService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri("https://www.alphavantage.co/");
    }

    public async Task<AlphaVantageDto> GetStockStats(string ticket, string interval)
    {
        var requestUri =
            $"/query?function=TIME_SERIES_INTRADAY&symbol={ticket}&interval={interval}&outputsize=full&apikey=demo";
        var response = await _client.GetAsync(requestUri);
        if (!response.IsSuccessStatusCode)
        {
            throw new HttpRequestException(response.ReasonPhrase);
        }

        var stringContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<AlphaVantageDto>(stringContent) ?? new AlphaVantageDto();
    }
}