using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.League;
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
            Assert.NotNull(jsonConverter1);

            string json2 =
                "   {\r\n        \"queueType\": \"RANKED_SOLO_5x5\",\r\n        \"hotStreak\": false,\r\n        \"wins\": 94,\r\n        \"veteran\": true,\r\n        \"losses\": 86,\r\n        \"playerOrTeamId\": \"466244\",\r\n        \"tier\": \"GOLD\",\r\n        \"playerOrTeamName\": \"Kesintisiz\",\r\n        \"inactive\": false,\r\n        \"rank\": \"II\",\r\n        \"freshBlood\": false,\r\n        \"leagueName\": \"Maokai\'s Weaponmasters\",\r\n        \"leaguePoints\": 61\r\n    }";
            LeaguePositionDTO jsonConverter2 = JsonConvert.DeserializeObject<LeaguePositionDTO>(json2);
            Assert.NotNull(jsonConverter2);
        }
    }
}