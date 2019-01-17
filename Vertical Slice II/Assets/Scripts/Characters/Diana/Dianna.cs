using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dianna : MonoBehaviour, IAbilities {

    CharacterStats getStats;

    public void SpecialAttack()
    {
        getStats = gameObject.GetComponent<CharacterStats>();
        Debug.Log("SpecialAttack (Dianna)");
        getStats.mana -= 30;
    }
    
    public void MainAttack()
    {
        getStats = gameObject.GetComponent<CharacterStats>();
        Debug.Log("MainAttack (Dianna)");
        getStats.mana -= 70;
    }

    public void SelfBuf(){

    }
}
