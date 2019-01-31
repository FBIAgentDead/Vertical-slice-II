using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluto : MonoBehaviour, IAbilities {
    CharacterStats getStats;
    public void SpecialAttack(){
        getStats = gameObject.GetComponent<CharacterStats>();
        if (getStats.canAttack){
            Debug.Log("SpecialAttack (Pluto)");
            getStats.mana -= 30;
        }
	}
    public void MainAttack(){
        getStats = gameObject.GetComponent<CharacterStats>();
        if(getStats.canAttack){
            Debug.Log("MainAttack (Pluto)");
            getStats.mana -= 70;
        }
	}

    public void SelfBuf(){
        getStats = gameObject.GetComponent<CharacterStats>();
        if(getStats.canAttack){
        
        }
    }

}
