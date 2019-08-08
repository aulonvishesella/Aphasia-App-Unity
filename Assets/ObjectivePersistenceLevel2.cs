using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//h/ttps://www.youtube.com/watch?v=0pe3vu0Ayco

public class ObjectivePersistenceLevel2 : MonoBehaviour
{

    public static void SaveData(levelcontroller2 l2)
    {
        PlayerPrefs.SetInt("objectivelevel2", l2.ObjectiveData2.ObjectiveLevel2);
        PlayerPrefs.SetInt("objective2level2", l2.ObjectiveData2.Objective2Level2);
        PlayerPrefs.SetInt("objective3level2", l2.ObjectiveData2.Objective3Level2);
        PlayerPrefs.SetInt("objective4level2", l2.ObjectiveData2.Objective4Level2);
    }


    public static ObjectiveData2 LoadData()
    {
        int objectivelevel2 = PlayerPrefs.GetInt("objectivelevel2");
        int objective2level2 = PlayerPrefs.GetInt("objective2level2");
        int objective3level2 = PlayerPrefs.GetInt("objective3level2");
        int objective4level2 = PlayerPrefs.GetInt("objective4level2");
        ObjectiveData2 objectiveData2 = new ObjectiveData2()
        {
            ObjectiveLevel2 = objectivelevel2,
            Objective2Level2 = objective2level2,
            Objective3Level2 = objective3level2,
            Objective4Level2 = objective4level2
        };

        return objectiveData2;
    }
}
