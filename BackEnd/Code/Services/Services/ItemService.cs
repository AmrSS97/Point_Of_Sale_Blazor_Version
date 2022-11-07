using Data.Infrastructure;
using Data.Repositories;
using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository ItemRepository;
        private readonly IUnitOfWork UnitOfWork;

        public ItemService(IItemRepository ItemRepository,IUnitOfWork UnitOfWork)
        {
            this.ItemRepository = ItemRepository;
            this.UnitOfWork = UnitOfWork;
        }

        public void AddItemList(List<Item> ItemList)
        {
            foreach(Item Item in ItemList)
            {
                CreateItem(Item);
                SaveItem();
            }
        }

        public void CreateItem(Item Item)
        {
            ItemRepository.Add(Item);
        }

        public void DeleteItem(Item Item)
        {
            ItemRepository.Delete(Item);
        }

        public void DeleteItemsDueToRefund(List<Item> ItemList)
        {
            foreach(Item Item in ItemList)
            {
                Item.IsDeleted = true;
                UpdateItem(Item.ItemID, Item);
                SaveItem();
            }
        }

        public Item GetItemById(Guid ItemID)
        {
            return ItemRepository.GetById(ItemID);
        }

        public void SaveItem()
        {
            UnitOfWork.Commit();
        }


        public void UpdateItem(Guid ItemID, Item Item)
        {
            ItemRepository.Update(ItemID, Item);
        }

        public ItemDTO SoftDeleteItem(Guid ItemID)
        {
            throw new NotImplementedException();
        }
    }
}
