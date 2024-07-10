using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository.interfaces
{
    public interface IUnitOfWork
    {
        IBrandRepository brandRepository { get; set; }
        ICarouselRepository carouselRepository { get; set; }
        ICategoryRepository categoryRepository { get; set; }
        IColorsRepository colorsRepository { get; set; }
        IDealersRepository dealersRepository { get; set; }
        IGaleryRepository galeryRepository { get; set; }
        IModelRepository modelRepository { get; set; }
        IPriceRepository priceRepository { get; set; }
        ISpecificationRepository specificationRepository { get; set; }
        IDealersXModelRepository dealersXModelRepository { get; set; }
        IMotorcycleRepository motorcycleRepository { get; set; }
        void Save();
    }
}
