using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change : MonoBehaviour
{
    public Material VertexDisplacementMaterial;
    public float points;
    public float totalPoints;
    public Color _color = new Color(0, 0, 0);
    public Color _colorb = new Color(0, 0, 0);


    // Start is called before the first frame update
    void Start()
    {
        VertexDisplacementMaterial.SetFloat("Vector1_99762302", points/totalPoints);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            points += 5;
            VertexDisplacementMaterial.SetFloat("Vector1_99762302", points/totalPoints);
        }

        if(Input.GetKeyDown(KeyCode.A)){
            _color.r +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_51E6F77E", _color);
        }

        if(Input.GetKeyDown(KeyCode.S)){
            _color.g +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_51E6F77E", _color);
        }

        if(Input.GetKeyDown(KeyCode.D)){
            _color.b +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_51E6F77E", _color);
        }

        if(Input.GetKeyDown(KeyCode.Q)){
            _colorb.r +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_22420FC7", _colorb);
        }

        if(Input.GetKeyDown(KeyCode.W)){
            _colorb.g +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_22420FC7", _colorb);
        }

        if(Input.GetKeyDown(KeyCode.E)){
            _colorb.b +=0.1f;
            VertexDisplacementMaterial.SetVector("Vector3_22420FC7", _colorb);
        }
    }
}
