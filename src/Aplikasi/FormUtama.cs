using Aplikasi.Services;
using Logika.Contoh;

namespace Aplikasi;

/// <summary>
/// CONTOH SAJA. Memperlihatkan pola: form disusun lewat kode (tanpa designer), tidak berisi logika
/// (semuanya di proyek Logika), dan menerima penyimpanan lewat konstruktor kelas logika. Ganti isinya
/// dengan tampilan aplikasi kelompok Anda; hapus bagian yang memakai Logika.Contoh bersama folder itu.
/// </summary>
public class FormUtama : Form
{
    private readonly Penghitung _penghitung;
    private readonly Label _label;

    public FormUtama()
    {
        _penghitung = new Penghitung(new PenyimpananBerkas("ProyekAkhirContoh"));

        Text = "Kerangka Proyek Akhir (contoh)";
        ClientSize = new Size(480, 240);
        StartPosition = FormStartPosition.CenterScreen;

        _label = new Label
        {
            AutoSize = true,
            Font = new Font("Segoe UI", 18),
            Location = new Point(30, 40),
        };
        var tombol = new Button
        {
            Text = "Tambah",
            Font = new Font("Segoe UI", 14),
            Size = new Size(160, 52),
            Location = new Point(30, 130),
        };
        tombol.Click += (_, _) =>
        {
            _penghitung.Tambah();
            Perbarui();
        };

        Controls.Add(_label);
        Controls.Add(tombol);
        Perbarui();
    }

    private void Perbarui() => _label.Text = $"Nilai tersimpan: {_penghitung.Nilai}";
}
