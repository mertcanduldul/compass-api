namespace compass_api.Models.Entities;

public abstract class BaseResponse
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
}