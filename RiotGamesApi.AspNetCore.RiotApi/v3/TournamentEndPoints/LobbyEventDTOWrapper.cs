using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace RiotGamesApi.AspNetCore.RiotApi.TournamentEndPoints
{
    public class LobbyEventDTOWrapper
    {
        [JsonProperty("eventList")]
        public List<LobbyEventDTO> eventList { get; set; }
    }
}