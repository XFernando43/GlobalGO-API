using data.repository.interfaces;
using GlobalGO.data;
using GlobalGO.models;


namespace data.repository
{
    public class UnitOfWork: IUnitOfWork
    {
        ApplicationDbContext _db;
        //public ICategoryRepository categoryRepository { get; set; }
        public ICategoryRepository categoryRepository {get;set;}
        public IBrandRepository brandRepository {get;set;}
        public IDealersRepository dealersRepository { get; set; }
        public IModelRepository modelRepository { get; set; }
        public ICarouselRepository carouselRepository {get; set; }
        public IColorsRepository colorsRepository {get; set; }
        public IPriceRepository priceRepository {get; set; }
        public ISpecificationRepository specificationRepository {get; set; }
        public IGaleryRepository galeryRepository { get; set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            categoryRepository = new CategoryRepository(_db);
            brandRepository = new BrandRepository(_db);
            dealersRepository = new DealerRepository(_db);
            modelRepository = new ModelsRepository(_db);
            carouselRepository = new CarouselRepository(_db);
            colorsRepository = new ColorRepository(_db);
            priceRepository = new PriceRepository(_db);
            specificationRepository = new SpecificationRepository(_db);
            galeryRepository = new GaleryRepository(_db);
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
