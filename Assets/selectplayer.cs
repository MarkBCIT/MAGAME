using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/** 
* class selectplayer
*       selectplayer menu
* author: mark
*/
public class selectplayer : MonoBehaviour
{
    public static selectplayer selectp;
    public GameObject thunder;
    public bool waitforclick = false;
    public Button button1;
    public Button button2;
    public Button button3;
    public Button button4;
    public Text button1text;
    public Text button2text;
    public Text button3text;
    public int p1;
    public int p2;
    public int p3;
    public bool selectassassin = false;
    public bool selectstreet = false;
    public bool selectthunder = false;

    void Awake()
    {
        selectp = this;
        this.gameObject.SetActive(false);
        thunder.gameObject.SetActive(false);
    }
    public void show()
    {
        this.gameObject.SetActive(true);
        thunder.gameObject.SetActive(false);
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);
        button3.gameObject.SetActive(true);
        button4.gameObject.SetActive(true);
        p1 = Main.current + 1;
        if (p1 >= 4) p1 -= 4;
        p2 = Main.current + 2;
        if (p2 >= 4) p2 -= 4;
        p3 = Main.current + 3;
        if (p3 >= 4) p3 -= 4;
        button1text.text = Main.list[p1].name;
        button2text.text = Main.list[p2].name;
        button3text.text = Main.list[p3].name;
        if (Main.list[Main.current].com)
        {
            if (selectassassin)
            {
                int l1 = Main.list[p1].level();
                if (Main.list[p1].study || safe(Main.list[p1].pos)) l1 = 0;
                int l2 = Main.list[p2].level();
                if (Main.list[p2].study || safe(Main.list[p2].pos)) l2 = 0;
                int l3 = Main.list[p3].level();
                if (Main.list[p3].study || safe(Main.list[p3].pos)) l3 = 0;
                if (l1 == 0 && l2 == 0 && l3 == 0)
                {
                    giveup();
                }
                else if (l1 >= l2 && l1 >= l3)
                {
                    select1();
                }
                else if (l2 >= l3 && l2 >= l1)
                {
                    select2();
                }
                else if (l3 >= l1 && l3 >= l2)
                {
                    select3();
                }
            }
            else if (selectstreet)
            {
                int l1 = Main.list[p1].level();
                if (Main.list[p1].study || safe(Main.list[p1].pos) || Main.list[p1].chip < 2) l1 = 9999;
                int l2 = Main.list[p2].level();
                if (Main.list[p2].study || safe(Main.list[p2].pos) || Main.list[p2].chip < 2) l2 = 9999;
                int l3 = Main.list[p3].level();
                if (Main.list[p3].study || safe(Main.list[p3].pos) || Main.list[p3].chip < 2) l3 = 9999;
                if (l1 == 9999 && l2 == 9999 && l3 == 9999||Main.list[Main.current].pos>600)
                {
                    giveup();
                }
                else if (l1 <= l2 && l1 <= l3)
                {
                    select1();
                }
                else if (l2 <= l1 && l2 <= l3)
                {
                    select2();
                }
                else if (l3 <= l1 && l3 <= l2)
                {
                    select3();
                }
            }
            else if (selectthunder)
            {
                if ((Main.list[p1].pos >= 607 && Main.list[p1].pos <= 609) || (Main.list[p1].pos >= 1203 && Main.list[p1].pos <= 1205) || (Main.list[p1].pos >= 2011 && Main.list[p1].pos <= 2013) || (Main.list[p1].pos >= 2603 && Main.list[p1].pos <= 2605) || (Main.list[p1].pos >= 3407 && Main.list[p1].pos <= 3409) || (Main.list[p1].pos >= 4003 && Main.list[p1].pos <= 4005) || (Main.list[p1].pos >= 4811 && Main.list[p1].pos <= 4813) || (Main.list[p1].pos >= 5403 && Main.list[p1].pos <= 5405) || Main.list[p1].pos == 5705)
                {
                    select1();
                }
                else if ((Main.list[p2].pos >= 607 && Main.list[p2].pos <= 609) || (Main.list[p2].pos >= 1203 && Main.list[p2].pos <= 1205) || (Main.list[p2].pos >= 2011 && Main.list[p2].pos <= 2013) || (Main.list[p2].pos >= 2603 && Main.list[p2].pos <= 2605) || (Main.list[p2].pos >= 3407 && Main.list[p2].pos <= 3409) || (Main.list[p2].pos >= 4003 && Main.list[p2].pos <= 4005) || (Main.list[p2].pos >= 4811 && Main.list[p2].pos <= 4813) || (Main.list[p2].pos >= 5403 && Main.list[p2].pos <= 5405) || Main.list[p2].pos == 5705)
                {
                    select2();
                }
                else if ((Main.list[p3].pos >= 607 && Main.list[p3].pos <= 609) || (Main.list[p3].pos >= 1203 && Main.list[p3].pos <= 1205) || (Main.list[p3].pos >= 2011 && Main.list[p3].pos <= 2013) || (Main.list[p3].pos >= 2603 && Main.list[p3].pos <= 2605) || (Main.list[p3].pos >= 3407 && Main.list[p3].pos <= 3409) || (Main.list[p3].pos >= 4003 && Main.list[p3].pos <= 4005) || (Main.list[p3].pos >= 4811 && Main.list[p3].pos <= 4813) || (Main.list[p3].pos >= 5403 && Main.list[p3].pos <= 5405) || Main.list[p3].pos == 5705)
                {
                    select3();
                }
                else
                {
                    done();
                }
            }
        }

    }

    public void select1()
    {

        if (selectassassin)
        {
            if (Main.list[p1].study == true || safe(Main.list[p1].pos))
            {
                Main.message = "You cannot reach " + Main.list[p1].name + " now!";
            }
            else
            {
                assassin.assassins.method(p1);
                done();
            }
        }
        else if (selectstreet)
        {
            if (Main.list[p1].study == true || safe(Main.list[p1].pos))
            {
                Main.message = "You cannot reach " + Main.list[p1].name + " now!";
            }
            else
            {
                urgent.urgents.fight(p1);
                done();
            }
        }
        else if (selectthunder)
        {
            Main.list[Main.current].yinyangcard[4] -= 1;
            Main.message = Main.list[Main.current].name + " used a thunder to send " + Main.list[p1].name + " to hospital!";
            thunder.gameObject.SetActive(true);
            Main.list[p1].gohosp();
            done();

        }
    }
    public void select2()
    {
        if (selectassassin)
        {
            if (Main.list[p2].study == true || safe(Main.list[p2].pos))
            {
                Main.message = "You cannot reach " + Main.list[p2].name + " now!";
            }
            else
            {
                assassin.assassins.method(p2);
                done();
            }
        }
        else if (selectstreet)
        {
            if (Main.list[p2].study == true || safe(Main.list[p2].pos))
            {
                Main.message = "You cannot reach " + Main.list[p2].name + " now!";
            }
            else
            {
                urgent.urgents.fight(p2);
                done();
            }
        }
        else if (selectthunder)
        {
            Main.list[Main.current].yinyangcard[4] -= 1;
            Main.message = Main.list[Main.current].name + " used a thunder to send " + Main.list[p2].name + " to hospital!";
            thunder.gameObject.SetActive(true);
            Main.list[p2].gohosp();
            done();
        }
    }
    public void select3()
    {
        if (selectassassin)
        {
            if (Main.list[p3].study == true || safe(Main.list[p3].pos))
            {
                Main.message = "You cannot reach " + Main.list[p3].name + " now!";
            }
            else
            {
                assassin.assassins.method(p3);
                done();
            }
        }
        else if (selectstreet)
        {
            if (Main.list[p3].study == true || safe(Main.list[p3].pos))
            {
                Main.message = "You cannot reach " + Main.list[p3].name + " now!";
            }
            else
            {
                urgent.urgents.fight(p3);
                done();
            }
        }
        else if (selectthunder)
        {
            Main.list[Main.current].yinyangcard[4] -= 1;
            Main.message = Main.list[Main.current].name + " used a thunder to send " + Main.list[p3].name + " to hospital!";
            thunder.gameObject.SetActive(true);
            Main.list[p3].gohosp();
            done();
        }
    }
    public void giveup()
    {
        if (selectassassin)
        {
            Main.message = Main.list[Main.current].name + " gave up assassin...";
            assassin.assassins.done();
        }
        else if (selectstreet)
        {
            Main.message = Main.list[Main.current].name + " gave up the fight";
            urgent.urgents.waitforclick = true;
        }
        else if (selectthunder)
        {
            Main.message = "Thunder cancelled...";
        }
        done();
    }
    public bool safe(int p)
    {
        if (p == 3 || p == 17 || p == 31 || p == 45 || p == 1 || p == 15 || p == 29 || p == 43 || p >= 600)
        {
            return true;
        }
        return false;
    }
    public void done()
    {
        selectassassin = false;
        selectstreet = false;
        button1.gameObject.SetActive(false);
        button2.gameObject.SetActive(false);
        button3.gameObject.SetActive(false);
        button4.gameObject.SetActive(false);

        if (selectthunder)
        {
            selectthunder = false;
            if(Main.list[Main.current].com){
                waitforclick = true;
            }else{
                waitforclick = true;
            }
            

        }
        else
        {
            this.gameObject.SetActive(false);
        }
    }
    void Update()
    {
        if (waitforclick && Input.GetMouseButtonDown(0))
        {
            waitforclick = false;
            yinyanglist.yinyanglists.show();
            Roll._Instance.show();
            if(Main.list[Main.current].com){
                Roll._Instance.dieroll();
            }
            thunder.gameObject.SetActive(false);
            this.gameObject.SetActive(false);
        }
    }
}
