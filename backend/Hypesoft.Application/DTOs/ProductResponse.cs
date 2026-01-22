namespace Hypesoft.Application.DTOs;

public record ProductResponse(
    Guid Id,
    string Name,
    decimal Price,
    Guid CategoryId
);
