using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFM104MVC.Models;
using TFM104MVC.Models.Entity;
using TFM104MVC.ResouceParameters;

namespace TFM104MVC.Services
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync(string keyword,string operatorType,int ratingValue,string Region,string Traveldays , string Triptype,int pageSize,int pageNumber,string OrderBy,string OrderByDesc,string goTouristTime);//取得所有商品
        Task<Product> GetProductWithNoPicturesAsync(Guid ProductId);
        Task<Product> GetProductAsync(Guid ProductId);//取得單一商品(使用者輸入商品ID)

        Task<bool> ProductExistAsync(Guid ProductId);
        Task<IEnumerable<ProductPicture>> GetPicturesByProductIdAsync(Guid productId); //主要是透過商品 一起撈出它的子資源圖片
                                                                                   //所以用父資源的Id去判斷(在子資源裡 會有多個父資源Id)
        Task<ProductPicture> GetPictureAsync(int pictureId);

        void AddProduct(Product product);

        Task<bool> SaveAsync();

        void AddProductPicture(Guid productId, ProductPicture productPicture);
        void DeleteProduct(Product product);
        void DeleteProductPicture(ProductPicture productPicture);

        Task AddOrder(Order order);
        Task<IEnumerable<Order>> GetOrders(int userId);
        Task<Orderdetail> GetOrderdetailByProductIdAndOrderId(Guid productId,int orderId);

        string GetProductTitle(Guid id);
        Task<List<Product>> GetProductsByIds(Guid[] productId);

        Task<IEnumerable<Order>> GetAllOrders(); //管理者 廠商 取得所有客戶的訂單
        Task<Order> GetOrderById(int orderId);
        Task<List<Orderdetail>> GetOrderdetailTotalPrice(int orderId);
    }
}
