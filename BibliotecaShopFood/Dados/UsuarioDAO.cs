using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.Dados
{
    public interface UsuarioDAO
    {
        void Insert(Usuario usuario);
        void Update(Usuario usuario);
        void Delete(Usuario usuario);
        bool VerificaDuplicidade(Usuario usuario);
        List<Usuario> Select(Usuario filtro);
    }
}
