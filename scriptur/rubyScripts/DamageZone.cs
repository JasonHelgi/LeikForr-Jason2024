using UnityEngine;

//ég gleimdi að það var hægt að copy og pastea marga hluti í einu svo eg copy og pastaði 108 sinnum
//andjóks svona hálftími í að copy paste færa aftur og aftur
public class DamageZone : MonoBehaviour 
{
    void OnTriggerStay2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        if (controller != null)
        {
            //the controller will take care of ignoring the damage during the invincibility time.
            controller.ChangeHealth(-10);
        }
    }
}
