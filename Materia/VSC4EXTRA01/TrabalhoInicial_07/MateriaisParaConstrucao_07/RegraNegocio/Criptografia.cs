using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegraNegocio
{
    public class Criptografia
    {

        public string Descriptografar(string senhaCripto)
        {
            //Variável do tipo Byte que armazenará a senha criptografada convertida para uma cadeia binária.
            byte[] senhaBinaria = Convert.FromBase64String(senhaCripto);

            //Variável do tipo string recebe o conteúdo da variável senhaBinaria convertido para a sua representação em caracteres.
            string senhaDecripto = ASCIIEncoding.ASCII.GetString(senhaBinaria);
            return senhaDecripto;
        }
    }
}
