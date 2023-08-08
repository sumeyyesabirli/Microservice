using AutoMapper;
using CasgemMicroservice.Services.Catalog.Dtos.CategoryDtos;
using CasgemMicroservice.Services.Catalog.Models;
using CasgemMicroservice.Services.Catalog.Settings;
using CasgemMicroservice.Shared.Dtos;
using MongoDB.Driver;

namespace CasgemMicroservice.Services.Catalog.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMongoCollection<Category> _categoryCollection;
        private readonly IMapper _mapper;

        public CategoryService(IMapper mapper, IDatabaseSettings _dataBaseSettings)
        {
            _mapper = mapper;
            var client = new MongoClient(_dataBaseSettings.ConnectionString);
            var database = client.GetDatabase(_dataBaseSettings.DatabaseName);
            _categoryCollection = database.GetCollection<Category>(_dataBaseSettings.CategoryCollectionName);
        }

        public async Task<Response<NoContent>> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            var value = _mapper.Map<Category>(createCategoryDto);
            await _categoryCollection.InsertOneAsync(value);
            return Response<NoContent>.Success(204);
        }

        public Task<Response<NoContent>> DeleteCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Response<List<ResultCategoryDto>>> GetAllCategoryAsync()
        {
            var values = await _categoryCollection.Find(x => true).ToListAsync();
            return Response<List<ResultCategoryDto>>.Success (_mapper.Map<List<ResultCategoryDto>>(values), 200);
        }

        public Task<Response<ResultCategoryDto>> GetByIdCategoryAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<Response<NoContent>> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
