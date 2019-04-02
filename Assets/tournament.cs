using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class tournament
*       tournament action
* author: mark
*/
public class tournament : MonoBehaviour {

    public static tournament tour;
    public bool waitforclick = false;
    public int attendnum = 0;
    public int currentp;
    public int[] attend = { -1, -1, -1, -1 };
    public bool select1 = false;
    public bool startfight = false;
    public bool waithosp;
    public int round1win;
    public int round2win;
    void Awake() {
        tour = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        if (!Main.list[Main.current].com) {
            select.stournament = true;
            select.selects.show();
        }
        else {
            match();
        }
    }

    public void match() {
        Main.message = Main.list[Main.current].name + " hold a tournament!";
        attendnum++;
        attend[0] = Main.current;
        currentp = Main.current;
        Main.list[currentp].pos = Main.list[currentp].dojopos;
        select1 = true;
    }
    public void accept() {
        Main.message = Main.list[currentp].name + " attends the tournament!";
        attend[attendnum] = currentp;
        attendnum += 1;
        Main.list[currentp].pos = Main.list[currentp].dojopos;
        select1 = true;
    }
    public void notaccept() {
        Main.message = Main.list[currentp].name + " dares not attend the tournament!";
        select1 = true;
    }
    public void nomatch() {
        Main.message = Main.list[Main.current].name + " avoids a tournament!";
        waitforclick = true;
    }
    public void roundarrange() {
        switch (attendnum) {
            case 1: {
                    match1();
                    break;
                }
            case 2: {
                    match2();
                    break;
                }
            case 3: {
                    match3();
                    break;
                }
            case 4: {
                    match4();
                    break;
                }
        }
    }
    public void match1() {
        combat.combats.tourmatch1fight = true;
        int a = Random.Range(4, 36);
        combat.combats.makefight(attend[0], a, false);
    }
    public void match2() {
        combat.combats.tourmatch2fight = true;
        combat.combats.makefight(attend[0], attend[1], false);
    }
    public void match3() {
        combat.combats.tourmatch3fight = true;
        combat.combats.makefight(attend[0], attend[1], false);
    }
    public void match32() {
        combat.combats.tourmatch32fight = true;
        int a = Random.Range(4, 36);
        combat.combats.makefight(attend[2], a, false);
    }
    public void match33() {
        if (round1win == -1 && (round2win >= 4 || round2win == -1)) {
            Main.message = "No player won the prize!";
            done();
        }
        else {
            if (round1win == -1) {
                match33win(round2win);
            }
            else if (round2win == -1) {
                match33win(round1win);
            }
            else {
                combat.combats.tourmatch33fight = true;
                combat.combats.makefight(round1win, round2win, false);

            }
        }
    }

    public void match4() {
        combat.combats.tourmatch4fight = true;
        combat.combats.makefight(attend[0], attend[1], false);
    }
    public void match42() {
        combat.combats.tourmatch42fight = true;
        combat.combats.makefight(attend[2], attend[3], false);
    }
    public void match43() {
        if (round1win == -1 && round2win == -1) {
            Main.message = "No player won the prize!";
            done();
        }
        else {
            if (round1win == -1) {
                match43win(round2win);
            }
            else if (round2win == -1) {
                match43win(round1win);
            }
            else {
                combat.combats.tourmatch43fight = true;
                combat.combats.makefight(round1win, round2win, false);
            }
        }


    }
    public void match1win(int p) {
        if (p < 4) {
            Main.message = Main.list[p].name + " won the prize!";
            Main.list[p].chip += 4;
        }
        else {
            Main.message = "No player won the prize!";
        }
        done();
    }
    public void match2win(int p) {
        if (p != -1) {
            Main.message = Main.list[p].name + " won the prize!";
            Main.list[p].chip += 4;
        }
        else {
            Main.message = "No player won the prize!";
        }
        done();
    }
    public void match3win(int p) {
        round1win = p;
        match32();
    }
    public void match32win(int p) {
        round2win = p;
        match33();
    }
    public void match33win(int p) {
        if (p >= 4 || p == -1) {
            Main.message = "No player won the prize!";
        }
        else {
            Main.message = Main.list[p].name + " won the prize!";
            Main.list[p].chip += 4;
        }
        done();
    }
    public void match4win(int p) {
        round1win = p;
        match42();
    }
    public void match42win(int p) {
        round2win = p;
        match43();
    }
    public void match43win(int p) {
        if (p == -1) {
            Main.message = "No player won the prize!";
        }
        else {
            Main.message = Main.list[p].name + " won the prize!";
            Main.list[p].chip += 4;
        }
        done();
    }
    public void done() {
        attendnum = 0;
        currentp = -1;
        attend = new int[] { -1, -1, -1, -1 };
        select1 = false;
        startfight = false;
        waitforclick = true;
        round1win = -1;
        round2win = -1;
    }
    void Update() {
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
        if (select1 && Input.GetMouseButtonDown(0)) {
            select1 = false;
            currentp = next(currentp);
            if (currentp == attend[0]) {
                Main.message = "Tournament start!";
                startfight = true;
            }
            else {
                if (Main.list[currentp].pos == 3 || Main.list[currentp].pos == 17 || Main.list[currentp].pos == 31 || Main.list[currentp].pos == 45) {
                    Main.message = Main.list[currentp].name + " is in hospital...";
                    waithosp = true;
                }
                else {
                    if (!Main.list[currentp].com) {
                        Main.message = "Will " + Main.list[currentp].name + " attend tournament?";
                        select.stournament2 = true;
                        select.selects.show();
                        select.selects.button1text.text = "Participate tournament";
                        select.selects.button2text.text = "Not participate";
                    }
                    else {
                        if (Main.list[currentp].pos>=600) {
                            notaccept();
                        }
                        else {
                            accept();
                        }
                    }
                }
            }
        }
        if (startfight && Input.GetMouseButtonDown(0)) {
            startfight = false;
            roundarrange();
        }
        if (waithosp && Input.GetMouseButtonDown(0)) {
            waithosp = false;
            select1 = true;
        }


    }
    public int next(int a) {
        int n = a + 1;
        if (n > 3) {
            n -= 4;
        }
        return n;
    }
}
