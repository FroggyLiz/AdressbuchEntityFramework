namespace AdressbuchEntityFramework.Model.Entities;

internal class Adressen
{

   public int Id { get; set; }
   
   public string Straße { get; set; }

   public string Hausnummer { get; set; }

   public string Postleitzahl { get; set; }

   public string Stadt { get; set; }

   public int AdressEintragId { get; set; }
   public virtual AdressEintrag AdressEintrag{ get; set; }

   public override string ToString()
   {
      return $"{this.Postleitzahl} {this.Stadt}\n{this.Straße} {this.Hausnummer}";
   }
}
