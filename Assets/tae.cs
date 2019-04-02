using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class tae
*       study tae form
* author: yipan
*/
public class tae : MonoBehaviour {

    public static tae ta;
    private bool waitforclick = false;

    void Awake() {
        ta = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        select.stae = true;
        select.selects.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip < 5 || Main.list[Main.current].taek) {
                select.selects.selectno();
            }
            else {
                select.selects.selectyes();
            }
        }
    }

    public void study() {
        Main.list[Main.current].pos = 2600;
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