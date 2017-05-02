using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RestServiceImpl" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RestServiceImpl.svc o RestServiceImpl.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class RestServiceImpl : IRestServiceImpl
    {
        public string DoWork(string id)
        {
            return "Hola Mundo hoy es viernes " + id;

        }
        public long Suma(string res)
        {
            int a=1;
            int b=2;
            //int c = res.Cast<int>().First();
            int d = b * 2;
            return d;

        }

    }

}
