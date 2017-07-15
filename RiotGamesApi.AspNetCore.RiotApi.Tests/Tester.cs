using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RiotGamesApi.AspNetCore.RiotApi.Enums;
using RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.League;
using RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.Match;
using RiotGamesApi.AspNetCore.RiotApi.StatusEndPoints;
using Xunit;

namespace RiotGamesApi.AspNetCore.RiotApi.Tests
{
    public class Tester
    {
        [Fact]
        public void PropertyTest()
        {
            var json1 = "{\r\n     \"tier\": \"CHALLENGER\",\r\n    \"queue\": \"RANKED_SOLO_5x5\",\r\n    \"name\": \"Annie\'s Chosen\",\r\n    \"entries\": [\r\n        {\r\n            \"hotStreak\": false,\r\n            \"wins\": 208,\r\n            \"veteran\": false,\r\n            \"losses\": 160,\r\n            \"rank\": \"I\",\r\n            \"playerOrTeamName\": \"i will split\",\r\n            \"inactive\": false,\r\n            \"playerOrTeamId\": \"12480305\",\r\n            \"freshBlood\": false,\r\n            \"leaguePoints\": 146\r\n        }]\r\n}";
            LeagueListDTO jsonConverter1 = JsonConvert.DeserializeObject<LeagueListDTO>(json1);
            Assert.NotNull(jsonConverter1.queue);

            string json2 =
                "   {\r\n        \"queueType\": \"RANKED_SOLO_5x5\",\r\n        \"hotStreak\": false,\r\n        \"wins\": 94,\r\n        \"veteran\": true,\r\n        \"losses\": 86,\r\n        \"playerOrTeamId\": \"466244\",\r\n        \"tier\": \"GOLD\",\r\n        \"playerOrTeamName\": \"Kesintisiz\",\r\n        \"inactive\": false,\r\n        \"rank\": \"II\",\r\n        \"freshBlood\": false,\r\n        \"leagueName\": \"Maokai\'s Weaponmasters\",\r\n        \"leaguePoints\": 61\r\n    }";
            LeaguePositionDTO jsonConverter2 = JsonConvert.DeserializeObject<LeaguePositionDTO>(json2);
            Assert.NotNull(jsonConverter2.queueType);

            string json3 =
                "{\r\n     \"seasonId\": 9,\r\n \"queueId\": 440,\r\n \"gameId\": 577423066,\r\n \"gameVersion\": \"7.14.195.3579\",\r\n \"platformId\": \"TR1\",\r\n \"gameMode\": \"CLASSIC\",\r\n \"mapId\": 11,\r\n \"gameType\": \"MATCHED_GAME\",\r\n \"gameCreation\": \"1499364575183\"}";
            MatchDto jsonConverter3 = JsonConvert.DeserializeObject<MatchDto>(json3);
            Assert.NotNull(jsonConverter3.gameCreation);
            Assert.NotNull(jsonConverter3.gameMode);
            Assert.NotNull(jsonConverter3.gameType);
            Assert.NotNull(jsonConverter3.platformId);

            string json4 = "{\r\n    \"name\": \"Turkey\",\r\n    \"region_tag\": \"tr1\",\r\n    \"hostname\": \"prod.tr.lol.riotgames.com\",\r\n    \"services\": [\r\n        {\r\n            \"status\": \"online\",\r\n            \"incidents\": [],\r\n            \"name\": \"Game\",\r\n            \"slug\": \"game\"\r\n        },\r\n        {\r\n            \"status\": \"online\",\r\n            \"incidents\": [],\r\n            \"name\": \"Store\",\r\n            \"slug\": \"store\"\r\n        },\r\n        {\r\n            \"status\": \"online\",\r\n            \"incidents\": [],\r\n            \"name\": \"Website\",\r\n            \"slug\": \"website\"\r\n        },\r\n        {\r\n            \"status\": \"online\",\r\n            \"incidents\": [],\r\n            \"name\": \"Client\",\r\n            \"slug\": \"client\"\r\n        }\r\n    ],\r\n    \"slug\": \"tr\",\r\n    \"locales\": [\r\n        \"tr_TR\"\r\n    ]\r\n}";
            ShardStatus jsonConverter4 = JsonConvert.DeserializeObject<ShardStatus>(json4);
            Assert.NotNull(jsonConverter4.region_tag);
            Assert.NotNull(jsonConverter4.locales);
        }
    }
}