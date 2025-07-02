namespace ConsumerDragonBallApi.Models;

public class Character
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Ki { get; set; }
    public string MaxKi { get; set; }
    public string Race { get; set; }
    public string Gender { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    public string Affiliation { get; set; }
    public OriginPlanet OriginPlanet { get; set; }
    public List<Transformation> Transformations { get; set; }
}
