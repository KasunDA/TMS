using System;
namespace hileets.TMS
{
    public interface IErrorHandler
    {
        void LogError(string error);
        void LogMsg(string message);
    }
}
