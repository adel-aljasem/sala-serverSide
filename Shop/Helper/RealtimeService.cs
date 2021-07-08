using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Helper
{
    public class RealtimeService
    {
        AuthenticationStateProvider authenticationStateProvider;
        public RealtimeService(AuthenticationStateProvider authenticationStateProvider)
        {
            this.authenticationStateProvider = authenticationStateProvider;
        }

        public async Task<string> GetCurrentUser()
        {
            try
            {
                var auth = await authenticationStateProvider.GetAuthenticationStateAsync();
                return auth.User.FindFirst(w => w.Type == "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/nameidentifier")?.Value;

            }
            catch (Exception e)
            {
                throw new Exception();
            }
        }


        int price;
        public int Price
        {
            get { return price; }
            set { price = value; UpdateEvent?.Invoke(); }

        }
        int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; UpdateEvent.Invoke(); }
        }

       
        public event Action UpdateEvent;
    }
}
