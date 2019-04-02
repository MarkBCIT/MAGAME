using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class prokick
*       study prokick form
* author: yipan
*/
public class prokick : MonoBehaviour {

    public static prokick pk;
    private bool waitforclick = false;

    void Awake() {
        pk = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        select.sprokick = true;
        select.selects.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip < 6 || Main.list[Main.current].prok) {
                select.selects.selectno();
            }
            else {
                select.selects.selectyes();
            }
        }
    }

    public void study() {
        Main.list[Main.current].pos = 3400;
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