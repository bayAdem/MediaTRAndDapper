using MediatR;
using Platform.Api.Database.Repositories.Abstract;

namespace MediaTRAndDapper.CQRS.Commands.Category.DeleteCategories
{
    public class DeleteCategoryCommandHandler(ICategoryRepository categoryRepository) : IRequestHandler<DeleteCategoryCommand>
    {
        private readonly ICategoryRepository _categoryRepository = categoryRepository;
        public async Task Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _categoryRepository.GetByIdAsync(request.Id) ?? throw new ArgumentException("Category not found.");

            var result = await _categoryRepository.DeleteAsync(category.Id);

            if (result)
            {
                new DeleteCategoryResponse(true, "Category updated successfully");
            }
        }
    }
}
