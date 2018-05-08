using System;
namespace hileets.TMS
{
    public class ErrorHandling
    {
        static IErrorHandler errorHandler;
        public ErrorHandling(IErrorHandler errorHandlerView)
        {
            errorHandler = errorHandlerView;
        }
        public static void LogE(string error)
        {
            errorHandler.LogError(error);
        }
        public static void LogM(string msg){
            errorHandler.LogMsg(msg);
        }
    }
}
