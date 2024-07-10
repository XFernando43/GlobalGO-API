using data.repository.interfaces;
using GlobalGO.models;
using Microsoft.AspNetCore.Http;
using models.request;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections.Generic;

namespace service
{
    public partial class ModelServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public ModelServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Modelos>> getModelos()
        {
            try
            {
                var modelos = await _unitOfWork.modelRepository.getModels();
                return modelos;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async void insertModel(Modelos model)
        {
            try
            {
               _unitOfWork.modelRepository.AddModels(model);
            }
            catch (Exception ex) {
                throw new Exception("Error ocurrido durante la inserccion del dato");
            }
        }

        public async Task SubmitDataByExcel(IFormFile archivoExcel)
        {
            if (archivoExcel == null || archivoExcel.Length == 0)
            {
                throw new Exception("No se ha proporcionado un archivo valido");
            }

            try
            {
                using (var stream = archivoExcel.OpenReadStream())
                {
                    IWorkbook miExcel = null;
                    if (Path.GetExtension(archivoExcel.FileName).ToLower() == ".xlsx")
                    {
                        miExcel = new XSSFWorkbook(stream);
                    }
                    else if (Path.GetExtension(archivoExcel.FileName).ToLower() == ".xls")
                    {
                        miExcel = new HSSFWorkbook(stream);
                    }
                    else
                    {
                        throw new Exception("Formato de archivo no soportado");
                    }

                    ISheet hojaExcel = miExcel.GetSheetAt(0);
                    int rowCounts = hojaExcel.LastRowNum;

                    for (int i = 0; i <= rowCounts; i++)
                    {
                        IRow fila = hojaExcel.GetRow(i);
                        if (fila == null)
                        {
                            continue; // Salta filas vacías
                        }
                        Console.WriteLine($"{fila.GetCell(0).ToString()} {fila.GetCell(1).ToString()} {fila.GetCell(2).ToString()} {fila.GetCell(3).ToString()}");
                        //_unitOfWork.modelRepository.Add(new ModelRequest
                        //{
                        //    IdMarca = 1,
                            
                        //})
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Se produjo un error procesando el archivo");
            }
        }
        
    }
}
