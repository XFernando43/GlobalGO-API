using data.repository;
using data.repository.interfaces;
using GlobalGO.models;
using models.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class MotorcycleService
    {
        private readonly IUnitOfWork _uniOfWork;
        public MotorcycleService(IUnitOfWork uniOfWork)
        {
            _uniOfWork = uniOfWork;
        }
        public async Task<IEnumerable<Motorcycle>> getMotorcycles()
        {
            try
            {
                var motorcycles = await _uniOfWork.motorcycleRepository.GetMotorcycles();
                return motorcycles;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
