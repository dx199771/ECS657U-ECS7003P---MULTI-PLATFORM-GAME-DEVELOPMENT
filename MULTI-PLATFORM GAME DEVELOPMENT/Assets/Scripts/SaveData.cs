using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    private static SaveData _current;
    public static SaveData current
    {
        get
        {
            if(_current == null)
            {
                _current = new SaveData();
            }
            return _current;
        }
    }

    //public PlayerProfile profile;
    public int fridgeIndex;
    public int date;
    //public float[] position;
    public int dogIndex;
}
