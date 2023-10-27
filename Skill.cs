namespace portfolio.api;

public enum Scale
{
    Strong = 0,
    Medium = 1,
    Weak = 2,
    HeardAbou = 3
}


public class Skill
{
    public Guid _id { get; set; }

    public string _name { get; set; }

    public Knowledge _knowledge { get; set; }
    public Scale _scale { get; set; }

}
