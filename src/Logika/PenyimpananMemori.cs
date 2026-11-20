namespace Logika;

/// <summary>
/// KERANGKA (sudah disediakan): penyimpanan di memori, tanpa berkas. Hilang saat aplikasi ditutup.
/// </summary>
public class PenyimpananMemori : IPenyimpanan
{
    private readonly Dictionary<string, string> _data = new();

    public string? Muat(string kunci) => _data.TryGetValue(kunci, out var nilai) ? nilai : null;

    public void Simpan(string kunci, string nilai) => _data[kunci] = nilai;
}
