﻿using System.Text.Json;
using Microsoft.AspNetCore.Mvc;

namespace Cobra.Server.Controllers.Hitman
{
    public partial class HitmanController
    {
        [HttpPost]
        [Route("AddMetrics")]
        public IActionResult AddMetrics([FromBody] JsonDocument request)
        {
            return Ok();
        }
    }
}
