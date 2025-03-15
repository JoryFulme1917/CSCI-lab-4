using System.Collections;
using UnityEngine;

public class DragonController : MonoBehaviour
{


    private Animator anim;
    int IdleSimple;
    int IdleAgressive;
    int IdleRestless;
    int Walk;
    int BattleStance;
    int Bite;
    int Drakaris;
    int FlyingFWD;
    int FlyingAttack;
    int Hover;
    int Lands;
    int TakeOff;
    int Die;









    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
        IdleSimple = Animator.StringToHash("IdleSimple");
        IdleAgressive = Animator.StringToHash("IdleAgressive");
        IdleRestless = Animator.StringToHash("IdleRestless");
        Walk = Animator.StringToHash("Walk");
        BattleStance = Animator.StringToHash("BattleStance");
        Bite = Animator.StringToHash("Bite");
        Drakaris = Animator.StringToHash("Drakaris");
        FlyingFWD = Animator.StringToHash("FlyingFWD");
        FlyingAttack = Animator.StringToHash("FlyingAttack");
        Hover = Animator.StringToHash("Hover");
        Lands = Animator.StringToHash("Lands");
        TakeOff = Animator.StringToHash("TakeOff");
        Die = Animator.StringToHash("Die");


        anim.SetBool(IdleAgressive, true);


    }



    public void DragonHit()
    {
        anim.SetBool(IdleAgressive, false);
        anim.SetBool(IdleSimple, false);
        anim.SetBool(IdleRestless, false);
        anim.SetBool(Walk, false);
        anim.SetBool(BattleStance, false);
        anim.SetBool(Bite, true);
        anim.SetBool(Drakaris, false);
        anim.SetBool(FlyingFWD, false);
        anim.SetBool(FlyingAttack, false);
        anim.SetBool(Hover, false);
        anim.SetBool(Lands, false);
        anim.SetBool(TakeOff, false);
        anim.SetBool(Die, false);

        StartCoroutine(DisableAnim(2f));
    }


    public void DragonHitSpecial()
    {

        anim.SetBool(IdleAgressive, false);
        anim.SetBool(IdleSimple, false);
        anim.SetBool(IdleRestless, false);
        anim.SetBool(Walk, false);
        anim.SetBool(BattleStance, false);
        anim.SetBool(Bite, false);
        anim.SetBool(Drakaris, true);
        anim.SetBool(FlyingFWD, false);
        anim.SetBool(FlyingAttack, false);
        anim.SetBool(Hover, false);
        anim.SetBool(Lands, false);
        anim.SetBool(TakeOff, false);
        anim.SetBool(Die, false);


        StartCoroutine(DisableAnim(3f));
    }

    public void DragonDie()
    {

        anim.SetBool(IdleAgressive, false);
        anim.SetBool(IdleSimple, false);
        anim.SetBool(IdleRestless, false);
        anim.SetBool(Walk, false);
        anim.SetBool(BattleStance, false);
        anim.SetBool(Bite, false);
        anim.SetBool(Drakaris, false);
        anim.SetBool(FlyingFWD, false);
        anim.SetBool(FlyingAttack, false);
        anim.SetBool(Hover, false);
        anim.SetBool(Lands, false);
        anim.SetBool(TakeOff, false);
        anim.SetBool(Die, true);

        StartCoroutine(DisableAnim(10f));
    }


    IEnumerator DisableAnim(float time)
    {
        yield return new WaitForSeconds(time);
        anim.SetBool(IdleAgressive, true);
        anim.SetBool(IdleSimple, false);
        anim.SetBool(IdleRestless, false);
        anim.SetBool(Walk, false);
        anim.SetBool(BattleStance, false);
        anim.SetBool(Bite, false);
        anim.SetBool(Drakaris, false);
        anim.SetBool(FlyingFWD, false);
        anim.SetBool(FlyingAttack, false);
        anim.SetBool(Hover, false);
        anim.SetBool(Lands, false);
        anim.SetBool(TakeOff, false);
        anim.SetBool(Die, false);
    }





    // Update is called once per frame
    void Update()
    {
        





    }
}
