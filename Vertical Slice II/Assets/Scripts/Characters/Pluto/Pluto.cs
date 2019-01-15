using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pluto : MonoBehaviour, IAbilities {
    CharacterStats getStats;
    public void SpecialAttack(){
        getStats = gameObject.GetComponent<CharacterStats>();
        Debug.Log("SpecialAttack (Pluto)");
        getStats.mana -= 30;
	}
    public void MainAttack(){
        getStats = gameObject.GetComponent<CharacterStats>();
        Debug.Log("MainAttack (Pluto)");
        getStats.mana -= 70;
	}

}
