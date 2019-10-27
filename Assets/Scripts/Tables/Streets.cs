﻿using SQLite4Unity3d;


public class Streets
{
    [PrimaryKey, AutoIncrement]
    public int IdStreet { get; set; }

    public string NameStreet { get; set; }
    public string AboutStreet { get; set; }

    public Street GetStreet(int[] paths)
    {
        return new Street(IdStreet, NameStreet, AboutStreet, paths);
    }
    
    public NetworkStreet GetNetworkStreet(int[] paths)
    {
        return new NetworkStreet(IdStreet, NameStreet, AboutStreet, paths);
    }

    public Streets(int idStreet, string nameStreet, string aboutStreet)
    {
        IdStreet = idStreet;
        NameStreet = nameStreet;
        AboutStreet = aboutStreet;
    }

    public Streets()
    {
    }
}