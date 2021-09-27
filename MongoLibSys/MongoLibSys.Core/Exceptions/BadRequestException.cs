namespace MongoLibSys.Core.Exceptions
{
    public class BadRequestException: HttpException
    {
        public BadRequestException(string message): base(400, message) { }
    }
}
