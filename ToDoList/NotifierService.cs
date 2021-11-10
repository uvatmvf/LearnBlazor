﻿using System;
using System.Threading.Tasks;

namespace ToDoList
{
    public class NotifierService
    {
        // Can be called from anywhere
        public async Task Update(string key, int value)
        {
            if (Notify != null)
            {
                await Notify.Invoke(key, value);
            }
        }

        public event Func<string, int, Task> Notify;
    }
}
