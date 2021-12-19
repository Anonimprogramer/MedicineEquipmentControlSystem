using System.Collections.Generic;
using System.Windows.Forms;
using MedicineEquipmentControSystem;

class EquipmentListView
{
    public DataGridView View;
    public DataGridViewTextBoxColumn NameColumn;
    public DataGridViewTextBoxColumn ProviderColumn;
    public DataGridViewTextBoxColumn TypeColumn;
    public DataGridViewTextBoxColumn CountColumn;
    public DataGridViewButtonColumn PlusColumn;
    public DataGridViewButtonColumn MinusColumn;
    public DataGridViewCheckBoxColumn SelectColumn;
    public DataGridView ViewCreate(EquipmentList equipmentList)
    {
        this.View = new DataGridView();
        this.NameColumn = new DataGridViewTextBoxColumn();
        this.NameColumn.HeaderText = "Название";
        this.ProviderColumn = new DataGridViewTextBoxColumn();
        this.ProviderColumn.HeaderText = "Поставщик";
        this.TypeColumn = new DataGridViewTextBoxColumn();
        this.TypeColumn.HeaderText = "Тип";
        this.CountColumn = new DataGridViewTextBoxColumn();
        this.CountColumn.HeaderText = "Количество";
        this.PlusColumn = new DataGridViewButtonColumn();
        this.MinusColumn = new DataGridViewButtonColumn();
        this.SelectColumn = new DataGridViewCheckBoxColumn();
        this.View.Columns.AddRange(this.NameColumn,this.ProviderColumn,this.MinusColumn,this.CountColumn,this.PlusColumn,this.TypeColumn);
        List<EquipmentNote> list=equipmentList.GetList();
        foreach (var note in list)
        {
            View.Rows.Add(note);
        }
        return this.View;
    }
}