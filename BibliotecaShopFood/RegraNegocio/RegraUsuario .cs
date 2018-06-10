using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.RegraNegocio
{
    public interface RegraUsuario
    {
        String Insert(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
        List<Usuario> Select(Usuario usuario);
    }
}
