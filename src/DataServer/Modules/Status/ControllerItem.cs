﻿// Copyright (c) 2017 TrakHound Inc., All Rights Reserved.

// This file is subject to the terms and conditions defined in
// file 'LICENSE.txt', which is part of this source code package.

using Newtonsoft.Json;
using System.Collections.Generic;

namespace TrakHound.DataServer.Modules.Status
{
    class ControllerItem
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("data")]
        public List<StatusItem> Data { get; set; }

        [JsonProperty("paths")]
        public List<PathItem> Paths { get; set; }

        public ControllerItem()
        {
            Data = new List<StatusItem>();
            Paths = new List<PathItem>();
        }
    }
}
