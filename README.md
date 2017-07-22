# ASP.NET Core & PostgreSQL Code Samples
Repository ini berisi contoh-contoh aplikasi web yang dibangun dengan ASP.NET Core untuk mengakses database PostgreSQL.  Setiap sebuah contoh aplikasi web akan disimpan di dalam sebuah folder.  Kode program pada repository ini ditulis dengan menggunakan Visual Studio Code.  
Berikut adalah daftar contoh aplikasi web yang ada di sini:
- BelajarASPNETCoreMVC
- PgDatabaseFirst
- PgCodeFirst
- PgIdentity
- EFCoreBookStore

## BelajarASPNETCoreMVC
BelajarASPNETCoreMVC adalah aplikasi web sangat sederhana yang berfungsi untuk menampilkan daftar pengisi buku tamu dan form untuk mengisi buku tamu.  Aplikasi ini memberikan contoh cara kerja ASP.NET Core MVC.

## PgDatabaseFirst
PgDatabaseFirst adalah aplikasi web yang memberikan contoh implementasi pendekatan Databaset First.  Pendekatan ini adalah pembangunan aplikasi web yang umum dilakukan, yaitu dengan cara membuat database dan table-table terlebih dahulu. Kemudian dilanjutkan dengan menulis kode untuk mengakses database tersebut. 

## PgCodeFirst
PgCodeFirst adalah aplikasi web yang memberikan contoh implmentasi pendekatan Code First dimana database dan table-table tidak dibuat di awal pembangunan aplikasi web.  Pada pendekatan ini yang pertama dibuat adalah kode program terlebih dahulu, yaitu class entity model yang merupakan representasi dari table.  Kemudian secara otomatis pembuatan database dan table-table dilakukan dengan menggunakan bantuan Entity Framework Core. 

## PgIdentity
PgIdentity adalah aplikasi web yang memberikan contoh implementasi framework ASP.NET Core Identity. Framework ini memudahkan implementasi pengelolaan user dan role serta implementasi keamanan.  Implementasi keamanan tersebut adalah proses otentikasi dan otorisasi. gunakan pada project ini adalah Database First, artinya database dan tabel-tabel telah dipersiapkan terlebih dahulu.

## PgBookStore
Book store adalah aplikasi web menggunakan ASP.NET Core MVC dan Bootstrap 3 framework untuk antarmuka. Database yang digunakan adalah PostgreSQL. Aplikasi web ini menggunakan pendekatan Code First dan implementasi ASP.NET Core Identity. Fitur-fitur aplikasi web ini adalah:
- Mengelola pengarang buku, fitur ini dapat digunakan untuk menampilkan, menambah, mengedit dan menghapus data pengarang buku.
- Mengelola kategori buku, fitur ini dapat digunakan untuk menampilkan, menambah, mengedit dan menghapus data kategori buku.
- Mengelola buku, fitur ini dapat digunakan untuk menampilkan, menambah, mengedit dan menghapus data buku.
- Mengelola role, fitur ini dapat digunakan untuk menampilkan, menambah, mengedit dan menghapus data role.
- Mengelola user, fitur ini dapat digunakan untuk menampilkan, menambah, mengedit dan menghapus data user.
