using System.Collections.Generic;
using SecMon;
using UnityEngine;

[CreateAssetMenu(fileName = "ScriptableDice", menuName = "SecMon/ScriptableDice")]
public class ScriptableDice : ScriptableObject
{
    [SerializeField]
    private List<int> _dice;

    private Dice _allDice;

    public List<Vector2Int> LastRolls => _allDice.LastRolls;

    public int RollDice(Roll roll)
    {
        switch (roll)
        {
            case Roll.Disadvantage:
                return RollDisadvantage();

            case Roll.Advantage:
                return RollAdvantage();

            case Roll.Standard:
            default:
                return RollStandard();
        }
    }

    private int RollStandard()
    {
        if (_allDice == null)
        {
            Init();
        }
        return _allDice.RollDice(Roll.Standard);
    }

    private int RollAdvantage()
    {
        if (_allDice == null)
        {
            Init();
        }
        return _allDice.RollDice(Roll.Advantage);
    }

    private int RollDisadvantage()
    {
        if (_allDice == null)
        {
            Init();
        }
        return _allDice.RollDice(Roll.Disadvantage);
    }

    private void Init()
    {
        var all = new HashSet<Die>();
        foreach (var i in _dice)
        {
            all.Add(new Die(i));
        }
        _allDice = new Dice(all);
    }
}