using System.Data.SqlClient;

namespace Resim_Görüntüleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {

            // parametre değerini textbox içerisinden alacağız


            int productId = Convert.ToInt32(txtId.Text);

            SqlConnection con = new SqlConnection("data source=.;initial catalog=AdventureWorks2019;integrated security=true");
            SqlCommand cmd = new SqlCommand(@"select pp.LargePhoto from Production.ProductPhoto pp 
            inner join Production.ProductProductPhoto ppp
            on ppp.ProductPhotoId = pp.ProductPhotoId
            inner join Production.Product p
            on p.ProductId=ppp.ProductId where p.ProductId=@id", con);
            cmd.Parameters.AddWithValue("@id", productId);

            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                byte[] selectedPicture = (byte[])dr["LargePhoto"];



                // byte array image çevrimi

            }
            dr.Close();
            con.Close();



        }
    }
}