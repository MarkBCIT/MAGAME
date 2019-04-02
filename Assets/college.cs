using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class college
*       college form function
* author: yipan
*/
public class college : MonoBehaviour {

    public static college colleges;
    private bool waitforclick = false;
    private bool start = false;
    public bool bonus = false;
    void Awake() {
        colleges = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        start = true;

    }
    public void study() {
        Main.message = "Roll free for knowledge!";

        Roll._Instance.study = true;

        Roll._Instance.show();
        if (Main.list[Main.current].com) {
            Roll._Instance.dieroll();
        }
    }
    public void studyafter(int d) {
        if (bonus) {
            d *= 2;
            bonus = false;
        }
        Main.list[Main.current].knwl += d;
        if (Main.list[Main.current].knwl > 50) Main.list[Main.current].knwl = 50;
        Main.message = Main.list[Main.current].name + " got " + d + " point knowledge!";
        waitforclick = true;
    }

    void Update() {
        if (start && Input.GetMouseButtonDown(0)) {
            start = false;
            study();
        }
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
    }
}