﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using RiotGamesApi.AspNetCore.RiotApi.Converters;
using RiotGamesApi.AspNetCore.RiotApi.Enums;

namespace RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.Match
{
    public class MatchDto
    {
        //
        [JsonProperty("seasonId")]
        public int seasonId { get; set; }

        //
        [JsonProperty("queueId")]
        public int queueId { get; set; }

        //
        [JsonProperty("gameId")]
        public long gameId { get; set; }

        //
        [JsonProperty("participantIdentities")]
        public List<ParticipantIdentityDto> participantIdentities { get; set; }

        //
        [JsonProperty("gameVersion")]
        public string gameVersion { get; set; }

        //

        [JsonConverter(typeof(StringToEnum<ServicePlatform>))]
        [JsonProperty("platformId")]
        public ServicePlatform platformId { get; set; }

        //
        [JsonProperty("gameMode")]
        public string gameMode { get; set; }

        //
        [JsonProperty("mapId")]
        public int mapId { get; set; }

        //
        [JsonProperty("gameType")]
        public string gameType { get; set; }

        //
        [JsonProperty("teams")]
        public List<TeamStatsDto> teams { get; set; }

        //
        [JsonProperty("participants")]
        public List<ParticipantDto> participants { get; set; }

        //
        [JsonProperty("gameDuration")]
        public long gameDuration { get; set; }

        [JsonConverter(typeof(LongToDateTime))]
        [JsonProperty("gameCreation")]
        public DateTime gameCreation { get; set; }
    }
}