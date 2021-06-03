using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questionnaire : ScriptableObject
{
    public List<AskItem> items;
    public Dictionary<int, AskItem> dicItem = new Dictionary<int, AskItem>();
    public Dictionary<int, AskItem> GetItems()
    {
        dicItem.Clear();
        for (int i = 0; i < items.Count; i++)
        {
            dicItem.Add(i, items[i]);
        }
        return dicItem;
    }
}

[System.Serializable]
public class AskItem
{
    public string problem;
    public string answer;
}
