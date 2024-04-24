using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhoWantsToBeAMillionaire.Models;

namespace WhoWantsToBeAMillionaire.Services
{
    public static class ContextProvider
    {
        private static MillionaireDBContext context;

        public static MillionaireDBContext GetDbContext()
        {
            if (context == null)
            {
                context = new MillionaireDBContext();
            }
            return context;
        }
    }
}
