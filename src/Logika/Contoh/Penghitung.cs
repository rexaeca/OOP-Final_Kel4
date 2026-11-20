namespace Logika.Contoh;

/// <summary>
/// CONTOH SAJA. Memperlihatkan pola: kelas logika murni (tanpa tipe UI), menerima IPenyimpanan lewat
/// konstruktor, dan tidak tahu apa pun tentang tampilan. HAPUS seluruh folder Contoh/ (dan bagian contoh
/// di FormUtama.cs) setelah Anda paham polanya. Folder ini tidak ikut dinilai.
/// </summary>
public class Penghitung
{
    private const string Kunci = "contoh.penghitung";
    private readonly IPenyimpanan _penyimpanan;

    public int Nilai { get; private set; }

    public Penghitung(IPenyimpanan penyimpanan)
    {
        _penyimpanan = penyimpanan ?? throw new ArgumentNullException(nameof(penyimpanan));
        if (int.TryParse(_penyimpanan.Muat(Kunci), out var tersimpan))
            Nilai = tersimpan;
    }

    public void Tambah()
    {
        Nilai++;
        _penyimpanan.Simpan(Kunci, Nilai.ToString());
    }
}
