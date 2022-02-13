using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain.Events;
using Domain.Exceptions;
using Domain.ValueObjects;
using SharedAbstractions.Domain;

namespace Domain.Entities
{
    public class PackingList:AggregateRoot<PackingListId>
    {
        public PackingListId Id { get; private set; }
        private PackingListName _name;
        private Localization _localization;

        private readonly LinkedList<PackingItem> _items = new();

        internal PackingList(PackingListId id, PackingListName name, Localization localization, LinkedList<PackingItem> items)
        {
            Id = id;
            _name = name;
            _localization = localization;
        }

        public void AddItem(PackingItem item)
        {
            var alreadyExists = _items.Any(i => i.Name == item.Name);
            if (alreadyExists)
            {
                throw new PacketItemAlreadyExistsException(_name, item.Name);
            }

            _items.AddLast(item);
            AddEvent(new PackingItemAdded(this,item));
        }

        public void AddItems(IEnumerable<PackingItem> items)
        {
            foreach (var item in items)
            {
                AddItem(item);
            }
        }

        public void PackItem(string itemName)
        {
            var item = GetItem(itemName);
            var PackedItem = item with {IsPacked = true};
        }

        private PackingItem GetItem(string itemName)
        {
            var item = _items.SingleOrDefault(i=> i.Name == itemName);
            if (item is null)
            {
                throw new PackingItemNotFoundException(itemName);
            }

            return item;
        }
    }
}
