using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Resturant.Model
{
    public partial class Add_Porduct_Details : SampleAdd
    {
        public Add_Porduct_Details()
        {
            InitializeComponent();
            GetCategoryName();
        }
        private int id = -1;
        public Add_Porduct_Details(int id)
        {
            InitializeComponent();
            this.id = id;
            GetCategoryName();
            Get_Data();
        }
        void GetCategoryName() {
            string qry = "select itcategory from Items ";
            try
            {
            DataBase.conn.Open();
                SqlDataReader reader = new SqlCommand(qry, DataBase.conn).ExecuteReader();
                while (reader.Read())
                {
                    
                    Cb_CategoriesName.Items.Add(reader["itcategory"].ToString());
            
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { DataBase.conn.Close(); }
        }
        private void Get_Data()
        {
            string qry = "select *from Items where itid=@id";
            DataBase.conn.Open();
            try
            {
                SqlDataReader reader = new SqlCommand(qry, DataBase.conn) { Parameters = { new SqlParameter("@id", id) } }.ExecuteReader();
                if (reader.Read())
                {
                    Txt_NameProduct.Text = reader["itname"].ToString();
                    Txt_PriceProduct.Text = reader["itprice"].ToString();
                    Cb_CategoriesName.Text = reader["itcategory"].ToString();
                   Pb_PictureProduct.Image= Image.FromStream(new MemoryStream((byte[])reader["itimage"]));
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { DataBase.conn.Close(); }


        }
        private byte[] ImageInfo(Image im)
        {
            byte[] image ;
            using (MemoryStream ms = new MemoryStream())
            {
                ImageFormat imformat = im.RawFormat??ImageFormat.Png;
                im.Save(ms,imformat);
                image = ms.ToArray();
            }
            return image;
        }
        private void resete()
        {
            Txt_NameProduct.Text = string.Empty;
            Txt_PriceProduct.Text = string.Empty;
            Cb_CategoriesName.Text = string.Empty;
            Pb_PictureProduct.Image =default;
            Txt_NameProduct.Focus();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string qry;
            if (id != -1) qry = $"update items set itname='{Txt_NameProduct.Text}'itprice='{Txt_PriceProduct.Text}',itcategory='{Cb_CategoriesName.SelectedItem.ToString()}',itimage={ImageInfo(Pb_PictureProduct.Image)} " +
                    $" where itid={id}";//can use if(!(~id)) same work 
            else
            {
            string hexString = "0x" + BitConverter.ToString(ImageInfo(Pb_PictureProduct.Image)).Replace("-", "");
                qry = $"insert into items values ('{Txt_NameProduct.Text}','{Cb_CategoriesName.SelectedItem.ToString()}','{Txt_PriceProduct.Text}',{hexString}) ";
            }       
            DataBase.UpdateData(qry);
           if(id==-1) resete();
           else this.Close();
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set filter options
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                openFileDialog.Title = "Select an Image File";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedImagePath = openFileDialog.FileName;
                    Pb_PictureProduct.Image = Image.FromFile(selectedImagePath);
                }
            }
        }
    }
}
