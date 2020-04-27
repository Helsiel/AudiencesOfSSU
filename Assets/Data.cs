using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Data : MonoBehaviour
{
    List<string> build = new List<string>() { "Н", "Ц", "Б" };
    List<string> aud = new List<string>() { "114", "115", "116", "117", "118", "119" };
    List<string> role = new List<string>() { "student", "teacher", "guest" };
    public Dropdown dropdown1, dropdown2, dropdown3;
    public Text selectAud;
    public Text selectBuild;
    public int builds;
    public int auds;

   
    public void Dropdown1_IndexChanged(int index)
    {
        selectBuild.text = build[index];
       
    }
    public void Dropdown2_IndexChanged(int index)
    {
        selectAud.text = aud[index];
      
    }
  

    void Start()
    {
        PopulateList();
    }

    void PopulateList()
    {
        dropdown1.AddOptions(build);
        dropdown2.AddOptions(aud);
        dropdown3.AddOptions(role);

    }
}
