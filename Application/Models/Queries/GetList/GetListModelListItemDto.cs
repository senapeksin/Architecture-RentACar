namespace Application.Models.Queries.GetList;

public class GetListModelListItemDto
{
    public Guid Id { get; set; }
    public Guid BrandName { get; set; }
    public Guid FuelName { get; set; }
    public Guid TransmissionName { get; set; }
    public string Name { get; set; }
    public decimal DailyPrice { get; set; }
    public string ImageUrl { get; set; }
}
