using CityInfo.API.Modles;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            new CityDto()
            {
                Id = 1,
                Name = "New York City",
                Description = "The one with that big park."
            };
            new CityDto()
            {
                Id = 1,
                Name = "New York City",
                Description = "The one with that big park."
            };
            new CityDto()
            {
                Id = 1,
                Name = "New York City",
                Description = "The one with that big park."
            };
            new CityDto()
            {
                Id = 1,
                Name = "New York City",
                Description = "The one with that big park."
            };
        }
    } 
}
