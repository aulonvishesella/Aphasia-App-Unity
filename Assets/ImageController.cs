using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ImageController : MonoBehaviour
{
    //the image controller will control an array of images from the class TypeImages. The TypeImages will have a number of images.
    public TypeImages[] images;

    void Start()
    {
        //once the application is loaded, the images are hidden.
        for (int i = 0; i < images.Length; i++)
        {
            if (images[i].typeOfImage == name)
            {
                images[i].images.SetActive(false);

            }

        }
    }
    //to retrieve an image, pass in a paramter 'name'
    public void ShowImage(String name)
    {
        //searches through the array of stored images to find an image from the name provided
        for (int i = 0; i < images.Length; i++)
        {
            if (images[i].typeOfImage == name)
            {
                //show that image
                images[i].images.SetActive(true);

            }

        }
    }
    //to retrieve an image, pass in a paramter 'name'

    public void HideImage(String name)
    {        
        //searches through the array of stored images to find an image from the name provided to hide
        for (int i = 0; i < images.Length; i++)
        {
            if (images[i].typeOfImage == name)
            {
                //show that image
                images[i].images.SetActive(false);

            }

        }
    }
}