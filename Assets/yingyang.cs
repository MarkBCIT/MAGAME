using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** 
* class yingyang
*       yingyang action
* author: mark
*/
public class yingyang : MonoBehaviour {
    public static yingyang yinyang;
    private bool waitforclick = false;
    private bool start = false;
    void Awake() {
        yinyang = this;
        this.gameObject.SetActive(false);
    }
    public void show() {
        this.gameObject.SetActive(true);
        start = true;
    }

    public void getyinyang() {
        
        int r = Random.Range(0, 9);
        switch (r) {
            case 0: {
                    Main.message = "TRAIN HARD CARD! GET 2 CHIPS!";
                    Main.list[Main.current].chip += 2;
                    
                    break;
                }
            case 1: {
                    Main.message = "KARMA CALLS YOU! GET A CHIP FROM EACH RIVAL!";
                    int p1 = Main.current + 1;
                    if (p1 > 3) p1 -= 4;
                    int p2 = Main.current + 2;
                    if (p2 > 3) p2 -= 4;
                    int p3 = Main.current + 3;
                    if (p3 > 3) p3 -= 4;
                    if(Main.list[p1].chip>0) {
                        Main.list[p1].chip -= 1;
                        Main.list[Main.current].chip += 1;
                    }
                    if (Main.list[p2].chip > 0) {
                        Main.list[p2].chip -= 1;
                        Main.list[Main.current].chip += 1;
                    }
                    if (Main.list[p3].chip > 0) {
                        Main.list[p3].chip -= 1;
                        Main.list[Main.current].chip += 1;
                    }
                    break;
                }
            case 2: {
                    Main.message = "2 CHIPS DISCOUNT CARD FOR STUDY MARTIAL!";
                    Main.list[Main.current].yinyangcard[0] += 1;
                    break;
                }
            case 3: {
                    Main.message = "QUICK RECOVERY CARD! GET OUT OF HOSPITAL!";
                    Main.list[Main.current].yinyangcard[1] += 1;
                    break;
                }
            case 4: {
                    Main.message = "THNUDER CARD! SEND RIVAL TO HOSPITAL!";
                    Main.list[Main.current].yinyangcard[2] += 1;
                    break;
                }
            case 5: {
                    Main.message = "EQUIPMENT CARD! GO TO BUY EQUIPMENT!";
                    Main.list[Main.current].yinyangcard[3] += 1;
                    break;
                }
            case 6: {
                    Main.message = "GUARD CARD! STOP ASSASSIAN!";
                    Main.list[Main.current].yinyangcard[4] += 1;
                    break;
                }
            case 7: {
                    Main.message = "DOUBLE ATTACK CARD!";
                    Main.list[Main.current].yinyangcard[5] += 1;
                    break;
                }
            case 8: {
                    Main.message = "DEBILITATE CARD! WEAKEN RIVAL IN COMBAT!";
                    Main.list[Main.current].yinyangcard[6] += 1;
                    break;
                }
        }
        waitforclick = true;
    }
    void Update () {
        if (waitforclick && Input.GetMouseButtonDown(0)) {
            waitforclick = false;
            this.gameObject.SetActive(false);
            Main.list[Main.current].formafter();
        }
        if (start && Input.GetMouseButtonDown(0)) {
            start = false;
            getyinyang();
        }


    }
}
