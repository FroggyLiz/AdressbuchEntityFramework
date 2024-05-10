namespace AdressbuchEntityFramework;

/// <summary>
/// Class that Contains Extension Methods for Labels
/// </summary>
internal static class LabelExtentions
{
   /// <summary>
   /// Invokes a Method that sets new Text to the UI Thread
   /// </summary>
   /// <param name="label"></param>
   /// <param name="newText"></param>
   internal static void InvokeTextToUI(this Label label, string newText)
   {
      label.BeginInvoke(delegate () { label.Text = newText; });
   }
}
