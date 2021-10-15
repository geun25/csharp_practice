using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsgApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailMessage em = new EmailMessage("dg@abc.com");
            em.ToWhom = "홍길동";
            em.Message = "서류가 완료되었습니다.";
            em.Send();
        }
    }
}
