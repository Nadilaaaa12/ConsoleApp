using System;
using System.Data;
using System.Data.SqlClient;

namespace PenjadwalanSiswa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            while (true)
            {
                try
                {
                    Console.WriteLine("Masukkan database tujuan: ");
                    Console.WriteLine("1. Masukkan UserName: ");
                    Console.WriteLine("2. Masukkan Password: ");
                    string db = Console.ReadLine();
                    Console.Write("\nKetik K untuk Terhubung ke database: ");
                    char chr = Convert.ToChar(Console.ReadLine());
                    switch (chr)
                    {
                        case 'K':
                            {
                                SqlConnection conn = null;
                                string strKoneksi = "Data Source = NADILA\\NADILA; " +
                                    "initial catalog = PenjadwalanSiswa;" +
                                    "User ID = sa; password = 123456";
                                conn = new SqlConnection(string.Format(strKoneksi, db));
                                conn.Open();
                                Console.Clear();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("\nMenu");
                                        Console.WriteLine("1. Tambah Siswa");
                                        Console.WriteLine("2. Hapus Siswa");
                                        Console.WriteLine("3. Tambah Guru");
                                        Console.WriteLine("4. Hapus Guru");
                                        Console.WriteLine("5. Tambah Mata Pelajaran");
                                        Console.WriteLine("6. Hapus Mata Pelajaran");
                                        Console.WriteLine("7. Tambah Jadwal");
                                        Console.WriteLine("8. Hapus Jadwal");
                                        Console.WriteLine("9. Melihat Seluruh Data");
                                        Console.WriteLine("10. Keluar");
                                        Console.WriteLine("\nEnter your choice (1-10): ");
                                        char ch = Convert.ToChar(Console.ReadLine());
                                        switch (ch)
                                        {
                                            case '1':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Tambah Siswa\n");
                                                    Console.WriteLine("Masukkan IdSiswa:");
                                                    string IdSiswa = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama_Siswa:");
                                                    string Nama_Siswa = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Jenis_Kelamin (L/P):");
                                                    string Jenis_Kelamin = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Kelas:");
                                                    string kelas = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Alamat:");
                                                    string Alamat = Console.ReadLine();
                                                    Console.WriteLine("Masukkan No_Telp:");
                                                    string No_Telp = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.InsertSiswa(IdSiswa, Nama_Siswa, Jenis_Kelamin, kelas, Alamat, No_Telp, conn);
                                                        Console.WriteLine("Siswa berhasil ditambahkan.");

                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\n Anda tidak memiliki " +
                                                            "akses untuk menambah data");
                                                        Console.WriteLine(e.ToString());
                                                    }

                                                }
                                                break;
                                            case '2':

                                                Console.Clear();
                                                Console.WriteLine("Hapus Siswa\n");
                                                Console.WriteLine("Masukkan IdSiswa yang akan dihapus:");
                                                string IdSiswaToDelete = Console.ReadLine();
                                                try
                                                {
                                                    pr.deleteSiswa(IdSiswaToDelete, conn);
                                                    Console.WriteLine("IdSiswa berhasil dihapus.");
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("\n Anda tidak memiliki akses untuk menghapus data");
                                                }
                                                break;

                                            case '3':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Tambah Guru\n");
                                                    Console.WriteLine("Masukkan IdGuru:");
                                                    string IdGuru = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama_Guru:");
                                                    string Nama_Guru = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Kd_Mp:");
                                                    string Kd_Mp = Console.ReadLine();
                                                    Console.WriteLine("Mp_Diampu:");
                                                    string Mp_Diampu = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.InsertGuru(IdGuru, Nama_Guru, Kd_Mp, Mp_Diampu, conn);
                                                        Console.WriteLine("Guru berhasil ditambahkan.");
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\n Anda tidak memiliki " +
                                                            "akses untuk menambah data");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;
                                            case '4':

                                                Console.Clear();
                                                Console.WriteLine("Hapus Nama_Guru\n");
                                                Console.WriteLine("Masukkan Nama_Guru yang akan dihapus:");
                                                string Nama_GuruToDelete = Console.ReadLine();
                                                try
                                                {
                                                    pr.deleteNama_Guru(Nama_GuruToDelete, conn);
                                                    Console.WriteLine("Nama_Guru berhasil dihapus.");
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("\n Anda tidak memiliki akses untuk menghapus data");
                                                }
                                                break;

                                            case '5':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Mata Pelajaran\n");
                                                    Console.WriteLine("Masukkan Kd_MP:");
                                                    string Kd_Mp = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama_Mp:");
                                                    string Nama_Mp = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Id_Siswa:");
                                                    string Id_Siswa = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.InsertMata_Pelajaran(Kd_Mp, Nama_Mp, Id_Siswa, conn);
                                                        Console.WriteLine("Mata Pelajaran berhasil ditambahkan.");
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki izin untuk menambah data.");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;

                                            case '6':
                                                Console.Clear();
                                                Console.WriteLine("Hapus Nama_Mp\n");
                                                Console.WriteLine("Masukkan Nama_Mp yang akan dihapus:");
                                                string Nama_MpToDelete = Console.ReadLine();
                                                try
                                                {
                                                    pr.deleteNama_Mp(Nama_MpToDelete, conn);
                                                    Console.WriteLine("Nama_Mp berhasil dihapus.");
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("\n Anda tidak memiliki akses untuk menghapus data");
                                                }
                                                break;

                                            case '7':
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("Input Jadwal \n");
                                                    Console.WriteLine("Masukkan Kd_Guru:");
                                                    string Kd_Guru = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Nama_Guru:");
                                                    string Nama_Guru = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Hari:");
                                                    string Hari = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Jam_Belajar:");
                                                    string Jam_Belajar = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Kelas:");
                                                    string kelas = Console.ReadLine();
                                                    Console.WriteLine("Masukkan Mata_Pelajaran:");
                                                    string Mata_Pelajaran = Console.ReadLine();
                                                    try
                                                    {
                                                        pr.InsertJadwal(Kd_Guru, Nama_Guru, Hari, Jam_Belajar, kelas, Mata_Pelajaran, conn);
                                                        Console.WriteLine("Jadwal berhasil ditambahkan.");
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.WriteLine("\nAnda tidak memiliki izin untuk menambah data.");
                                                        Console.WriteLine(e.ToString());
                                                    }
                                                }
                                                break;

                                            case '8':
                                                Console.Clear();
                                                Console.WriteLine("Hapus Jam_Belajar\n");
                                                Console.WriteLine("Masukkan Jam_Belajar yang akan dihapus:");
                                                string Jam_BelajarToDelete = Console.ReadLine();
                                                try
                                                {
                                                    pr.deleteJam_Belajar(Jam_BelajarToDelete, conn);
                                                    Console.WriteLine("Jam_Belajar berhasil dihapus.");
                                                }
                                                catch
                                                {
                                                    Console.WriteLine("\n Anda tidak memiliki akses untuk menghapus data");
                                                }
                                                break;
                                            case '9':
                                                conn.Close();
                                                Console.Clear();
                                                Main(new String[0]);
                                                return;
                                            default:
                                                {
                                                    Console.Clear();
                                                    Console.WriteLine("\nInvalid option");
                                                }
                                                break;
                                        }
                                    }
                                    catch
                                    {
                                        Console.Clear();
                                        Console.WriteLine("\nCheck for the value entered.");
                                    }
                                }
                            }
                        default:
                            {
                                Console.WriteLine("\nInvalid option");
                            }
                            break;
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Tidak dapat mengakses database tersebut\n");
                    Console.ResetColor();
                }
            }
        }
        public void baca(SqlConnection conn)
        {
            SqlCommand cmd  = new SqlCommand("Select IdSiswa,Nama_Siswa,jenis_kelamin,Alamat,No_Telp From Siswa", conn);
            SqlCommand cmd1 = new SqlCommand("Select IdGuru,Nama_Guru,Kd_Mp,Mp_Diampu From Guru", conn);
            SqlCommand cmd2 = new SqlCommand("Select Kode_Mp,Nama_Mp,Id_Siswa From Mata Pelajaran", conn);
            SqlCommand cmd3 = new SqlCommand("Select Kd_Guru,Nama_Guru,Hari,Jam_Belajar,Kelas,Mata_Pelajaran From Jadwal", conn);
            SqlDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                for (int i = 0; i < r.FieldCount; i++)
                {
                    Console.WriteLine(r.GetValue(i));
                }
                Console.WriteLine();
            }
            r.Close();
        }
        public void InsertSiswa(string IdSiswa, string Nama_Siswa, string Jenis_Kelamin, string Kelas, string Alamat, string No_Telp, SqlConnection con)
        {
            string str = "INSERT INTO Siswa (IdSiswa, Nama_Siswa, Jenis_Kelamin, Kelas, Alamat, No_Telp) " +
                "VALUES (@id, @nama, @jk, @kelas, @alamat, @noTelp)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id", IdSiswa));
            cmd.Parameters.Add(new SqlParameter("nama", Nama_Siswa));
            cmd.Parameters.Add(new SqlParameter("jk", Jenis_Kelamin));
            cmd.Parameters.Add(new SqlParameter("kelas", Kelas));
            cmd.Parameters.Add(new SqlParameter("alamat", Alamat));
            cmd.Parameters.Add(new SqlParameter("noTelp", No_Telp));

            cmd.ExecuteNonQuery();
            Console.WriteLine("Siswa Berhasil Ditambahkan");
        }
        public void deleteSiswa(String IdSiswa, SqlConnection conn)
        {
            string str = ""; str = "Delete Siswa where IdSiswa= @Id";
            SqlCommand cmd = new SqlCommand(str, conn); cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("id", IdSiswa));
            cmd.ExecuteNonQuery(); Console.WriteLine("IdSiswa Berhasil Dihapus");
        }

        public void InsertGuru(string IdGuru, string Nama_Guru, string Kd_Mp, string Mp_Diampu, SqlConnection con)
        {
            string str = "INSERT INTO Guru (IdGuru,Nama_Guru,Kd_Mp,Mp_Diampu) " + "VALUES (@IdGuru,@Nama_Guru,@Kd_Mp, @Mp_Diampu)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("IdGuru", IdGuru));
            cmd.Parameters.Add(new SqlParameter("Nama_Guru", Nama_Guru));
            cmd.Parameters.Add(new SqlParameter("Kd_Mp", Kd_Mp));
            cmd.Parameters.Add(new SqlParameter("Mp_Diampu", Mp_Diampu));

            cmd.ExecuteNonQuery();
            Console.WriteLine("Guru Berhasil Ditambahkan");
        }
        public void deleteNama_Guru(String Nama_Guru, SqlConnection conn)
        {
            string str = ""; str = "Delete Guru where Nama_Guru= @Nama_Guru";
            SqlCommand cmd = new SqlCommand(str, conn); cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("Nama_Guru", Nama_Guru));
            cmd.ExecuteNonQuery(); Console.WriteLine("Nama_Guru Berhasil Dihapus");
        }


        public void InsertMata_Pelajaran(string Kd_Mp, string Nama_Mp, string Id_Siswa, SqlConnection con)
        {
            string str = "INSERT INTO Mata_Pelajaran (Kd_Mp,Nama_Mp, Id_Siswa) VALUES (@Kd_Mp,@Id_Siswa, @Nama_Mp)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("Kd_Mp", Kd_Mp));
            cmd.Parameters.Add(new SqlParameter("Nama_Mp", Nama_Mp));
            cmd.Parameters.Add(new SqlParameter("Id_Siswa", Id_Siswa));

            cmd.ExecuteNonQuery();
            Console.WriteLine("Mata_Pelajaran Berhasil Ditambahkan");
        }
        public void deleteNama_Mp(String Nama_Mp, SqlConnection conn)
        {
            string str = ""; str = "Delete Mata_Pelajaran where Nama_Mp= @Nama_Mp";
            SqlCommand cmd = new SqlCommand(str, conn); cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("Nama_Mp", Nama_Mp));
            cmd.ExecuteNonQuery(); Console.WriteLine("Nama_Mp Berhasil Dihapus");
        }
        public void InsertJadwal(string Kd_Guru, string Nama_Guru, string Hari, string Jam_Belajar, string Kelas, string Mata_Pelajaran, SqlConnection con)
        {
            string str = "INSERT INTO JadwalPelajaran (Kd_Guru, Nama_Guru, Hari, Jam_Belajar, Kelas, Mata_Pelajaran) " +
                "VALUES (@kd_Guru, @Nama_Guru, @Hari, @Jam_Belajar, @Kelas, @Mata_Pelajaran)";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new SqlParameter("kd_Guru", Kd_Guru));
            cmd.Parameters.Add(new SqlParameter("Nama_Guru", Nama_Guru));
            cmd.Parameters.Add(new SqlParameter("Hari", Hari));
            cmd.Parameters.Add(new SqlParameter("Jam_Belajar", Jam_Belajar));
            cmd.Parameters.Add(new SqlParameter("Kelas", Kelas));
            cmd.Parameters.Add(new SqlParameter("Mata_Pelajaran", Mata_Pelajaran));

            cmd.ExecuteNonQuery();
            Console.WriteLine("Jadwal Berhasil Ditambahkan");
        }
        public void deleteJam_Belajar(String Jam_Belajar, SqlConnection conn)
        {
            string str = ""; str = "Delete Jadwal where Jam_Belajar= @NamaMp";
            SqlCommand cmd = new SqlCommand(str, conn); cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add(new SqlParameter("NmaMp", Jam_Belajar));
            cmd.ExecuteNonQuery(); Console.WriteLine("Jam_Belajar Berhasil Dihapus");
        }

    }
}

