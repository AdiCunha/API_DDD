using Dominio.Interfaces.InterfaceServicos;
using Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces.Servicos
{

    public class ServicoNoticia : IServicoNoticia
    {
        private readonly INoticia _INoticia;


        public ServicoNoticia(INoticia INoticia)
        {
            _INoticia = INoticia;
        }


        public async Task AdicionaNoticia(Noticia noticia)
        {
            throw new NotImplementedException();
        }

        public async Task AtualizaNoticia(Noticia noticia)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Noticia>> ListarNoticiasAtivas()
        {
            throw new NotImplementedException();
        }
    }
}
