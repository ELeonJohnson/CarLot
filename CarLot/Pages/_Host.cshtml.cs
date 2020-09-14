using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace CarLot.Pages
{
    public class HostModel : PageModel
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public HostModel(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string UserAgent { get; set; }
        public string IPAddress { get; set; }

        // The following links may be useful for getting the IP Adress:
        // https://stackoverflow.com/questions/35441521/remoteipaddress-is-always-null
        // https://stackoverflow.com/questions/28664686/how-do-i-get-client-ip-address-in-asp-net-core

        public void OnGet()
        {
            UserAgent = _httpContextAccessor.HttpContext.Request.Headers["User-Agent"];
            // Note that the RemoteIpAddress property returns an IPAdrress object 
            // which you can query to get required information. Here, however, we pass 
            // its string representation
            IPAddress = _httpContextAccessor.HttpContext.Connection.RemoteIpAddress.ToString();
        }
    }
}
