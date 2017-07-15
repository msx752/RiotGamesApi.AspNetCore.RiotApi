﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RiotGamesApi.AspNetCore.RiotApi.TournamentStub
{
    public class LobbyEventDTO
    {
        //The type of event that was triggered
        [JsonProperty("eventType")]
        public string eventType { get; set; }

        //The summoner that triggered the event
        [JsonProperty("summonerId")]
        public string summonerId { get; set; }

        //Timestamp from the event
        [JsonProperty("timestamp")]
        public string timestamp { get; set; }
    }
}