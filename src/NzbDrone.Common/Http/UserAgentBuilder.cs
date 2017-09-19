using NzbDrone.Common.EnvironmentInfo;

namespace NzbDrone.Common.Http
{
    public static class UserAgentBuilder
    {
        public static string UserAgent { get; private set; }
        public static string UserAgentSimplified { get; private set; }

        static UserAgentBuilder()
        {
            UserAgent = string.Format("Bonarr/{0} ({1} {2})",
                BuildInfo.Version,
                OsInfo.Os, OsInfo.Version.ToString(2));

            UserAgentSimplified = string.Format("Bonarr/{0}",
                BuildInfo.Version.ToString(2));
        }
    }
}
