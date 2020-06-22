using JetBrains.Annotations;

namespace Qase.API.Extensions
{
  public static class StringExtensions
  {
    public static string TrimLengthWithEllipsis([NotNull] this string str, int maxLength)
    {
      if (str.Length <= maxLength)
      {
        return str;
      }

      return str.Substring(0, maxLength) + "...";
    }
  }
}
