namespace AdressbuchEntityFramework.Model.Entities;

internal class AdressEintrag
{
   public int Id { get; set; }

   public string Name { get; set; } = string.Empty;

   public DateTime Geburtstag { get; set; }

   public string TelefonNummer { get; set; } = string.Empty;

   public virtual ICollection<Adressen> Adressen { get; set; }
}