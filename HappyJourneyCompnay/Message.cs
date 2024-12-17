using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyJourneyCompnay
{
    internal class Message
    {
        private String message;
        private int messageId;
        private User reciver;
        private Admin sender;
        private string subject;

        public string MessageText { get { return message; } set { message = value; } }
        public int MessageId { get { return messageId; } set { messageId = value; } }  
        public User Reciver { get { return reciver; } set { reciver = value; } }
        public Admin Sender { get { return sender; } set { sender = value; } }  
        public string Subject { get { return subject; } set { subject = value; } }  

    }
}