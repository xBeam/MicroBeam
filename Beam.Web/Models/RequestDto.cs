using static Beam.Web.Utility.SD;

namespace Beam.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public object Data { get; set; } 
        public string AccessToken { get; set; }
    }
}
