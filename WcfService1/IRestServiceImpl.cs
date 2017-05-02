using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IRestServiceImpl" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IRestServiceImpl
    {
        [OperationContract]
        [WebInvoke(Method="GET",
            ResponseFormat=WebMessageFormat.Json,
            BodyStyle=WebMessageBodyStyle.Wrapped,
            UriTemplate="json/{id}")]
        string DoWork(string id);

        [OperationContract]
        [WebInvoke(Method = "GET",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped,
            UriTemplate = "Suma/{res}")]
        long Suma(string res);
    }
}
