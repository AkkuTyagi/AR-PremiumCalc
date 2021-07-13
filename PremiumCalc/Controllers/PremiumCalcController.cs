using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PremiumCalc.Controllers
{
    [ApiController]
    [Route("premiumCalc")]
    public class PremiumController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<OccupationDet> Get()
        {
            IEnumerable<OccupationDet> occupations = new List<OccupationDet>() {
                new OccupationDet() { Occupation =  "Cleaner", Rating = "Light Manual" },
                new OccupationDet() { Occupation = "Doctor", Rating = "Professional" },
                new OccupationDet() { Occupation = "Author", Rating = "White Collar" },
                new OccupationDet() { Occupation = "Farmer", Rating = "Heavy Manual" },
                new OccupationDet() { Occupation = "Mechanic", Rating = "Heavy Manual" },
                new OccupationDet() { Occupation = "Florist", Rating = "Light Manual" },
            };
            return occupations;
        }
    }

    public class OccupationDet {
        public string Occupation { get; set; }
        public string Rating { get; set; }
    }
    public class RatingDet
    {
        public string Factor { get; set; }
        public string Rating { get; set; }
    }
}
