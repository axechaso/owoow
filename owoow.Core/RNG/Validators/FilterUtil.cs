using owoow.Core.Enums;
using PKHeX.Core;

namespace owoow.Core.RNG;

public static class FilterUtil
{
    public static ShinyType GetFilterShinyType(int selected) => selected switch
    {
        1 => ShinyType.Either,
        2 => ShinyType.Square,
        3 => ShinyType.Star,
        4 => ShinyType.None,
        _ => ShinyType.Any,
    };

    public static AuraType GetFilterAuraType(int selected) => selected switch
    {
        1 => AuraType.Brilliant,
        2 => AuraType.None,
        _ => AuraType.Any,
    };

    public static ScaleType GetFilterScaleType(int selected) => (ScaleType)selected;

    public static RibbonIndex GetFilterMarkType(int selected) => selected switch
    {
        1 => RibbonIndex.MAX_COUNT, // None
        2 => RibbonIndex.MAX_COUNT + 2, // Any
        3 => RibbonIndex.MAX_COUNT + 3, // Personality
        4 => RibbonIndex.MAX_COUNT + 4, // Personality/Rare
        5 => RibbonIndex.MAX_COUNT + 5, // Any except Uncommon
        6 => RibbonIndex.MarkUncommon,
        7 => RibbonIndex.MarkLunchtime, // Time
        8 => RibbonIndex.MarkCloudy, // Weather
        9 => RibbonIndex.MarkFishing,
        10 => RibbonIndex.MarkRare,
        11 => RibbonIndex.MarkRowdy,
        12 => RibbonIndex.MarkAbsentMinded,
        13 => RibbonIndex.MarkJittery,
        14 => RibbonIndex.MarkExcited,
        15 => RibbonIndex.MarkCharismatic,
        16 => RibbonIndex.MarkCalmness,
        17 => RibbonIndex.MarkIntense,
        18 => RibbonIndex.MarkZonedOut,
        19 => RibbonIndex.MarkJoyful,
        20 => RibbonIndex.MarkAngry,
        21 => RibbonIndex.MarkSmiley,
        22 => RibbonIndex.MarkTeary,
        23 => RibbonIndex.MarkUpbeat,
        24 => RibbonIndex.MarkPeeved,
        25 => RibbonIndex.MarkIntellectual,
        26 => RibbonIndex.MarkFerocious,
        27 => RibbonIndex.MarkCrafty,
        28 => RibbonIndex.MarkScowling,
        29 => RibbonIndex.MarkKindly,
        30 => RibbonIndex.MarkFlustered,
        31 => RibbonIndex.MarkPumpedUp,
        32 => RibbonIndex.MarkZeroEnergy,
        33 => RibbonIndex.MarkPrideful,
        34 => RibbonIndex.MarkUnsure,
        35 => RibbonIndex.MarkHumble,
        36 => RibbonIndex.MarkThorny,
        37 => RibbonIndex.MarkVigor,
        38 => RibbonIndex.MarkSlump,
        _ => RibbonIndex.MAX_COUNT + 1, // Ignore
    };

    public static string GetRibbonTitle(RibbonIndex rib) => rib switch
    {
        RibbonIndex.MarkUncommon => "不怕人的",
        RibbonIndex.MarkLunchtime => "肚子饿扁了的\n想睡觉的\n开始犯困的\n很早就醒来的",
        RibbonIndex.MarkCloudy => "盯着云看的\n在雨中哽咽的\n对打雷大呼小叫的\n在雪里打滚的\n冻得发抖的\n喉咙干渴的\n满身沙子的\n对雾感到困惑的",
        RibbonIndex.MarkFishing => "刚钓上来活蹦乱跳的",
        RibbonIndex.MarkRare => "没见过人类的",
        RibbonIndex.MarkRowdy => "脾气暴躁的",
        RibbonIndex.MarkAbsentMinded => "脑袋空空的",
        RibbonIndex.MarkJittery => "心跳不已的",
        RibbonIndex.MarkExcited => "兴奋期待的",
        RibbonIndex.MarkCharismatic => "感觉到气场的",
        RibbonIndex.MarkCalmness => "酷酷的",
        RibbonIndex.MarkIntense => "好斗的",
        RibbonIndex.MarkZonedOut => "在发呆的",
        RibbonIndex.MarkJoyful => "看起来很幸福的",
        RibbonIndex.MarkAngry => "气呼呼的",
        RibbonIndex.MarkSmiley => "笑眯眯的",
        RibbonIndex.MarkTeary => "泪汪汪的",
        RibbonIndex.MarkUpbeat => "心情好的",
        RibbonIndex.MarkPeeved => "心情不好的",
        RibbonIndex.MarkIntellectual => "聪慧的",
        RibbonIndex.MarkFerocious => "狂暴的",
        RibbonIndex.MarkCrafty => "伺机而动的",
        RibbonIndex.MarkScowling => "粗犷的",
        RibbonIndex.MarkKindly => "温柔的",
        RibbonIndex.MarkFlustered => "慌慌张张的",
        RibbonIndex.MarkPumpedUp => "充满干劲的",
        RibbonIndex.MarkZeroEnergy => "毫无干劲的",
        RibbonIndex.MarkPrideful => "嚣张跋扈的",
        RibbonIndex.MarkUnsure => "缺乏自信的",
        RibbonIndex.MarkHumble => "朴素的",
        RibbonIndex.MarkThorny => "装模作样的",
        RibbonIndex.MarkVigor => "精力充沛的",
        RibbonIndex.MarkSlump => "看似疲惫的",
        _ => string.Empty
    };
}
