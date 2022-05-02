using System.Text.Json.Serialization;

using System.Collections.Generic;
namespace JobCloud.Client.Models
{
    public class JobListItem
    {
        public string Id { get; set; }
        public string JobNumber { get; set; }
        public DateTime Date { get; set; }
        public string Customer { get; set; }
        public string Team { get; set; }
        public string LoggedBy { get; set; }
    }
}



