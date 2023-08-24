using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minion : MonoBehaviour
{
    [SerializeField] float rangeAutoAttack = 5f;
    [SerializeField] float attackSpeed = 1f;
    [SerializeField] float attackDamage = 10f;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float health = 100f;
    [SerializeField] float armor = 10f;
    [SerializeField] float magicResist = 10f;
    [SerializeField] float gold = 0;
    [SerializeField] float experience = 0;
    [SerializeField] float level = 1;
    [SerializeField] float mana = 100f;
    [SerializeField] float manaRegen = 1f;
    [SerializeField] float healthRegen = 1f;
    [SerializeField] float cooldownReduction = 0f;
    [SerializeField] float criticalStrikeChance = 0f;
    [SerializeField] float criticalStrikeDamage = 0f;
    [SerializeField] float lifeSteal = 0f;
    [SerializeField] float abilityPower = 0f;
    [SerializeField] float armorPenetration = 0f;
    [SerializeField] float magicPenetration = 0f;
    [SerializeField] float tenacity = 0f;
    [SerializeField] float slowResist = 0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void autoAttack()
    {
        if (Vector3.Distance(transform.position, GameObject.Find("player").transform.position) <= rangeAutoAttack)
        {
            //GameObject.Find("player").GetComponent<player>().health -= attackDamage;
        }
    }
}
