﻿using System;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;
using System.Reflection;

namespace Popcorn.Utils
{
    /// <summary>
    /// Constants of the project
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// App version
        /// </summary>
        public const string AppVersion = "3.3.0";

        /// <summary>
        /// Endpoint to API
        /// </summary>
        public const string PopcornApi = "https://popcornapi.azurewebsites.net/api";

        /// <summary>
        /// Url used to start a local OWIN server
        /// </summary>
        public const string ServerUrl = "http://*:9900/";
        
        /// <summary>
        /// Open Subtitles User Agent
        /// </summary>
        public const string OsdbUa = "Popcorn v1.0";

        /// <summary>
        /// Trakt Client Api key
        /// </summary>
        public const string TraktClientApiKey = "a946923efa1f62c49cef3052d13591ee3584ce74ee3db6cb65c7baab8b63414f";

        /// <summary>
        /// Trakt Secret Api key
        /// </summary>
        public const string TraktSecretKey = "3c1633962c5654ec3cb124df7993a89f4aaf279992de3fde7435a749e8970650";

        /// <summary>
        /// Client ID for TMDb
        /// </summary>
        public const string TmDbClientId = "a21fe922d3bac6654e93450e9a18af1c";

        /// <summary>
        /// Path to the FFmpeg shared libs
        /// </summary>
        public static string FFmpegPath => $@"{Directory.GetParent(new Uri(Assembly.GetExecutingAssembly().CodeBase)
            .AbsolutePath)}\FFmpeg";

        /// <summary>
        /// In percentage, the minimum of buffering before we can actually start playing the movie
        /// </summary>
        public static double MinimumMovieBuffering
        {
            get
            {
                try
                {
                    return double.Parse((ConfigurationManager.GetSection("settings") as NameValueCollection)["MinimumMovieBuffering"]);
                }
                catch (Exception)
                {
                    return 10d;
                }
            }
        }

        /// <summary>
        /// In percentage, the minimum of buffering before we can actually start playing the episode
        /// </summary>
        public static double MinimumShowBuffering
        {
            get
            {
                try
                {
                    return double.Parse((ConfigurationManager.GetSection("settings") as NameValueCollection)["MinimumShowBuffering"]);
                }
                catch (Exception)
                {
                    return 10d;
                }
            }
        }

        /// <summary>
        /// The maximum number of movies per page to load from the API
        /// </summary>
        public const int MaxMoviesPerPage = 20;

        /// <summary>
        /// The maximum number of shows per page to load from the API
        /// </summary>
        public const int MaxShowsPerPage = 20;

        /// <summary>
        /// Url of the server updates
        /// </summary>
        public const string GithubRepository = "https://github.com/bbougot/Popcorn";

        /// <summary>
        /// Default request timeout
        /// </summary>
        public const int DefaultRequestTimeoutInSecond = 10;
    }
}