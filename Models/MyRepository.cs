using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Party.Models
{
    public static class MyRepository
    {
        private static List<GuestResposne> guests = new List<GuestResposne>();
        public static IEnumerable<GuestResposne> Resposnes
        {
            get
            {
                return guests;
            }
        }
        public static void AddResponse(GuestResposne guest)
        {
            guests.Add(guest);
        }
    }

}
