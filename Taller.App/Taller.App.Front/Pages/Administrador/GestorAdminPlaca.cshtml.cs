using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Taller.App.Front.Pages.Administrador
{
    public class GestorAdminPlaca : PageModel
    {
        private readonly ILogger<GestorAdminPlaca> _logger;

        public GestorAdminPlaca(ILogger<GestorAdminPlaca> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}