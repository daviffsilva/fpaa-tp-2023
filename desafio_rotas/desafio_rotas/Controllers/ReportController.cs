﻿using desafio_rotas.Model;
using Microsoft.AspNetCore.Mvc;

namespace desafio_rotas.Controllers
{
    [ApiController]
    [Route("report")]
    public class ReportController : ControllerBase
    {
        [HttpGet]
        public List<Report> getReports() => DataApplication.reports.OrderByDescending(x=> x.dateTime).ToList();
        [HttpDelete]
        public List<Report> resetReport() => DataApplication.reports = new();
    }
}
