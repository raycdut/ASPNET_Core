﻿namespace Demo.Models
{
    using System.Collections.Generic;

    public interface ITodoRepository
    {
        void Add(TodoItem item);

        IEnumerable<TodoItem> GetAll();

        TodoItem Find(string key);

        TodoItem Remove(string key);

        void Update(TodoItem item);
    }
}