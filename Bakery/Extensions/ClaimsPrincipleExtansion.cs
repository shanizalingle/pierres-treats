using System.Linq;
using System.Security.Claims;

namespace Bakery.Extensions
{
	public static class ClaimsPrincipalExtension
	{
		public static string GetFullName(this ClaimsPrincipal principal)
		{
			var fullName = principal.Claims.FirstOrDefault(c => c.Type == "FullName");
			return fullName?.Value;
		}
	}
}