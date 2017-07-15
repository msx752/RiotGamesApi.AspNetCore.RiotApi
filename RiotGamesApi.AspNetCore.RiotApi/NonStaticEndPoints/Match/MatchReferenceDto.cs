using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using RiotGamesApi.AspNetCore.RiotApi.Converters;
using RiotGamesApi.AspNetCore.RiotApi.Enums;

namespace RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.Match
{
    public class MatchReferenceDto
    {
        //
        [JsonProperty("lane")]
        public string lane { get; set; }

        //
        [JsonProperty("gameId")]
        public long gameId { get; set; }

        //
        [JsonProperty("champion")]
        public int champion { get; set; }

        //
        [JsonConverter(typeof(StringToEnum<Platform>))]
        [JsonProperty("platformId")]
        public Platform platformId { get; set; }

        //
        [JsonProperty("season")]
        public int season { get; set; }

        //
        [JsonProperty("queue")]
        public int queue { get; set; }

        //
        [JsonConverter(typeof(StringToEnum<Role>))]
        [JsonProperty("role")]
        public Role role { get; set; }

        [JsonProperty("timestamp")]
        public long timestamp { get; set; }
    }
}