using System.ComponentModel.DataAnnotations;

namespace Play.Catalog.Service.Dtos
{
    public record ItemDto(Guid Id, string Name, string Description, decimal Price, DateTimeOffset CreatedDate);

    public record CreateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price)
    {
        public static DateTimeOffset CreatedDate { get; internal set; }
    }

    public record UpdateItemDto([Required] string Name, string Description, [Range(0, 1000)] decimal Price);

}