using System.Security.Cryptography;
using System.Text;

public static class TitkositasSeged
{
    public static string Titkosit(string szoveg)
    {
        var adat = Encoding.UTF8.GetBytes(szoveg);
        var titkositott = ProtectedData.Protect(adat, null, DataProtectionScope.CurrentUser);
        return Convert.ToBase64String(titkositott);
    }

    public static string Visszafejt(string base64Titkositott)
    {
        var titkositott = Convert.FromBase64String(base64Titkositott);
        var eredeti = ProtectedData.Unprotect(titkositott, null, DataProtectionScope.CurrentUser);
        return Encoding.UTF8.GetString(eredeti);
    }
}