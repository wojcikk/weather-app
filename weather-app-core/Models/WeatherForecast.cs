// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;

public class Forecast
{
    [JsonProperty("forecastday")]
    public List<Forecastday> Forecastday { get; } = new List<Forecastday>();
}

public class Forecastday
{
    [JsonProperty("date")]
    public string? Date { get; set; }

    [JsonProperty("date_epoch")]
    public int? DateEpoch { get; set; }

    [JsonProperty("day")]
    public Day? Day { get; set; }

    [JsonProperty("astro")]
    public Astro? Astro { get; set; }

    [JsonProperty("hour")]
    public List<Hour> Hour { get; } = new List<Hour>();
}
public class Astro
{
    [JsonProperty("sunrise")]
    public string? Sunrise { get; set; }

    [JsonProperty("sunset")]
    public string? Sunset { get; set; }

    [JsonProperty("moonrise")]
    public string? Moonrise { get; set; }

    [JsonProperty("moonset")]
    public string? Moonset { get; set; }

    [JsonProperty("moon_phase")]
    public string? MoonPhase { get; set; }

    [JsonProperty("moon_illumination")]
    public string? MoonIllumination { get; set; }

    [JsonProperty("is_moon_up")]
    public int? IsMoonUp { get; set; }

    [JsonProperty("is_sun_up")]
    public int? IsSunUp { get; set; }
}

public class Condition
{
    [JsonProperty("text")]
    public string? Text { get; set; }

    [JsonProperty("icon")]
    public string? Icon { get; set; }

    [JsonProperty("code")]
    public int? Code { get; set; }
}

public class Current
{
    [JsonProperty("last_updated_epoch")]
    public int? LastUpdatedEpoch { get; set; }

    [JsonProperty("last_updated")]
    public string? LastUpdated { get; set; }

    [JsonProperty("temp_c")]
    public double? TempC { get; set; }

    [JsonProperty("temp_f")]
    public double? TempF { get; set; }

    [JsonProperty("is_day")]
    public int? IsDay { get; set; }

    [JsonProperty("condition")]
    public Condition? Condition { get; set; }

    [JsonProperty("wind_mph")]
    public double? WindMph { get; set; }

    [JsonProperty("wind_kph")]
    public double? WindKph { get; set; }

    [JsonProperty("wind_degree")]
    public int? WindDegree { get; set; }

    [JsonProperty("wind_dir")]
    public string? WindDir { get; set; }

    [JsonProperty("pressure_mb")]
    public double? PressureMb { get; set; }

    [JsonProperty("pressure_in")]
    public double? PressureIn { get; set; }

    [JsonProperty("precip_mm")]
    public double? PrecipMm { get; set; }

    [JsonProperty("precip_in")]
    public double? PrecipIn { get; set; }

    [JsonProperty("humidity")]
    public int? Humidity { get; set; }

    [JsonProperty("cloud")]
    public int? Cloud { get; set; }

    [JsonProperty("feelslike_c")]
    public double? FeelslikeC { get; set; }

    [JsonProperty("feelslike_f")]
    public double? FeelslikeF { get; set; }

    [JsonProperty("vis_km")]
    public double? VisKm { get; set; }

    [JsonProperty("vis_miles")]
    public double? VisMiles { get; set; }

    [JsonProperty("uv")]
    public double? Uv { get; set; }

    [JsonProperty("gust_mph")]
    public double? GustMph { get; set; }

    [JsonProperty("gust_kph")]
    public double? GustKph { get; set; }
}

public class Day
{
    [JsonProperty("maxtemp_c")]
    public double? MaxtempC { get; set; }

    [JsonProperty("maxtemp_f")]
    public double? MaxtempF { get; set; }

    [JsonProperty("mintemp_c")]
    public double? MintempC { get; set; }

    [JsonProperty("mintemp_f")]
    public double? MintempF { get; set; }

    [JsonProperty("avgtemp_c")]
    public double? AvgtempC { get; set; }

    [JsonProperty("avgtemp_f")]
    public double? AvgtempF { get; set; }

    [JsonProperty("maxwind_mph")]
    public double? MaxwindMph { get; set; }

    [JsonProperty("maxwind_kph")]
    public double? MaxwindKph { get; set; }

    [JsonProperty("totalprecip_mm")]
    public double? TotalprecipMm { get; set; }

    [JsonProperty("totalprecip_in")]
    public double? TotalprecipIn { get; set; }

    [JsonProperty("totalsnow_cm")]
    public double? TotalsnowCm { get; set; }

    [JsonProperty("avgvis_km")]
    public double? AvgvisKm { get; set; }

    [JsonProperty("avgvis_miles")]
    public double? AvgvisMiles { get; set; }

    [JsonProperty("avghumidity")]
    public double? Avghumidity { get; set; }

    [JsonProperty("daily_will_it_rain")]
    public int? DailyWillItRain { get; set; }

    [JsonProperty("daily_chance_of_rain")]
    public int? DailyChanceOfRain { get; set; }

    [JsonProperty("daily_will_it_snow")]
    public int? DailyWillItSnow { get; set; }

    [JsonProperty("daily_chance_of_snow")]
    public int? DailyChanceOfSnow { get; set; }

    [JsonProperty("condition")]
    public Condition? Condition { get; set; }

    [JsonProperty("uv")]
    public double? Uv { get; set; }
}

public class Hour
{
    [JsonProperty("time_epoch")]
    public int? TimeEpoch { get; set; }

    [JsonProperty("time")]
    public string? Time { get; set; }

    [JsonProperty("temp_c")]
    public double? TempC { get; set; }

    [JsonProperty("temp_f")]
    public double? TempF { get; set; }

    [JsonProperty("is_day")]
    public int? IsDay { get; set; }

    [JsonProperty("condition")]
    public Condition? Condition { get; set; }

    [JsonProperty("wind_mph")]
    public double? WindMph { get; set; }

    [JsonProperty("wind_kph")]
    public double? WindKph { get; set; }

    [JsonProperty("wind_degree")]
    public int? WindDegree { get; set; }

    [JsonProperty("wind_dir")]
    public string? WindDir { get; set; }

    [JsonProperty("pressure_mb")]
    public double? PressureMb { get; set; }

    [JsonProperty("pressure_in")]
    public double? PressureIn { get; set; }

    [JsonProperty("precip_mm")]
    public double? PrecipMm { get; set; }

    [JsonProperty("precip_in")]
    public double? PrecipIn { get; set; }

    [JsonProperty("humidity")]
    public int? Humidity { get; set; }

    [JsonProperty("cloud")]
    public int? Cloud { get; set; }

    [JsonProperty("feelslike_c")]
    public double? FeelslikeC { get; set; }

    [JsonProperty("feelslike_f")]
    public double? FeelslikeF { get; set; }

    [JsonProperty("windchill_c")]
    public double? WindchillC { get; set; }

    [JsonProperty("windchill_f")]
    public double? WindchillF { get; set; }

    [JsonProperty("heatindex_c")]
    public double? HeatindexC { get; set; }

    [JsonProperty("heatindex_f")]
    public double? HeatindexF { get; set; }

    [JsonProperty("dewpoint_c")]
    public double? DewpointC { get; set; }

    [JsonProperty("dewpoint_f")]
    public double? DewpointF { get; set; }

    [JsonProperty("will_it_rain")]
    public int? WillItRain { get; set; }

    [JsonProperty("chance_of_rain")]
    public int? ChanceOfRain { get; set; }

    [JsonProperty("will_it_snow")]
    public int? WillItSnow { get; set; }

    [JsonProperty("chance_of_snow")]
    public int? ChanceOfSnow { get; set; }

    [JsonProperty("vis_km")]
    public double? VisKm { get; set; }

    [JsonProperty("vis_miles")]
    public double? VisMiles { get; set; }

    [JsonProperty("gust_mph")]
    public double? GustMph { get; set; }

    [JsonProperty("gust_kph")]
    public double? GustKph { get; set; }

    [JsonProperty("uv")]
    public double? Uv { get; set; }
}

public class Location
{
    [JsonProperty("name")]
    public string? Name { get; set; }

    [JsonProperty("region")]
    public string? Region { get; set; }

    [JsonProperty("country")]
    public string? Country { get; set; }

    [JsonProperty("lat")]
    public double? Lat { get; set; }

    [JsonProperty("lon")]
    public double? Lon { get; set; }

    [JsonProperty("tz_id")]
    public string? TzId { get; set; }

    [JsonProperty("localtime_epoch")]
    public int? LocaltimeEpoch { get; set; }

    [JsonProperty("localtime")]
    public string? Localtime { get; set; }
}

public class Root
{
    [JsonProperty("location")]
    public Location? Location { get; set; }

    [JsonProperty("current")]
    public Current? Current { get; set; }

    [JsonProperty("forecast")]
    public Forecast? Forecast { get; set; }
}

