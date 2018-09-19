using System;
using System.Collections.Generic;
using System.Text;

namespace CBS.Common.Services.Email
{
    public class EmailDto
    {
        public string EmailSender { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
        public string EmailRecipient { get; set; }

        public IList<EmailRecipients> EmailRecipients { get; set; }
    }

    public class EmailRecipients
    {
        public string EmailRecipient { get; set; }
    }
}
