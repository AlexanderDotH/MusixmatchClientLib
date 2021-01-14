﻿using MusixmatchClientLib.API.Model.Types;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusixmatchClientLib.API.Model
{
    public class TrackGet : MusixmatchApiResponse
    {
        [JsonProperty("track")]
        public Track Track;
    }
}
