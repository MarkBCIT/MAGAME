using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/** 
* class main
*       control the game process
* author: mark
*/
public class Main : MonoBehaviour {
    public static int current;
    public static bool gameover = false;
    public static Player[] list = new Player[] { new Player(0), new Player(1), new Player(2), new Player(3) };
    public string[] beltname = { "None", "White", "Red", "Brown", "Black" };
    public Text Player0;
    public Text Player1;
    public Text Player2;
    public Text Player3;
    public Text Message;
    public static string message;
    public Text Button;
    public static string button;
    // Use this for initialization
    void Start() {

        startGame();

    }

    // Update is called once per frame
    void Update() {
        setText();
    }

    void startGame() {
        setText();
        if(list[0].name=="")list[0].name = "Les";
        // list[0].belt = 4;
        // list[0].weapon[4] = 2;
        // list[0].weapon[3] = 2;
        // list[0].weapon[2] = 2;
        // list[0].weapon[1] = 2;
        // list[0].weapon[0] = 2;
        // list[0].chip = 20;
        // list[0].str = 50;
        // list[0].dex = 50;
        // list[0].knwl = 50;
        // list[0].yinyangcard[0] = 1;
        // list[0].yinyangcard[1] = 1;
        // list[0].yinyangcard[2] = 1;
        // list[0].yinyangcard[3] = 1;
        // list[0].yinyangcard[4] = 1;
        // list[0].yinyangcard[5] = 1;
        // list[0].yinyangcard[6] = 1;
        // list[0].yinyangcard[7] = 1;
        // list[0].yinyangcard[8] = 1;

        if (list[1].name=="")list[1].name = "Mark";
        // list[1].belt = 4;
        // list[1].weapon[1] = 2;
        // list[1].weapon[1] = 2;
        // list[1].weapon[1] = 2;
        // list[1].weapon[1] = 2;
        // list[1].weapon[1] = 2;
        // list[1].chip = 20;
        // list[1].str = 50;
        // list[1].dex = 50;
        // list[1].knwl = 50;        
        // list[1].yinyangcard[0] = 1;
        // list[1].yinyangcard[1] = 1;
        // list[1].yinyangcard[2] = 1;
        // list[1].yinyangcard[3] = 1;
        // list[1].yinyangcard[4] = 1;
        // list[1].yinyangcard[5] = 1;
        // list[1].yinyangcard[6] = 1;
        // list[1].yinyangcard[7] = 1;
        // list[1].yinyangcard[8] = 1;

        if (list[2].name == "") list[2].name = "Yang";
        // list[2].belt = 4;
        // list[2].weapon[4] = 2;
        // list[2].weapon[3] = 2;
        // list[2].weapon[2] = 2;
        // list[2].weapon[1] = 2;
        // list[2].weapon[0] = 2;
        // list[2].chip = 20;
        // list[2].str = 50;
        // list[2].dex = 50;
        // list[2].knwl = 50;   
        // list[2].yinyangcard[0] = 1;
        // list[2].yinyangcard[1] = 1;
        // list[2].yinyangcard[2] = 1;
        // list[2].yinyangcard[3] = 1;
        // list[2].yinyangcard[4] = 1;
        // list[2].yinyangcard[5] = 1;
        // list[2].yinyangcard[6] = 1;
        // list[2].yinyangcard[7] = 1;
        // list[2].yinyangcard[8] = 1;

        if (list[3].name=="")list[3].name = "Yipan";
        // list[3].belt = 4;
        // list[3].weapon[4] = 2;
        // list[3].weapon[3] = 2;
        // list[3].weapon[2] = 2;
        // list[3].weapon[1] = 2;
        // list[3].weapon[0] = 2;
        // list[3].chip = 20;
        // list[3].str = 50;
        // list[3].dex = 50;
        // list[3].knwl = 50;   
        // list[3].yinyangcard[0] = 1;
        // list[3].yinyangcard[1] = 1;
        // list[3].yinyangcard[2] = 1;
        // list[3].yinyangcard[3] = 1;
        // list[3].yinyangcard[4] = 1;
        // list[3].yinyangcard[5] = 1;
        // list[3].yinyangcard[6] = 1;
        // list[3].yinyangcard[7] = 1;
        // list[3].yinyangcard[8] = 1;
        current = 0;
        list[0].act();

    }
    public void setText() {
        // Player0.text = "Player No: " + list[0].playerNo.ToString() +1+ "\r\n";
        Player0.text = "Name: " + list[0].name + "\r\n";
        // Player0.text += "Player pos: " + list[0].pos.ToString() + "\r\n";
        Player0.text += "chip: " + list[0].chip.ToString() + "\r\n";
        Player0.text += "belt: " + beltname[list[0].belt] + "\r\n";
        Player0.text += "knowledge: " + list[0].knwl.ToString() + "\r\n";
        Player0.text += "strengh: " + list[0].str.ToString() + "\r\n";
        Player0.text += "dexterity: " + list[0].dex.ToString() + "\r\n";
        Player0.text += "weapon: " + "\r\n";
        if (list[0].weapon[0] > 0) Player0.text += "SHURIKEN x" + list[0].weapon[0] + "\r\n";
        if (list[0].weapon[1] > 0) Player0.text += "SAI'S x" + list[0].weapon[1] + "\r\n";
        if (list[0].weapon[2] > 0) Player0.text += "STAFF x" + list[0].weapon[2] + "\r\n";
        if (list[0].weapon[3] > 0) Player0.text += "NUNCHAKU x" + list[0].weapon[3] + "\r\n";
        if (list[0].weapon[4] > 0) Player0.text += "SWORD x" + list[0].weapon[4] + "\r\n";

        // Player1.text = "Player No: " + list[1].playerNo.ToString() + 1+"\r\n";
        Player1.text = "Name: " + list[1].name + "\r\n";
        // Player1.text += "Player pos: " + list[1].pos.ToString() + "\r\n";
        Player1.text += "chip: " + list[1].chip.ToString() + "\r\n";
        Player1.text += "belt: " + beltname[list[1].belt] + "\r\n";
        Player1.text += "knowledge: " + list[1].knwl.ToString() + "\r\n";
        Player1.text += "strengh: " + list[1].str.ToString() + "\r\n";
        Player1.text += "dexterity: " + list[1].dex.ToString() + "\r\n";
        Player1.text += "weapon: " + "\r\n";
        if (list[1].weapon[0] > 0) Player1.text += "SHURIKEN x" + list[1].weapon[0] + "\r\n";
        if (list[1].weapon[1] > 0) Player1.text += "SAI'S x" + list[1].weapon[1] + "\r\n";
        if (list[1].weapon[2] > 0) Player1.text += "STAFF x" + list[1].weapon[2] + "\r\n";
        if (list[1].weapon[3] > 0) Player1.text += "NUNCHAKU x" + list[1].weapon[3] + "\r\n";
        if (list[1].weapon[4] > 0) Player1.text += "SWORD x" + list[1].weapon[4] + "\r\n";

        // Player2.text = "Player No: " + list[2].playerNo.ToString() + 1+"\r\n";
        Player2.text = "Name: " + list[2].name + "\r\n";
        // Player2.text += "Player pos: " + list[2].pos.ToString() + "\r\n";
        Player2.text += "chip: " + list[2].chip.ToString() + "\r\n";
        Player2.text += "belt: " + beltname[list[2].belt] + "\r\n";
        Player2.text += "knowledge: " + list[2].knwl.ToString() + "\r\n";
        Player2.text += "strengh: " + list[2].str.ToString() + "\r\n";
        Player2.text += "dexterity: " + list[2].dex.ToString() + "\r\n";
        Player2.text += "weapon: " + "\r\n";
        if (list[2].weapon[0] > 0) Player2.text += "SHURIKEN x" + list[2].weapon[0] + "\r\n";
        if (list[2].weapon[1] > 0) Player2.text += "SAI'S x" + list[2].weapon[1] + "\r\n";
        if (list[2].weapon[2] > 0) Player2.text += "STAFF x" + list[2].weapon[2] + "\r\n";
        if (list[2].weapon[3] > 0) Player2.text += "NUNCHAKU x" + list[2].weapon[3] + "\r\n";
        if (list[2].weapon[4] > 0) Player2.text += "SWORD x" + list[2].weapon[4] + "\r\n";

        // Player3.text = "Player No: " + list[3].playerNo.ToString() + 1+"\r\n";
        Player3.text = "Name: " + list[3].name + "\r\n";
        // Player3.text += "Player pos: " + list[3].pos.ToString() + "\r\n";
        Player3.text += "chip: " + list[3].chip.ToString() + "\r\n";
        Player3.text += "belt: " + beltname[list[3].belt] + "\r\n";
        Player3.text += "knowledge: " + list[3].knwl.ToString() + "\r\n";
        Player3.text += "strengh: " + list[3].str.ToString() + "\r\n";
        Player3.text += "dexterity: " + list[3].dex.ToString() + "\r\n";
        Player3.text += "weapon: " + "\r\n";
        if (list[3].weapon[0] > 0) Player3.text += "SHURIKEN x" + list[3].weapon[0] + "\r\n";
        if (list[3].weapon[1] > 0) Player3.text += "SAI'S x" + list[3].weapon[1] + "\r\n";
        if (list[3].weapon[2] > 0) Player3.text += "STAFF x" + list[3].weapon[2] + "\r\n";
        if (list[3].weapon[3] > 0) Player3.text += "NUNCHAKU x" + list[3].weapon[3] + "\r\n";
        if (list[3].weapon[4] > 0) Player3.text += "SWORD x" + list[3].weapon[4] + "\r\n";
        Message.text = message;
        Button.text = button;

    }


}

public class Player {

    public bool com = false;
    public bool study = false;
    public int playerNo;
    public int pos;
    public int dojopos;
    public int chip;
    public int belt;
    public int knwl;
    public int str;
    public int dex;
    public int[] weapon;
    public int[] yinyangcard;
    public bool maimed = false;
    public bool yinyangrevover = false;
    public bool kara = false;
    public bool sava = false;
    public bool kung = false;
    public bool taek = false;
    public bool prok = false;
    public bool judd = false;
    public bool ninj = false;
    public bool aiki = false;
    public string name;
    public string message;
    public int op;
    public Player(int playNo) {
        this.playerNo = playNo;
        pos = playNo * 14 + 1;
        dojopos = pos;
        chip = 0;
        belt = 0;
        knwl = 0;
        str = 0;
        dex = 0;
        weapon = new int[] { 0, 0, 0, 0, 0 };
        yinyangcard = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    }
    public void act() {
        if(!Main.list[Main.current].com){
            rule.rules.gameObject.SetActive(true);
        }
        if (pos > 56) {
            study = true;
        }
        else {
            study = false;
        }
        if (pos >= 5700) {
            form(pos);
        }
        else {
            Main.button = Main.list[Main.current].name + "'s turn";
            if (maimed) {
                maimed = false;
                Main.message = Main.list[Main.current].name + "was maimed";
                hospital.hospitals.show();
            }
            else {
                yinyangrevover = false;
                //
                yinyanglist.yinyanglists.show();
                Roll._Instance.show();
                if (com) {
                    if (yinyangcard[7] >= 1 && yinyangcard[8] >= 1 && str == 50 && dex == 50 && knwl == 50 && belt == 4 && weapon[4] >= 3) {
                        yinyanglist.yinyanglists.challenge();
                    }else{
                        if (yinyangcard[4] > 0) {
                            yinyanglist.yinyanglists.thunder();
                        }else{
                            Roll._Instance.dieroll();
                        }
                        
                    }
                }
            }
        }
    }
    public void actafter(int die) {
        rule.rules.gameObject.SetActive(false);
        Roll._Instance.done();
        Roll._Instance.gameObject.SetActive(false);
        if ((pos == 3 || pos == 17 || pos == 31 || pos == 45) && (yinyangcard[1] > 0)) {
            yinyangcard[1] -= 1;
            yinyangrevover = true;
            Main.message = "QUICK RECOVER!";
        }
        if ((pos == 3 || pos == 17 || pos == 31 || pos == 45) && (die % 2 == 0) && (!yinyangrevover)) {
            Main.message = Main.list[Main.current].name + " got stuck in hospital";
            //stuck in hospital
            hospital.hospitals.show();
        }
        else {
            if (study) die = (die + 2) / 3;
            int newpos = pos + die;
            if (newpos > 56 && newpos <= 100) {
                newpos -= 56;
            }
            if (newpos > 609 && newpos < 615) {
                newpos = 10;
                Main.message = name + " learnt Karate successfully! Belt level up! Got 4 chips!";
                kara = true;
                belt += 1;
                if (belt > 4) belt = 4;
                chip += 4;
            }
            if (newpos > 1205 && newpos < 1211) {
                newpos = 18;
                Main.message = name + " learnt Savate successfully! Belt level up! Got 3 chips!";
                sava = true;
                belt += 1;
                if (belt > 4) belt = 4;
                chip += 3;
            }
            if (newpos > 2013 && newpos < 2019) {
                newpos = 52;
                Main.message = name + " learnt Kungfu successfully! Belt level up! Got 5 chips!";
                kung = true;
                belt += 1;
                if (belt > 4) belt = 4;
                chip += 5;
            }
            if (newpos > 2605 && newpos < 2611) {
                newpos = 32;
                Main.message = name + " learnt Tae Kwon successfully! Belt level up! Got 3 chips!";
                taek = true;
                belt += 1;
                if (belt > 4) belt = 4;
                chip += 3;
            }
            if (newpos > 3409 && newpos < 3415) {
                newpos = 38;
                Main.message = name + " learnt Pro-Kick Boxing successfully! Belt level up! Got 6 chips!";
                prok = true;
                belt += 1;
                if (belt > 4) belt = 4;
                chip += 4;
            }
            if (newpos > 4005 && newpos < 4011) {
                newpos = 46;
                Main.message = name + " learnt Judo successfully! Belt level up! Got 3 chips!";
                judd = true;
                belt += 1;
                if (belt > 4) belt = 4;
                chip += 3;
            }
            if (newpos > 4813 && newpos < 4819) {
                newpos = 24;
                Main.message = name + " learnt Ninjitsu successfully! Belt level up! Got 5 chips!";
                ninj = true;
                belt += 1;
                if (belt > 4) belt = 4;
                chip += 5;
            }
            if (newpos > 5405 && newpos < 5411) {
                newpos = 4;
                Main.message = name + " learnt Aikido successfully! Belt level up! Got 3 chips!";
                aiki = true;
                belt += 1;
                if (belt > 4) belt = 4;
                chip += 3;
            }
            move(pos, newpos);

        }
        yinyangrevover = false;
    }

    public void move(int pos1, int pos2) {
        //
        pos = pos2;
        if (Main.current == 0) { blue.blueplayer.Move(); }
        if (Main.current == 1) { green.greenplayer.Move(); }
        if (Main.current == 2) { black.blackplayer.Move(); }
        if (Main.current == 3) { red.redplayer.Move(); }

    }
    public void afterMove() {
        form(pos);
    }

    public void form(int pos) {
        switch (pos) {
            case 1://dojo
            case 15:
            case 29:
            case 43: {
                    Main.message = "dojo";
                    dojo.dojos.show();
                    break;
                }
            case 2://yinyang
            case 16:
            case 30:
            case 44:
            case 604:
            case 3404: {
                    Main.message = "Yin Yang";
                    yingyang.yinyang.show();
                    break;
                }
            case 3://hospital
            case 17:
            case 31:
            case 45: {
                    Main.message = "Hospital";
                    hospital.hospitals.show();
                    //
                    break;
                }
            case 4: {
                    Main.message = "Aikido finished";
                    aikido.ai.gameObject.SetActive(true);
                    aikido.ai.done();
                    break;
                }

            case 18: {
                    Main.message = "Savate finished";
                    savate.s.gameObject.SetActive(true);
                    savate.s.done();
                    break;
                }
            case 32: {
                    Main.message = "Tae Kwon finished";
                    tae.ta.gameObject.SetActive(true);
                    tae.ta.done();
                    break;
                }
            case 46: {
                    Main.message = "Judo finished";
                    judo.j.gameObject.SetActive(true);
                    judo.j.done();
                    break;
                }
            case 5://equipment
            case 19:
            case 33:
            case 47:
            case 2012:
            case 4812: {
                    Main.message = "Equipment";
                    shop.shops.show();
                    break;
                }
            case 6:
                Main.message = "KARATA";
                //KARATE
                karate.k.show();
                break;
            case 601: {
                    Main.message = "Unstable Stance DEX + 5";
                    karate.k.gameObject.SetActive(true);
                    dex += 5;
                    if (dex > 50) dex = 50;
                    karate.k.done();
                    break;
                }
            case 602: {
                    Main.message = "Quick Backfist KNWL + 10";
                    karate.k.gameObject.SetActive(true);
                    knwl += 10;
                    if (knwl > 50) knwl = 50;
                    karate.k.done();
                    break;
                }
            case 603: {
                    Main.message = "KUMI DACHE STR + 15";
                    karate.k.gameObject.SetActive(true);

                    str += 15;
                    if (str > 50) str = 50;
                    karate.k.done();
                    break;
                }

            case 605: {
                    Main.message = "ZEN KNWL + 25";
                    karate.k.gameObject.SetActive(true);
                    knwl += 25;
                    if (knwl > 50) knwl = 50;
                    karate.k.done();
                    break;
                }
            case 606: {
                    Main.message = name + " injured himself!";
                    karate.k.gameObject.SetActive(true);
                    Main.list[Main.current].pos = 17;
                    karate.k.done();
                    break;
                }
            case 607: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "BACK HAND STR x2";
                        str *= 2;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "BACK HAND DEX x2";
                        dex *= 2;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "BACK HAND KNWL x2";
                        knwl *= 2;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    karate.k.gameObject.SetActive(true);
                    karate.k.done();
                    break;
                }

            case 609: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "WICKED SIDEKICK STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "WICKED SIDEKICK DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "WICKED SIDEKICK KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    karate.k.gameObject.SetActive(true);
                    karate.k.done();
                    break;
                }
            case 20:
                Main.message = "KUNG FU";
                //KUNG FU
                kungfu.kf.show();
                break;
            case 2001: {
                    Main.message = "Poor Focus KNWL + 5";
                    kungfu.kf.gameObject.SetActive(true);
                    knwl += 5;
                    if (knwl > 50) knwl = 50;
                    kungfu.kf.done();
                    break;
                }
            case 2002: {
                    Main.message = "Perfect Form DEX + 20";
                    kungfu.kf.gameObject.SetActive(true);
                    dex += 20;
                    if (dex > 50) dex = 50;
                    kungfu.kf.done();
                    break;
                }
            case 2003: {
                    Main.message = "Body is Defined STR + 30";
                    kungfu.kf.gameObject.SetActive(true);
                    str += 30;
                    if (str > 50) str = 50;
                    kungfu.kf.done();
                    break;
                }
            case 2004: {
                    Main.message = "Zen Medition KNWL + 30";
                    kungfu.kf.gameObject.SetActive(true);
                    knwl += 30;
                    if (knwl > 50) knwl = 50;
                    kungfu.kf.done();
                    break;
                }
            case 2005: {
                    Main.message = name + " injured himself!";
                    kungfu.kf.gameObject.SetActive(true);
                    Main.list[Main.current].pos = 31;
                    kungfu.kf.done();
                    break;
                }
            case 2006: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Dragon Style STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Dragon Style DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Dragon Style KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    kungfu.kf.gameObject.SetActive(true);
                    kungfu.kf.done();
                    break;
                }

            case 2008: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Monkey Form STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Monkey Form DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Monkey Form KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    kungfu.kf.gameObject.SetActive(true);
                    kungfu.kf.done();
                    break;
                }
            case 2009: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Snake Type STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Snake Type DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Snake Type KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    kungfu.kf.gameObject.SetActive(true);
                    kungfu.kf.done();
                    break;
                }
            case 2010: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Tiger Claw STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Tiger Claw DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Tiger Claw KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    kungfu.kf.gameObject.SetActive(true);
                    kungfu.kf.done();
                    break;
                }
            case 2011: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Swift Crane STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Swift Crane DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Swift Crane KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    kungfu.kf.gameObject.SetActive(true);
                    kungfu.kf.done();
                    break;
                }

            case 2013: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Patience Deserved STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Patience Deserved DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Patience Deserved KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    kungfu.kf.gameObject.SetActive(true);
                    kungfu.kf.done();
                    break;
                }
            case 34:
                Main.message = "PRO KICK";
                prokick.pk.show();
                //PROKICK
                break;
            case 3401: {
                    Main.message = "Down Round 1 KNWL + 5";
                    prokick.pk.gameObject.SetActive(true);
                    knwl += 5;
                    if (knwl > 50) knwl = 50;
                    prokick.pk.done();
                    break;
                }
            case 3402: {
                    Main.message = "Fast Blocks DEX + 10";
                    prokick.pk.gameObject.SetActive(true);
                    dex += 10;
                    if (dex > 50) dex = 50;
                    prokick.pk.done();
                    break;
                }
            case 3403: {
                    Main.message = "Body Blows STR + 15";
                    prokick.pk.gameObject.SetActive(true);
                    str += 15;
                    if (str > 50) str = 50;
                    prokick.pk.done();
                    break;
                }

            case 3405: {
                    Main.message = "Power Hook STR + 25";
                    prokick.pk.gameObject.SetActive(true);
                    str += 25;
                    if (str > 50) str = 50;
                    prokick.pk.done();
                    break;
                }
            case 3406: {
                    Main.message = name + " injured himself!";
                    prokick.pk.gameObject.SetActive(true);
                    Main.list[Main.current].pos = 45;
                    prokick.pk.done();
                    break;
                }
            case 3407: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "KO Rival STR x2";
                        str *= 2;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "KO Rival DEX x2";
                        dex *= 2;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "KO Rival KNWL x2";
                        knwl *= 2;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    prokick.pk.gameObject.SetActive(true);
                    prokick.pk.done();
                    break;
                }

            case 3409: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Rated #1 STR x2";
                        str *= 2;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Rated #1 DEX x2";
                        dex *= 2;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Rated #1 KNWL x2";
                        knwl *= 2;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    prokick.pk.gameObject.SetActive(true);
                    prokick.pk.done();
                    break;
                }
            case 48:
                Main.message = "NINJITSU";
                //NINJITSU
                ninjitsu.n.show();
                break;
            case 4801: {
                    Main.message = "TAIHENJUTSU DEX + 5";
                    ninjitsu.n.gameObject.SetActive(true);
                    dex += 5;
                    if (dex > 50) dex = 50;
                    ninjitsu.n.done();
                    break;
                }
            case 4802: {
                    Main.message = "JUTAIJUTSU KNWL + 20";
                    ninjitsu.n.gameObject.SetActive(true);
                    knwl += 20;
                    if (knwl > 50) knwl = 50;
                    ninjitsu.n.done();
                    break;
                }
            case 4803: {
                    Main.message = "Pass Strength Test STR + 30";
                    ninjitsu.n.gameObject.SetActive(true);
                    str += 30;
                    if (str > 50) str = 50;
                    ninjitsu.n.done();
                    break;
                }
            case 4804: {
                    Main.message = "Balance On Wire DEX + 30";
                    ninjitsu.n.gameObject.SetActive(true);
                    dex += 30;
                    if (dex > 50) dex = 50;
                    ninjitsu.n.done();
                    break;
                }
            case 4805: {
                    Main.message = name + " injured himself!";
                    ninjitsu.n.gameObject.SetActive(true);
                    Main.list[Main.current].pos = 3;
                    ninjitsu.n.done();
                    break;
                }
            case 4806: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Fire Response STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Fire Response DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Fire Response KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    ninjitsu.n.gameObject.SetActive(true);
                    ninjitsu.n.done();
                    break;
                }

            case 4808: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Water Response STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Water Response DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Water Response KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    ninjitsu.n.gameObject.SetActive(true);
                    ninjitsu.n.done();
                    break;
                }
            case 4809: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Earth Response STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Earth Response DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Earth Response KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    ninjitsu.n.gameObject.SetActive(true);
                    ninjitsu.n.done();
                    break;
                }
            case 4810: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Wind Response STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Wind Response DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Wind Response KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    ninjitsu.n.gameObject.SetActive(true);
                    ninjitsu.n.done();
                    break;
                }
            case 4811: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "GONTOPO Invisible STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "GONTOPO Invisible DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "GONTOPO Invisible KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    ninjitsu.n.gameObject.SetActive(true);
                    ninjitsu.n.done();
                    break;
                }
            case 4813: {
                    int a = Random.Range(0, 3);
                    if (a == 0) {
                        Main.message = "Cut-in Perfect STR x3";
                        str *= 3;
                        if (str > 50) {
                            str = 50;
                        }
                    }
                    else if (a == 1) {
                        Main.message = "Cut-in Perfect DEX x3";
                        dex *= 3;
                        if (dex > 50) {
                            dex = 50;
                        }
                    }
                    else if (a == 2) {
                        Main.message = "Cut-in Perfect KNWL x3";
                        knwl *= 3;
                        if (knwl > 50) {
                            knwl = 50;
                        }
                    }
                    ninjitsu.n.gameObject.SetActive(true);
                    ninjitsu.n.done();
                    break;
                }


            case 7://assassian
            case 21:
            case 35:
            case 49: {
                    Main.message = "ASSASSIAN";
                    //
                    assassin.assassins.show();
                    break;
                }
            case 8://tournament
            case 22:
            case 36:
            case 50: {
                    Main.message = "tournament";
                    //
                    tournament.tour.show();
                    break;
                }
            case 9://college gym iron
            case 37: {
                    Main.message = "college";
                    //
                    //knwl += roll();
                    college.colleges.show();
                    break;
                }
            case 23: {
                    Main.message = "iron";
                    //str += roll();
                    iron.irons.show();
                    break;
                }
            case 51: {
                    Main.message = "gym";
                    //dex += roll();
                    gym.gyms.show();
                    break;
                }
            case 10: {
                    Main.message = "Karate finished";
                    karate.k.gameObject.SetActive(true);
                    karate.k.done();
                    break;
                }
            case 24: {
                    Main.message = "Kung Fu finished";
                    kungfu.kf.gameObject.SetActive(true);
                    kungfu.kf.done();
                    break;
                }
            case 38: {
                    Main.message = "Pro-Kick Boxing finished";
                    prokick.pk.gameObject.SetActive(true);
                    prokick.pk.done();
                    break;
                }
            case 52: {
                    Main.message = "Ninjitsu finished";
                    ninjitsu.n.gameObject.SetActive(true);
                    ninjitsu.n.done();
                    break;
                }
            case 11://goto dojo
            case 25:
            case 39:
            case 53: {
                    Main.message = "goto dojo";
                    gotodojo.gotodojos.show();
                    break;
                }
            case 12://SAVATE
                Main.message = "SAVATE";
                savate.s.show();
                break;
            case 1201: {
                    Main.message = "Lost In Thought KNWL + 5";
                    savate.s.gameObject.SetActive(true);
                    knwl += 5;
                    if (knwl > 50) knwl = 50;
                    savate.s.done();
                    break;
                }
            case 1202: {
                    Main.message = "Good Balance DEX + 10";
                    savate.s.gameObject.SetActive(true);
                    dex += 10;
                    if (dex > 50) dex = 50;
                    savate.s.done();
                    break;
                }
            case 1203: {
                    Main.message = "Flexing Stretch STR + 15";
                    savate.s.gameObject.SetActive(true);
                    str += 15;
                    if (str > 50) str = 50;
                    savate.s.done();
                    break;
                }
            case 1204: {
                    Main.message = "Timed Sweeps DEX + 10";
                    savate.s.gameObject.SetActive(true);
                    dex += 10;
                    if (dex > 50) dex = 50;
                    savate.s.done();
                    break;
                }
            case 1205: {
                    Main.message = "Solid Blocking KNWL + 15";
                    savate.s.gameObject.SetActive(true);
                    knwl += 15;
                    if (knwl > 50) knwl = 50;
                    savate.s.done();
                    break;
                }
            case 26://TAEKWON
                Main.message = "TAEKWON";
                tae.ta.show();
                break;
            case 2601: {
                    Main.message = "Sloppy Balance KNWL + 5";
                    tae.ta.gameObject.SetActive(true);
                    knwl += 5;
                    if (knwl > 50) knwl = 50;
                    tae.ta.done();
                    break;
                }
            case 2602: {
                    Main.message = "Great Toss DEX + 10";
                    tae.ta.gameObject.SetActive(true);
                    dex += 10;
                    if (dex > 50) dex = 50;
                    tae.ta.done();
                    break;
                }
            case 2603: {
                    Main.message = "Body Drills STR + 15";
                    tae.ta.gameObject.SetActive(true);
                    str += 15;
                    if (str > 50) str = 50;
                    tae.ta.done();
                    break;
                }
            case 2604: {
                    Main.message = "Take Down DEX + 10";
                    tae.ta.gameObject.SetActive(true);
                    dex += 10;
                    if (dex > 50) dex = 50;
                    tae.ta.done();
                    break;
                }
            case 2605: {
                    Main.message = "Fast Kick KNWL + 15";
                    tae.ta.gameObject.SetActive(true);
                    knwl += 15;
                    if (knwl > 50) knwl = 50;
                    tae.ta.done();
                    break;
                }
            case 40://JUDO
                Main.message = "JUDO";
                judo.j.show();
                break;
            case 4001: {
                    Main.message = "Real Bad Form DEX + 5";
                    dex += 5;
                    if (dex > 50) dex = 50;
                    judo.j.gameObject.SetActive(true);
                    judo.j.done();
                    break;
                }
            case 4002: {
                    Main.message = "Break-Fall KNWL + 10";
                    knwl += 10;
                    if (knwl > 50) knwl = 50;
                    judo.j.gameObject.SetActive(true);
                    judo.j.done();
                    break;
                }

            case 4003: {
                    Main.message = "Work-Out STR + 15";
                    str += 15;
                    if (str > 50) str = 50;
                    judo.j.gameObject.SetActive(true);
                    judo.j.done();
                    break;
                }
            case 4004: {
                    Main.message = "UCHI MATA KNWL + 10";
                    knwl += 10;
                    if (knwl > 50) knwl = 50;
                    judo.j.gameObject.SetActive(true);
                    judo.j.done();
                    break;
                }
            case 4005: {
                    Main.message = "Demand Effort DEX + 15";
                    dex += 15;
                    if (dex > 50) dex = 50;
                    judo.j.gameObject.SetActive(true);
                    judo.j.done();
                    break;
                }

            case 54://AIKIDO
                Main.message = "AIKIDO";
                aikido.ai.show();
                break;
            case 5401: {
                    Main.message = "Weak Stance DEX + 5";
                    dex += 5;
                    if (dex > 50) dex = 50;
                    aikido.ai.gameObject.SetActive(true);
                    aikido.ai.done();
                    break;
                }
            case 5402: {
                    Main.message = "Shino Nage KNWL + 10";
                    knwl += 10;
                    if (knwl > 50) knwl = 50;
                    aikido.ai.gameObject.SetActive(true);
                    aikido.ai.done();
                    break;
                }
            case 5403: {
                    Main.message = "Tough Train STR + 15";
                    str += 15;
                    if (str > 50) str = 50;
                    aikido.ai.gameObject.SetActive(true);
                    aikido.ai.done();
                    break;
                }
            case 5404: {
                    Main.message = "Koshi Nage KNWL + 10";
                    knwl += 10;
                    if (knwl > 50) knwl = 50;
                    aikido.ai.gameObject.SetActive(true);
                    aikido.ai.done();
                    break;
                }
            case 5405: {
                    Main.message = "Tight Nikkyo DEX + 15";
                    dex += 15;
                    if (dex > 50) dex = 50;
                    aikido.ai.gameObject.SetActive(true);
                    aikido.ai.done();
                    break;
                }
            case 13://urgent
            case 27:
            case 41:
            case 55:
            case 608:
            case 2007:
            case 3408:
            case 4807: {
                    Main.message = "urgent";
                    //
                    urgent.urgents.show();
                    break;
                }
            case 14://train chip
            case 28:
            case 42:
            case 56: {
                    Main.message = "Train and get 2 chips";
                    //
                    train.trains.show();
                    break;
                }
            case 5701: {
                    Main.message = "Water Stage!";
                    labyrinth.laby.show();
                    break;
                }
            case 5702: {
                    Main.message = "Earth Stage!";
                    labyrinth.laby.show();
                    break;
                }
            case 5703: {
                    Main.message = "Wind Stage!";
                    labyrinth.laby.show();
                    break;
                }
            case 5704: {
                    Main.message = "Fire Stage!";
                    labyrinth.laby.show();
                    break;
                }
            case 5705: {
                    Main.message = "Grand Master Stage!";
                    labyrinth.laby.show();
                    break;
                }



        }

    }
    public void formafter() {
        //street fight
        if (pos != 1 && pos != 15 && pos != 29 && pos != 43 && pos != 3 && pos != 17 && pos != 31 && pos != 45 && pos <= 56) {
            int p = Main.current + 1;
            if (p >= 4) p -= 4;
            int p2 = Main.current + 2;
            if (p2 >= 4) p2 -= 4;
            int p3 = Main.current + 3;
            if (p3 >= 4) p3 -= 4;
            if (pos == Main.list[p].pos) {
                streetfight(Main.current, p);
            }
            else if (pos == Main.list[p2].pos) {
                streetfight(Main.current, p2);
            }
            else if (pos == Main.list[p3].pos) {
                streetfight(Main.current, p3);
            }
            else {
                if (!Main.gameover) {
                    next();
                }
                else {
                    Main.message = name + " becomes new Grand Master!";
                }
            }
        }
        else {
            if (!Main.gameover) {
                if (pos > 56) {
                    study = true;
                }
                else {
                    study = false;
                }
                next();
            }
            else {
                Main.message = name + " becomes new Grand Master!";
            }
        }
    }
    public void streetfight(int f1, int f2) {
        Main.message = Main.list[f1].name + " come across " + Main.list[f2].name + " on street!";
        op = f2;
        combat.combats.streetfight = true;
        combat.combats.makefight(f1, f2, true);
    }


    public void streetafter(int winner) {

        if (winner == Main.current) {
            Main.message = name + " robbed " + Main.list[op].name + " on street!";
            if (Main.list[op].chip >= 2) {
                Main.list[op].chip -= 2;
                chip += 2;
            }
            else if (Main.list[op].chip >= 1) {
                Main.list[op].chip -= 1;
                chip += 1;
            }
        }
        else if (winner == op) {
            Main.message = Main.list[op].name + " robbed " + name + " on street!";
            if (chip >= 2) {
                chip -= 2;
                Main.list[op].chip += 2;
            }
            else if (chip >= 1) {
                chip -= 1;
                Main.list[op].chip += 1;
            }
        }
        else {
            Main.message = name + " and " + Main.list[op].name + " both got injured on street!";
        }
        op = -1;
        next();
    }
    public void next() {
        Main.current += 1;
        if (Main.current > 3) {
            Main.current -= 4;
        }
        Main.list[Main.current].act();
    }

    public void gohosp() {
        if ((pos >= 1 && pos <= 3) || (pos >= 46 && pos <= 56) || (pos >= 5400 && pos < 5499) || (pos >= 4800 && pos < 4899)) pos = 3;
        if (pos >= 4 && pos <= 17 || (pos >= 600 && pos < 699) || (pos >= 1200 && pos < 1299)) pos = 17;
        if (pos >= 18 && pos <= 31 || (pos >= 2000 && pos < 2099) || (pos >= 2600 && pos < 2699) || pos >= 5700) pos = 31;
        if (pos >= 32 && pos <= 45 || (pos >= 3400 && pos < 3499) || (pos >= 4000 && pos < 4099)) pos = 45;
    }
    public int level() {
        int a = belt * 20 + str + dex + knwl + chip + 2 * weapon[0] + 4 * weapon[1] + 6 * weapon[2] + 8 * weapon[3] + 10 * weapon[4];
        if (com) a /= 2;
        return a;
    }


}



