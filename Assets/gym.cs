using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class gym
*       gym function
* author: yipan
*/
public class gym : MonoBehaviour {

    public static gym gyms;
    private bool waitforclick = false;
    private bool start = false;
    public bool bonus = false;
    void Awake() {
        gyms = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        start = true;
    }
    public void selectexe() {
        if (!Main.list[Main.current].com) {
            select.sgym = true;
            select.selects.show();
        }
        else {
            if (Main.list[Main.current].chip >= 1 && Main.list[Main.current].dex < 50) {
                startexe();
            }
            else {
                noexe();
            }
        }
    }

    public void startexe() {
        Main.message = "Roll to gain dexterity!";
        Roll._Instance.exe = true;
        Roll._Instance.show();
        if (Main.list[Main.current].com) {
            Roll._Instance.dieroll();
        }

    }


    public void exeafter(int d) {
        if (bonus) {
            d *= 2;
            bonus = false;
        }
        Main.list[Main.current].dex += d;
        if (Main.list[Main.current].dex > 50) Main.list[Main.current].dex = 50;
        Main.message = Main.list[Main.current].name + " got " + d + " point dexterity!";
        waitforclick = true;
    }


    public void noexe() {

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
            selectexe();
        }
    }
}