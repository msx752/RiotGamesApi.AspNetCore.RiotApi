using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using RiotGamesApi.AspNetCore.RiotApi.Converters;
using RiotGamesApi.AspNetCore.RiotApi.Enums;

namespace RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.League
{
    public class LeagueListDTO
    {
        [JsonProperty("tier")]
        public string tier { get; set; }

        [JsonConverter(typeof(StringToEnum<Queue>))]
        [JsonProperty("queue")]
        public Queue queue { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("entries")]
        public List<LeagueItemDTO> entries { get; set; }
    }
}