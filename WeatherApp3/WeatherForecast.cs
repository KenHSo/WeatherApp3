namespace WeatherApp3
{
    public class WeatherForecast
    {
        public City city { get; set; }
        public string cod { get; set; }
        public int cnt { get; set; }
        public List<WeatherData> list { get; set; }
    }

    public class City
    {
        public string name { get; set; }
        public string country { get; set; }
    }

    public class WeatherData
    {
        public long dt { get; set; }
        public Main main { get; set; }
        public Weather[] weather { get; set; }
        public string dt_txt { get; set; }

        public DateTime DateTime => DateTimeOffset.FromUnixTimeSeconds(dt).DateTime;
    }

    public class Main
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
    }

    public class Weather
    {
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
}
