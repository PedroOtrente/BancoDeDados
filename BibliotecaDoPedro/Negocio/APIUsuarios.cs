using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BD;
using Objetos;

namespace Negocio
{
    public class APIUsuarios
    {
        bdusuario BARBIE = new bdusuario();

        public DataTable login(Usuario uai)
        {
            return BARBIE.login(uai);
        }

        public bool usuarioexiste(Usuario uai)
        {
            return BARBIE.verificarocaodousuario(uai);
        }

        public void desgraca(Usuario uai)
        {
            BARBIE.cadastraressecu(uai);
        }
    }
}
