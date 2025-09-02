using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

public static class TitkositasSeged
{
    // 32 bájtos kulcs (AES-256) és 16 bájtos IV
    private static readonly byte[] Kulcs = Encoding.UTF8.GetBytes("EzEgy32BajtosTitkosKulcs12345678");
    private static readonly byte[] IV = Encoding.UTF8.GetBytes("EzEgy16BajtosIV!");

    public static string Titkosit(string szoveg)
    {
        using var aes = Aes.Create();
        aes.Key = Kulcs;
        aes.IV = IV;

        using var ms = new MemoryStream();
        using (var cs = new CryptoStream(ms, aes.CreateEncryptor(), CryptoStreamMode.Write))
        using (var sw = new StreamWriter(cs))
        {
            sw.Write(szoveg);
        }

        return Convert.ToBase64String(ms.ToArray());
    }

    public static string Visszafejt(string base64Titkositott)
    {
        var adat = Convert.FromBase64String(base64Titkositott);

        using var aes = Aes.Create();
        aes.Key = Kulcs;
        aes.IV = IV;

        using var ms = new MemoryStream(adat);
        using var cs = new CryptoStream(ms, aes.CreateDecryptor(), CryptoStreamMode.Read);
        using var sr = new StreamReader(cs);
        return sr.ReadToEnd();
    }
}
