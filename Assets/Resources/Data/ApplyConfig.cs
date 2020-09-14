

using Assets.Data;
using System.Collections;
using System.Collections.Generic;
using System;

using System.Xml.Linq;
using UnityEngine;

public class ApplyConfig:MonoBehaviour
{
    public ManagerScore managerScore;
    public ConfigPlayer config;
    private string pathConfig = "ConfigDefault.xml";
    private string pathScore = "ListScore.xml";
    void DefaultPlayer()
    {
        try
        {
            XElement data = null;
            try
            {

                data = ReadWrite.LoadData(pathConfig, "ConfigDefault", "Config");
                if (data == null)
                {
                    throw new System.Exception("Error load data");
                }
            }
            catch (Exception e)
            {
                UnityEngine.Debug.Log(e.Message);
                ReadWrite.CreatConfig(pathConfig);
            }

           // config.NamPlayer = data.Element("NamePlayer").Value;
            config.Damage = float.Parse(data.Element("Damage").Value);
            config.Point = float.Parse(data.Element("Score").Value);
            config.Blood = float.Parse(data.Element("Blood").Value);
            config.MaxBlood = float.Parse(data.Element("MaxBlood").Value);
            config.moveSpeed = float.Parse(data.Element("MoveSpeed").Value);
        }
        catch(Exception e)
        {
            UnityEngine.Debug.Log("Error DefaultPlayer: " + e.Message);
            Time.timeScale = 0;
        }
    }
    void LoadScore()
    {
        try
        {
            managerScore.ListScore = ReadWrite.LoadScore(pathScore, "ListScore");
        }
        catch
        {

        }
    }
    void Start()
    {
        
        DefaultPlayer();
        LoadScore();
       
    }
    

}

