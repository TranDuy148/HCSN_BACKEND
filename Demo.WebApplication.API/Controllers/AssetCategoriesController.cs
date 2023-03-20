using Demo.WebApplication.API.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetCategoriesController : ControllerBase
    {
        //tạo 1 list phòng ban fake data
        public static List<AssetCategory> assetCategories = new List<AssetCategory>
        {
            new AssetCategory
            {
                AssetCategoryId = new Guid("123e4567-e89b-12d3-a456-426655440000"),
                AssetCategoryCode = "LT-1957",
                AssetCategoryName = "Máy tính xách tay",
                DepreciationRate = 10.5f,
                LifeTime = 20,
                Description = "",
                CreatedDate = DateTime.Now,
                CreatedBy = "Trần Xuân Duy",
                ModifiedDate = DateTime.Now,
                ModifiedBy = "Trần Xuân Duy"
            },
            new AssetCategory
            {
                AssetCategoryId = new Guid("123e4567-e89b-12d3-a456-426655440003"),
                AssetCategoryCode = "LT-6357",
                AssetCategoryName = "Bàn làm việc",
                DepreciationRate = 10.5f,
                LifeTime = 20,
                Description = "",
                CreatedDate = DateTime.Now,
                CreatedBy = "Trần Xuân Duy",
                ModifiedDate = DateTime.Now,
                ModifiedBy = "Trần Xuân Duy"
            }
        };

        /// <summary>
        /// API lấy thông tin 1 loại tài sản
        /// </summary>
        /// <param name="assetCategoryId">Id loại tài sản muốn lấy</param>
        /// <returns>1 đối tượng tài sản</returns>
        /// created by: Trần Xuân Duy (9/3/2023)
        [HttpGet("{assetCategoryId}")]
        public IActionResult GetAssetCategoryById([FromRoute] Guid assetCategoryId)
        {
            AssetCategory aC = assetCategories.FirstOrDefault(d => d.AssetCategoryId == assetCategoryId);
            if (aC == null)
            {
                return NotFound(); // trả về mã trạng thái 404 Not Found nếu không tìm thấy phòng ban
            }
            return StatusCode(201, aC);

        }

        /// <summary>
        /// API thêm mới loại tài sản
        /// </summary>
        /// <param name="assetCategory"></param>
        /// <returns>StatusCode(201)</returns>
        /// Created By: Trần Xuân Duy (9/3/2023)
        [HttpPost]
        public IActionResult InsertAssetCategory([FromBody] AssetCategory assetCategory)
        {
            assetCategories.Add(assetCategory);
            return StatusCode(201);

            //return StatusCode(400, new
            //{
            //    Code = 1,
            //    Message = "Trùng mã"
            //});
        }

        /// <summary>
        /// API sửa loại tài sản
        /// </summary>
        /// <param name="assetCategory"></param>
        /// <returns>StatusCode(201)</returns>
        /// Created By: Trần Xuân Duy (9/3/2023)
        [HttpPut]
        public IActionResult UpdateAssetCategory([FromBody] AssetCategory assetCategory)
        {
            for (int i = 0; i < assetCategories.Count; i++)
            {
                if (assetCategories[i].AssetCategoryId == assetCategory.AssetCategoryId)
                {
                    assetCategories[i] = assetCategory;
                    return StatusCode(201);
                }
            }
            return StatusCode(400);

            //return StatusCode(400, new
            //{
            //    Code = 1,
            //    Message = "Trùng mã ..."
            //});
        }

        /// <summary>
        /// API xóa loại tài sản
        /// </summary>
        /// <param name="assetCategoryId"></param>
        /// <returns>StatusCode(201)</returns>
        /// Created By: Trần Xuân Duy (9/3/2023)
        [HttpDelete]
        public IActionResult DeleteAssetCategory([FromBody] Guid assetCategoryId)
        {
            AssetCategory aC = assetCategories.FirstOrDefault(d => d.AssetCategoryId == assetCategoryId);
            if (aC == null)
            {
                return NotFound(); // trả về mã trạng thái 404 Not Found nếu không tìm thấy phòng ban
            }
            assetCategories.Remove(aC);
            return StatusCode(201);

            //return StatusCode(400, new
            //{
            //    Code = 1,
            //    Message = "Trùng mã ..."
            //});
        }
    }
}

