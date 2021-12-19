using System.Collections.Generic;

namespace MedicineEquipmentControSystem
{
    public class EquipmentList
    {
        private List<EquipmentNote> equipmentList;
        public EquipmentList(List<EquipmentNote> list){
            equipmentList=list;
        }

        public void SetList(List<EquipmentNote> list)
        {
            equipmentList = list;
        }

        public List<EquipmentNote> GetList()
        {
            return equipmentList;
        }
    }
}