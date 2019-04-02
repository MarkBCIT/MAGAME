using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class savate
*       study savate form
* author: yipan
*/
public class savate : MonoBehaviour {

    public static savate s;
    private bool waitforclick = false;

    void Awake() {
        s = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        select.ssavate = true;
        select.selects.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip < 5 || Main.list[Main.current].sava) {
                select.selects.selectno();
            }
            else {
                select.selects.selectyes();
            }
        }
    }

    public void study() {
        Main.list[Main.current].pos = 1200;
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