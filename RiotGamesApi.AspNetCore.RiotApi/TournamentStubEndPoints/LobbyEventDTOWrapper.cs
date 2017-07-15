using System.Collections.Generic;
using Newtonsoft.Json;

namespace RiotGamesApi.AspNetCore.RiotApi.TournamentStubEndPoints
{
    public class LobbyEventDTOWrapper
    {
        [JsonProperty("eventList")]
        public List<LobbyEventDTO> eventList { get; set; }
    }
}