using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
	public Text p1name;
	public Text p2name;
	public Text p3name;
	public Text p4name;

	
    public void p1com()
    {
        Main.list[0].com = !Main.list[0].com;
    }
    public void p2com()
    {
        Main.list[1].com = !Main.list[1].com;
    }
    public void p3com()
    {
        Main.list[2].com = !Main.list[2].com;
    }
    public void p4com()
    {
        Main.list[3].com = !Main.list[3].com;
    }

public void startgame(){
	Main.list[0].name = p1name.text;
	Main.list[1].name = p2name.text;
	Main.list[2].name = p3name.text;
	Main.list[3].name = p4name.text;
	
	SceneManager.LoadScene("New Scene");
}

    // Use this for initialization


    // Update is called once per frame

}
