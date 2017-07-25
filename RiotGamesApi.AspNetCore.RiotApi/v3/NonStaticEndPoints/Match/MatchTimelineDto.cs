﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.Match
{
    public class MatchTimelineDto
    {
        //
        [JsonProperty("frames")]
        public List<MatchFrameDto> frames { get; set; }

        [JsonProperty("frameInterval")]
        public long frameInterval { get; set; }
    }
}