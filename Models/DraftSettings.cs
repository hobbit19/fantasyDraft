﻿using System;
using System.Collections.Generic;

namespace FantasyDraftAPI.Models
{
    /// <summary>
    /// Summary description for DraftSettings
    /// </summary>
    public class DraftSettings
    {
        public int SecondsPerPick { get; set; }
        public int ClockWarningSeconds { get; set; }
        public int TeamsPerDraft { get; set; }
        public int RoundsPerDraft { get; set; }
        public int DraftSeasonID { get; set; }
        public int ChatRoomCache { get; set; }
        public int MSPerRefresh { get; set; }
        public int MSPerChatRefresh { get; set; }
        public int MSPerStatusRefresh { get; set; }
        public int ActiveUserSeconds { get; set; }
        public DateTime ChatFilter { get; set; }
        public Dictionary<String, int> PositionMaxes { get; set; }

        public DraftSettings()
        {
            SecondsPerPick = 120;
            ClockWarningSeconds = 30;
            TeamsPerDraft = 12;
            RoundsPerDraft = 17;
            DraftSeasonID = 12;
            ChatRoomCache = 50;
            MSPerRefresh = 1000;
            MSPerChatRefresh = 1500;
            MSPerStatusRefresh = 5000;
            ActiveUserSeconds = 15;
            ChatFilter = new DateTime(2018, 8, 16, 12, 0, 0);
            PositionMaxes = new Dictionary<string,int>
            {
                {"QB", 4},
                {"RB", 9},
                {"WR", 9},
                {"TE", 4}
            };
        }
    }
}