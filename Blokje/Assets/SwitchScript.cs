using System.Collections;
using UnityEngine;

public enum AttackTypes
{
    MeleeAttack = 0,
    RangedAttack=  1,
    MagicAttack = 2

}

public class SwitchScript : MonoBehaviour
{



    [SerializeField]
    private AttackTypes attackType;
    private int number;





    void Awake()

    {


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            switch (attackType)
            {
                case AttackTypes.MeleeAttack:
                    Debug.Log("Melee");
                    break;
                case AttackTypes.RangedAttack:
                    Debug.Log("Ranged");
                    break;
                case AttackTypes.MagicAttack:
                    Debug.Log("Magic");
                    break;

            }


        }
    }
}