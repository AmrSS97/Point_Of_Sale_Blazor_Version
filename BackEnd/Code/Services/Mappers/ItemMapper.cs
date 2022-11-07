using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ItemMapper : IItemMapper
    {
        private readonly IProductService ProductService;

        public ItemMapper(IProductService ProductService)
        {
            this.ProductService = ProductService;
        }
        public List<Item> MapItemDtoListToItemList(List<ItemDTO> ItemDtoList, Guid BillID)
        {
            List<Item> ItemList = new List<Item>();
            foreach(var ItemDto in ItemDtoList)
            {
                Item Item = new Item();
                Item.ItemQuantity = ItemDto.ItemQuantity;
                Item.ProductID = ProductService.GetProductByName(ItemDto.ProductName).ProductID;
                Item.BillID = BillID;
                Item.IsDeleted = false;
                ItemList.Add(Item);
            }
            return ItemList;
        }
    }
}
