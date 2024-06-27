using GlobalGO.models;
using models.request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.repository.interfaces
{
    public interface ICarouselRepository: IRepository<Carruseles>
    {
        void addCarrousel();
        void Update(int id);
        void Save();
        //List<Carruseles> getCarousels();
        Task<IEnumerable<Carruseles>> GetCarruseles();
        void deleteCarousel(int id);
    }
}
