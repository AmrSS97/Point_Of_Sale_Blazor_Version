using Models;
using Models.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IItemMapper
    {
        public List<Item> MapItemDtoListToItemList(List<ItemDTO> ItemDtoList, Guid BillID);
    }
}
