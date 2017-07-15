﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.Spectator
{
    public class FeaturedGameInfo
    {
        //The ID of the game
        [JsonProperty("gameId")]
        public long gameId { get; set; }

        //The game start time represented in epoch milliseconds
        [JsonProperty("gameStartTime")]
        public long gameStartTime { get; set; }

        //The ID of the platform on which the game is being played
        [JsonProperty("platformId")]
        public string platformId { get; set; }

        //The game mode
        [JsonProperty("gameMode")]
        public string gameMode { get; set; }

        //The ID of the map
        [JsonProperty("mapId")]
        public long mapId { get; set; }

        //The game type
        [JsonProperty("gameType")]
        public string gameType { get; set; }

        //Banned champion information
        [JsonProperty("bannedChampions")]
        public List<BannedChampion> bannedChampions { get; set; }

        //The observer information
        [JsonProperty("observers")]
        public Observer observers { get; set; }

        //The participant information
        [JsonProperty("participants")]
        public List<Participant> participants { get; set; }

        //The amount of time in seconds that has passed since the game started
        [JsonProperty("gameLength")]
        public long gameLength { get; set; }

        //The queue type (queue types are documented on the Game Constants page)
        [JsonProperty("gameQueueConfigId")]
        public long gameQueueConfigId { get; set; }
    }
}