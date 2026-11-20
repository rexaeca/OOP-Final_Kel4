namespace Logika;

/// <summary>
/// KERANGKA (sudah disediakan): pintu untuk menyimpan dan memuat data kecil, mis. skor dan progres.
/// Di aplikasi, implementasinya memakai berkas JSON (lihat src/Aplikasi/Services). Untuk percobaan tanpa
/// berkas, ada <see cref="PenyimpananMemori"/>. Karena kelas Anda hanya mengenal interface ini, logika aplikasi
/// tidak terikat pada cara data disimpan. Ini contoh dependency injection (pertemuan 7).
/// </summary>
public interface IPenyimpanan
{
    /// <summary>Mengembalikan nilai yang tersimpan untuk kunci itu, atau null bila belum ada.</summary>
    string? Muat(string kunci);

    void Simpan(string kunci, string nilai);
}
