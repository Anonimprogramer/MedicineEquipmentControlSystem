using System.Collections.Generic;

namespace MedicineEquipmentControSystem
{
    public class ProductsList
    {
        private List<ProductsNote> equipmentList;
        public ProductsList(List<ProductsNote> list){
            equipmentList=list;
        }

        public void SetList(List<ProductsNote> list)
        {
            equipmentList = list;
        }

        public List<ProductsNote> GetList()
        {
            return equipmentList;
        }
    }
}