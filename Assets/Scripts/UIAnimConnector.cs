using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class UIAnimConnector : MonoBehaviour
{
    private Image _image;
    private Material _material;

    public bool animated = true;

    public bool masked = false;

    public string floatProperty_1 = string.Empty;
    public string floatProperty_2 = string.Empty;
    public string floatProperty_3 = string.Empty;

    public float param_float_1;
    public float param_float_2;
    public float param_float_3;
    
    public string colorProperty_1 = string.Empty;
    public string colorProperty_2 = string.Empty;
    public string colorProperty_3 = string.Empty;

    [ColorUsage(true, true)]
    public Color param_color_1;
    [ColorUsage(true, true)]
    public Color param_color_2;
    [ColorUsage(true, true)]
    public Color param_color_3;



    //Updates Per Second
    public float ups = 30f;
    

    
    
    // Start is called before the first frame update
    void Start()
    {
        _image = GetComponent<Image>();
        _image.material = new Material(_image.material);

        if(masked)
            _material = _image.materialForRendering;
        else
            _material = _image.material;
        
        if (animated)
        {
            StartCoroutine(UpdateProperty(1f/ups));
        }
        else
        {
            if(floatProperty_1 != null)
                _material.SetFloat(floatProperty_1, param_float_1);
            if(floatProperty_2 != null)
                _material.SetFloat(floatProperty_2, param_float_2);
            if(floatProperty_3 != null)
                _material.SetFloat(floatProperty_3, param_float_3);

            if(colorProperty_1 != null)
                _material.SetColor(colorProperty_1, param_color_1);
            if(colorProperty_2 != null)
                _material.SetColor(colorProperty_2, param_color_2);
            if(colorProperty_3 != null)
                _material.SetColor(colorProperty_3, param_color_3);    

        }

    }

     IEnumerator UpdateProperty(float time)
    {
        while (true)
        {
            if(floatProperty_1 != "")
                _material.SetFloat(floatProperty_1, param_float_1);
            if(floatProperty_2 != "")
                _material.SetFloat(floatProperty_2, param_float_2);
            if(floatProperty_3 != "")
                _material.SetFloat(floatProperty_3, param_float_3);

            if(colorProperty_1 != "")
                _material.SetColor(colorProperty_1, param_color_1);
            if(colorProperty_2 != "")
                _material.SetColor(colorProperty_2, param_color_2);
            if(colorProperty_3 != "")
                _material.SetColor(colorProperty_3, param_color_3);

            yield return new WaitForSeconds(time);
        }
        
    }
}
