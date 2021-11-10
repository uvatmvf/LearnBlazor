using System;
using System.Timers;

namespace ToDoList
{
    public class TodoGenerator : IDisposable
    {
        private IServiceProvider _serviceProvider;
        private Timer _timer;

        public TodoGenerator(IServiceProvider services)
        {
            _serviceProvider = services;
            _timer = new Timer(2500);
            _timer.Elapsed += Timer_Elapsed;
            _timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            var todo = (NotifierService)_serviceProvider.GetService(typeof(NotifierService));
            todo.Update(string.Empty, 0);
        }

        public void Dispose()
        {
            _timer.Elapsed -= Timer_Elapsed;
            _timer.Stop();
        }
    }
}
