using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class ninjitsu
*       study ninjitsu form
* author: yipan
*/
public class ninjitsu : MonoBehaviour {

    public static ninjitsu n;
    private bool waitforclick = false;

    void Awake() {
        n = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        select.sninjitsu = true;
        select.selects.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip < 10 || Main.list[Main.current].ninj) {
                select.selects.selectno();
            }
            else {
                select.selects.selectyes();
            }
        }
    }

    public void study() {
        Main.list[Main.current].pos = 4800;
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