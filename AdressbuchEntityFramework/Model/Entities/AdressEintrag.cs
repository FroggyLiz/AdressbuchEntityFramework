namespace AdressbuchEntityFramework.Model.Entities;

/// <summary>
/// <see cref="AdressEintrag"/> Buisnessmodel
/// </summary>
public class AdressEintrag
{
   /// <summary>
   /// Constructor with Default Values
   /// </summary>
   public AdressEintrag()
   {
      this.Adressen = new HashSet<Adresse>();
   }

   public int Id { get; set; }

   public string Name { get; set; } = string.Empty;

   public DateTime Geburtstag { get; set; }

   public string TelefonNummer { get; set; } = string.Empty;

   public virtual ICollection<Adresse> Adressen { get; set; }
}