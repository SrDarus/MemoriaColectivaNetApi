using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class ResponseEntity
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }

        public ResponseEntity()
        {

        }

        public ResponseEntity(HttpStatusCode code, dynamic data)
        {
            Code = code;
            Data = data;
        }

        public ResponseEntity(HttpStatusCode code, string message)
        {
            Code = code;
            Message = message;
        }

        public ResponseEntity(HttpStatusCode code, string message, dynamic data)
        {
            Code = code;
            Message = message;
            Data = data;
        }
    }
}
