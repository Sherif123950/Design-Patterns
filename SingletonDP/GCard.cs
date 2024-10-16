using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDP
{
    public class GCard
    {
        private GCard(string title)
        {
            Title = title;
        }

        public string Title { get; set; }
        private static GCard Instance;
        static GCard()
        {
            Instance = new GCard("title1");
        }
        public static GCard Create()
        {
            return Instance;
        }
    }
}
