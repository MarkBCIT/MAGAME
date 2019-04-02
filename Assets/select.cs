using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/** 
* class select
*       select menu
* author: mark
*/
public class select : MonoBehaviour {
    public static select selects;
    public Button button1;
    public Button button2;
    public Text button1text;
    public Text button2text;
    public static bool siron = false;
    public static bool sgym = false;
    public static bool scollege = false;
    public static bool stournament = false;
    public static bool stournament2 = false;
    public static bool sdojo = false;
    public static bool skarate = false;
    public static bool ssavate = false;
    public static bool skungfu = false;
    public static bool stae = false;
    public static bool sprokick = false;
    public static bool sjudo = false;
    public static bool sninjitsu = false;
    public static bool sakido = false;
    public static bool yes = false;
    public static bool no = false;

    public static bool assassinse = false;
    // Use this for initialization
    void Awake() {
        selects = this;
        this.gameObject.SetActive(false);
    }

    public void show() {
        this.gameObject.SetActive(true);
    }
    public void selectyes() {
        yes = true;
    }
    public void selectno() {
        no = true;
    }
    public void done() {
        siron = false;
        sgym = false;
        scollege = false;
        stournament = false;
        stournament2 = false;
        sdojo = false;
        skarate = false;
        ssavate = false;
        skungfu = false;
        stae = false;
        sprokick = false;
        sjudo = false;
        sninjitsu = false;
        sakido = false;
        yes = false;
        no = false;
        assassinse = false;
        button1text.text = "yes";
        button2text.text = "no";
        this.gameObject.SetActive(false);

    }
    // Update is called once per frame
    void Update() {
        if (stournament) {
            button1text.text = "Hold a tournament!";
            button2text.text = "Not hold";
            if (yes) {
                tournament.tour.match();
                done();
            }
            if (no) {
                tournament.tour.nomatch();
                done();
            }
        }
        if (stournament2) {
            button1text.text = "Participate tournament";
            button2text.text = "Not participate";
            if (yes) {
                tournament.tour.accept();
                done();
            }
            if (no) {
                tournament.tour.notaccept();
                done();
            }
        }
        if (siron) {
            button1text.text = "Punch iron!";
            button2text.text = "Save energy...";
            if (yes) {
                if (Main.list[Main.current].chip > 0) {
                    Main.list[Main.current].chip -= 1;
                    iron.irons.startpunch();
                    done();
                }
                else {
                    Main.message = "Too poor!";
                    iron.irons.nopunch();
                    done();
                }
            }
            if (no) {
                Main.message = Main.list[Main.current].name + " doesn't want punch iron...";
                iron.irons.nopunch();
                done();
            }
        }
        if (sgym) {
            button1text.text = "Execrise!";
            button2text.text = "Save energy...";
            if (yes) {
                if (Main.list[Main.current].chip > 0) {
                    Main.list[Main.current].chip -= 1;
                    gym.gyms.startexe();
                    done();
                }
                else {
                    Main.message = "Too poor!";
                    gym.gyms.noexe();
                    done();
                }

            }
            if (no) {
                Main.message = Main.list[Main.current].name + " doesn't want exerices...";
                gym.gyms.noexe();
                done();
            }
        }
        if (sdojo) {

            button1text.text = "Back for a fight!";
            button2text.text = "Give 2 chips...";
            if (yes) {
                dojo.dojos.fight();
                done();
            }
            if (no) {
                if (Main.list[(Main.list[Main.current].pos - 1) / 14].chip < 2) {
                    Main.message = Main.list[(Main.list[Main.current].pos - 1) / 14].name + " have no chips to pay!";
                }
                else {
                    dojo.dojos.giveup();
                    done();
                }

            }
        }
        if (assassinse) {
            button1text.text = "Hire someone by 5 chips";
            button2text.text = "Do it by yourself!";
            if (yes) {
                if (Main.list[Main.current].chip < 5) {
                    Main.message = "Not enough chips!";
                }
                else {
                    assassin.assassins.hire();
                    done();
                }
            }
            if (no) {
                assassin.assassins.self();
                done();
            }
        }
        if (sakido) {
            button1text.text = "Study Aikido with 5 chips";

            button2text.text = "Give up";
            int discount = 0;
            if (Main.list[Main.current].yinyangcard[0] > 0) {
                discount = 2;
                button1text.text = "Study Aikido with 3 chips";
            }
            if (yes) {
                if (Main.list[Main.current].aiki) {
                    Main.message = Main.list[Main.current].name + " has already learnt Aikido";
                }
                else if (Main.list[Main.current].chip < 5 - discount) {
                    Main.message = "Not enough chips!";
                }
                else {
                    Main.list[Main.current].chip -= (5 - discount);
                    if (Main.list[Main.current].yinyangcard[0] > 0) Main.list[Main.current].yinyangcard[0] -= 1;
                    aikido.ai.study();
                    Main.message = Main.list[Main.current].name + " decided to study Aikido!";
                    done();
                }
            }
            if (no) {
                aikido.ai.done();
                Main.message = Main.list[Main.current].name + " don't want to study Aikido...";
                done();
            }
        }
        if (skarate) {
            button1text.text = "Study Karate with 6 chips";
            button2text.text = "Give up";
            int discount = 0;
            if (Main.list[Main.current].yinyangcard[0] > 0) {
                discount = 2;
                button1text.text = "Study Karate with 4 chips";
            }
            if (yes) {
                if (Main.list[Main.current].kara) {
                    Main.message = Main.list[Main.current].name + " has already learnt Karate";
                }
                else if (Main.list[Main.current].chip < 6 - discount) {
                    Main.message = "Not enough chips!";
                }
                else {
                    Main.list[Main.current].chip -= (6 - discount);
                    if (Main.list[Main.current].yinyangcard[0] > 0) Main.list[Main.current].yinyangcard[0] -= 1;
                    karate.k.study();
                    Main.message = Main.list[Main.current].name + " decided to study Karate!";
                    done();
                }
            }
            if (no) {
                karate.k.done();
                Main.message = Main.list[Main.current].name + " don't want to study Karate...";
                done();
            }
        }
        if (ssavate) {
            button1text.text = "Study Savate with 5 chips";
            button2text.text = "Give up";
            int discount = 0;
            if (Main.list[Main.current].yinyangcard[0] > 0) {
                discount = 2;
                button1text.text = "Study Savate with 3 chips";
            }
            if (yes) {
                if (Main.list[Main.current].sava) {
                    Main.message = Main.list[Main.current].name + " has already learnt Savate";
                }
                else if (Main.list[Main.current].chip < 5 - discount) {
                    Main.message = "Not enough chips!";
                }
                else {
                    Main.list[Main.current].chip -= (5 - discount);
                    if (Main.list[Main.current].yinyangcard[0] > 0) Main.list[Main.current].yinyangcard[0] -= 1;
                    savate.s.study();
                    Main.message = Main.list[Main.current].name + " decided to study Savate!";
                    done();
                }
            }
            if (no) {
                savate.s.done();
                Main.message = Main.list[Main.current].name + " don't want to study Savate...";
                done();
            }
        }
        if (skungfu) {
            button1text.text = "Study Kungfu with 10 chips";
            button2text.text = "Give up";
            int discount = 0;
            if (Main.list[Main.current].yinyangcard[0] > 0) {
                discount = 2;
                button1text.text = "Study Kungfu with 8 chips";
            }
            if (yes) {
                if (Main.list[Main.current].kung) {
                    Main.message = Main.list[Main.current].name + " has already learnt Kungfu";
                }
                else if (Main.list[Main.current].chip < 10 - discount) {
                    Main.message = "Not enough chips!";
                }
                else {
                    Main.list[Main.current].chip -= (10 - discount);
                    if (Main.list[Main.current].yinyangcard[0] > 0) Main.list[Main.current].yinyangcard[0] -= 1;
                    kungfu.kf.study();
                    Main.message = Main.list[Main.current].name + " decided to study Kungfu!";
                    done();
                }
            }
            if (no) {
                kungfu.kf.done();
                Main.message = Main.list[Main.current].name + " don't want to study Kungfu...";
                done();
            }
        }
        if (stae) {
            button1text.text = "Study Tae Kwon with 5 chips";
            button2text.text = "Give up";
            int discount = 0;
            if (Main.list[Main.current].yinyangcard[0] > 0) {
                discount = 2;
                button1text.text = "Study Tae Kwon with 3 chips";
            }
            if (yes) {
                if (Main.list[Main.current].taek) {
                    Main.message = Main.list[Main.current].name + " has already learnt Tae Kwon";
                }
                else if (Main.list[Main.current].chip < 5 - discount) {
                    Main.message = "Not enough chips!";
                }
                else {
                    Main.list[Main.current].chip -= (5 - discount);
                    if (Main.list[Main.current].yinyangcard[0] > 0) Main.list[Main.current].yinyangcard[0] -= 1;
                    tae.ta.study();
                    Main.message = Main.list[Main.current].name + " decided to study Tae Kwon!";
                    done();
                }
            }
            if (no) {
                tae.ta.done();
                Main.message = Main.list[Main.current].name + " don't want to study Tae Kwon...";
                done();
            }
        }
        if (sprokick) {
            button1text.text = "Study Pro-Kick Boxing with 6 chips";
            button2text.text = "Give up";
            int discount = 0;
            if (Main.list[Main.current].yinyangcard[0] > 0) {
                discount = 2;
                button1text.text = "Study Pro-Kick Boxing with 4 chips";
            }
            if (yes) {
                if (Main.list[Main.current].prok) {
                    Main.message = Main.list[Main.current].name + " has already learnt Pro-Kick Boxing";
                }
                else if (Main.list[Main.current].chip < 6 - discount) {
                    Main.message = "Not enough chips!";
                }
                else {
                    Main.list[Main.current].chip -= (6 - discount);
                    if (Main.list[Main.current].yinyangcard[0] > 0) Main.list[Main.current].yinyangcard[0] -= 1;
                    prokick.pk.study();
                    Main.message = Main.list[Main.current].name + " decided to study Pro-Kick Boxing!";
                    done();
                }
            }
            if (no) {
                prokick.pk.done();
                Main.message = Main.list[Main.current].name + " don't want to study Pro-Kick Boxing...";
                done();
            }
        }
        if (sjudo) {
            button1text.text = "Study Judo with 5 chips";
            button2text.text = "Give up";
            int discount = 0;
            if (Main.list[Main.current].yinyangcard[0] > 0) {
                discount = 2;
                button1text.text = "Study Judo with 3 chips";
            }
            if (yes) {
                if (Main.list[Main.current].judd) {
                    Main.message = Main.list[Main.current].name + " has already learnt Judo";
                }
                else if (Main.list[Main.current].chip < 5 - discount) {
                    Main.message = "Not enough chips!";
                }
                else {
                    Main.list[Main.current].chip -= (5 - discount);
                    if (Main.list[Main.current].yinyangcard[0] > 0) Main.list[Main.current].yinyangcard[0] -= 1;
                    judo.j.study();
                    Main.message = Main.list[Main.current].name + " decided to study Judo!";
                    done();
                }
            }
            if (no) {
                judo.j.done();
                Main.message = Main.list[Main.current].name + " don't want to study Judo...";
                done();
            }
        }
        if (sninjitsu) {
            button1text.text = "Study Ninjitsu with 10 chips";
            button2text.text = "Give up";
            int discount = 0;
            if (Main.list[Main.current].yinyangcard[0] > 0) {
                discount = 2;
                button1text.text = "Study Ninjitsu with 8 chips";
            }
            if (yes) {
                if (Main.list[Main.current].ninj) {
                    Main.message = Main.list[Main.current].name + " has already learnt Ninjitsu";
                }
                else if (Main.list[Main.current].chip < 10 - discount) {
                    Main.message = "Not enough chips!";
                }
                else {
                    Main.list[Main.current].chip -= (10 - discount);
                    if (Main.list[Main.current].yinyangcard[0] > 0) Main.list[Main.current].yinyangcard[0] -= 1;
                    ninjitsu.n.study();
                    Main.message = Main.list[Main.current].name + " decided to study Ninjitsu!";
                    done();
                }
            }
            if (no) {
                ninjitsu.n.done();
                Main.message = Main.list[Main.current].name + " don't want to study Ninjitsu...";
                done();
            }
        }
    }
}
