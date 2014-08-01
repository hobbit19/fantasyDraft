﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Serialization;
using System.IO;

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

	public DraftSettings()
	{
        SecondsPerPick = 90;
        ClockWarningSeconds = 30;
        TeamsPerDraft = 12;
        RoundsPerDraft = 18;
        DraftSeasonID = 8;
        ChatRoomCache = 50;
        MSPerRefresh = 1000;
        MSPerChatRefresh = 1500;
        MSPerStatusRefresh = 5000;
        ActiveUserSeconds = 5;
        ChatFilter = new DateTime(2010, 8, 25, 12, 0, 0);
	}
}