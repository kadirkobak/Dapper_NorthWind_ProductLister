using Dapper_NorthWind_ProductLister.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_NorthWind_ProductLister.Repositories.CategoryRepositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCategoryAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultCategoryDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetByIdCategoryDto> GetByIdCategoryDtoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateCategoryAsync(int id, CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
