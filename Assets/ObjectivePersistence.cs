using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//h/ttps://www.youtube.com/watch?v=0pe3vu0Ayco

public class ObjectivePersistence : MonoBehaviour {

    public static void SaveData(Level1Controller l1)
    {
        PlayerPrefs.SetInt("objective", l1.ObjectiveData.Objective);
        PlayerPrefs.SetInt("objective2", l1.ObjectiveData.Objective2);
        PlayerPrefs.SetInt("objective3", l1.ObjectiveData.Objective3);
        PlayerPrefs.SetInt("objective4", l1.ObjectiveData.Objective4);
    }


    public static ObjectiveData LoadData()
    {
        int objective = PlayerPrefs.GetInt("objective");
        int objective2 = PlayerPrefs.GetInt("objective2");
        int objective3 = PlayerPrefs.GetInt("objective3");
        int objective4 = PlayerPrefs.GetInt("objective4");
        ObjectiveData objectiveData = new ObjectiveData()
        {
            Objective = objective,
            Objective2 = objective2,
             Objective3 = objective3,
              Objective4 = objective4
        };

        return objectiveData;
    }
}
