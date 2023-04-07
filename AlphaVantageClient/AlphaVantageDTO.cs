namespace AlphaVantageClient;

public class AlphaVantageDto
{
    public MetaData MetaData { get; set; }
    public TimeSeries TimeSeries { get; set; }
}

public class MetaData
{
    public string Information { get; set; }
    public string Symbol { get; set; }
    public string LastRefreshed { get; set; }
    public string Interval { get; set; }
    public string OutputSize { get; set; }
    public string TimeZone { get; set; }
}

public class TimeSeries
{
    public List<StockRecord> Records { get; set; }
}

public class StockRecord
{
    public string Open { get; set; }
    public string High { get; set; }
    public string Low { get; set; }
    public string Close { get; set; }
    public string Volume { get; set; }
}

