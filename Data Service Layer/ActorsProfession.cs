using System.ComponentModel.DataAnnotations;


namespace DataServiceLayer
{
    public class ActorsProfession
    {
        [Key]
        public string Nconst { get; set; }
        public string PrimaryProfession { get; set; }
    }
}




