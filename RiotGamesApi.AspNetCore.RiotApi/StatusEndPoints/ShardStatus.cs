using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using RiotGamesApi.AspNetCore.RiotApi.Converters;
using RiotGamesApi.AspNetCore.RiotApi.Enums;

namespace RiotGamesApi.AspNetCore.RiotApi.StatusEndPoints
{
    public class ShardStatus
    {
        //
        [JsonProperty("name")]
        public string name { get; set; }

        //
        [JsonConverter(typeof(StringToEnum<Platform>))]
        [JsonProperty("region_tag")]
        public Platform region_tag { get; set; }

        //
        [JsonProperty("hostname")]
        public string hostname { get; set; }

        //
        [JsonProperty("services")]
        public List<Service> services { get; set; }

        //
        [JsonProperty("slug")]
        public string slug { get; set; }

        [JsonProperty("locales")]
        public List<string> locales { get; set; }
    }
}