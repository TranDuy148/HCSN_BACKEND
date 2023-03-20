namespace Demo.WebApplication.API.Entites
{
    /// <summary>
    /// Thông tin phòng ban
    /// </summary>
    public class Department
    {
        //ID phòng ban
        public Guid DepartmentId { get; set; }

        //Mã phòng ban
        public string DepartmentCode { get; set; }

        //Tên phòng ban
        public string DepartmentName { get; set; }

        //Mô tả
        public string Description { get; set; }

        //Có phải cha không
        public bool IsParent { get; set; }

        //ID của cha
        public Guid ParentID { get; set; }

        //Tạo bởi
        public string CreatedBy { get; set; }

        //Ngày tạo
        public DateTime CreatedDate { get; set; }

        public string ModifiedBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        
    }
    
}
