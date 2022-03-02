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
        public Coord Coord { get; set; }

        [ForeignKey(nameof(WeatherId))]
        public int? WeatherId { get; set; }
        public ICollection<Weathers> Weather { get; set; }
        public string Base { get; set; }

        [ForeignKey(nameof(MainId))]
        public int? MainId { get; set; }
        public Main Main { get; set; }
        public int Visibility { get; set; }

        [ForeignKey(nameof(WindId))]
        public int? WindId { get; set; }
        public Wind Wind { get; set; }

        [ForeignKey(nameof(CloudsId))]
        public int? CloudsId { get; set; }
        public Clouds Clouds { get; set; }
        public int Dt { get; set; }

        [ForeignKey(nameof(SysId))]
        public int? SysId { get; set; }
        public Sys Sys { get; set; }
        public int Timezone { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cod { get; set; }
        public DateTime Date { get; set; }
    }
}
