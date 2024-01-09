using System.Collections;
using UnityEngine;

[CreateAssetMenu()]
public class WeaponObjectSO : ScriptableObject
{
    public Bullet bulletPrefab;
    public Sprite inGameWeaponVisual;
    public string weaponName;
    public string weaponDescription;
    public float fireRate;
    public int penetratingCount;
    public float damagePerBullet;
    public float activeAbilityGain;

    public virtual void UseAbility()
    {
        
    }
}
