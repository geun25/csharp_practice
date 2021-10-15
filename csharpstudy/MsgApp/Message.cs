using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace MsgApp
{
    abstract class MessageBase
    {
        protected Guid id = Guid.NewGuid();
        public string ToWhom { get; set; }
        public string Message { get; set; }

        public abstract void Send(); // 구현이 안되어 있기 때문에 객체 생성 불가

        //public virtual void Send()
        //{
        //    Console.WriteLine($"Send Message to {ToWhom}");
        //    Console.WriteLine($"{Message}");
        //}

        protected void DebugMessageInfo()
        {
            Debug.WriteLine($"Message Id: {id}");
            Debug.WriteLine($"To: {ToWhom}");
            Debug.WriteLine($"Message: {Message}");
        }
    }

    sealed class EmailMessage : MessageBase // sealed : 파생 클래스 더 이상 생성 불가
    {
        public string Email { get; set; }

        public EmailMessage(string email)
        {
            Email = email;
        }

        // 메서드 오버라이딩
        public override void Send() 
        {
            MailMessage msg = new MailMessage("sender@live.com", this.Email, "제목", this.Message);
            SmtpClient smtp = new SmtpClient("smtp.live.com", 587);
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("sender@live.com", "password");
            smtp.Send(msg);
        }
    }

    class SMSMessage : MessageBase
    {
        public string PhoneNumber { get; set; }

        public override void Send()
        {         

        }
    }
}
