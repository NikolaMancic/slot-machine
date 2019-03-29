using System.Collections.Generic;
using UnityEngine;

public static class Symbol
{
    public const float Bar1Angle   = 0;
    public const float Bar2Angle   = 60;
    public const float BellAngle   = 120;
    public const float CherryAngle = 180;
    public const float GrapeAngle  = 240;
    public const float DollarAngle = 300;

    public static Dictionary<SymbolType, float> SymbolAngles = new Dictionary<SymbolType, float>()
    {
        {SymbolType.Bar1,   Bar1Angle},
        {SymbolType.Bar2,   Bar2Angle},
        {SymbolType.Bell,   BellAngle},
        {SymbolType.Cherry, CherryAngle},
        {SymbolType.Grape,  GrapeAngle},
        {SymbolType.Dollar, DollarAngle}
    }; 
    
    public static SymbolType PickRandomSymbol()
    {
        var symbols = new SymbolType[]
        {
            SymbolType.Bar1,
            SymbolType.Bar2,
            SymbolType.Bell,
            SymbolType.Cherry,
            SymbolType.Grape,
            SymbolType.Dollar,
        };

        var randomIndex = Random.Range(0, symbols.Length);

        return symbols[randomIndex];
    }
}