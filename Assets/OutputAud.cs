using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
public class OutputAud : LoadMap1
{
    public Text fText;
    public void setget()
    {
        fText.text = "Audience " + Aud.ToString();
    }
 


}
