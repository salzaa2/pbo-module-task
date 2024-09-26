// Kelas Hewan
public class Hewan
{
    public string Nama { get; set; }
    public int Umur { get; set; }

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama} \nUmur: {Umur} tahun";
    }
}

// Kelas Mamalia yang mewarisi kelas Hewan
public class Mamalia : Hewan
{
    public int JumlahKaki { get; set; }

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $" \nJumlah Kaki: {JumlahKaki}";
    }
}

// Kelas Reptil yang mewarisi Hewan
public class Reptil : Hewan
{
    public double PanjangTubuh { get; set; }

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $" Panjang Tubuh: {PanjangTubuh} cm";
    }
}

// Kelas Singa yang mewarisi Mamalia
public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Singa itu mengaum";
    }

    public void Mengaum()
    {
        Console.WriteLine($"{Nama} itu mengaum");
    }
}

// Kelas Gajah yang mewarisi Mamalia
public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Gajah itu mengeluarkan suara seperti terompet";
    }
}

// Kelas Ular yang mewarisi Reptil
public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Ular itu mendesis";
    }

    public void Merayap()
    {
        Console.WriteLine($"{Nama} sedang merayap di tanah");
    }
}

// Kelas Buaya yang mewarisi Reptil
public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Buaya itu menggeram";
    }
}

// Kelas KebunBinatang
public class KebunBinatang
{
    private List<Hewan> koleksiHewan;

    public KebunBinatang()
    {
        koleksiHewan = new List<Hewan>();
    }

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        Console.WriteLine("Daftar Hewan di Kebun Binatang:");
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
            Console.WriteLine($"Suara: {hewan.Suara()}\n");
        }
    }
}

// Main Method
class Program
{
    static void Main(string[] args)
    {
        // Membuat objek kebun binatang dan hewan
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Leo", 5, 4);
        Gajah gajah = new Gajah("Trunky", 10, 4);
        Ular ular = new Ular("Snappy", 2, 3.5);
        Buaya buaya = new Buaya("Croco", 7, 5);

        // Menambahkan hewan ke kebun binatang
        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        // Selanjutnya menampilkan daftar hewan di kebun binatang
        kebunBinatang.DaftarHewan();

        // Demonstrasi Polymorphism
        Console.WriteLine("Demonstrasi Polymorphism:");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());

        // Untuk memanggil method khusus
        singa.Mengaum();
        ular.Merayap();
    }
}