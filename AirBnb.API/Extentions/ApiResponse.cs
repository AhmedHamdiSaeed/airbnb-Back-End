namespace AirBnb.API.Extentions
{
    public record ApiResponse(int StatusCode, string Message, object Data);

}
