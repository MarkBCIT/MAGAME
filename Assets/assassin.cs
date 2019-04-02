using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class assassin
*       assassin form function
* author: yang
*/
public class assassin : MonoBehaviour {
    public static assassin assassins;
    public int target = -1;
    public int op = -1;
    private bool start = false;
    private bool waitforclick = false;
    private bool waitfornpcattack = false;
    private bool waitforself = false;
    void Awake() {
        assassins = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        start = true;
    }
    public void selectp() {
        selectplayer.selectp.selectassassin = true;
        selectplayer.selectp.show();
    }

    public void method(int p) {
        target = p;
        Main.message = "Who is going to do it?";
        select.assassinse = true;
        select.selects.show();
        if (Main.list[Main.current].com) {
            if (Main.list[Main.current].chip < 5) {
                select.selects.selectno();
            }else {
                if (2*Main.list[Main.current].level() >= Main.list[target].level()) {
                    select.selects.selectno();
                }
                else {
                    select.selects.selectyes();
                }
            }
        }
    }
    public void hire() {
        Main.list[Main.current].chip -= 5;
        op = Random.Range(4, 36);
        Main.message = Main.list[Main.current].name + " hired " + combat.combats.npcname[op] + " to attack " + Main.list[target].name + " !";
        waitfornpcattack = true;
    }
    public void self() {
        op = Main.current;
        Main.message = Main.list[Main.current].name + " attacks " + Main.list[target].name + " !";
        waitforself = true;
    }
    public void npcattack() {
        if (Main.list[target].yinyangcard[6] > 0) {
            Main.list[target].yinyangcard[6] -= 1;
            Main.message = "Guard Card! Assassin attempt failed!";
            done();
        }
        else {
            combat.combats.assassinfight = true;
            combat.combats.makefight(target, op, true);
        }
    }
    public void selfattack() {
        if (Main.list[target].yinyangcard[6] > 0) {
            Main.list[target].yinyangcard[6] -= 1;
            Main.message = "Guard Card! Assassin attempt failed!";
            done();
        }
        else {
            Main.list[Main.current].pos = Main.list[target].pos;
            combat.combats.assassinfight = true;
            combat.combats.makefight(target, Main.current, true);
        }
    }

    public void result(int winner) {
        if (winner == -1) {
            Main.message = "Assassin exposed! Both got injured!";

        }
        else if (winner == target) {
            Main.message = Main.list[target].name + " beat assassin!";
            if(op == Main.current) {
                Main.list[Main.current].gohosp();
            }
        }
        else {
            Main.message = Main.list[target].name + " was maimed by assassin!";
            Main.list[target].maimed = true;
            if (Main.list[target].belt > 0) Main.list[target].belt -= 1;
            Main.list[target].str -= 10;
            if (Main.list[target].str < 0) Main.list[target].str = 0;
            Main.list[target].dex -= 10;
            if (Main.list[target].dex < 0) Main.list[target].dex = 0;
            Main.list[target].knwl -= 10;
            if (Main.list[target].knwl < 0) Main.list[target].knwl = 0;
            Main.list[target].chip -= 10;
            if (Main.list[target].chip < 0) Main.list[target].chip = 0;
            Main.list[target].weapon = new int[]{0,0,0,0,0};
            Main.list[target].gohosp();
        }
        done();
    }

    public void done() {
        target = -1;
        op = -1;
        waitforclick = true;
    }

    void Update() {
        if (start && Input.GetMouseButtonDown(0)) {
            start = false;
            selectp();
        }
        if (waitfornpcattack && Input.GetMouseButtonDown(0)) {
            waitfornpcattack = false;
            npcattack();
        }
        if (waitforself && Input.GetMouseButtonDown(0)) {
            waitforself = false;
            selfattack();
        }
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
    }
}
