using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class karate
*       study karate form
* author: yipan
*/
public class karate : MonoBehaviour {

    public static karate k;
    private bool waitforclick = false;

    void Awake() {
        k = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        select.skarate = true;
        select.selects.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip < 6 || Main.list[Main.current].kara) {
                select.selects.selectno();
            }
            else {
                select.selects.selectyes();
            }
        }
    }

    public void study() {
        Main.list[Main.current].pos = 600;
        done();
    }
    public void done() {
        waitforclick = true;
    }

    void Update() {
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
    }
}