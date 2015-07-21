using Microsoft.AspNet.Authentication.OAuth;
using System.Net.Http;
using Microsoft.AspNet.Authentication;
using Microsoft.AspNet.Http.Authentication;
using System.Threading.Tasks;

namespace Iteam.JukeboxHero.OAuth.Battlenet
{
	internal class BattlenetAuthenticationHandler : OAuthAuthenticationHandler<BattlenetAuthenticationOptions, IOAuthAuthenticationNotifications>
	{
		public BattlenetAuthenticationHandler(HttpClient client) : base(client) 
		{
			
		}

        protected override async Task<AuthenticationTicket> GetUserInformationAsync(AuthenticationProperties properties, TokenResponse tokens)
        {
            return await base.GetUserInformationAsync(properties, tokens);            
        }
    }
}
