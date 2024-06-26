using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository.interfaces
{
    public interface IUnitOfWork
    {
        ICategoryRepository categoryRepository { get; set; }
        IBrandRepository brandRepository { get; set; }
        //IProductRepository productRepository { get; set; }
        //IUserRepository userRepository { get; set; }
        //IAuthorizationRepository authorizationRepository { get; set; }
        //IRolRepository rolRepository { get; set; }
        //IItemCartRepository itemCartRepository { get; set; }
        //IShoppingCartRepository shoppingCartRepository { get; set; }
        void Save();
    }
}
