using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RiotGamesApi.AspNetCore.RiotApi.TournamentEndPoints
{
    public class SummonerIdParams
    {
        //the tournament participants
        [JsonProperty("participants")]
        public List<long> participants { get; set; }
    }
}