using data.repository.interfaces;
using GlobalGO.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public class SpecificationsService
    {
        private readonly IUnitOfWork _unitOfWork;
        public SpecificationsService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Especificaciones>> getSpecifications()
        {
            try
            {
                var specifications = await _unitOfWork.specificationRepository.getSpecifications();
                return specifications;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
