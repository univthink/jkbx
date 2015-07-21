using Microsoft.AspNet.Authentication.OAuth;
using Microsoft.AspNet.Http;

namespace Iteam.JukeboxHero.OAuth.Battlenet
{
	public class BattlenetAuthenticationOptions : OAuthAuthenticationOptions<IOAuthAuthenticationNotifications>
	{
		public BattlenetAuthenticationOptions() 
		{
			AuthenticationScheme = BattlenetAuthenticationDefaults.AuthenticationScheme;
			Caption = AuthenticationScheme;
			CallbackPath = new PathString("/signin-battlenet");
			AuthorizationEndpoint = BattlenetAuthenticationDefaults.AuthorizationEndpoint;
			TokenEndpoint = BattlenetAuthenticationDefaults.TokenEndpoint;
		}
	}	
}