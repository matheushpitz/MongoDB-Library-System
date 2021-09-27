using System;

namespace MongoLibSys.Core.Exceptions
{
    public class HttpException: Exception
    {
        public int Status { get; set; }
        public object Body { get; set; }
        public HttpException(int status)
        {
            this.Status = status;
        }
        public HttpException(int status, object body): this(status)
        {
            this.Body = body;

        }
    }
}
