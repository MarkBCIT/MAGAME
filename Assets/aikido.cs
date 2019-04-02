using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class aikido
*       study aikido form
* author: yipan
*/
public class aikido : MonoBehaviour {

    public static aikido ai;
    private bool waitforclick = false;

    void Awake() {
        ai = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        select.sakido = true;
        select.selects.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip < 5 || Main.list[Main.current].aiki) {
                select.selects.selectno();
            }
            else {
                select.selects.selectyes();
            }
        }
    }

    public void study(){
        Main.list[Main.current].pos = 5400;
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