﻿using Fumbbl.Dto;
using Fumbbl.Model;

namespace Fumbbl.UI.LogText
{
    [ReportType(typeof(Dto.Reports.Block))]
    public class Block : ILogTextGenerator
    {
        public string Convert(IReport report)
        {
            Dto.Reports.Block block = (Dto.Reports.Block)report;
            string attacker = FFB.Instance.Model.GetPlayerName(FFB.Instance.Model.ActingPlayer?.PlayerId);
            string defender = FFB.Instance.Model.GetPlayerName(block.defenderId);
            
            ActingPlayer.ActionType action = FFB.Instance.Model.ActingPlayer.CurrentAction;

            string actionString = action == ActingPlayer.ActionType.Blitz ? "blitzes" : "blocks";

            return $"{attacker} {actionString} {defender}.";
        }
    }
}
