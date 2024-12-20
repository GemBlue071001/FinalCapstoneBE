﻿namespace Domain
{
    public class AppSettings
    {
        public ConnectionStrings ConnectionStrings { get; set; }
        public Logging Logging { get; set; }
        public string AllowedHosts { get; set; }
        public SecretToken SecretToken { get; set; }
        public ApiSettings ApiSettings { get; set; }
    }
    public class ConnectionStrings
    {
        public string DefaultConnection { get; set; }
        public string LocalDockerConnection { get; set; }
    }

    public class Logging
    {
        public LogLevel LogLevel { get; set; }
    }

    public class LogLevel
    {
        public string Default { get; set; }
        public string MicrosoftAspNetCore { get; set; }
    }

    public class SecretToken
    {
        public string Value { get; set; }
    }
    public class ApiSettings
    {
        public string RootServerUrl { get; set; }
        public string UpLoadAndProcess { get; set; }
        public string UpLoadCv { get; set; }
        public string UpLoadJob { get; set; }
        public string AnalyzeMatch { get; set; }
        public string JobsSearch { get; set; }
        public string Embed { get; set; }

    }

}
