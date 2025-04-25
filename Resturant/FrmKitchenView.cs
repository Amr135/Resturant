using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant
{
    public partial class FrmKitchenView: Form
    {
      private  FlowLayoutPanel BigF;
        public FrmKitchenView()
        {
            InitializeComponent();
        BigF = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                Size = this.Size,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right
            };
            Get_Data();
        }
      Dictionary <string,int>_NamesProducts= new Dictionary<string,int>();
       
        private Dictionary<string,int> Get_Names_Products(int First, string table,int stop_from_end)
        {
            try
            {
                DataBase.conn.Open();
                SqlDataReader ColName = new SqlCommand("Select  top 1 * from " + table, DataBase.conn).ExecuteReader();
                Dictionary<string, int> H = new Dictionary<string, int>();

                while (H.Count < ColName.FieldCount - 1 - stop_from_end)
                {
                    H[ColName.GetName(First++)] = 0;
                }
                ColName.Close();
                DataBase.conn.Close();
            return H;
            }
            catch(Exception e) { MessageBox.Show("Erorr:" + e.Message); return null; }
        }
        private FlowLayoutPanel Show_Order(ref Dictionary<string, int>  List,string Tnumber,string OrderType) {
                 FlowLayoutPanel F=new FlowLayoutPanel();
            F.FlowDirection = FlowDirection.TopDown;    
            F.AutoSize = true;
            F.Width = 250;
            F.Height = 350;
            F.BorderStyle = BorderStyle.FixedSingle;
            F.BackColor = Color.Teal;
            F.Margin =new Padding( 10,10,10,10);
            if (Tnumber != "" && Tnumber != null) F.Controls.Add(new Label { AutoSize = true, Text = "Table :" + Tnumber, ForeColor = Color.White });
            F.Controls.Add(new Label { AutoSize = true, Text = "OrderType :" + OrderType, ForeColor = Color.White });
            foreach ( KeyValuePair<string,int>  P in  List)
            {
                if(P.Value != 0)
                {
                    F.Controls.Add(new Label {AutoSize=true,Text = P.Key + ": " + P.Value,ForeColor=Color.White });
                    List[P.Key]= 0;
                }

            }

            return F;
        }
        void Get_Data()
        {
            var List = Get_Names_Products(0, "OrderDetails", 1);
            BigF.Controls.Clear();
            FlowLayoutPanel F;
            try
            {
                DataBase.conn.Open();
                SqlDataReader Reader = new SqlCommand("Select* from OrderDetails where state=1", DataBase.conn).ExecuteReader();
              while (Reader.Read())
                {
                 
                    foreach (KeyValuePair<string,int> P in List)
                    {
                       if(P.Key.ToLower()!="tnumber"&&P.Key.ToLower()!="ordertype")
                            List[P.Key] = (int)Reader[P.Key.ToString()];
                    }
                    F = Show_Order(ref List, Reader["Tnumber"].ToString(), Reader["OrderType"].ToString());
                    F.Controls.Add(Btn_Complete(Reader["idOrder"].ToString(),Convert.ToInt32( Reader["Price"])));

                    BigF.Controls.Add(F);

                }

                    this.Controls.Add(BigF);
            }
           
            catch(Exception e)
            {
                 MessageBox.Show("Erorr:" + e.Message); 
            }
            DataBase.conn.Close();

        }
        Guna2Button Btn_Complete(string id,int price)
        {
            
            Guna2Button button = new Guna2Button();
            button.Text = "Complete";
            button.Tag = id;
            button.AutoRoundedCorners = true;
            button.Click +=(s,e)=> Click_Complete_Order(s,e,price);
            return button;
        }
        bool Send_To_DataBase(int id, int price)
        {
            try
            {
                string qry = "Insert into  Bills_Details Values (@id,@price,@state)";
                SqlCommand command1 = new SqlCommand(qry, DataBase.conn);
                
                command1.Parameters.AddWithValue("@id", id);
                command1.Parameters.AddWithValue("@price", price);
                command1.Parameters.AddWithValue("@state", 0);
                command1.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); return false; }
          
        }
        void Click_Complete_Order(object s,EventArgs e,int Price)
        {
            if (s is Guna2Button button ) { string qry = "update OrderDetails set state=0 where idorder=@Tag";
                try
                {
                    DataBase.conn.Open();
                    SqlCommand command = new SqlCommand(qry, DataBase.conn);

                    if (!Send_To_DataBase(Convert.ToInt32(button.Tag), Price)) MessageBox.Show("Failed");

                    else
                    {
                        command.Parameters.AddWithValue("@Tag", button.Tag);
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); DataBase.conn.Close(); }
                finally
                {
                    DataBase.conn.Close();
                    Get_Data();
                }
            }
        }
      
        private void FrmKitchenView_Load(object sender,EventArgs e)
        {


        }
    }
}
