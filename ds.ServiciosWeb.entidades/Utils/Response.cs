using System.Collections.Generic;

namespace ds.WebServices.entities.Utils
{
    public  class Response
    {
        public  bool IsSuccess { get; set; }
        public  string Message { get; set; }
        public  object Result { get; set; }
        public  List<object> Results { get; set; }
    }
}
