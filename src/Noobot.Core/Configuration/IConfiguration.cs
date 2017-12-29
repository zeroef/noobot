using System;

namespace Noobot.Core.Configuration
{
    /// <summary>
    /// This dependency defines all the middleware/plugins you want to be executed in your application
    /// </summary>
    public interface IConfiguration
    {
        /// <summary>
        /// Automatically scan for implementations of <see cref="MessagingPipeline.Middleware.IMiddleware" />
        /// </summary>
        bool AutoDiscoverMiddleware { get; }

        /// <summary>
        /// Automatically scan for implementations of <see cref="Plugins.IPlugin" />
        /// </summary>
        bool AutoDiscoverPlugins { get; }

        /// <summary>
        /// Priority order pipeline for middleware to be executed
        /// </summary>
        Type[] ListMiddlewareTypes();

        /// <summary>
        /// A list of plugins to use within the application
        /// </summary>
        Type[] ListPluginTypes();
    }
}