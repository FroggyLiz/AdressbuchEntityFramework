namespace AdressbuchEntityFramework.Model.Entities;

/// <summary>
/// <see cref="Adresse"/> Buisnessmodel
/// </summary>
public class Adresse
{
   public int Id { get; set; }

   public string Straße { get; set; } = string.Empty;

   public string Hausnummer { get; set; } = string.Empty;

   public string Postleitzahl { get; set; } = string.Empty;

   public string Stadt { get; set; } = string.Empty; 

   public int AdressEintragId { get; set; }

   public virtual AdressEintrag AdressEintrag { get; set; } = new();

   /// <summary>
   /// Converts this Object into a Readable Format for the User
   /// </summary>
   /// <returns></returns>
   public override string ToString()
   {
      return $"{this.Straße} {this.Hausnummer}, {this.Postleitzahl} {this.Stadt}";
   }
}
