using System;
using System.Collections.Generic;
using hileets.TMS.Models;

namespace hileets.TMS.Views
{
    public interface IPersonView
    {
        void LoggedIn(Person sender);
        void SignedUp(Person sender);
        void DisplayMenu(IEnumerable<string> Menu);
    }
}
