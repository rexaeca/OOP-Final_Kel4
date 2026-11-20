using System.Text.Json;
using Logika;

namespace Aplikasi.Services;

/// <summary>
/// KERANGKA (sudah disediakan): IPenyimpanan di atas berkas JSON di folder %AppData%\&lt;namaAplikasi&gt;.
/// Data hanya tersimpan di komputer pengguna (tidak dikirim ke mana pun), sehingga tidak ada data pribadi
/// yang kita kumpulkan. Ganti <c>namaAplikasi</c> dengan nama aplikasi kelompok Anda.
/// </summary>
public class PenyimpananBerkas : IPenyimpanan
{
    private readonly string _jalur;
    private readonly Dictionary<string, string> _data;

    public PenyimpananBerkas(string namaAplikasi)
    {
        var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), namaAplikasi);
        Directory.CreateDirectory(folder);
        _jalur = Path.Combine(folder, "progres.json");
        _data = Baca();
    }

    public string? Muat(string kunci) => _data.TryGetValue(kunci, out var nilai) ? nilai : null;

    public void Simpan(string kunci, string nilai)
    {
        _data[kunci] = nilai;
        try { File.WriteAllText(_jalur, JsonSerializer.Serialize(_data)); }
        catch (IOException) { /* tidak tersimpan; aplikasi tetap berjalan */ }
    }

    private Dictionary<string, string> Baca()
    {
        try
        {
            if (File.Exists(_jalur))
                return JsonSerializer.Deserialize<Dictionary<string, string>>(File.ReadAllText(_jalur)) ?? new();
        }
        catch (Exception e) when (e is IOException or JsonException) { /* berkas rusak: mulai kosong */ }
        return new();
    }
}
