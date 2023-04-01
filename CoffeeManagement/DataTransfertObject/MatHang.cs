
namespace CoffeeManagement
{
    public class MatHang
    {
       
        
       
        public string ID { get; set; }
        public string TenMatHang { get; set; }
        public string DonViTinh { get; set; }
        public int Gia { get; set; }

        public MatHang(string ID, string tenMH, string DVT, int gia)
        {
            this.ID = ID;
            this.TenMatHang = tenMH;
            this.DonViTinh = DVT;
            this.Gia = gia;
        }
        public MatHang()
        {

        }
    }

    public class MatHangChiTiet
    {
        public string ID { get; set; }
        public string TenMatHang { get; set; }
        public string DonViTinh { get; set; }
        public string LoaiMatHang { get; set; }
        public int Gia { get; set; }
      
    }
}
