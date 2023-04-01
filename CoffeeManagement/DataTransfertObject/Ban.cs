

namespace CoffeeManagement
{
    public class Ban
    {
        public string ID { get; set; }
        public string TenBan { get; set; }
        public int TinhTrang { get; set; } // 0: ban trong, 1: ban da duoc dat.

  

        public Ban(string ID, string TenBan, int TinhTrang)
        {
            this.ID = ID;
            this.TenBan = TenBan;
            this.TinhTrang = TinhTrang;
        }
    }   
}
