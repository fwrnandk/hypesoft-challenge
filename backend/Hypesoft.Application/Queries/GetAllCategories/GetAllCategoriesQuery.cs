using MediatR;
using Hypesoft.Application.DTOs;

namespace Hypesoft.Application.Queries.GetAllCategories;

public record GetAllCategoriesQuery()
    : IRequest<List<CategoryResponse>>;
