using CBS.Common.Services.Email;
using System.Threading.Tasks;

namespace CBS.Common.Interface
{
    public interface IEmailSender
    {
        string SendEmail(EmailDto emaildto);
    }
}
