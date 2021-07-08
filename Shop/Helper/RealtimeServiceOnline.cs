using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Helper
{
    public class RealtimeServiceOnline
    {
        public event Action OnAddedToCartNotifications;

        public void UpdateNotficationOnAdminGUI()
        {
            OnAddedToCartNotifications?.Invoke();
        }
    }
}
