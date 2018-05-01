using Developers.DataAccess.UnitOfWork;
using Developers.DataModel.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Developers.Business.Services.Developers
{
    public class DevelopersService: BaseService, IDevelopersService
    {
        public DevelopersService(IUnitOfWork uOw)
        {
            unitOfWork = uOw;
        }

        public IEnumerable<Developer> ReadAll()
        {
            try
            {
                return unitOfWork.DevelopersRepository.ReadAll();
            }
            catch(Exception ex)
            {
                // TODO: Log exception
                // TODO: Convert to a custom exception
                throw ex;
            }
        }

        public async Task<IEnumerable<Developer>> ReadAllAsync()
        {
            try
            {
                return await unitOfWork.DevelopersRepository.ReadAllAsync();
            }
            catch (Exception ex)
            {
                // TODO: Log exception
                // TODO: Convert to a custom exception
                throw ex;
            }
        }
    }
}