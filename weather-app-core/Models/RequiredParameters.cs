namespace weather_app_core.Models
{
    public class RequiredParameters
    {
        private readonly string _q; // location - Pass US Zipcode, UK Postcode, Canada Postalcode, IP address, Latitude/Longitude (decimal degree) or city name.

        public RequiredParameters(string q)
        {
            _q = q;
        }
    }
}
