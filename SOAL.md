<!-- Dibuat otomatis dari ets/proyek/buat-dokumen.py. Isinya sama dengan berkas Word di Classroom. -->

# Requirement Proyek Akhir Pemrograman Berorientasi Objek: Aplikasi Pembelajaran Desktop

## Gambaran umum

Dalam empat minggu, setiap kelompok (3 orang) membuat **aplikasi pembelajaran untuk siswa SD sampai SMP** dengan C# dan **Windows Forms**: aplikasi desktop Windows yang dapat dijalankan guru atau siswa dari satu paket unduhan, tanpa Visual Studio. **Idenya kalian sendiri.** Dosen tidak memberi topik; kalian yang menemukan masalah belajar, merancang cara membantunya, dan mewujudkannya. Karena itu hasil akhir tiap kelompok **harus berbeda**: tidak boleh ada dua kelompok yang membuat aplikasi yang sama. Proyek ini adalah kesempatan menerapkan seluruh materi PBO (pertemuan 4-14) pada satu produk yang benar-benar dapat dipakai orang lain. Kalian juga wajib mengujinya kepada pengguna nyata (anak atau guru) dan memperbaikinya dari temuan itu.

## Yang dinilai

Penilaian dibagi dua: **nilai kelompok** (kualitas rancangan OOP, produk, kode, proses, dan presentasi) dan **nilai individu** (ujian lisan dan kontribusi). Anggota yang kontribusinya kecil tidak dapat "menumpang" nilai kelompok. Bobot lengkap ada di bagian Rubrik. **Tidak ada pemeriksaan otomatis.** Dosen menilai langsung saat sesi demo, satu kelompok per kesempatan: menjalankan aplikasi dari paket rilis, membaca kode, lalu bertanya kepada tiap anggota.

## Ketentuan umum

- **Kelompok:** 3 orang, **dibentuk dosen** supaya setiap kelompok berimbang dan diumumkan di Classroom (karena jumlah mahasiswa tidak habis dibagi 3, satu kelompok beranggotakan 4 orang dengan ketentuan per anggota yang sama). Tiap kelompok mengirim akun GitHub seluruh anggota bersamaan dengan pengajuan ide (paling lambat Jumat, 20 November 2026 pukul 23.59 WIB). Satu kelompok memakai satu repo GitHub **milik salah satu anggota** (tidak perlu di organisasi kelas), dan seluruh anggota ditambahkan sebagai *collaborator* supaya masing-masing push atas nama akunnya sendiri. Tautan repo dikumpulkan di Classroom bersama pengajuan ide.
- **Waktu pengerjaan:** dari Selasa, 17 November 2026 sampai **Minggu, 13 Desember 2026 pukul 23.59 WIB** (empat minggu). Ada tiga pos mingguan (lihat Jadwal). Tidak ada perpanjangan; yang dinilai adalah commit terakhir yang sudah di-push ke branch `main` sebelum batas waktu. Jangan menulis ulang riwayat git (force push, rebase ke `main`); riwayat dipakai sebagai bukti kontribusi.
- **Akses repo:** repo boleh publik. Bila privat, tambahkan akun GitHub dosen sebagai *collaborator* (username diumumkan di Classroom) paling lambat pos M1. Repo atau paket rilis yang tidak dapat dibuka dosen dianggap tidak dikumpulkan.
- **Presentasi dan ujian lisan:** pertemuan 16 (Selasa, 15 Desember 2026), jadwal rinci diumumkan kemudian.
- **Teknologi:** C# dan .NET 8 atau lebih baru, **Windows Forms** untuk tampilan (sesuai materi pertemuan 10-14). Tes otomatis tidak diwajibkan; pengujian dilakukan secara manual dan lewat uji coba pengguna. Aplikasi berjalan di Windows. Kerangka solusi disediakan (lihat Ketentuan teknis). Kerangka tampilan lain (WPF, MAUI, Unity, dan sebagainya) tidak dipakai agar penilaian seragam; bila punya alasan kuat, ajukan ke dosen sebelum pos M1.
- **Kebebasan:** ide, jenis aplikasi, tema, tampilan, dan fitur tambahan sepenuhnya kalian tentukan, selama aturan ide dan persyaratan di bawah terpenuhi. Kerangka hanya titik awal.
- **Kebijakan AI:** AI generatif boleh dipakai, termasuk untuk memikirkan ide, dengan syarat dicatat di `AI-LOG.md` (satu bagian per anggota, ditulis siapa yang memakai). Ide yang dihasilkan AI tetap harus lolos aturan keunikan dan harus kalian pahami. Selama ujian lisan, AI dan internet tidak dipakai.
- **Prinsip penilaian:** kode yang tidak bisa dijelaskan penulisnya dianggap bukan hasil kerjanya. Tiap anggota harus memahami seluruh arsitektur dan menguasai bagian yang ia tulis.

## Ide dan keunikan

Mulailah dari **pengguna**, bukan dari teknologi. Pengguna kalian adalah **siswa sekolah** (dan gurunya), jadi urutannya: (1) **wawancarai calon pengguna**, minimal 3 narasumber (siswa SD/SMP dan/atau guru) tentang kesulitan dan kebiasaan belajar mereka; (2) **susun user persona** dari hasil wawancara itu; (3) pilih **masalah belajar** yang paling layak dibantu; (4) baru **rancang ide** yang menjawabnya. Ide yang lahir dari persona yang nyata hampir pasti spesifik dan berbeda dari kelompok lain.

Saat wawancara, jangan menawarkan ide kalian dan jangan menanyakan "apakah kamu mau aplikasi ini?". Mintalah narasumber menceritakan kejadian nyata terakhir ("kapan terakhir kali kamu bingung pada pelajaran itu?"), lalu catat kutipan aslinya. Wawancara dengan anak wajib seizin guru atau orang tua/wali, tanpa mencatat nama lengkap, memotret wajah, atau merekam suara anak. Pertanyaan panduan, formulir izin, dan format persona ada di templat Proposal.

Pengajuan ide memuat ringkasan, **persona hasil wawancara**, dan ide beserta pembedanya (bagian A, C2, dan D1 templat Proposal). Versi lengkapnya ditulis di **dokumen Proposal** (lihat Dokumen yang dikumpulkan di Classroom). Yang harus ada:

| Butir | Pertanyaan yang dijawab |
|---|---|
| Persona dari wawancara | Siapa narasumbernya (kode, peran, jenjang), apa temuan utamanya, dan persona yang kalian susun beserta kutipan asli yang mendasarinya. Persona harus dapat ditelusuri ke wawancara nyata. |
| Masalah belajar | Siapa (jenjang atau kelas) kesulitan memahami apa, pada topik apa? Buktinya dari wawancara dan persona yang mana? |
| Tujuan belajar | Setelah memakai aplikasi, apa yang dapat dilakukan pengguna? Tulis 2-3 tujuan yang dapat diamati. |
| Cara belajar (mekanik utama) | Bagaimana pengguna belajar lewat aplikasi? Mengapa cara itu cocok untuk topiknya, bukan sekadar dekorasi? |
| Pembeda | Apa yang membuat ide ini berbeda dari aplikasi serupa di internet dan dari ide kelompok lain yang sudah disetujui? |
| Kelayakan | Mengapa dapat selesai dalam empat minggu oleh 3 orang, termasuk uji coba pada pengguna nyata? |

**Aturan keunikan.**

- Dua ide dianggap **sama** bila **topik pembelajaran dan cara belajarnya (mekanik utama)** sama, walaupun nama, tampilan, atau tema ceritanya berbeda (mis. dua kuis pilihan ganda tentang perkalian). Mengganti gambar atau nama tokoh tidak membuat ide menjadi berbeda.
- Topik yang sama boleh dipakai dua kelompok bila cara belajarnya **jelas berbeda**, dan cara belajar yang mirip boleh bila topiknya berbeda. Dosen yang memutuskan sebuah ide cukup berbeda atau tidak.
- **Daftar ide yang disetujui** diumumkan dosen di Classroom. Periksa daftar itu sebelum mengajukan.
- Bila dua pengajuan bentrok, pengajuan yang **masuk lebih dulu** (menurut waktu kirim) dipertahankan; kelompok lain mengubah topik atau mekanik dan mengajukan ulang.
- Setelah disetujui, ide hanya boleh diganti dengan persetujuan dosen, paling lambat sebelum pos M2, dan ide penggantinya juga harus lolos aturan keunikan.
- Dosen membandingkan rancangan dan kode antar kelompok. Kemiripan yang tidak dapat dijelaskan ditanyakan saat ujian lisan.

**Batasan ide.** Aplikasi harus mengajarkan sesuatu: hiburan tanpa tujuan belajar tidak diterima. Ide tidak boleh menjiplak contoh dari dosen atau tutorial pertemuan (mis. sprite berjalan, navigasi form, bola memantul, alat gambar) tanpa dasar pembelajaran yang kalian rancang sendiri; teknik dari pertemuan itu boleh dipakai sebagai bahan. Ide tidak boleh membutuhkan server, akun, jaringan, atau perangkat khusus, dan harus memenuhi persyaratan privasi dan etika (P5).

**Contoh ide.** Dosen tidak menyediakan topik yang harus dipilih. Contoh di bawah hanya memperlihatkan **tingkat kekhususan** yang diharapkan: masalah belajarnya jelas dan cara belajarnya berbeda dari kuis biasa. Ini bukan daftar pilihan. Kelompok yang mengajukan ide yang sama persis dengan salah satu contoh dianggap kurang orisinal (nilai komponen Produk lebih rendah) dan tetap harus lolos aturan keunikan. Ubah topiknya, ubah cara belajarnya, atau cari ide lain.

| Ide | Masalah belajar dan sasaran | Cara belajar dan rancangan OOP yang mungkin |
|---|---|---|
| Neraca Persamaan (Matematika SMP kelas 7) | Siswa menghafal "pindah ruas ganti tanda" tanpa paham alasannya, sehingga salah saat soal berubah bentuk. | Simulasi neraca: pengguna menambah atau mengurangi beban di **kedua** sisi sampai `x` berdiri sendiri, dan neraca miring bila tidak seimbang. Hierarki `Beban` (beban tetap, beban `x`), interface cara menilai langkah. |
| Rangkaian Listrik Mini (IPA SMP kelas 9) | Siswa mengira arus "habis" setelah melewati lampu, dan bingung beda seri dan paralel. | Kanvas tempat menyusun baterai, saklar, dan lampu; aplikasi menghitung terang tiap lampu dan memberi misi (mis. "buat dua lampu tetap menyala bila satu dilepas"). Hierarki `Komponen`, event saat rangkaian berubah. |
| Warung Harga (IPS SMP kelas 7) | Konsep permintaan dan penawaran terasa abstrak karena hanya dibaca dari grafik. | Simulasi beberapa hari berjualan: pengguna menetapkan harga, melihat pembeli dan stok berubah, lalu membaca rekap keuntungan. Interface model permintaan dengan dua implementasi (musim biasa, musim ramai). |
| Toko Kata (Bahasa Inggris SD kelas 5) | Kosakata cepat lupa karena dilatih sekali lewat daftar kata. | Latihan adaptif: kata yang salah muncul lebih sering, yang benar berulang makin jarang (kotak Leitner). Interface penjadwal ulang dengan dua strategi. |
| Urutan Cerita (Bahasa Indonesia SD kelas 2) | Anak sulit menyusun peristiwa menjadi cerita yang runtut. | Menyusun 4-6 kartu gambar dan kalimat menjadi cerita yang masuk akal, dengan penjelasan mengapa urutan tertentu keliru. Hierarki `Kartu`, penilai urutan yang dapat diganti. |
| Ritme Ketuk (Seni Musik SD kelas 4) | Nilai not (satu ketuk, setengah ketuk) sulit dibayangkan hanya dari gambar. | Pengguna mengetuk mengikuti pola ritme yang diputar; aplikasi menilai ketepatan waktu dan menampilkan not yang sedang berbunyi. Memakai `Timer` (pertemuan 10-12), `State` untuk fase latihan. |
| Tukang Ubin (Matematika SD kelas 4) | Siswa mencampur luas dan keliling karena hanya menghafal rumus. | Menyeret ubin ke lantai berpetak untuk menutup ruangan, lalu aplikasi meminta menghitung jumlah ubin dan panjang plin. Hierarki `BentukRuang`, event saat lantai penuh. |

**Terlalu umum** berarti belum ada masalah belajar yang spesifik, mis. "game kuis IPA" atau "aplikasi belajar matematika". Tanyakan: siapa yang kesulitan, pada bagian mana, dan mengapa cara belajar yang kalian pilih membantunya?

## Jadwal

| Tonggak | Waktu | Yang sudah harus ada di repo |
|---|---|---|
| Rilis soal | Selasa, 17 November 2026 | Kelompok diumumkan; mulai mewawancarai calon pengguna |
| Pengajuan ide dan akun GitHub kelompok | Jumat, 20 November 2026 pukul 23.59 WIB | Ringkasan, persona hasil wawancara, dan ide beserta pembedanya, nama, NRP, akun GitHub tiap anggota, dan tautan repo dikumpulkan di Classroom. Dosen menanggapi sesegera mungkin; selama menunggu, kerjakan kerangka dulu, jangan membangun fitur besar sebelum ide disetujui. |
| M1 (pos 1) | Minggu, 22 November 2026 pukul 23.59 WIB | Ide disetujui dosen, Proposal (dokumen) dikumpulkan di Classroom, repo aktif dengan commit semua anggota, aplikasi kerangka sudah dapat dijalankan |
| M2 (pos 2) | Minggu, 29 November 2026 pukul 23.59 WIB | Inti logika: hierarki kelas, enkapsulasi, interface dan DI (K1-K4), satu alur belajar dapat dijalankan dari awal sampai akhir |
| M3 (pos 3) | Minggu, 6 Desember 2026 pukul 23.59 WIB | Isi lengkap (minimal 3 level, 30 butir), exception dan event (K5-K6), uji coba dengan minimal 3 orang dan perbaikan dari temuan, paket rilis pertama |
| Sesi uji silang (rencana) | Selasa, 8 Desember 2026 | Tiap kelompok memainkan aplikasi kelompok lain dan memberi umpan balik tertulis |
| Batas akhir | Minggu, 13 Desember 2026 pukul 23.59 WIB | Semua persyaratan dan paket rilis yang berfungsi; **Laporan Akhir** (dokumen, memuat tautan repo dan paket rilis) dikumpulkan di Classroom |
| Presentasi dan lisan | Selasa, 15 Desember 2026 | Demo langsung di laptop dan tanya jawab individu |

## Produk yang dibuat

| ID | Persyaratan | Rincian |
|---|---|---|
| P1 | Ide, sasaran, dan isi | Ide milik kelompok sendiri, **disetujui dosen**, dan berbeda dari kelompok lain (lihat Ide dan keunikan). Untuk siswa SD sampai SMP, satu mata pelajaran atau topik. Minimal **3 level** atau tingkat kesulitan dan isi yang setara minimal **30 butir** (soal, tantangan, kartu, skenario, atau langkah). Bila jenis aplikasi kalian tidak cocok dengan hitungan butir, sepakati ukuran setara dengan dosen di proposal. Isi harus akurat dan sesuai jenjang; cantumkan sumber rujukan di README. |
| P2 | Pedagogi | Ada umpan balik edukatif (penjelasan singkat saat jawaban atau tindakan benar maupun salah), bukan hanya "benar/salah". Kemajuan pengguna terlihat (skor, bintang, atau level). Bahasa ramah anak. Tanpa konten kekerasan, judi, atau iklan. |
| P3 | Dapat dijalankan dan mudah dipakai | Guru atau penguji dapat menjalankan aplikasi **tanpa Visual Studio**: sertakan paket rilis (zip hasil `dotnet publish src/Aplikasi -c Release -r win-x64 --self-contained true -o terbit`) di GitHub Releases, tautannya di README, dan uji di komputer lain selain milik pembuat. Tampilan tidak patah di layar 1366 x 768, teks isi minimal 14 pt, tombol mudah diklik, dan ada cara bermain atau petunjuk di dalam aplikasi. |
| P4 | Progres tersimpan | Skor atau level yang sudah dicapai tersimpan di komputer lewat `IPenyimpanan` (mis. berkas JSON di folder `%AppData%`) dan tetap ada setelah aplikasi ditutup lalu dibuka lagi. Tidak ada akun, server, atau jaringan. |
| P5 | Privasi dan etika | Tidak mengumpulkan data pribadi, tidak mengirim data lewat jaringan, tidak memakai pelacak atau iklan. Gambar dan suara buatan sendiri atau berlisensi bebas dengan sumber dicatat. Wawancara dan uji coba pada anak dilakukan dengan izin guru atau orang tua/wali (formulir di Lampiran 1 templat Proposal), tanpa mencatat nama lengkap, memotret wajah, atau merekam suara anak, dan **tidak ada nama atau foto anak** di repo maupun dokumen. |
| P6 | Pengujian dan uji coba pengguna nyata | Diuji pada minimal **3 orang** dari sasaran (anak SD/SMP, atau guru bila anak sulit dijangkau), dengan mengamati mereka memakai aplikasi. Narasumber wawancara boleh ikut menguji dan sebaiknya ada minimal satu penguji baru; cocokkan hasilnya dengan persona. Tulis di bagian Uji coba pengguna nyata pada Laporan Akhir: siapa (cukup usia atau kelas), apa yang diamati, temuan, dan minimal **3 perbaikan** yang kalian kerjakan karena temuan itu. |
| P7 | Panduan singkat | README memuat ide dan pembedanya, tujuan belajar, cakupan materi, cara menjalankan (dari paket rilis) dan cara memakai, ditujukan untuk guru yang ingin memakai aplikasi ini. |

## Rancangan OOP (dinilai pada proyek Logika)

Seluruh logika aplikasi ditulis di proyek **Logika** dan tidak boleh bergantung pada tampilan. Persyaratan K1-K7 sengaja dipetakan ke materi pertemuan 4-14 dan dinilai dosen saat demo dengan membaca kode proyek Logika. Rancangan kelasnya ditentukan oleh ide kalian; dua kelompok dengan ide berbeda akan punya rancangan berbeda.

| ID | Persyaratan | Rincian |
|---|---|---|
| K1 | Enkapsulasi (P4) | Tidak ada field `public`. Data dibuka lewat properti atau method yang memvalidasi (konstruktor atau setter melempar `ArgumentException` atau turunannya). Minimal satu `private set` atau `init`. Koleksi internal dibuka sebagai `IReadOnlyList<T>`, bukan `List<T>`. |
| K2 | Komposisi dan pewarisan (P5) | Minimal satu hierarki: induk dengan minimal 2 turunan dan `: base(...)`. Minimal dua hubungan komposisi (has-a), mis. level memiliki daftar tantangan. |
| K3 | Polimorfisme (P6) | Minimal dua anggota `virtual` atau `abstract` yang di-`override` turunan dan dipakai lewat tipe induk (mis. berbagai jenis tantangan dalam satu daftar). `ToString()` di-override. Tidak ada rantai `if (x is A) ... else if (x is B)` sebagai pengganti polimorfisme. |
| K4 | Abstract class, interface, dan DI (P7) | Minimal satu `abstract class` dengan anggota abstrak sekaligus konkret. Minimal satu interface dengan minimal 2 implementasi (mis. cara menilai atau cara menyimpan). Ketergantungan interface disuntikkan lewat konstruktor. |
| K5 | Exception dan life cycle (P8) | Minimal dua exception kustom. `try/catch/finally` yang bermakna, tanpa `catch` kosong. Minimal satu kelas `IDisposable` yang dipakai dengan `using`. Minimal satu konstruktor berantai `: this(...)`. |
| K6 | Event (P10) | Minimal satu `event` dideklarasikan di Logika (mis. skor berubah, level selesai) dan minimal satu langganan `+=` di Logika atau Aplikasi (mis. form memperbarui tampilan saat event terjadi). |
| K7 | Logika murni | Proyek Logika tidak merujuk `System.Windows.Forms`, kelas gambar (`Bitmap`, `Graphics`, `Image`), atau proyek Aplikasi; tipe sederhana seperti `Point` dan `Rectangle` boleh. Semua yang berurusan dengan tampilan, berkas, atau jam lewat interface (mis. `IPenyimpanan`). |

Pola desain yang diterapkan dengan sengaja (misalnya Strategy untuk penilaian, State untuk layar atau keadaan, Template Method) dan dijelaskan di README menjadi nilai tambah.

## Ketentuan teknis

- Ambil kerangka solusi dari berkas zip di Classroom: ekstrak, buat repo GitHub baru, lalu jadikan kerangka itu commit pertama. Strukturnya: `src/Logika` (library C#), dan `src/Aplikasi` (Windows Forms, target `net8.0-windows`).
- Prasyarat di komputer: Windows, .NET SDK 8 atau lebih baru, dan Git. Visual Studio atau VS Code, bebas.
- Jalankan lokal: `dotnet run --project src/Aplikasi`.
- Buat paket rilis: `dotnet publish src/Aplikasi -c Release -r win-x64 --self-contained true -o terbit`, kompres folder `terbit` menjadi zip, lalu unggah ke GitHub Releases di repo kelompok. Tuliskan tautannya di README bagian **Tautan** paling lambat pos M1 (rilis percobaan boleh berisi kerangka saja), dan perbarui setiap pos.
- Folder `src/Logika/Contoh` dan bagian contoh di `Aplikasi` hanya contoh pola. Hapus setelah kalian paham; folder `Contoh` tidak ikut dinilai.
- Jangan mengumpulkan data pengguna dan jangan menyertakan pustaka yang mengirim data lewat jaringan.
- `bin/`, `obj/`, dan `terbit/` tidak ikut ter-commit (sudah diatur di `.gitignore`).

## Kerja kelompok

- **Pembagian tugas tertulis.** Tiap anggota memiliki minimal satu subsistem (kelas, kelompok kelas, atau form) yang ia tulis sendiri, dicatat di Proposal (rencana) dan Laporan Akhir (hasil).
- **Alur git.** Kerjakan di branch kecil lalu buka **Pull Request** ke `main`; PR direview anggota lain sebelum digabung. Tiap anggota minimal **3 PR** dan **10 commit** atas nama akun GitHub-nya sendiri (jangan memakai satu akun bersama).
- **Kerja bertahap.** Commit tersebar di minimal **10 hari berbeda**. Satu commit besar menjelang batas tidak memenuhi.
- **Kontribusi.** Kontribusi sebaiknya seimbang. Anggota yang kontribusinya di bawah 20% dari total (commit dan baris kode menurut riwayat git) akan ditanyai khusus saat lisan. Di pos terakhir, setiap anggota mengisi penilaian antaranggota yang dikirim ke dosen secara pribadi.

## Dokumen yang dikumpulkan di Classroom

Proposal dan Laporan Akhir berbentuk **dokumen** (Word atau Google Docs; kumpulkan sebagai .docx atau PDF), **satu dokumen per kelompok**, dikumpulkan di tugas Classroom yang disediakan dosen. Tulis nama, NRP, dan kode kelompok seluruh anggota serta tautan repo di halaman pertama. Templat tiap dokumen (berisi bagian-bagian di bawah) dibagikan di Classroom. Dokumen tidak dikumpulkan di repo; repo memuat kode dan catatan proses, dan tautannya dikumpulkan di Classroom.

| Dokumen | Waktu | Fungsi |
|---|---|---|
| Pengajuan ide (ringkasan, persona, ide) + tautan repo | Jumat, 20 November 2026 pukul 23.59 WIB | Mendapat persetujuan ide, memastikan ide tidak bentrok dengan kelompok lain, dan memastikan persona berasal dari wawancara |
| Proposal | Minggu, 22 November 2026 pukul 23.59 WIB | Rancangan lengkap sebelum membangun fitur besar, dengan Lampiran 1 (izin) dan Lampiran 2 (dokumentasi wawancara); dasar penilaian kesesuaian rencana dan hasil |
| Laporan Akhir (memuat pengujian) + tautan repo dan paket rilis | Minggu, 13 Desember 2026 pukul 23.59 WIB | Bukti rancangan, pengujian, dan uji coba pengguna; dibaca dosen saat demo |

**Bagian Proposal.**

| Bagian | Isi |
|---|---|
| A. Ringkasan proyek | Maksimal 100 kata: siapa penggunanya, kesulitan belajar yang ditemukan dari wawancara, dan aplikasi yang akan dibuat. |
| B. Narasumber dan sasaran aplikasi | Daftar narasumber wawancara (minimal 3: kode, peran, jenjang atau mata pelajaran, tanggal, izin), serta sasaran dan konteks pemakaian: jenjang, topik, tempat, dan perangkat yang tersedia. |
| C. Temuan wawancara dan persona | Peta temuan wawancara, **user persona** (satu utama, satu persona guru atau persona kedua disarankan) yang dapat ditelusuri ke kode narasumber, masalah belajar yang dipilih beserta buktinya, dan tujuan belajar. |
| D. Ide dan solusi | Ide dan pembeda (dari aplikasi serupa dan dari ide kelompok lain), alur aplikasi yang dihubungkan dengan kebutuhan persona, paket wajib, daftar fitur, di luar ruang lingkup, dan kriteria keberhasilan. |
| E. Rancangan OOP awal | Kelas utama proyek Logika, rencana memenuhi K1-K7, diagram kelas awal, wireframe, penyimpanan progres, dan sumber isi pembelajaran. |
| F. Rencana kerja | Kegiatan per minggu dengan luaran dan penanggung jawab, serta pembagian tugas anggota. |
| G. Kebutuhan isi dan rencana pertemuan dengan narasumber | Materi, soal, dan aset yang dibutuhkan beserta batas waktunya, validasi isi oleh guru, dan rencana tiga pertemuan dengan narasumber. |
| H. Risiko dan mitigasi | Apa yang paling mungkin menghambat selesai dalam empat minggu, dan bagaimana mengatasinya. |
| I. Penggunaan AI | Rencana penggunaan AI. Wawancara dan persona tidak boleh dikarang atau dihasilkan AI. |
| J. Pernyataan kelompok | Pernyataan bahwa wawancara dan persona nyata, izin ada, privasi anak dijaga, dan ide orisinal; ditandatangani seluruh anggota. |
| Lampiran 1. Formulir persetujuan | Persetujuan wawancara dan uji coba, ditandatangani guru atau orang tua/wali (atau narasumber dewasa itu sendiri). |
| Lampiran 2. Dokumentasi wawancara dan persona | Log wawancara, pertanyaan panduan, catatan per narasumber, bukti (tanpa wajah anak), dan daftar periksa. |

**Bagian Laporan Akhir.**

| Bagian | Isi |
|---|---|
| 1. Identitas | Nama aplikasi, kode kelompok, nama, NRP, dan akun GitHub tiap anggota, serta **tautan repo dan paket rilis**. |
| 2. Ringkasan aplikasi | Ide dan pembedanya, sasaran, tujuan belajar, dan cara memakai aplikasi. Sertakan tangkapan layar tiap layar utama. |
| 3. Rancangan OOP | Diagram kelas akhir yang cocok dengan kode, keputusan rancangan dan alasannya, pola desain yang dipakai, dan **pemetaan K1-K7**: untuk tiap butir, sebutkan kelas dan berkas yang memenuhinya. |
| 4. Pengujian fungsional manual | Tabel skenario uji untuk fitur utama: langkah, hasil yang diharapkan, hasil sebenarnya, dan status (lulus atau gagal). Sertakan juga pengujian pada kasus tepi (input kosong, nilai di luar rentang, data tersimpan rusak) dan pengujian paket rilis di komputer lain. |
| 5. Uji coba pengguna nyata | Minimal **3 orang** dari sasaran (cukup tulis usia atau kelas; jangan nama atau foto anak). Untuk tiap penguji: tanggal, apa yang diamati, dan temuan. Lalu minimal **3 perbaikan** yang kalian kerjakan karena temuan itu, dihubungkan dengan commit atau PR-nya. Nilai juga apakah kebutuhan persona terpenuhi. Catatan yang jujur lebih berharga daripada yang mulus. |
| 6. Pembagian tugas dan kontribusi | Subsistem yang ditulis tiap anggota, dengan tautan PR yang mewakilinya, dan ringkasan kontribusi lain (rancangan, review, uji coba). |
| 7. Penggunaan AI | Ringkasan penggunaan AI oleh tiap anggota (rincian ada di `AI-LOG.md` di repo). Tulis "tidak memakai AI" bila memang tidak. |
| 8. Kendala, refleksi, dan pengembangan lanjut | Kendala terbesar dan cara mengatasinya, apa yang akan kalian rancang berbeda bila mengulang, dan fitur lanjutan yang mungkin. |
| 9. Lampiran dan sumber | Sumber rujukan isi pembelajaran dan sumber gambar atau suara beserta lisensinya. |

Proposal boleh berubah setelah dikumpulkan karena rencana memang berkembang. Bila ide atau rancangan berubah besar, jelaskan perubahannya di Laporan Akhir.

## Bukti proses di repo

| Bukti | Isi minimum |
|---|---|
| AI-LOG.md | Satu bagian per anggota: prompt ringkas, bagian yang dipakai, apa yang diubah. Tulis "tidak memakai AI" bila memang tidak. |
| Riwayat git dan PR | Commit dan PR tiap anggota, dengan pesan yang menjelaskan isinya. |

## Demo kelompok dan ujian lisan individu

Pada pertemuan 16, kelompok dipanggil **satu per satu**. Tiap kelompok **mendemokan aplikasi langsung di laptop** (sekitar 5 menit), menjelaskan ide beserta pembedanya dan arsitekturnya, lalu **tiap anggota ditanya secara individu sekitar 8 menit**. Pertanyaan dirakit dari kode yang benar-benar ditulis anggota itu dan dari arsitektur seluruh aplikasi, sehingga berbeda untuk tiap orang.

| Bagian | Yang dilakukan | Contoh |
|---|---|---|
| 1. Telusuri bagian sendiri | Menjelaskan alur dari satu aksi pengguna sampai tampilan berubah, melewati kelas yang ia tulis | "Saat pengguna menekan jawaban, method apa saja yang berjalan? Mana yang dipilih saat runtime?" |
| 2. Prediksi | Menebak akibat perubahan satu bagian kode sebelum dicoba | "Jika `override` di kelas ini dihapus? Jika setter ini menjadi public?" |
| 3. Ubah langsung | Satu perubahan kecil tanpa AI dan internet | Menambah satu jenis tantangan baru tanpa mengubah kelas lain; menambah satu aturan penilaian lewat interface |
| 4. Seluruh arsitektur | Menjelaskan bagian kelompok yang bukan tulisannya | "Mengapa Logika tidak boleh tahu tentang form? Siapa yang memanggil `IPenyimpanan`?" |

## Rubrik penilaian

Nilai proyek akhir (0-100) terdiri atas bagian kelompok dan bagian individu:

| Komponen | Bobot | Jenis |
|---|---|---|
| Desain OOP (K1-K7 pada Logika) | 25% | Kelompok |
| Produk (ide dan keunikan, isi, pedagogi, kemudahan dipakai) | 15% | Kelompok |
| Kualitas kode dan pengujian manual | 5% | Kelompok |
| Proses dan dokumentasi | 10% | Kelompok |
| Demo dan presentasi | 5% | Kelompok |
| Ujian lisan individu | 25% | Individu |
| Kontribusi (riwayat git, PR, penilaian antaranggota) | 15% | Individu |

Persyaratan P1-P7 dinilai pada komponen Produk dan Proses; K1-K7 pada Desain OOP. Proposal dan Laporan Akhir (termasuk pengujian manual dan uji coba pengguna) dinilai pada Proses dan dokumentasi serta Kualitas kode dan pengujian. Pada komponen Produk, ide yang **orisinal, spesifik pada masalah belajar yang nyata, dan cara belajarnya mendukung tujuan** dinilai lebih tinggi daripada ide yang umum. Produk yang lengkap tetapi tidak dipahami anggotanya tidak akan mendapat nilai bagus. Ketidakhadiran pada jadwal lisan tanpa alasan sah memberi skor 0 pada komponen lisan anggota itu.

## FAQ

**Apakah harus berbentuk game?**

Tidak. Game, kuis, simulasi, alat peraga interaktif, latihan bertahap, atau penjelas interaktif boleh, asalkan pengguna belajar sesuatu dan persyaratan P1-P7 dan K1-K7 terpenuhi.

**Bolehkah idenya mirip aplikasi yang sudah ada di internet?**

Boleh terinspirasi, tetapi tuliskan pembedanya di Proposal dan jangan menyalin kode, gambar, atau suara. Yang tidak boleh adalah mirip dengan kelompok lain di kelas ini (lihat aturan keunikan).

**Idenya bentrok dengan kelompok lain. Bagaimana?**

Pengajuan yang masuk lebih dulu dipertahankan. Kelompok yang lain mengubah topik atau cara belajarnya, lalu mengajukan ulang. Cara termudah menghindarinya: periksa daftar ide yang disetujui dan ajukan lebih awal.

**Bolehkah ide diganti setelah disetujui?**

Boleh dengan persetujuan dosen sebelum pos M2, dan ide baru harus lolos aturan keunikan. Setelah itu tidak boleh.

**Bolehkah memakai animasi sprite, timer, atau perpindahan form seperti di pertemuan 10-14?**

Boleh dan menjadi nilai tambah bila memang mendukung cara belajarnya. Logikanya tetap harus ada di proyek Logika.

**Bolehkah menambah proyek atau paket baru?**

Boleh (mis. proyek library tambahan atau paket NuGet), selama logika tetap terpisah dari tampilan (K7) dan solusi dapat dibangun dengan `dotnet build`.

**Tidak ada anggota yang punya komputer Windows.**

Hubungi dosen sebelum pos M1. Windows Forms hanya berjalan di Windows, jadi kita carikan solusi (mis. memakai komputer lab) sejak awal, bukan di akhir.

**Bagaimana menguji pada anak jika tidak punya adik atau keponakan?**

Hubungi guru di sekolah kalian dulu, atau minta tetangga atau saudara. Bila benar-benar sulit, minta guru SD/SMP mencoba dan memberi catatan untuk kalian tulis di Laporan Akhir. Jangan membuat catatan uji coba rekaan.

**Siapa yang membuat repo, dan harus di organisasi?**

Salah satu anggota membuatnya di akun GitHub-nya sendiri; tidak perlu organisasi. Tambahkan dua anggota lain sebagai collaborator. Tautannya dikumpulkan di Classroom bersama pengajuan ide dan Laporan Akhir.

**Repo kami privat. Bagaimana dosen melihatnya?**

Tambahkan akun GitHub dosen (username diumumkan di Classroom) sebagai collaborator, atau jadikan repo publik. Pastikan paket rilis juga dapat diunduh.

**Bagaimana cara mewawancarai siswa?**

Singkat (15-20 menit), santai, dan seizin guru atau orang tua. Minta mereka menceritakan kejadian nyata ("kapan terakhir kali kamu bingung?"), jangan menawarkan ide. Catat kutipan aslinya. Pertanyaan panduan ada di Lampiran 2 templat Proposal.

**Kami sulit menjangkau siswa atau guru. Bagaimana?**

Mulai dari orang yang kalian kenal: adik, keponakan, tetangga, murid les, atau guru di sekolah lama. Bila sama sekali sulit, wawancarai minimal dua guru. Hubungi dosen sebelum pengajuan ide; jangan mengarang narasumber.

**Bolehkah persona dibuat dengan bantuan AI?**

AI boleh membantu merapikan tulisan, tetapi isi persona harus berasal dari wawancara nyata dan dapat ditelusuri ke kode narasumber. Persona karangan atau hasil AI tanpa wawancara dianggap pemalsuan.

**Anggota kami tidak aktif. Bagaimana?**

Beri tahu dosen secepatnya, bukan di akhir. Riwayat git dan PR dipakai sebagai bukti, dan nilai individu mengikuti kontribusi nyata.

**Boleh memperbaiki setelah batas waktu?**

Tidak. Penilaian memakai commit terakhir sebelum batas waktu.
