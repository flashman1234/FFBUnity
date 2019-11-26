﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fumbbl.Model
{
    public class Coach
    {
        public bool IsHome { get { return true; } }

        public string Name => "Coach";

        public object FormattedName
        {
            get
            {
                string color = IsHome ? "#ff0000" : "#0000ff";
                return $"<{color}>{TextPanelHandler.SanitizeText(Name)}</color>";
            }
        }
    }
}