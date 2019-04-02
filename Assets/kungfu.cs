using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class kungfu
*       study kungfu form
* author: yipan
*/
public class kungfu : MonoBehaviour {

    public static kungfu kf;
    private bool waitforclick = false;

    void Awake() {
        kf = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        select.skungfu = true;
        select.selects.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip < 10 || Main.list[Main.current].kung) {
                select.selects.selectno();
            }
            else {
                select.selects.selectyes();
            }
        }
    }

    public void study() {
        Main.list[Main.current].pos = 2000;
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