namespace Demo.WebApplication.API.Entites
{
    public class Asset
    {
        //ID tài sản
        public Guid AssetId { get; set; }

        //mã tài sản
        public string AssetCode { get; set; }

        //Tên tài sản
        public string AssetName { get; set; }

        //ID bộ phận sử dụng
        public Guid DepartmentID { get; set; }

        //Mã bộ phận sử dụng
        public string DepartmentCode { get; set; }

        //Tên bộ phận sử dụng
        public string DepartmentName { get; set; }

        //ID loại tài sản
        public Guid AssetCategoryID { get; set; }

        //Mã loại tài sản
        public string AssetCategoryCode { get; set; }

        //Tên loại tài sản
        public string AssetCategoryName { get; set; }

        //Ngày mua
        public DateTime PurchaseDate { get; set; }

        //Nguyên giá
        public decimal Cost { get; set; }

        //Số lượng
        public int Quantity { get; set; }

        //Tỉ lệ hao mòn
        public float DepreciationRate { get; set; }

        //Năm bắt đầu theo dõi tài sản
        public int TrackedYear { get; set; }

        //Số năm sử dụng
        public int LifeTime { get; set; }

        //Năm sử dụng
        public int ProductionYear { get; set; }

        //Trạng thái
        public bool Active { get; set; }

        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }
    }
}
