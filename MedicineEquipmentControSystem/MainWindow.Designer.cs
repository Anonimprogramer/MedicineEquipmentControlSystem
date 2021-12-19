using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace MedicineEquipmentControSystem
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private DataStorage DataStorage;
        private DataGridView DataView;

        public DataGridViewTextBoxColumn NameColumn;
        public DataGridViewTextBoxColumn ProviderColumn;
        public DataGridViewTextBoxColumn TypeColumn;
        public DataGridViewTextBoxColumn CountColumn;
        public DataGridViewButtonColumn PlusColumn;
        public DataGridViewButtonColumn MinusColumn;
        public DataGridViewCheckBoxColumn SelectColumn;

        private MenuStrip MainMenu;
        private ContextMenuStrip contextMenuStrip;
        private Button Action;
        private Button SaveStatus;
        private Button orders;
        private Button waitings;
        private Button instoks;
        private Status status;
        
        
        private ToolStripMenuItem Open;
        private ToolStripMenuItem Save;
        private ToolStripMenuItem Add;
        private ToolStripMenuItem Sort;
        private ToolStripMenuItem View;
        private ToolStripMenuItem Print;

        private ToolStripMenuItem OpenFile;
        private ToolStripMenuItem OpenList;

        private ToolStripMenuItem SaveFile;
        private ToolStripMenuItem SaveFileAs;
        private ToolStripMenuItem SaveList;
        private ToolStripMenuItem SaveListAs;

        private ToolStripMenuItem AddNote;

        private ToolStripMenuItem SortByName;
        private ToolStripMenuItem SortByProducer;
        private ToolStripMenuItem SortByCount;
        private ToolStripMenuItem SortByType;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Text = "MainWindow";
            this.contextMenuStrip = new ContextMenuStrip(this.components);
            
            
            this.MainMenu = new MenuStrip();
        this.Open=new ToolStripMenuItem();
        this.Save=new ToolStripMenuItem();
        this.Add=new ToolStripMenuItem();
        this.Sort=new ToolStripMenuItem();
        this.View=new ToolStripMenuItem();
        this.Print=new ToolStripMenuItem();

        this.instoks = new Button();
        this.instoks.Click+=new System.EventHandler(this.instock);
        this.instoks.Location = new Point(540, 60);
        this.instoks.Size = new Size(100, 30);
        this.instoks.Text = "В наличии";

        this.waitings = new Button();
        this.waitings.Click+=new System.EventHandler(this.waiting);
        this.waitings.Location = new Point(640, 60);
        this.waitings.Size = new Size(100, 30);
        this.waitings.Text = "Ожидание";

        this.orders = new Button();
        this.orders.Click+=new System.EventHandler(this.order);
        this.orders.Location = new Point(740, 60);
        this.orders.Size = new Size(100, 30);
        this.orders.Text = "Заказы";
        
        this.Controls.Add(this.instoks);
        this.Controls.Add(this.orders);
        this.Controls.Add(this.waitings);

        this.OpenFile=new ToolStripMenuItem();
        this.OpenList=new ToolStripMenuItem();

        this.SaveFile=new ToolStripMenuItem();
        this.SaveFileAs=new ToolStripMenuItem();
        this.SaveList=new ToolStripMenuItem();
        this.SaveListAs=new ToolStripMenuItem();

        this.AddNote=new ToolStripMenuItem();

        this.SortByName=new ToolStripMenuItem();
        this.SortByProducer=new ToolStripMenuItem();
        this.SortByCount=new ToolStripMenuItem();
        this.SortByType=new ToolStripMenuItem();
            
            
            this.MainMenu.Items.AddRange(new ToolStripItem[]
                {this.Open,this.Save,this.Sort,this.Add,this.View,this.Print});
            this.MainMenu.Location = new Point(0, 0);
            this.MainMenu.Size =new Size(800, 50);
            
            this.Open.DropDownItems.AddRange(new ToolStripMenuItem[]
                {this.OpenFile,this.OpenList});
            this.Open.Text="Открыть";
            this.OpenFile.Text = "Открыть файл";
            this.OpenFile.Click += new System.EventHandler(this.open);
            this.OpenList.Text = "Открыть таблицу";
            
            this.Save.DropDownItems.AddRange(new ToolStripMenuItem[]
                {this.SaveFile,this.SaveList,this.SaveFileAs,this.SaveListAs});
            this.Save.Text = "Сохранить";
            this.SaveFile.Text ="Сохранить файл " ;
            this.SaveFile.Click += new EventHandler(this.save);
            this.SaveList.Text = "Сохранить таблицу";
            this.SaveFileAs.Text = "Сохранить файл как";
            this.SaveListAs.Text = "Сохранить таблицу как";
            
            
            
            this.Sort.DropDownItems.AddRange(new ToolStripMenuItem[]
                {this.SortByName, this.SortByProducer, this.SortByCount, this.SortByType});
            this.Sort.Text="Отсортировать";
            this.SortByName.Text="по названию";
            this.SortByProducer.Text="по производителю";
            this.SortByCount.Text="по количеству";
            this.SortByType.Text="по типу";
            
            
            this.Add.DropDownItems.AddRange(new ToolStripMenuItem[]
                {this.AddNote});
            this.Add.Text = "Добавить";
            this.AddNote.Text = "запись";
            this.AddNote.Click += new EventHandler(this.add);
            
            
            this.View.DropDownItems.AddRange(new ToolStripItem[]
                {});
            this.View.Text = "Рассмотреть";
            
            
            this.Print.DropDownItems.AddRange(new ToolStripItem[]
                {});
            this.Print.Text = "Распечатать";
            



            this.Action = new Button();
            this.Action.Text = "Списать";
            this.Action.Location = new Point(500, 500);
            this.Action.Size = new Size(100, 100);
            this.Action.Click += new EventHandler(this.action);
            this.Controls.Add(Action);

            this.MainMenuStrip = this.MainMenu;
            this.DataView = null;
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.DataView);
            this.DataStorage = null;
            open(new Object(),new EventArgs());
        }

        private void open(object sender, EventArgs e)
        {
            this.status = Status.InStock;
            List<EquipmentNote> orderList=new List<EquipmentNote>();
            List<EquipmentNote> waitingList=new List<EquipmentNote>();
            List<EquipmentNote> inStockList=new List<EquipmentNote>();
            List<CriticalAmountNote> criticalAmountList = new List<CriticalAmountNote>();
            List<ProductsNote> productsList = new List<ProductsNote>();
            EquipmentNote a = new EquipmentNote();
            ProductsNote b = new ProductsNote();
            CriticalAmountNote c = new CriticalAmountNote();
            
            String connectionString="server=127.0.0.1;port=3306;database=database;user=root;password=SlimShady45";
            MySqlConnection con = new MySqlConnection(connectionString);
            
            
            con.Open();
            string orderSelect = "Select * FROM orders";
            MySqlCommand ordersql = new MySqlCommand(orderSelect,con);
            MySqlDataReader orderReader = ordersql.ExecuteReader();
            while (orderReader.Read())
            {
                a.name = orderReader[0].ToString();
                a.producer = orderReader[1].ToString();
                a.count = Convert.ToInt32(orderReader[2].ToString());
                a.type = orderReader[3].ToString();
                orderList.Add(a);
                a = new EquipmentNote();
            }
            orderReader.Close();
            
            string waitSelect = "Select * FROM wait";
            MySqlCommand waitsql = new MySqlCommand(waitSelect,con);
            MySqlDataReader waitReader = waitsql.ExecuteReader();
            while (waitReader.Read())
            {
                a.name = waitReader[0].ToString();
                a.producer = waitReader[1].ToString();
                a.count = Convert.ToInt32(waitReader[2].ToString());
                a.type = waitReader[3].ToString();
                waitingList.Add(a);
                a = new EquipmentNote();
            }
            waitReader.Close();
            
            
            string inStock = "Select * FROM instock";
            MySqlCommand insql = new MySqlCommand(inStock,con);
            MySqlDataReader inReader = insql.ExecuteReader();
            while (inReader.Read())
            {
                a.name = inReader[0].ToString();
                a.producer = inReader[1].ToString();
                a.count = Convert.ToInt32(inReader[2].ToString());
                a.type = inReader[3].ToString();
                inStockList.Add(a);
                a = new EquipmentNote();
            }
            inReader.Close();
            
            string products = "Select * FROM products";
            MySqlCommand productssql = new MySqlCommand(products,con);
            MySqlDataReader productsReader = productssql.ExecuteReader();
            while (productsReader.Read())
            {
                b.name = productsReader[0].ToString();
                b.producer = productsReader[1].ToString();
                b.type = productsReader[2].ToString();
                productsList.Add(b);
                b = new ProductsNote();
            }
            productsReader.Close();
            
            string criticalAmount = "Select * FROM criticalamount";
            MySqlCommand critsql = new MySqlCommand(criticalAmount,con);
            MySqlDataReader critReader = critsql.ExecuteReader();
            while (critReader.Read())
            {
                c.name = critReader[0].ToString();
                c.count = Convert.ToInt32(critReader[1].ToString());
                c.type = critReader[0].ToString();
                criticalAmountList.Add(c);
                c = new CriticalAmountNote();
            }
            critReader.Close();
            
            EquipmentList OrderList = new EquipmentList(orderList);
            EquipmentList WaitingList = new EquipmentList(waitingList);
            EquipmentList InStockList = new EquipmentList(inStockList);
            ProductsList ProductsList = new ProductsList(productsList);
            CriticalAmountList CriticalAmountList = new CriticalAmountList(criticalAmountList);

            this.DataStorage = new DataStorage(OrderList,WaitingList,InStockList,ProductsList,CriticalAmountList);
            ViewCreate(DataStorage.GetInStockList());
            con.Close();
        }
        private void ViewCreate(EquipmentList equipmentList)
        {
            this.DataView = new DataGridView();
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
            this.DataView.Columns.AddRange(this.NameColumn,this.ProviderColumn,this.MinusColumn,this.CountColumn,this.PlusColumn,this.TypeColumn,this.SelectColumn);
            List<EquipmentNote> list=equipmentList.GetList();
            foreach (var note in list)
            {
                DataView.Rows.Add(note.name,note.producer,"-",note.count,"+",note.type,false);
            }
            this.DataView.Location = new Point(100, 100);
            this.DataView.Size = new Size(1200, 400);
            this.Controls.Add(this.DataView);
        }

        private void instock(object sender, EventArgs e)
        {
            this.Controls.Remove(this.DataView);
            ViewCreate(DataStorage.GetInStockList());
            status = Status.InStock;
            this.Action.Text = "Списать";
        }
        private void waiting(object sender, EventArgs e)
        {
            this.Controls.Remove(this.DataView);
            ViewCreate(DataStorage.GetWaitingList());
            status = Status.Waiting;
            this.Action.Text = "Принять";
        }
        private void order(object sender, EventArgs e)
        {
            this.Controls.Remove(this.DataView);
            ViewCreate(DataStorage.GetOrderList());
            status = Status.Order;
            this.Action.Text = "Заказать";
        }

        private void add(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm();
            if (addForm.ShowDialog(this) == DialogResult.OK)
            {
                EquipmentNote a = new EquipmentNote();
                a.name = addForm.namebox.Text;
                a.producer = addForm.providerbox.Text;
                a.count = Convert.ToInt32(addForm.countbox.Text);
                a.type = addForm.typebox.Text;
                if (this.status == Status.Order)
                {
                    this.Controls.Remove(this.DataView);
                   DataStorage.GetOrderList().GetList().Add(a);
                   ViewCreate(DataStorage.GetOrderList());
                }

                if (this.status == Status.Waiting)
                {
                    this.Controls.Remove(this.DataView);
                    DataStorage.GetWaitingList().GetList().Add(a);
                    ViewCreate(DataStorage.GetWaitingList());
                }

                if (this.status == Status.InStock)
                {
                    this.Controls.Remove(this.DataView);
                    DataStorage.GetInStockList().GetList().Add(a);
                    ViewCreate(DataStorage.GetInStockList());
                }
            }
            else
            {
                
            }

            addForm.Dispose();
        }

        private void action(object sender, EventArgs e)
        {
            int r ;
            bool flag;
            List<EquipmentNote> a = new List<EquipmentNote>();
            Object k = new Object();
            List<EquipmentNote> c =DataStorage.GetOrderList().GetList();
            List<EquipmentNote> w =DataStorage.GetWaitingList().GetList();
            List<EquipmentNote> d =DataStorage.GetInStockList().GetList();
            EquipmentNote b = new EquipmentNote();
            k = DataView.Rows;
            for (int rows = 0; rows < DataView.Rows.Count-1; rows++)
            {
                if (DataView.Rows[rows].Cells[6].Value.ToString() == "True")
                {
                    b.name = DataView.Rows[rows].Cells[0].Value.ToString();
                    b.producer = DataView.Rows[rows].Cells[1].Value.ToString();
                    b.count =Convert.ToInt32(DataView.Rows[rows].Cells[3].Value);
                    b.type=DataView.Rows[rows].Cells[5].Value.ToString();
                    a.Add(b);
                    b = new EquipmentNote();
                }
            }
            this.Controls.Remove(this.DataView);
            if (this.status == Status.Order)
            {
                for (int j=0;j<a.Count;j++)
                {
                    flag = false;
                    for (int i = 0; i < c.Count ; i++)
                    {
                        if (c[i].name == a[j].name && c[i].producer == a[j].producer)
                        {
                            c.Remove(c[i]);
                            break;
                        }
                    }
                    for (int i = 0; i < w.Count; i++)
                    {
                        if (w[i].name == a[j].name && w[i].producer == a[j].producer)
                        {
                            var element = w[i].count;
                            element += a[j].count;
                            flag = true;
                            break;
                        }
                    }
                    if(!flag)
                    {
                        w.Add(a[j]);
                    }
                }
                DataStorage.GetOrderList().SetList(c);
                DataStorage.GetWaitingList().SetList(w);
                ViewCreate(DataStorage.GetOrderList());
            }

            else if (this.status == Status.Waiting)
            {
                for (int j=0;j<a.Count;j++)
                {
                    flag = false;
                    for (int i = 0; i < w.Count ; i++)
                    {
                        if (w[i].name == a[j].name && w[i].producer == a[j].producer)
                        {
                            w.Remove(w[i]);
                            break;
                        }
                    }
                    for (int i = 0; i < d.Count; i++)
                    {
                        if (d[i].name == a[j].name && d[i].producer == a[j].producer)
                        {
                            var element = d[i].count;
                            element += a[j].count;
                            flag = true;
                            break;
                        }
                    }
                    if(!flag)
                    {
                        d.Add(a[j]);
                        break;
                    }
                }
                DataStorage.GetInStockList().SetList(d);
                DataStorage.GetWaitingList().SetList(w);
                ViewCreate(DataStorage.GetWaitingList());
            }

            else if (this.status == Status.InStock)
            {
                this.Controls.Remove(this.DataView);
                for (int j = 0; j < a.Count; j++)
                {
                    for (int i = 0; i < d.Count; i++)
                    {
                        if (d[i].name == a[j].name && d[i].producer == a[j].producer)
                        {
                            d.Remove(d[i]);
                            break;
                        }
                    }
                }
                DataStorage.GetInStockList().SetList(d);
                ViewCreate(DataStorage.GetInStockList());
            }
        }

        private void save(object sender, EventArgs e)
        {
            String connectionString="server=127.0.0.1;port=3306;database=database;user=root;password=SlimShady45";
            MySqlConnection con = new MySqlConnection(connectionString);
            
            
            con.Open();
            string oSelect = "TRUNCATE TABLE orders";
            string wSelect = "TRUNCATE TABLE wait";
            string iSelect = "TRUNCATE TABLE instock";
            MySqlCommand oordersql = new MySqlCommand(oSelect,con);
            oordersql.ExecuteNonQuery();
            MySqlCommand command ;
            MySqlCommand wordersql = new MySqlCommand(wSelect,con);
            wordersql.ExecuteNonQuery();
            MySqlCommand iordersql = new MySqlCommand(iSelect,con);
            iordersql.ExecuteNonQuery();
            List<EquipmentNote> c =DataStorage.GetOrderList().GetList();
            List<EquipmentNote> w =DataStorage.GetWaitingList().GetList();
            List<EquipmentNote> d =DataStorage.GetInStockList().GetList();
            foreach (var i in c)
            {
                oSelect = "Insert into orders (productName,provider,count,type) VALUES (@a,@b,@c,@d)";
                command = new MySqlCommand(oSelect,con);
                command.Parameters.AddWithValue("@a",i.name );
                command.Parameters.AddWithValue("@b", i.producer);
                command.Parameters.AddWithValue("@c", i.count);
                command.Parameters.AddWithValue("@d", i.type);
                command.ExecuteNonQuery();

            }
            
            foreach (var i in w)
            {
                oSelect = "Insert into wait (productName,provider,count,type) VALUES (@a,@b,@c,@d)";
                command = new MySqlCommand(oSelect,con);
                command.Parameters.AddWithValue("@a",i.name );
                command.Parameters.AddWithValue("@b", i.producer);
                command.Parameters.AddWithValue("@c", i.count);
                command.Parameters.AddWithValue("@d", i.type);
                command.ExecuteNonQuery();

            }
            
            foreach (var i in d)
            {
                oSelect = "Insert into instock (productName,provider,count,type) VALUES (@a,@b,@c,@d)";
                command = new MySqlCommand(oSelect,con);
                command.Parameters.AddWithValue("@a",i.name );
                command.Parameters.AddWithValue("@b", i.producer);
                command.Parameters.AddWithValue("@c", i.count);
                command.Parameters.AddWithValue("@d", i.type);
                command.ExecuteNonQuery();

            }
            con.Close();

        }
        

        #endregion
    }
}