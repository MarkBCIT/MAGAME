using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class urgent
*       urgent action
* author: mark
*/
public class urgent : MonoBehaviour {

    public static urgent urgents;
    private bool start = false;
    public bool waitforclick = false;
    private bool wait4 = false;
    private bool wait7 = false;
    private bool wait8 = false;
    private bool wait9 = false;
    void Awake() {
        urgents = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        start = true;
    }

    public void accident() {
        //show image
        int r = Random.Range(0, 13);
        switch (r) {
            case 0: {
                    Main.message = "EXTRA SPARRING TRAINING";
                    int a = Random.Range(1, 4);
                    int op = Main.current + a;
                    if (op > 3) {
                        op -= 4;
                    }
                    Main.list[Main.current].move(Main.list[Main.current].pos, Main.list[op].dojopos);
                    this.gameObject.SetActive(false);
                    break;
                }
            case 1: {
                    Main.message = "GO TO YIN YANG SPACE";
                    int a = Random.Range(0, 4);
                    Main.list[Main.current].move(Main.list[Main.current].pos, 2 + a * 14);
                    this.gameObject.SetActive(false);
                    break;
                }
            case 2: {
                    Main.message = "CLUB REUNION";
                    Main.list[Main.current].move(Main.list[Main.current].pos, Main.list[Main.current].dojopos);
                    this.gameObject.SetActive(false);
                    break;
                }
            case 3: {
                    Main.message = "YOUR DOJO Holds a Tournament";
                    tournament.tour.gameObject.SetActive(true);
                    tournament.tour.match();
                    this.gameObject.SetActive(false);
                    break;
                }
            case 4: {
                    Main.message = "FIGHT ANY PLAYER";
                    wait4 = true;
                    break;
                }
            case 5: {
                    Main.message = "TEACHER DEMOTES YOU ONE BELT LEVEL";
                    if (Main.list[Main.current].belt >= 1) {
                        Main.list[Main.current].belt -= 1;
                    }
                    waitforclick = true;
                    break;
                }
            case 6: {
                    Main.message = "TEACHER PROMOTES YOU ONE BELT LEVEL";
                    if (Main.list[Main.current].belt <= 3) {
                        Main.list[Main.current].belt += 1;
                    }
                    waitforclick = true;
                    break;
                }
            case 7: {
                    Main.message = "TEACHER SENDS YOU TO PUMP IRON";
                    Main.list[Main.current].pos = 23;
                    wait7 = true;
                    break;
                }
            case 8: {
                    Main.message = "TEACHER SENDS YOU TO GYMNASTICS";
                    Main.list[Main.current].pos = 51;
                    wait8 = true;
                    break;
                }
            case 9: {
                    Main.message = "TEACHER SENDS YOU TO MEDITATION";
                    int a = Random.Range(0, 2);
                    Main.list[Main.current].move(Main.list[Main.current].pos, 9 + 28 * a);
                    wait9 = true;

                    break;
                }
            case 10: {
                    Main.message = "GO TO ART FORM";
                    int a = Random.Range(0, 8);
                    int[] artpos = { 6, 12, 20, 26, 34, 40, 48, 54 };
                    Main.list[Main.current].move(Main.list[Main.current].pos, artpos[a]);
                    this.gameObject.SetActive(false);
                    break;
                }
            case 11:
            case 12: {
                    Main.message = "STREET FIGHT";
                    combat.combats.npcstreetfight = true;
                    int a = Random.Range(4, 36);
                    combat.combats.makefight(Main.current, a, true);
                    break;
                }
        }

    }

    public void fight(int p) {

        Main.list[Main.current].pos = Main.list[p].pos;
        Main.list[Main.current].formafter();
    }

    public void npcfightafter(int winner) {
        if (winner != Main.current) {
            Main.message = Main.list[Main.current].name + " is beaten on street!";
            Main.list[Main.current].gohosp();
        }
        else {
            Main.message = Main.list[Main.current].name + " beat enemy on street and get 2 chips!";
            Main.list[Main.current].chip += 2;
        }
        waitforclick = true;
    }

    void Update() {
        if (wait4 && Input.GetMouseButtonDown(0)) {
            wait4 = false;
            selectplayer.selectp.selectstreet = true;
            selectplayer.selectp.show();
        }
        if (wait7 && Input.GetMouseButtonDown(0)) {
            wait7 = false;
            iron.irons.bonus = true;
            iron.irons.gameObject.SetActive(true);
            iron.irons.startpunch();
            this.gameObject.SetActive(false);
        }
        if (wait8 && Input.GetMouseButtonDown(0)) {
            wait8 = false;
            gym.gyms.bonus = true;
            gym.gyms.gameObject.SetActive(true);
            gym.gyms.startexe();
            this.gameObject.SetActive(false);
        }
        if (wait9 && Input.GetMouseButtonDown(0)) {
            wait9 = false;
            college.colleges.bonus = true;
            this.gameObject.SetActive(false);
        }
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
        if (start && Input.GetMouseButtonDown(0)) {
            start = false;
            accident();
        }


    }
}