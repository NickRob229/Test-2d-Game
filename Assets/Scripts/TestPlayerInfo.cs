using UnityEngine;

public class TestPlayerStats
{
    public class Stats
    {
        public int meleeDamage;
        public int spell1BaseDamage;
        public int spell2BaseDamage;
        public int spell3BaseDamage;
        public int health;
        public int speed;
        public int jumpHeight;
    }
    public class Weapons
    {
        public string meleeWeaponName;
        public int meleeDamage;
        public int attackDelay;
        public bool meleeTwoHanded;

        public string magicWeaponName;
        public float spellDamageMultiplier;
        public int spellCooldownMultilier;
        public bool magicTwoHanded;
    }

}
