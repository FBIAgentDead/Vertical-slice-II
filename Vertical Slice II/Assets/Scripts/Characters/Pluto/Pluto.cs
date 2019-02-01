using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluto : MonoBehaviour, IAbilities {
    CharacterStats getStats;
    Animator playAbilitie;
    public GameObject enemyObject;
    private Animator enemy;

    void Awake()
    {
        playAbilitie = GetComponentInChildren<Animator>();
        enemy = enemyObject.GetComponentInChildren<Animator>();
    }

    public void SpecialAttack(){
        getStats = gameObject.GetComponent<CharacterStats>();
        if (getStats.canAttack){
            Debug.Log("SpecialAttack (Pluto)");
            getStats.mana -= 30;
            playAbilitie.Play("AttackAnim");
            enemy.Play("SelfHeal");
        }
	}
    public void MainAttack(){
        getStats = gameObject.GetComponent<CharacterStats>();
        if(getStats.canAttack){
            Debug.Log("MainAttack (Pluto)");
            getStats.mana -= 70;
            playAbilitie.Play("AttackAnim");
            enemy.Play("SelfHeal");
        }
	}

    public void SelfBuf(){
        getStats = gameObject.GetComponent<CharacterStats>();
        if(getStats.canAttack){
            playAbilitie.Play("Hit");
            getStats.health += 10;
        }
    }

}
