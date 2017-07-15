﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using RiotGamesApi.AspNetCore.RiotApi.Converters;
using RiotGamesApi.AspNetCore.RiotApi.Enums;

namespace RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.Spectator
{
    public class CurrentGameInfo
    {
        //The ID of the game
        [JsonProperty("gameId")]
        public long gameId { get; set; }

        //The game start time represented in epoch milliseconds
        [JsonProperty("gameStartTime")]
        public long gameStartTime { get; set; }

        //The ID of the platform on which the game is being played

        [JsonConverter(typeof(StringToEnum<Platform>))]
        [JsonProperty("platformId")]
        public Platform platformId { get; set; }

        //The game mode

        [JsonConverter(typeof(StringToEnum<GameMode>))]
        [JsonProperty("gameMode")]
        public GameMode gameMode { get; set; }

        //The ID of the map
        [JsonProperty("mapId")]
        public long mapId { get; set; }

        //The game type
        [JsonConverter(typeof(StringToEnum<GameType>))]
        [JsonProperty("gameType")]
        public GameType gameType { get; set; }

        //Banned champion information
        [JsonProperty("bannedChampions")]
        public List<BannedChampion> bannedChampions { get; set; }

        //The observer information
        [JsonProperty("observers")]
        public Observer observers { get; set; }

        //The participant information
        [JsonProperty("participants")]
        public List<CurrentGameParticipant> participants { get; set; }

        //The amount of time in seconds that has passed since the game started
        [JsonProperty("gameLength")]
        public long gameLength { get; set; }

        //The queue type (queue types are documented on the Game Constants page)
        [JsonProperty("gameQueueConfigId")]
        public long gameQueueConfigId { get; set; }
    }
}