using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move_obj : MonoBehaviour
{
    [SerializeField]
    public float speed;
    public float _end = Screen.width/2;
    // Start is called before the first frame update
    private void Start()
    {
        _end = Camera.main.pixelWidth;
    }

    private void Update()
    {
         
            if (transform.position.x >= _end + GetComponent<RectTransform>().localScale.x / 2f)
        {
            
            gameObject.SetActive(false);

            }
        transform.Translate(Vector3.right * speed * Time.deltaTime); // Движение вправо со скоростью speed
            if (transform.position.x >= _end / 2f + gameObject.transform.parent.localScale.x / 2f) // Проверка на прохождение середины экрана
            {

                
                SetHalfTransparent(); 

            }
        
    }
    private void SetHalfTransparent()
    {
        var sr = GetComponent<Image>();
        Color color = sr.color;
        color.a = 0.2f; // Устанавливаем прозрачность в 50%
        sr.color = color;
    
    }
    

}
