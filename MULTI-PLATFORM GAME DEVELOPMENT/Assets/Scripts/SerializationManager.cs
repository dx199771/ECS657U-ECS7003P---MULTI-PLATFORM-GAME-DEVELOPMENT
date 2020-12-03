using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class SerializationManager
{
    public static bool Save(string saveName, object saveData)
    {
        BinaryFormatter formatter = new BinaryFormatter();

        if(!Directory.Exists(Application.persistentDataPath + "/saves"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/saves");
        }

        string path = Application.persistentDataPath + "/saves/" + saveName + ".png";

        FileStream file = File.Create(path);

        formatter.Serialize(file, saveData);

        file.Close();

        void Sleep()
        {
            SaveData.current.fridgeIndex = FridgeIndex.fridgeIndex;
            SaveData.current.date = DateInfo.date;
        }

        return true;
    }

    

}
