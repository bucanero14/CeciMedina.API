using System.ComponentModel;

namespace CeciMedina.API.Helpers
{
    public class PaginationParams
    {
        [DefaultValue(15)]
        public int PageSize { get; set; }
        
        [DefaultValue(1)]
        public int PageNumber { get; set; }
    }
}