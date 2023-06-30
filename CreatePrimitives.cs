using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CreatePrimitives : MonoBehaviour
{
    void Start()
    {
        // Создаем куб и устанавливаем его позицию в (0,0,0)
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0);
        
        // Создаем куб и устанавливаем его позицию в (-0.5f, 1, 0)
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 1, 0);
        
        // Создаем куб и устанавливаем его позицию в (0.5f, 1, 0)
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 1, 0);
        
        // Создаем куб и устанавливаем его позицию в (0.5f, 2, 0)
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0.5f, 2, 0);
        
        // Создаем куб и устанавливаем его позицию в (-0.5f, 2, 0)
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-0.5f, 2, 0);
        
        // Создаем куб и устанавливаем его позицию в (0, 3, 0)
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 3, 0);
    }
}