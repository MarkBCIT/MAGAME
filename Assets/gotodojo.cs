using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class gotodojo
*       control gotodojo 
* author: yang
*/
public class gotodojo : MonoBehaviour {

    public static gotodojo gotodojos;
    private bool waitforclick = false;

    void Awake() {
        gotodojos = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        go();
    }

    public void go() {
        //
        waitforclick = true;
    }

    void Update() {
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].pos += 4;
            if (Main.list[Main.current].pos > 56) {
                Main.list[Main.current].pos -= 56;
            }
            Main.list[Main.current].form(Main.list[Main.current].pos);
        }
    }
}