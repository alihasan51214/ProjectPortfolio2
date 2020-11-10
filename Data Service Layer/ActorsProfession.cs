using System.ComponentModel.DataAnnotations;


namespace DataServiceLayer
{
    public class ActorsProfession
    {
        [Key]
        public string Nconst { get; set; }
        public string PrimaryProfession { get; set; }

        public override string ToString()
        {
            return $"Nconst = {Nconst}, PrimaryProfession = {PrimaryProfession}";
        }
    }
}




