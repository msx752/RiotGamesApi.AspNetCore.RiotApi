﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.Match
{
    public class ParticipantIdentityDto
    {
        //
        [JsonProperty("player")]
        public PlayerDto player { get; set; }

        [JsonProperty("participantId")]
        public int participantId { get; set; }
    }
}