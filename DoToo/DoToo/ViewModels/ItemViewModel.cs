using System;
using DoToo.Models;
using DoToo.Repositories;
using System.Windows.Input;
using Xamarin.Forms;


namespace DoToo.ViewModels
{
    public class ItemViewClass : ViewModel
    {
        private readonly TodoItemRepository repository;
        public ItemViewModel(TodoItemRepository repository)
        {
            this.repository = repository;
        }
    }

}
