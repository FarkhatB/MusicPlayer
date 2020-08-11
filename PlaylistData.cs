using Newtonsoft.Json;
using RestSharp.Serializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    class PlaylistData
    {
        public string id;
        public string name;
        public string description;
        public bool confidential;

        public PlaylistData(string name, string description, bool confidential)
        {
            this.name = name;
            this.description = description;
            this.confidential = confidential;
        }
    }
}
