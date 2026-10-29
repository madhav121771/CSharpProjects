using System;
/// <summary>
/// This is example of ABSTRACTION  using abstract class 
/// here print() method is abstracted as below
/// </summary>
namespace _27_Abstraction
{
    public interface IService // base interface
    {
        void Execute();
    }

    public class EmailService : IService
    {
        public void Execute()
        {
            Console.WriteLine("Sending an email");
        }
    }

    public class SMSService : IService
    {
        public void Execute()
        {
            Console.WriteLine("Sending an SMS");
        }
    }

    public class NotificationManager
    {
        private readonly IService _service;

        public NotificationManager(IService service)
        {
            _service = service;
        }

        public void Notify()
        {
            _service.Execute();
        }
    }

}
