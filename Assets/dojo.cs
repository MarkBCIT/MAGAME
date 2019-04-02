using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class dojo
*       control dojo 
* author: yang
*/
public class dojo : MonoBehaviour {
    public static dojo dojos;
    public bool waithosp;
    public bool waitAI;
    private bool waitforclick = false;

    void Awake() {
        dojos = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        dojoin();
    }
    public void dojoin() {
        if (Main.list[Main.current].pos == Main.list[Main.current].dojopos) {
            Main.message = Main.list[Main.current].name + " arrive at his own dojo and get 2 hours trainning!";
            afterdojo(Main.current);
        }
        else {
            Main.message = Main.list[Main.current].name + " challenge " + Main.list[(Main.list[Main.current].pos - 1) / 14].name + " !";
            if (Main.list[(Main.list[Main.current].pos - 1) / 14].pos == 3 || Main.list[(Main.list[Main.current].pos - 1) / 14].pos == 17 || Main.list[(Main.list[Main.current].pos - 1) / 14].pos == 31 || Main.list[(Main.list[Main.current].pos - 1) / 14].pos == 45) {
                waithosp = true;
            }
            else {
                select.sdojo = true;
                if (!Main.list[(Main.list[Main.current].pos - 1) / 14].com) {
                    select.selects.show();
                }
                else {
                    waitAI = true;
                }
            }
        }
    }
    public void actAI() {
        if (Main.list[(Main.list[Main.current].pos - 1) / 14].study) {
            if (Main.list[(Main.list[Main.current].pos - 1) / 14].chip >= 2) {
                giveup();
            }
        }
        else {
            fight();
        }
        select.sdojo = false;
    }
    public void fight() {
        Main.message = Main.list[(Main.list[Main.current].pos - 1) / 14].name + " decide to teach " + Main.list[Main.current].name + " a lesson!";
        //combat.combats.p1 = Main.current;
        //combat.combats.p2 = (Main.list[Main.current].pos - 1) / 14;
        //combat.combats.p1name = Main.list[Main.current].name;
        //combat.combats.p2name = Main.list[(Main.list[Main.current].pos - 1) / 14].name;
        //combat.combats.weaponallow = false;
        Main.list[(Main.list[Main.current].pos - 1) / 14].pos = Main.list[Main.current].pos;
        combat.combats.dojofight = true;
        combat.combats.makefight(Main.current, (Main.list[Main.current].pos - 1) / 14, false);
    }
    public void hosp() {
        Main.message = Main.list[Main.current].name + " rob " + Main.list[(Main.list[Main.current].pos - 1) / 14].name + "'s dojo when " + Main.list[(Main.list[Main.current].pos - 1) / 14].name + " is in hospital!";
        if(Main.list[(Main.list[Main.current].pos - 1) / 14].chip >= 2) {
            Main.list[(Main.list[Main.current].pos - 1) / 14].chip -= 2;
            Main.list[Main.current].chip += 2;
        }
        else if(Main.list[(Main.list[Main.current].pos - 1) / 14].chip == 1) {
            Main.list[(Main.list[Main.current].pos - 1) / 14].chip -= 1;
            Main.list[Main.current].chip += 1;
        }
        waitforclick = true;
    }
    public void giveup() {
        Main.message = Main.list[(Main.list[Main.current].pos - 1) / 14].name + " give " + Main.list[Main.current].name + " 2 chips to avoid a fight";
        Main.list[(Main.list[Main.current].pos - 1) / 14].chip -= 2;
        Main.list[Main.current].chip += 2;
        waitforclick = true;
    }
    public void afterdojo(int winner) {
        if (winner != -1) Main.list[winner].chip += 2;
        waitforclick = true;
    }
    void Update() {
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
        if (waithosp && Input.GetMouseButtonDown(0)) {
            waithosp = false;
            hosp();
        }
        if (waitAI && Input.GetMouseButtonDown(0)) {
            waitAI = false;
            actAI();
        }
    }
}
