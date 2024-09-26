using System;

class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebunBinatang = new KebunBinatang();

        Singa singa = new Singa("Singa", 8, 4);
        Gajah gajah = new Gajah("Gajah", 40, 4);
        Ular ular = new Ular("Ular", 5, 3.5);
        Buaya buaya = new Buaya("Buaya", 10, 4.0);

        kebunBinatang.TambahHewan(singa);
        kebunBinatang.TambahHewan(gajah);
        kebunBinatang.TambahHewan(ular);
        kebunBinatang.TambahHewan(buaya);

        kebunBinatang.DaftarHewan();

        Console.WriteLine("\nMemanggil method Suara() untuk beberapa hewan berbeda : ");
        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        Console.WriteLine("\n=== Method Khusus ===");
        singa.Mengaum();
        ular.Merayap();
    }
}

class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        this.Nama = nama;
        this.Umur = umur;
    }
    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }
    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur}";
    }
}

class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        this.JumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        this.PanjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh} meter";
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Singa mengaum";
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa sedang mengaum");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki)
    {
    }

    public override string Suara()
    {
        return "Gajah mengeluarkan suara terompet";
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Ular mendesis";
    }

    public void Merayap()
    {
        Console.WriteLine("Ular sedang merayap");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh)
    {
    }

    public override string Suara()
    {
        return "Buaya menggeram";
    }
}

class KebunBinatang
{
    public List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
        Console.WriteLine($"{hewan.Nama} berhasil ditambahkan ke kebun binatang.");
    }

    public void DaftarHewan()
    {
        Console.WriteLine("\nDaftar Hewan di Kebun Binatang");
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}