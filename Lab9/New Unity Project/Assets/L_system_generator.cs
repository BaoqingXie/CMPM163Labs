﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L_system_generator : MonoBehaviour
{
    private string axiom;
    private float angle;
    private Dictionary<char, string> rules = new Dictionary<char, string>();
    private string currentString;
    private Stack<TransformInfo> transformStack = new Stack<TransformInfo>();

    private float length;
    private bool isGenerating = false;
    // Start is called before the first frame update
    void Start()
    {
        
        axiom = "F";
        rules.Add('F', "FFF-[-F+F+F]-[+F-F-F]");
        angle = 5f;
        length = 10f;
        

        /*
        axiom = "F-G-G";
        rules.Add('F', "F-G+F+G-F");
        rules.Add('G', "GG");
        angle = 120f;
        length = 10f;
        */

        currentString = axiom;
        StartCoroutine(GenerateLSystem());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator GenerateLSystem(){
        int count = 0;
        while(count < 5){
            if(!isGenerating){
                isGenerating = true;
                StartCoroutine(Generate());
            }else{
                yield return new WaitForSeconds(0.1f);
            }
        }
    }

    IEnumerator Generate(){
        length = length/2;
        string newString = "";
        char[] stringCharacters = currentString.ToCharArray();

        for(int i = 0; i< stringCharacters.Length;i++){
            char currentCharacter = stringCharacters [i];

            if(rules.ContainsKey(currentCharacter)){
                newString += rules [currentCharacter];
            }else{
                newString += currentCharacter.ToString();
            }
        }

        currentString = newString;
        Debug.Log(currentString);

        stringCharacters = currentString.ToCharArray();

        for(int i=0; i < stringCharacters.Length;i++){
            char currentCharacter = stringCharacters [i];

            if(currentCharacter == 'F' || currentCharacter == 'G'){
                Vector3 initialPosition = transform.position;
                transform.Translate(Vector3.forward * length);
                if(i%2 == 0){
                Debug.DrawLine(initialPosition, transform.position, Color.red, 10000f, false);
                }else{
                Debug.DrawLine(initialPosition, transform.position, Color.blue, 10000f, false);
                }
                yield return null;
            }else if(currentCharacter == '+'){
                transform.Rotate(Vector3.up * angle);
            }else if(currentCharacter == '-'){
                transform.Rotate(Vector3.up * -angle);
            }else if(currentCharacter == '['){
                TransformInfo ti = new TransformInfo();
                ti.position = transform.position;
                ti.rotation = transform.rotation;
                transformStack.Push(ti);

            }else if(currentCharacter == ']'){
                TransformInfo ti = transformStack.Pop();
                transform.position = ti.position;
                transform.rotation = ti.rotation;

            }   
    }

    isGenerating = false;

    
}
}
