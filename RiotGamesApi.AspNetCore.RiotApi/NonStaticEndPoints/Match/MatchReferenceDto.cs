﻿using Newtonsoft.Json;
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
        [JsonConverter(typeof(StringToEnum<ServicePlatform>))]
        [JsonProperty("platformId")]
        public ServicePlatform platformId { get; set; }

        //
        [JsonProperty("season")]
        public int season { get; set; }

        //
        [JsonProperty("queue")]
        public int queue { get; set; }

        //
        [JsonProperty("role")]
        public string role { get; set; }

        [JsonProperty("timestamp")]
        public long timestamp { get; set; }
    }
}