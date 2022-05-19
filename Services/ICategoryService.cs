using Acme.Blog.Category.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Acme.Blog.Category.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<CategoryVm>> GetAll(CancellationToken? cancellationToken);

        Task<CategoryVm> Add(CreateCategoryDto createCategory, CancellationToken? cancellationToken);
    }
}
