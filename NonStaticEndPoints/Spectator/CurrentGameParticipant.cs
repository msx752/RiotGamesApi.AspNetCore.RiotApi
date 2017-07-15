﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.Spectator
{
    public class CurrentGameParticipant
    {
        //The ID of the profile icon used by this participant
        [JsonProperty("profileIconId")]
        public long profileIconId { get; set; }

        //The ID of the champion played by this participant
        [JsonProperty("championId")]
        public long championId { get; set; }

        //The summoner name of this participant
        [JsonProperty("summonerName")]
        public string summonerName { get; set; }

        //The runes used by this participant
        [JsonProperty("runes")]
        public List<Rune> runes { get; set; }

        //Flag indicating whether or not this participant is a bot
        [JsonProperty("bot")]
        public bool bot { get; set; }

        //The team ID of this participant, indicating the participant's team
        [JsonProperty("teamId")]
        public long teamId { get; set; }

        //The ID of the second summoner spell used by this participant
        [JsonProperty("spell2Id")]
        public long spell2Id { get; set; }

        //The masteries used by this participant
        [JsonProperty("masteries")]
        public List<Mastery> masteries { get; set; }

        //The ID of the first summoner spell used by this participant
        [JsonProperty("spell1Id")]
        public long spell1Id { get; set; }

        //The summoner ID of this participant
        [JsonProperty("summonerId")]
        public long summonerId { get; set; }
    }
}