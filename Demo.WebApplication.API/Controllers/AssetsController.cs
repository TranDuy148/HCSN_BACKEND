using Demo.WebApplication.API.Entites;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System;

namespace Demo.WebApplication.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetsController : ControllerBase
    {
        //fake 1 list assets:
        public static List<Asset> assets = new List<Asset>
        {
            new Asset
            {
                AssetId = new Guid("123e4567-e89b-12d3-a456-426655440000"),
                AssetCode = "BP-1207",
                AssetName = "Phòng đào tạo",
                DepartmentID = Guid.NewGuid(),
                DepartmentCode = "BP-2123",
                DepartmentName = "Phòng hành chính",
                AssetCategoryID = Guid.NewGuid(),
                AssetCategoryCode = "LT-2532",
                AssetCategoryName = "Máy tính xách tay",
                PurchaseDate = DateTime.Now,
                Cost = 20000000,
                Quantity = 123,
                DepreciationRate = 10.5f,
                TrackedYear = 2020,
                LifeTime = 20,
                ProductionYear = 2020,
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "Trần Xuân Duy",
                ModifiedDate = DateTime.Now,
                ModifiedBy = "Trần Xuân Duy"
            },
            new Asset
            {
                AssetId = new Guid("123e4567-e89b-12d3-a456-426655440001"),
                AssetCode = "BP-1324",
                AssetName = "Phòng hành chính",
                DepartmentID = Guid.NewGuid(),
                DepartmentCode = "BP-2123",
                DepartmentName = "Phòng hành chính",
                AssetCategoryID = Guid.NewGuid(),
                AssetCategoryCode = "LT-2532",
                AssetCategoryName = "Máy tính bàn",
                PurchaseDate = DateTime.Now,
                Cost = 20000000,
                Quantity = 123,
                DepreciationRate = 10.5f,
                TrackedYear = 2020,
                LifeTime = 20,
                ProductionYear = 2020,
                Active = true,
                CreatedDate = DateTime.Now,
                CreatedBy = "Trần Xuân Duy",
                ModifiedDate = DateTime.Now,
                ModifiedBy = "Trần Xuân Duy"
            }
        };

        /// <summary>
        /// API lấy thông tin 1 tài sản
        /// </summary>
        /// <param name="assetId">Id tài sản muốn lấy</param>
        /// <returns>1 đối tượng tài sản</returns>
        /// created by: Trần Xuân Duy (9/3/2023)
        [HttpGet("{assetId}")]
        public IActionResult GetAssetById([FromRoute] Guid assetId)
        {
            Asset asset = assets.FirstOrDefault(a => a.AssetId == assetId);
            if (asset == null)
            {
                return NotFound(); // trả về mã trạng thái 404 Not Found nếu không tìm thấy phòng ban
            }
            return StatusCode(201, asset);
        }

        /// <summary>
        /// API phân trang tài sản--------------------not yet
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="departmentId"></param>
        /// <param name="assetCategoryId"></param>
        /// <param name="pageSite"></param>
        /// <param name="pageNumber"></param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult GetPaging(
            [FromQuery] string? keyword,
            [FromQuery] Guid? departmentId,
            [FromQuery] Guid? assetCategoryId,
            [FromQuery] int pageSite = 10,
            [FromQuery] int pageNumber = 1
            )
        {
            return StatusCode(200, new
            {
                Data = new List<Asset>()
                {
                new Asset
                    {
                        AssetId = Guid.NewGuid(),
                        AssetCode = "BP-1207",
                        AssetName = "Asus TUF Gaming",
                        DepartmentID = Guid.NewGuid(),
                        DepartmentCode = "BP-2123",
                        DepartmentName = "Phòng hành chính",
                        AssetCategoryID = Guid.NewGuid(),
                        AssetCategoryCode = "LT-2532",
                        AssetCategoryName = "Máy tính xách tay",
                        PurchaseDate = DateTime.Now,
                        Cost = 20000000,
                        Quantity = 123,
                        DepreciationRate = 10.5f,
                        TrackedYear = 2020,
                        LifeTime = 20,
                        ProductionYear = 2020,
                        Active = true,
                        CreatedDate = DateTime.Now,
                        CreatedBy = "Trần Xuân Duy",
                        ModifiedDate = DateTime.Now,
                        ModifiedBy = "Trần Xuân Duy"
                    },
                    new Asset
                    {
                        AssetId = Guid.NewGuid(),
                        AssetCode = "BP-1100",
                        AssetName = "Macbook 2022 pro",
                        DepartmentID = Guid.NewGuid(),
                        DepartmentCode = "BP-3123",
                        DepartmentName = "Phòng đào tạo",
                        AssetCategoryID = Guid.NewGuid(),
                        AssetCategoryCode = "LT-2532",
                        AssetCategoryName = "Máy tính xách tay",
                        PurchaseDate = DateTime.Now,
                        Cost = 40000000,
                        Quantity = 53,
                        DepreciationRate = 7.5f,
                        TrackedYear = 2020,
                        LifeTime = 30,
                        ProductionYear = 2020,
                        Active = true,
                        CreatedDate = DateTime.Now,
                        CreatedBy = "Trần Xuân Duy",
                        ModifiedDate = DateTime.Now,
                        ModifiedBy = "Trần Xuân Duy"
                    }
                }
            }

            );
        }

        /// <summary>
        /// API thêm mới tài sản
        /// </summary>
        /// <param name="asset"></param>
        /// <returns>StatusCode(201)</returns>
        /// Created By: Trần Xuân Duy (9/3/2023)
        [HttpPost]
        public IActionResult InsertAsset([FromBody] Asset asset)
        {
            assets.Add(asset);
            return StatusCode(201);

            //return StatusCode(400, new
            //{
            //    Code = 1,
            //    Message = "Trùng mã tài sản"
            //});
        }

        /// <summary>
        /// API sửa tài sản
        /// </summary>
        /// <param name="asset"></param>
        /// <returns>StatusCode(201)</returns>
        /// Created By: Trần Xuân Duy (9/3/2023)
        [HttpPut]
        public IActionResult UpdateAsset([FromBody] Asset asset)
        {
            for(int i=0; i< assets.Count; i++)
            {
                if (assets[i].AssetId == asset.AssetId)
                {
                    assets[i] = asset;
                    return StatusCode(201);
                }
            }

            return StatusCode(400, new
            {
                Code = 1,
                Message = "Trùng mã ..."
            });
        }

        /// <summary>
        /// API xóa tài sản
        /// </summary>
        /// <param name="asset"></param>
        /// <returns>StatusCode(201)</returns>
        /// Created By: Trần Xuân Duy (9/3/2023)
        [HttpDelete]
        public IActionResult DeleteAsset([FromBody] Guid assetId)
        {
            // tìm tài sản theo Id
            Asset asset = assets.FirstOrDefault(d => d.AssetId == assetId);
            if (asset == null)
            {
                return NotFound(); // trả về mã trạng thái 404 Not Found nếu không tìm thấy phòng ban
            }

            assets.Remove(asset); // xóa phòng ban

            return StatusCode(201);
        }
    }
}
