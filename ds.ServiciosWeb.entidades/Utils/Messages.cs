using System;
using System.Collections.Generic;
using System.Text;

namespace ds.WebServices.entities.Utils
{
  public static class Messages
    {
        public static string Exception { get { return "Ha ocurrido una Excepción"; } }
        public static string RegistryExists { get { return "Existe un registro de igual información"; } }
        public static string Successful { get { return "La acción se ha realizado satisfactoriamente"; } }
        public static string Error { get { return "Ha ocurrido error inesperado"; } }
        public static string UserNotConfirmed { get { return "Usuario sin Confirmar"; } }
        public static string RecordNoFound { get { return "El registro solicitado no se ha encontrado"; } }
        public static string InvalidModel { get { return "El Módelo es inválido"; } }
        public static string UnsatisfactoryDeletion { get { return "No es posible eliminar el registro, existen relaciones que dependen de él"; } }
    }
}
