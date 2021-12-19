using System.Collections.Generic;

namespace MedicineEquipmentControSystem
{
    public class CriticalAmountList
    {
        private List<CriticalAmountNote> equipmentList;
        public CriticalAmountList(List<CriticalAmountNote> list){
            equipmentList=list;
        }

        public void SetList(List<CriticalAmountNote> list)
        {
            equipmentList = list;
        }

        public List<CriticalAmountNote> GetList()
        {
            return equipmentList;
        }
    }
}