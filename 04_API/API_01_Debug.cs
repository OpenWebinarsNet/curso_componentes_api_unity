using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class API_01_Debug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Esto es un mensaje de información");
        Debug.LogWarning("Esto es una advertencia");
        Debug.LogError("Esto es un grave error");

        Debug.LogFormat("Soy el objeto {0}. Todo OK", name);
        Debug.LogWarningFormat("Cuidado con {0}, que parece que falla", name);
        Debug.LogErrorFormat("Ha ocurrido un error en {0}, el objeto {0} ha fallado en el frame {1}", name, Time.frameCount);

        //Debug.Break();
    }

}
