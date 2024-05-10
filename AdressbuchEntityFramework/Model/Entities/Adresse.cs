namespace AdressbuchEntityFramework.Model.Entities;

public class Adresse
{
   public int Id { get; set; }
   
   public string Straße { get; set; }

   public string Hausnummer { get; set; }

   public string Postleitzahl { get; set; }
   
   public string Stadt { get; set; }

   public int AdressEintragId { get; set; }
   public virtual AdressEintrag AdressEintrag { get; set; }

   public override string ToString()
   {
      return $"{this.Straße} {this.Hausnummer}, {this.Postleitzahl} {this.Stadt}";
   }
}
