namespace Demo.WebApplication.API.Entites
{
    public class AssetCategory
    {
        //ID loại tài sản
        public Guid AssetCategoryId { get; set; }

        //Mã loại tài sản
        public string AssetCategoryCode { get; set; }

        //Tên loại tài sản
        public string AssetCategoryName { get; set;}

        //Tỉ lệ hao mòn
        public float DepreciationRate { get; set;}

        //Số năm sử dụng
        public int LifeTime { get; set;}

        //Mô tả
        public string Description { get;set;}

        public string CreatedBy { get; set;}

        public DateTime CreatedDate { get; set;}

        public string ModifiedBy { get; set;}

        public DateTime ModifiedDate { get; set;}

    }
}
