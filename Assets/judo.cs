using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class judo
*       study judo form
* author: yipan
*/
public class judo : MonoBehaviour {

    public static judo j;
    private bool waitforclick = false;

    void Awake() {
        j = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        select.sjudo = true;
        select.selects.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip < 5|| Main.list[Main.current].judd) {
                select.selects.selectno();
            }
            else {
                select.selects.selectyes();
            }
        }
    }

    public void study() {
        Main.list[Main.current].pos = 4000;
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