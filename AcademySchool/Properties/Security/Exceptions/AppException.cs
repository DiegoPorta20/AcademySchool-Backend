using System.Globalization;

namespace AcademySchool.Security.Exceptions;

public class AppException : Exception
{
    public AppException()
    {
    }

    public AppException(string? message) : base(message)
    {
    }

    public AppException(string message, params object[] args) : 
        base(String.Format(CultureInfo.CurrentCulture, message, args))
    {
    }
}