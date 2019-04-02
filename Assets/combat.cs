using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/** 
* class combat
*       control combat procession
* author: mark
*/
public class combat : MonoBehaviour {
    public GameObject left;
    public GameObject right;
    public GameObject leftboompic;
    public GameObject rightboompic;
    public GameObject bothboompic;
    public GameObject leftweapon;
    public GameObject rightweapon;
    public Transform leftpos;
    public Transform rightpos;
    public Transform leftattackpos;
    public Transform rightattackpos;
        public Transform leftweaponposo;
    public Transform rightweaponposo;
    public Transform leftweaponpos;
    public Transform rightweaponpos;
    public bool leftattacking=false;
    public bool rightattacking=false;
    public bool leftkoing = false;
    public bool rightkoing = false;
    public bool leftweaponing = false;
    public bool rightweaponing = false;
    public Sprite opsprite;

    public Sprite w4;
    public Sprite w6;
    public Sprite w8;
    public Sprite w10;
    public Sprite w12;

    public SpriteRenderer leftspr;
    public SpriteRenderer leftweaponspr;
    public SpriteRenderer rightspr;
    public SpriteRenderer rightweaponspr;
    public static combat combats;
    private bool waitforclick = false;
    public int p1 = -1;
    public int p2 = -1;
    public string p1name;
    public string p2name;
    public int fight1 = 0;
    public int fight2 = 0;
    public bool dojofight = false;
    public bool tourmatch2fight = false;
    public bool tourmatch1fight = false;
    public bool tourmatch3fight = false;
    public bool tourmatch32fight = false;
    public bool tourmatch33fight = false;
    public bool tourmatch4fight = false;
    public bool tourmatch42fight = false;
    public bool tourmatch43fight = false;
    public bool streetfight = false;
    public bool npcstreetfight = false;
    public bool assassinfight = false;
    public bool npcfight = false;
    public bool labyfight = false;
    public bool weaponallow = false;
    public int weaponpower = 0;
    public bool doubleatk = false;
    public int round = 0;
    public bool leftboom = false;
    public bool rightboom = false;
    public int winner;
    public bool leftover = false;
    public bool leftinjured = false;
    public bool rightover = false;
    public bool rightinjured = false;
    public bool waitnpc;
    public bool npcattack = false;
    public bool left10 = false;
    public bool right10 = false;
    public bool startwait = false;
    public int[] npcatk = { 0,0,0,0,22, 29, 22, 7, 10, 12, 10, 20,
        20, 27, 23, 5, 4, 9, 12, 19,
        23, 15, 17, 17, 14, 20, 18, 20,
        10, 7, 4, 25, 22, 29, 28, 15,
        23, 18, 18, 26, 23, 21, 15, 5 };
    public string[] npcname = { "","","","",
    "CHEN DIMA","SANDFORD TUEY","BUCK MORRIS","KGB Agent Zorkov","Sly Guy","Sloppi Story","Twy ME Now","The TONFA",
    "JASON \"The JET\" QUAN","MOUNTAIN WARRIOR","LEI TOU YEN","Constable Armers", "Sugar Boy Blizter","Howard Hardkicker","Lyn Sinn","KADO",
    "CITY BOY TARROR","Harlun","Jioris","MANCO","Horvath (HITMAN) Lugan","UNKNOWN","KiyoSHI","DEREK NORTH",
    "Zeek Di Whey","Stan \"the Strangler\"","IGY FUNK", "RONIN WARRIOR", "CHARLES JERVEC","GRANDMASTER","WHITE NINJA","ISAS",
    "TY YUNG","Soldier of Fortune","PVT WALKER 717-909-230", "EVIL NINJA","CHAN","SS VON ADOLF","Why Me ONG","Mohamed Sharit"};
    // Use this for initialization
    void Awake() {
        combats = this;
        this.gameObject.SetActive(false);
        w4 = Resources.Load("4w", typeof(Sprite)) as Sprite;
        w6 = Resources.Load("6w", typeof(Sprite)) as Sprite;
        w8 = Resources.Load("8w", typeof(Sprite)) as Sprite;
        w10 = Resources.Load("10w", typeof(Sprite)) as Sprite;
        w12 = Resources.Load("12w", typeof(Sprite)) as Sprite;
        leftspr = left.GetComponent<SpriteRenderer>();
        rightspr = right.GetComponent<SpriteRenderer>();
        leftweaponspr = leftweapon.GetComponent<SpriteRenderer>();
        rightweaponspr = rightweapon.GetComponent<SpriteRenderer>();
        leftboompic.gameObject.SetActive(false);
        rightboompic.gameObject.SetActive(false);
        bothboompic.gameObject.SetActive(false);
        leftweapon.gameObject.SetActive(false);
        rightweapon.gameObject.SetActive(false);

    }
    public void show() {
        this.gameObject.SetActive(true);
        //SpriteRenderer spr = left.GetComponent<SpriteRenderer>();
        //spr.sprite = Resources.Load("op", typeof(Sprite)) as Sprite;


        startwait = true;
    }
    public void startw() {
        rightover = true;
    }

    public void makefight(int pl1, int pl2, bool weapon) {
        p1 = pl1;
        p1name = Main.list[pl1].name;
        leftspr.sprite = Resources.Load(p1+"-"+Main.list[p1].belt, typeof(Sprite)) as Sprite;
        p2 = pl2;
        if (p2 >= 4) {
            p2name = npcname[p2];
            //////

            rightspr.sprite = Resources.Load("" + p2, typeof(Sprite)) as Sprite;
        }
        else {
            p2name = Main.list[p2].name;

            rightspr.sprite = Resources.Load(p2+"-"+Main.list[p2].belt, typeof(Sprite)) as Sprite;
        }

        weaponallow = weapon;
        left.transform.forward = Vector3.forward;
        right.transform.forward = Vector3.forward;
        show();
    }


    public void leftfight() {
        if (round >= 4 && (fight1 != fight2 || leftboom || rightboom)) {
            //victory
            if (leftboom && rightboom) {
                Main.message = p1name + " and " + p2name + " both injured!";
                winner = -1;
            }
            else if ((fight1 > fight2 && !leftboom) || rightboom) {
                Main.message = p1name + " win !";
                winner = p1;
            }
            else if ((fight1 < fight2 && !rightboom) || leftboom) {
                Main.message = p2name + " win !";
                winner = p2;
            }
            done();
        }
        else if (leftboom) {
            Main.message = p1name + " got injured";

            leftinjured = true;
        }
        else {

            Main.button = p1name + " attack!";
            Main.message = p1name + " attack!";
            weaponpower = 0;

            weaponlist.weaponlists.user = p1;
            weaponlist.weaponlists.show();

            Roll._Instance.leftfight = true;
            Roll._Instance.show();

            if (Main.list[p1].com) {
                if (assassinfight || Main.list[p1].pos == 5705) {
                    weaponlist.weaponlists.doubleatk();
                    weaponlist.weaponlists.debilitate();
                }
                if ((assassinfight || Main.list[p1].pos == 5705) && weaponallow) {
                    if (Main.list[p1].weapon[4] >= 1) {
                        weaponlist.weaponlists.sword();
                    }
                    else if (Main.list[p1].weapon[3] >= 1) {
                        weaponlist.weaponlists.nunchaku();
                    }
                    else if (Main.list[p1].weapon[2] >= 1) {
                        weaponlist.weaponlists.staff();
                    }
                    else if (Main.list[p1].weapon[1] >= 1) {
                        weaponlist.weaponlists.sai();
                    }
                    else if (Main.list[p1].weapon[0] >= 1) {
                        weaponlist.weaponlists.shuriken();
                    }
                }
                Roll._Instance.dieroll();
            }
        }
    }

    public void leftafter(int die) {
        weaponlist.weaponlists.done();
        if (die == 1) {
            Main.message = p1name + " injured himself!";
            //boom anime
            leftboompic.gameObject.SetActive(true);
            if(!leftboom)left.transform.Rotate(Vector3.back * -90);
            leftboom = true;
            if (assassinfight) {
                Main.message += " Assassin exposed! Both got injured!";
                bothboompic.gameObject.SetActive(true);
                if(!rightboom)right.transform.Rotate(Vector3.forward * -90);
                rightboom = true;
            }

        }
        else {
            if (left10 && die == 10) {
                Main.message = p1name + " KO " + p2name + " and send him to hospital!";
                if(!rightboom)right.transform.Rotate(Vector3.forward * -90);
                rightboom = true;
                rightboompic.gameObject.SetActive(true);
                leftkoing = true;
                //KO anime
            }
            else {
                if (die == 10) {
                    left10 = true;
                }
                else {
                    left10 = false;
                }
                if (Main.list[p1].belt > 0) {
                    die += Main.list[p1].belt * 2 - 1;
                }
                if(weaponpower>0){
                    leftweaponing = true;
                }
                die += weaponpower;
                die += (Main.list[p1].str + Main.list[p1].dex + Main.list[p1].knwl) / 30;
                //attack anime
                leftattacking = true;

                weaponpower = 0;
                if (doubleatk) {
                    doubleatk = false;
                    die *= 2;
                }
                Main.message = p1name + " attack " + p2name + " and cause " + die + " damage!";
                fight1 += die;


            }
        }


        leftover = true;

    }
    public void rightfight() {

        if (rightboom) {
            Main.message = p2name + " got injured";
            rightinjured = true;
        }
        else {

            if (p2 > 3) {
                Main.message = p2name + " attack!";
                waitnpc = true;
            }
            else {
                Main.button = p2name + " attack!";
                Main.message = p2name + " attack!";
                weaponpower = 0;

                weaponlist.weaponlists.user = p2;
                weaponlist.weaponlists.show();

                Roll._Instance.rightfight = true;

                Roll._Instance.show();
                //judge if the player is computeristic
                if (Main.list[p2].com) {
                    if (assassinfight || Main.list[p1].pos == 5705) {
                        if (Main.list[p1].yinyangcard[7] > 0) weaponlist.weaponlists.doubleatk();
                        if (Main.list[p1].yinyangcard[8] > 0) weaponlist.weaponlists.debilitate();
                    }
                    //judge if weapon is allowed
                    if ((assassinfight || Main.list[p2].pos == 5705) && weaponallow) {
                        //choose strongest weapon
                        if (Main.list[p2].weapon[4] >= 1) {
                            weaponlist.weaponlists.sword();
                        }
                        else if (Main.list[p2].weapon[3] >= 1) {
                            weaponlist.weaponlists.nunchaku();
                        }
                        else if (Main.list[p2].weapon[2] >= 1) {
                            weaponlist.weaponlists.staff();
                        }
                        else if (Main.list[p2].weapon[1] >= 1) {
                            weaponlist.weaponlists.sai();
                        }
                        else if (Main.list[p2].weapon[0] >= 1) {
                            weaponlist.weaponlists.shuriken();
                        }
                    }
                    //automatically roll the die
                    Roll._Instance.dieroll();
                }
            }
        }
    }

    public void rightafter(int die) {
        weaponlist.weaponlists.done();
        if (die == 1) {
            Main.message = p2name + " injured himself!";
            if(!rightboom)right.transform.Rotate(Vector3.forward * -90);
            rightboompic.gameObject.SetActive(true);
            //boom anime
            rightboom = true;
            if (assassinfight) {
                Main.message += " Assassin exposed! Both got injured!";
                if(!leftboom)left.transform.Rotate(Vector3.back * -90);
                bothboompic.gameObject.SetActive(true);
                leftboom = true;
            }
            rightover = true;
        }
        else {
            if (right10 && die == 10) {
                Main.message = p2name + " KO " + p1name + " and send him to hospital!";
                leftboom = true;
                if(!leftboom)left.transform.Rotate(Vector3.back * -90);
                leftboompic.gameObject.SetActive(true);
                rightkoing = true;
                //KO anime
            }
            else {
                if (p2 < 4 && die == 10) {
                    right10 = true;
                }
                else {
                    right10 = false;
                }
                if (p2 < 4) {
                    die += (Main.list[p2].str + Main.list[p2].dex + Main.list[p2].knwl) / 30;
                }
                if (p2 < 4 && Main.list[p2].belt > 0) {
                    die += Main.list[p2].belt * 2 - 1;

                }
                if(weaponpower>0){
                    rightweaponing = true;                    
                }
                die += weaponpower;
                if (doubleatk) {
                    doubleatk = false;
                    die *= 2;
                }
                //attack anime
                rightattacking = true;
                weaponpower = 0;
                Main.message = p2name + " attack " + p1name + " and cause " + die + " damage!";
                fight2 += die;
                
            }


            rightover = true;
        }
    }
    void done() {

        fight1 = 0;
        fight2 = 0;
        round = 0;
        if (leftboom) {
            Main.list[p1].gohosp();
        }
        if (rightboom && p2 < 4) {
            Main.list[p2].gohosp();
        }
        p1 = -1;
        p2 = -1;

        left10 = false;
        right10 = false;
        if (leftboom) {
            //left.transform.Rotate(Vector3.forward * -90);
            //left.transform.forward=Vector3.back;
            leftboom = false;
        }
        if (rightboom) {
            //right.transform.forward = Vector3.forward;
            rightboom = false;
        }
        
        waitforclick = true;
        weaponpower = 0;

    }
    // Update is called once per frame
    void Update() {
        if (leftkoing) {
            left.transform.position = Vector3.MoveTowards(left.transform.position, leftweaponpos.position, 30f * Time.deltaTime);
        }
        if (leftattacking) {
            left.transform.position = Vector3.MoveTowards(left.transform.position, leftattackpos.position, 20f * Time.deltaTime);
        }
        if (!leftattacking&&!leftkoing) {
            left.transform.position = Vector3.MoveTowards(left.transform.position, leftpos.position, 50f * Time.deltaTime);
        }

        if (rightkoing) {
            right.transform.position = Vector3.MoveTowards(right.transform.position, rightweaponpos.position, 30f * Time.deltaTime);
        }
        if (rightattacking) {
            right.transform.position = Vector3.MoveTowards(right.transform.position, rightattackpos.position, 20f * Time.deltaTime);
        }
        if (!rightattacking&&!rightkoing) {
            right.transform.position = Vector3.MoveTowards(right.transform.position, rightpos.position, 50f * Time.deltaTime);
        }

        if(leftweaponing){
            leftweapon.transform.Rotate(Vector3.forward * 20f);
            leftweapon.transform.position = Vector3.MoveTowards(leftweapon.transform.position, leftweaponpos.position, 15f * Time.deltaTime);
        }
        if(!leftweaponing){
            leftweapon.transform.position = leftweaponposo.transform.position;
        }
        if(rightweaponing){
            rightweapon.transform.Rotate(Vector3.back * 20f);
            rightweapon.transform.position = Vector3.MoveTowards(rightweapon.transform.position,rightweaponpos.position, 15f * Time.deltaTime);
        }
        if(!rightweaponing){
            rightweapon.transform.position = rightweaponposo.transform.position;
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && dojofight) {
            waitforclick = false;
            dojofight = false;
            this.gameObject.SetActive(false);
            dojo.dojos.afterdojo(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && tourmatch1fight) {
            waitforclick = false;
            tourmatch1fight = false;
            this.gameObject.SetActive(false);
            tournament.tour.match1win(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && tourmatch2fight) {
            waitforclick = false;
            tourmatch2fight = false;
            this.gameObject.SetActive(false);
            tournament.tour.match2win(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && tourmatch3fight) {
            waitforclick = false;
            tourmatch3fight = false;
            this.gameObject.SetActive(false);
            tournament.tour.match3win(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && tourmatch32fight) {
            waitforclick = false;
            tourmatch32fight = false;
            this.gameObject.SetActive(false);
            tournament.tour.match32win(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && tourmatch33fight) {
            waitforclick = false;
            tourmatch33fight = false;
            this.gameObject.SetActive(false);
            tournament.tour.match33win(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && tourmatch4fight) {
            waitforclick = false;
            tourmatch4fight = false;
            this.gameObject.SetActive(false);
            tournament.tour.match4win(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && tourmatch42fight) {
            waitforclick = false;
            tourmatch42fight = false;
            this.gameObject.SetActive(false);
            tournament.tour.match42win(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && tourmatch43fight) {
            waitforclick = false;
            tourmatch43fight = false;
            this.gameObject.SetActive(false);
            tournament.tour.match43win(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && npcstreetfight) {
            waitforclick = false;
            npcstreetfight = false;
            this.gameObject.SetActive(false);
            urgent.urgents.npcfightafter(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && streetfight) {
            waitforclick = false;
            streetfight = false;
            this.gameObject.SetActive(false);
            urgent.urgents.gameObject.SetActive(false);
            Main.list[Main.current].streetafter(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && assassinfight) {
            waitforclick = false;
            assassinfight = false;
            this.gameObject.SetActive(false);
            assassin.assassins.result(winner);
        }
        if (waitforclick && Input.GetMouseButtonDown(0) && labyfight) {
            waitforclick = false;
            labyfight = false;
            this.gameObject.SetActive(false);
            if (winner <= 3) { labyrinth.laby.win(); }
            else { labyrinth.laby.lose(); }
        }
        if (leftover && Input.GetMouseButtonDown(0)) {
            leftover = false;
            leftattacking = false;
            leftkoing = false;
            leftweaponing = false;
            leftweapon.gameObject.SetActive(false);
            leftboompic.gameObject.SetActive(false);
            rightboompic.gameObject.SetActive(false);
            bothboompic.gameObject.SetActive(false);
            rightfight();
        }
        if (rightover && Input.GetMouseButtonDown(0)) {
            rightover = false;
            round += 1;
            rightattacking = false;
            rightkoing = false;
            rightweaponing = false;
            rightweapon.gameObject.SetActive(false);
            leftboompic.gameObject.SetActive(false);
            rightboompic.gameObject.SetActive(false);
            bothboompic.gameObject.SetActive(false);
            leftfight();
        }
        if (npcattack && Input.GetMouseButtonDown(0)) {
            npcattack = false;
            int power = npcatk[p2];
            if (tournament.tour.attendnum > 0) {
                power /= 2;
            }
            rightafter(power);
        }
        if (waitnpc && Input.GetMouseButtonDown(0)) {
            waitnpc = false;
            npcattack = true;
        }
        if (leftinjured && Input.GetMouseButtonDown(0)) {
            leftinjured = false;
            leftover = true;
        }
        if (rightinjured && Input.GetMouseButtonDown(0)) {
            rightinjured = false;
            rightover = true;
        }
        if (startwait && Input.GetMouseButtonDown(0)) {
            startwait = false;
            Main.message = p1name + " VS " + p2name;
            startw();
        }
    }


}
