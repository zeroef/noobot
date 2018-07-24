using System;
using System.Collections.Generic;
using Noobot.Core.MessagingPipeline.Middleware.ValidHandles;
using Noobot.Core.MessagingPipeline.Request;
using Noobot.Core.MessagingPipeline.Response;

namespace Noobot.Core.MessagingPipeline.Middleware.StandardMiddleware
{
    internal class AboutMiddleware : MiddlewareBase
    {
        public AboutMiddleware(IMiddleware next) : base(next)
        {
            HandlerMappings = new[]
            {
                new HandlerMapping
                {
                    ValidHandles = ExactMatchHandle.For("about"),
                    Description = "Tells you some stuff about this bot :-)",
                    EvaluatorFunc = AboutHandler
                }
            };
        }

        private IEnumerable<ResponseMessage> AboutHandler(IncomingMessage message, IValidHandle matchedHandle)
        {
            yield return message.ReplyDirectlyToUser("uBot - a sassy uInform bot");
            yield return message.ReplyDirectlyToUser("I am a SlackBot built in C# using piles of spaghet");
            yield return message.ReplyDirectlyToUser("Contact Matt Wilson (uConnect|IET) for help / troubleshooting");
        }
    }
}
