using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace QuanLySieuThi
{
    public class MyAuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            
            if (!CheckAuth.CheckExist(context.UserName,context.Password))
            {
                context.SetError("invalid_grant", "Provided username and password is incorrect");
                return;
            }
            var rs = CheckAuth.CheckRole(context.UserName);
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            switch (rs)
            {
                case "Admin":
                    identity.AddClaim(new Claim(ClaimTypes.Role, "Admin"));
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User_Kho"));
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User_BanHang"));
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User_ThongKe"));
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                    break;
                case "User_Kho":
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User_Kho"));
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                    break;
                case "User_BanHang":
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User_BanHang"));
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                    break;
                case "User_ThongKe":
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User_ThongKe"));
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                    break;
                default:
                    identity.AddClaim(new Claim(ClaimTypes.Role, "User"));
                    break;

            }                       
            identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
            context.Validated(identity);

        }
    }
}