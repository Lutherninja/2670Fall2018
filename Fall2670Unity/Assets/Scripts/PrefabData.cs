using UnityEngine;

//Made By Jonathan Luther
[CreateAssetMenu]
public class PrefabData : ScriptableObject
{
   public GameObject Prefab;
   public Sprite SpriteImage;
   public Color SpriteColor;

   public void OnConfigure()
   {
       var newPrefab = Instantiate(Prefab);
       var newSprite = newPrefab.GetComponent<SpriteRenderer>();
       newSprite.sprite = SpriteImage;
       newSprite.color = SpriteColor;

   }
}
