using Acme.Blog.Category.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Acme.Blog.Category.Entities;

namespace Acme.Blog.Category.Services
{
    public class CategoryService : ICategoryService
    {

        private readonly IMongoDatabase _db;
        private readonly IMongoCollection<Category> _category;

        public CategoryService()
        {
            var mongoClient = new MongoClient(System.Environment.GetEnvironmentVariable("MongoDBAtlasConnectionString"));
            _db = mongoClient.GetDatabase(System.Environment.GetEnvironmentVariable("MongoDBAtlasConnectionString"));
        }

        public async Task<IEnumerable<CategoryVm>> GetAll(CancellationToken? cancellationToken)
        {
            var category =  _db.GetCollection<Category>("category");

            return (IEnumerable<CategoryVm>) await category.AsQueryable<Category>().ToListAsync();
        }

        public Task<CategoryVm> Add(CreateCategoryDto createCategory, CancellationToken? cancellationToken)
        {
            throw new NotImplementedException();
        }

        // vdbqsfdkchzrcrdd
    }
}
