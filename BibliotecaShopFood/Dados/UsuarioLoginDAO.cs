using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaShopFood.ClassesBasicas;

namespace BibliotecaShopFood.Dados
{
    public interface UsuarioLoginDAO
    {
      Usuario UsuarioLogin(string cpf, string senha);
    }
}
