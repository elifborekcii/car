3D Araba Simülasyonu ve Yarış Oyunu

Bu proje, Unity oyun motoru kullanılarak geliştirilmekte olan 3D bir araba sürme ve yarış simülasyonudur. Proje şu anda **aktif geliştirme aşamasındadır** ve temel sürüş mekanikleri ile çevre tasarımları tamamlanmıştır.

Projenin Amacı ve Mevcut Durum

Bu projenin temel amacı, Unity'nin fizik motorunu (Rigidbody, Wheel Colliders) anlamak ve C# ile obje etkileşimlerini koda dökmektir. 

Şu anki sürümde tamamlanan özellikler:
*   **Temel Araç Fiziği:** Aracın hızlanma, frenleme ve dönüş dinamikleri.
*   **Pist ve Çevre Tasarımı:** Asfalt dokusu, doğa manzarası (ağaçlandırma) ve yarış atmosferini destekleyen görsel öğeler.
*   **Çarpışma Kontrolleri (Colliders):** Aracın pist dışına çıkmasını engelleyen, pist sınırları boyunca özel olarak ayarlanmış Mesh/Box Collider sistemleri.

Planlanan Geliştirmeler (Yakında)

Oyunun oynanışını zenginleştirmek için üzerine çalıştığım ve yakında eklenecek mekanikler:
*   **Toplanabilir Objeler (Collectibles):** Pist üzerine yerleştirilecek altın/jeton gibi objeler ve bunları topladıkça artan bir Skor Sistemi.
*   **Yarış Mekanikleri:** Süreye karşı yarış (Time Trial) veya belirli görevleri tamamlama dinamikleri.
*   **UI (Kullanıcı Arayüzü) Geliştirmeleri:** Hız göstergesi, güncel skor ve bitiş ekranı tasarımları.

Kullanılan Teknolojiler

*   **Oyun Motoru:** Unity 3D
*   **Programlama Dili:** C#
*   **Geliştirme Ortamı:** Visual Studio
*   **Versiyon Kontrolü:** Git & GitHub

Projeyi Bilgisayarınızda Çalıştırmak İçin

Projenin mevcut kodlarını ve sahne hiyerarşisini Unity editöründe incelemek isterseniz:

1. Sağ üstteki yeşil **Code** butonuna tıklayıp **Download ZIP** seçeneği ile projeyi indirin.
2. Dosyaları ZIP'ten çıkardıktan sonra **Unity Hub** üzerinden **Add** diyerek klasörü seçin.
3. Proje açıldığında `Assets/Scenes` klasöründeki ana sahneyi (SampleScene) çalıştırarak inceleyebilirsiniz.

---
*Bu proje, Yönetim Bilişim Sistemleri (YBS) eğitimim kapsamında yazılım geliştirme ve oyun tasarımı becerilerimi pratikte uygulamak amacıyla açık kaynaklı olarak geliştirilmektedir.*
