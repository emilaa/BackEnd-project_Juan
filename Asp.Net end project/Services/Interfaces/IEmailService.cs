using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.Net_end_project.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(string from, string to, string body, string subject);
    }
}
