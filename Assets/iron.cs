using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class iron
*       iron form
* author: yipan
*/
public class iron : MonoBehaviour {

    public static iron irons;
    private bool waitforclick = false;
    private bool start = false;
    public bool bonus = false;
    void Awake() {
        irons = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        start = true;
    }

    public void selectpunch() {

        if (!Main.list[Main.current].com) {
            select.siron = true;
            select.selects.show();
        }
        else {
            if (Main.list[Main.current].chip >= 1 && Main.list[Main.current].str < 50) {
                startpunch();
            }
            else {
                nopunch();
            }
        }
    }
    public void startpunch() {
        Main.message = "Roll to gain strength!";
        Roll._Instance.punch = true;

        Roll._Instance.show();
        if (Main.list[Main.current].com) {
            Roll._Instance.dieroll();
        }

    }


    public void punchafter(int d) {
        if (bonus) {
            d *= 2;
            bonus = false;
        }
        Main.list[Main.current].str += d;
        if (Main.list[Main.current].str > 50) Main.list[Main.current].str = 50;
        Main.message = Main.list[Main.current].name + " got " + d + " point strength!";
        waitforclick = true;
    }


    public void nopunch() {

        waitforclick = true;
    }

    void Update() {
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
        if (start && Input.GetMouseButtonDown(0)) {
            start = false;
            selectpunch();
        }
    }
}
