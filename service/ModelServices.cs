using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Http.HttpResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace service
{
    public partial class ModelServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModelServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Modelos>> getAll()
        {
            try
            {
                List<Modelos> listModels = _unitOfWork.modelRepository.getModels();
                return listModels;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
