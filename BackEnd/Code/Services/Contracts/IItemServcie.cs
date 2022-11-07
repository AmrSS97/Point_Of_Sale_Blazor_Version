using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IItemService
    {
        void CreateItem(Item Item);
        void DeleteItem(Item Item);
        ItemDTO SoftDeleteItem(Guid ItemID);
        void UpdateItem(Guid ItemID, Item Item);
        void SaveItem();
        void AddItemList(List<Item> ItemList);
        Item GetItemById(Guid ItemID);
        void DeleteItemsDueToRefund(List<Item> ItemList);
    }
}
