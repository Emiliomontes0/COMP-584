using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace serverproject.Dtos
{
    public class CityCountry
    {
        public int Id { get; set; }

        public string City1 { get; set; } = null!;

        public int Population { get; set; }

        public string Country1 { get; set; } = null!;
    }
}
