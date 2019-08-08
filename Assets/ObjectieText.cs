using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectieText : MonoBehaviour {
    public Text objectiveText;
    public Text objectiveText2;
    public Text objectiveText3;
    public Text objectiveText4;



    public Text returnText()
    {
        return objectiveText;
    }

    public Text returnText2()
    {
        return objectiveText2;
    }
    public Text returnText3()
    {
        return objectiveText3;
    }
    public Text returnText4()
    {
        return objectiveText4;
    }
}
