using UnityEngine;
public class Touch : Sense
{
    private Color color;

    void OnTriggerEnter(Collider other)
    {
        Aspect aspect = other.GetComponent<Aspect>();
        if (aspect != null)
        {
            //Check the aspect
            if (aspect.aspectType != aspectName)
            {
                // GetComponent<Renderer>(Color.cyan);

                print("Enemy Touch Detected");
                
            }
        }
    }
}