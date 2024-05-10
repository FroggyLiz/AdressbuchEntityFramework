namespace AdressbuchEntityFramework.Model.Entities;

internal class Adressen
{
   internal Adressen()
   {
      this.AdressEintraege = new HashSet<AdressEintrag>();
   }

   public int Id { get; set; }
   
   public string Name { get; set; }

   public virtual ICollection<AdressEintrag> AdressEintraege { get; set; }
}
