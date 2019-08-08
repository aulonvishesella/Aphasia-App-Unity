using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//h/ttps://www.youtube.com/watch?v=0pe3vu0Ayco

public class ObjectivePersistence3 : MonoBehaviour
{

    public static void SaveData(controllerforlevel3 l3)
    {
        PlayerPrefs.SetInt("objectivelevel3", l3.ObjectiveData3.ObjectiveLevel3);
        PlayerPrefs.SetInt("objective2level3", l3.ObjectiveData3.Objective2Level3);
        PlayerPrefs.SetInt("objective3level3", l3.ObjectiveData3.Objective3Level3);
        PlayerPrefs.SetInt("objective4level3", l3.ObjectiveData3.Objective4Level3);
    }


    public static ObjectiveData3 LoadData()
    {
        int objectivelevel3 = PlayerPrefs.GetInt("objectivelevel3");
        int objective2level3 = PlayerPrefs.GetInt("objective2level3");
        int objective3level3 = PlayerPrefs.GetInt("objective3level3");
        int objective4level3 = PlayerPrefs.GetInt("objective4level3");
        ObjectiveData3 objectiveData3 = new ObjectiveData3()
        {
            ObjectiveLevel3 = objectivelevel3,
            Objective2Level3 = objective2level3,
            Objective3Level3 = objective3level3,
            Objective4Level3 = objective4level3
        };

        return objectiveData3;
    }
}
