namespace RCollection;
using System.Collections;
using System.Collections.Generic;

public class Player:IComparable{
    public string name;
    public int runs;
    public int matches;
    public int age;

    public Player(string name, int runs, int matches, int age){
        this.name = name;
        this.runs = runs;
        this.matches = matches;
        this.age = age;
    }

    public int CompareTo(object? obj){
        Player newPlayer = (Player) obj;
        if(this.runs > newPlayer.runs)
            return 1;
        else if(this.runs < newPlayer.runs)
            return -1;
        else return 0;
    }
}