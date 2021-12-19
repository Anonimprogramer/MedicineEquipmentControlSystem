using System.Reflection;
using System.Runtime.InteropServices;

namespace MedicineEquipmentControSystem
{
    public class DataStorage
    {
        private EquipmentList orderList;
        private EquipmentList waitingList;
        private EquipmentList inStockList;
        public ProductsList productsList;
        public CriticalAmountList criticalAmountList;
        private Status status;

        public void SetStatus(Status status)
        {
            this.status = status;
        }

        public Status GetStatus()
        {
            return this.status;
        }

        public EquipmentList GetOrderList()
        {
            return this.orderList;
        }

        public EquipmentList GetWaitingList()
        {
            return this.waitingList;
        }

        public EquipmentList GetInStockList()
        {
            return this.inStockList;
        }

        public DataStorage(EquipmentList orderList, EquipmentList waitingList, EquipmentList inStockList,ProductsList productsList,CriticalAmountList criticalAmountList)
        {
            this.orderList = orderList;
            this.waitingList = waitingList;
            this.inStockList = inStockList;
            this.criticalAmountList = criticalAmountList;
            this.productsList = productsList;
        }
        
    }
}