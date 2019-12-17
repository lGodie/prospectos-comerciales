using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using prospectos_comerciales.Data.Entities;

namespace prospectos_comerciales.Controllers
{
    public class ProspectosController : Controller
    {
        private readonly SentryContext _context;

        public ProspectosController(SentryContext context)
        {
            _context = context;
        }

        
    }
}
