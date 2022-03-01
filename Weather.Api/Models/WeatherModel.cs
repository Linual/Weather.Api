using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Weather.Api.Models
{
    public class WeatherModel
    {
        [Key]
        public int idWeather { get; set; }

        [ForeignKey(nameof(CoordId))]
        public int? CoordId { get; set; }
        public virtual Coord? Coord { get; set; }
        public virtual ICollection<Weathers> Weather { get; set; }
        public string Base { get; set; } = "";
        public virtual Main Main { get; set; }
        public int Visibility { get; set; }
        public virtual Wind Wind { get; set; } 
        public virtual Clouds Clouds { get; set; }
        public int Dt { get; set; }
        public int SysId { get; set; }

        [ForeignKey(nameof(SysId))]
        public virtual Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
        public DateTime Date { get; set; }
    }
}
