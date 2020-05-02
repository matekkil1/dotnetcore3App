using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalManager.Services
{
    public class TestMailService : IMailService
    {
        private readonly ILogger<TestMailService> logger;

        public TestMailService(ILogger<TestMailService> _logger)
        {
            logger = _logger;
        }
        public void SendMessage(string to, string subject, string body)
        {
            logger.LogInformation($"To {to} Subjetct {subject} Body {body}");


        }
    }
}
