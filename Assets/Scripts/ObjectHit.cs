using UnityEngine;

public class ObjectHit : MonoBehaviour
{
   private void OnCollisionEnter(Collision other) {
    //carptıgında rengi değişecek
    if(other.gameObject.tag == "Player"){
        GetComponent<MeshRenderer>().material.color = Color.black;
        gameObject.tag = "Hit";
    }
    
    
   }
}
