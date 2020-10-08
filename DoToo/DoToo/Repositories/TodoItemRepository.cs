using DoToo.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace DoToo.Repositories
{
    public class TodoItemRepository:ITodoItemRepository
    {
       {
        public event EventHandler<TodoItem> OnItemAdded;
        public event EventHandler<TodoItem> OnItemUpdated;
        public async Task<List<TodoItem>>GetItems()
        {
            return null;
        }
        public async Task AddItem(TodoItem item)
        {

        }
        public async Task UpdateItem(TodoItem item)
        {

        }
        public async Task AddOrUpdateItem(TodoItem item)
        {
            if (item.Id == 0)
            {
                await AddItem(item);
            }
            else
            {
                await UpdateItem(item);
            }
        }
    }
}
