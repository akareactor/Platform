using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct LeaderboardItem {
    public int rank; // 2026-07-19 10:43:48 номер места в таблице, ведь можно запросить произвольный диапазон
    public string name;
    public int score;
    public bool current; // является ли рекордсмен этим зареганным игроком?
}
