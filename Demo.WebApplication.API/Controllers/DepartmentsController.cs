using Demo.WebApplication.API.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Demo.WebApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        //tạo 1 list phòng ban fake data
        public static List<Department> departments = new List<Department>
        {
            new Department { 
                DepartmentId = new Guid("123e4567-e89b-12d3-a456-426655440000"),
                DepartmentCode = "BP-6507",
                DepartmentName = "Phòng đào tạo",
                Description = "",
                IsParent = true,
                ParentID = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CreatedBy = "Trần Xuân Duy",
                ModifiedDate = DateTime.Now,
                ModifiedBy = "Trần Xuân Duy" },
            new Department { 
                DepartmentId = Guid.NewGuid(),
                DepartmentCode = "BP-0908",
                DepartmentName = "Phòng hành chính",
                Description = "",
                IsParent = false,
                ParentID = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CreatedBy = "Trần Duy",
                ModifiedDate = DateTime.Now,
                ModifiedBy = "Trần Duy" },
            new Department { DepartmentId = Guid.NewGuid(),
                DepartmentCode = "BP-1207",
                DepartmentName = "Phòng đào tạo",
                Description = "",
                IsParent = true,
                ParentID = Guid.NewGuid(),
                CreatedDate = DateTime.Now,
                CreatedBy = "Trần Xuân Duy",
                ModifiedDate = DateTime.Now,
                ModifiedBy = "Trần Xuân Duy" }
        };

        /// <summary>
        /// API lấy thông tin 1 phòng ban
        /// </summary>
        /// <param name="departmentId">Id phòng ban muốn lấy</param>
        /// <returns>1 đối tượng phòng ban</returns>
        /// created by: Trần Xuân Duy (9/3/2023)
        [HttpGet("{departmentId}")]
        public IActionResult GetDepartmentById([FromRoute]Guid departmentId)
        {
            Department dep = departments.FirstOrDefault(a => a.DepartmentId == departmentId);
            if (dep == null)
            {
                return NotFound(); // trả về mã trạng thái 404 Not Found nếu không tìm thấy phòng ban
            }
            return StatusCode(201, dep);
        }


        /// <summary>
        /// API thêm mới phòng ban (bộ phận)
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        /// Created By: Trần Xuân Duy (9/3/2023)
        [HttpPost]
        public IActionResult InsertDepartment([FromBody] Department department)
        {
            departments.Add(department);
            return StatusCode(201);

            //return StatusCode(400, new
            //{
            //    Code = 1,
            //    Message = "Trùng mã phòng ban"
            //});
        }

        /// <summary>
        /// API sửa thông tin 1 phòng ban (bộ phận)
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        /// Created By: Trần Xuân Duy (9/3/2023)
        [HttpPut]
        public IActionResult UpdateDepartment([FromBody] Department department)
        {

            return StatusCode(201);

            //return StatusCode(400, new
            //{
            //    Code = 1,
            //    Message = "Trùng mã phòng ban"
            //});
        }

        /// <summary>
        /// API xóa 1 phòng ban (bộ phận)
        /// </summary>
        /// <param name="department"></param>
        /// <returns></returns>
        /// Created By: Trần Xuân Duy (9/3/2023)
        [HttpDelete]
        public IActionResult DeleteDepartment([FromBody] Guid departmentId)
        {

            // tìm phòng ban theo departmentId
            Department department = departments.FirstOrDefault(d => d.DepartmentId == departmentId);
            if (department == null)
            {
                return NotFound(); // trả về mã trạng thái 404 Not Found nếu không tìm thấy phòng ban
            }

            departments.Remove(department); // xóa phòng ban

            return StatusCode(201);
        }
    }

    
}
