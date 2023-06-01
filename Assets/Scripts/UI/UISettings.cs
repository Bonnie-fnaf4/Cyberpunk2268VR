using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISettings : MonoBehaviour
{
    public Image[] SettingUi;
    public int id = 0;
    public Color color = Color.blue;
    public Text[] NameSettingUI;

    public Text[] SecondTextSettingUI;

    //Дальше идут переменные массивы которые нужны что бы
    //заполнить значение определённой настройки т.к. не всем настройкам нужно 2 и более параметра
    public int SoundValue, MusicValue;

    public Image[] SoundValueImage, MusicValueImage;

    public int[] IdSettingUI;

    private void Start()
    {
        color = SettingUi[id].color;
        SettingUi[id].color = Color.black;

        for (int i = 0; i < SoundValueImage.Length; i++)
        {
            if (i < SoundValue)
            {
                SoundValueImage[i].color = Color.white;
            }
            else
            {
                SoundValueImage[i].color = Color.black;
            }
            if (i < MusicValue)
            {
                MusicValueImage[i].color = Color.white;
            }
            else
            {
                MusicValueImage[i].color = Color.black;
            }
        }
    }

    private void Update()
    {

    }

    public void Up()
    {
        if (!(SettingUi.Length - 1 > id)) return;
        SettingUi[id].color = color;
        id++;
        SettingUi[id].color = Color.black;
    }
    public void Down()
    {
        if (!(0 < id)) return;
        SettingUi[id].color = color;
        id--;
        SettingUi[id].color = Color.black;
    }
    public void Left()
    {
        if (id == 1 || id == 2)
        {
            if (id == 2) SoundValue--;
            if (id == 1) MusicValue--;
            for (int i = 0; i < SoundValueImage.Length; i++)
            {
                if (i < SoundValue)
                {
                    SoundValueImage[i].color = Color.white;
                }
                else
                {
                    SoundValueImage[i].color = Color.black;
                }
                if (i < MusicValue)
                {
                    MusicValueImage[i].color = Color.white;
                }
                else
                {
                    MusicValueImage[i].color = Color.black;
                }
            }
        }
    }
    public void Right()
    {
        if (id == 1 || id == 2)
        {
            if (id == 2) SoundValue++;
            if (id == 1) MusicValue++;
            for (int i = 0; i < SoundValueImage.Length; i++)
            {
                if (i < SoundValue)
                {
                    SoundValueImage[i].color = Color.white;
                }
                else
                {
                    SoundValueImage[i].color = Color.black;
                }
                if (i < MusicValue)
                {
                    MusicValueImage[i].color = Color.white;
                }
                else
                {
                    MusicValueImage[i].color = Color.black;
                }
            }
        }
    }
}
