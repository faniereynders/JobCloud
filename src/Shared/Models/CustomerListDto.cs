namespace JobCloud.Shared.Models
{
    public class CustomerListDto
    {
        public int Count => Items.Count();
        public IEnumerable<CustomerListItemDto> Items { get; set; }
    }
}
