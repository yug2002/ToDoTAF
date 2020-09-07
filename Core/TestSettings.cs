namespace Core
{
    public class TestSettings : ITestSettings
    {
        public string BaseUrl { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Browser { get; set; }

        public string GridUrl { get; set; }

        public int Timeout { get; set; } 
    }
}
