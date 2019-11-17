﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumbbl.Dto
{
    public class ClientJoin : AbstractCommand
    {
        public ClientJoin() : base("clientJoin") { }

        public string clientMode;
        public string coach;
        public string password;
        public int gameId;
        public string gameName;
        public string teamId;
        public string teamName;
    }
}
