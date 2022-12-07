using AvaliacaoB3.Dominio.Interfaces.Servicos;
using AvaliacaoB3.Dominio.Servicos;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoB3.Testes
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ICdbServico, CdbServico>();
        }
    }
}
