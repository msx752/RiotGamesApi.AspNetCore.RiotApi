﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace RiotGamesApi.AspNetCore.RiotApi.NonStaticEndPoints.Spectator
{
    public class Observer
    {
        //Key used to decrypt the spectator grid game data for playback
        [JsonProperty("encryptionKey")]
        public string encryptionKey { get; set; }
    }
}