
--Procedimeinto en IIS--
**Crear un nuevo sitio web en IIS en el que especificaremos los siguientes par�metros:
**Nombre del sitio
**Physical path, indicar la ruta d�nde se va a publicar el servicio REST.
**En la parte de Binding, especificar el puerto a utilizar. En este caso el 65141

--Procedimiento en VB--
**Publicar el Servicio en el directorio creado para tal fin. Seleccionamos el nombre del proyecto y pulsamos sobre la opci�n �Publicar�.
**Tipo de despliegue �Web Deploy� y configuramos los siguientes par�metros:
***La Url del servicio REST en el sitio web creado. 
***El sitio web en IIS, qu� es RestService tal y como se configur� anteriormente.
***Publish