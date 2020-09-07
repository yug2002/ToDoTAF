namespace Core
{
    public interface ITestSettings
    {
        string BaseUrl { get; set; }
        string Browser { get; set; }
        string GridUrl { get; set; }
        string Login { get; set; }
        string Password { get; set; }
        int Timeout { get; set; }
    }
}