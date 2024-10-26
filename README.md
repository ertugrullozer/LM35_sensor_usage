# LM35_sensor_usage
LM35 Sıcaklık Sensörü ile Arduino ve C# Form Uygulaması Üzerinden Seri Haberleşme Projesi

Bu proje, Arduino ile LM35 sıcaklık sensöründen sıcaklık verisi okuyarak, bu veriyi C# form uygulamasına seri haberleşme yoluyla iletmeyi amaçlar.

Donanım Bağlantıları:

LM35 Sensörü: VCC → 5V, GND → GND, OUT → A0 pinine.
Arduino-Bilgisayar: USB kablo ile bağlanır.
Arduino Kodu:

LM35'ten sıcaklık değerini okuyarak seri porttan C# uygulamasına gönderir.
C# Form Uygulaması:
![C#Görsel](https://github.com/user-attachments/assets/ba2f21ef-7437-4729-acfb-91a4dc1d7435)

Seri port üzerinden gelen sıcaklık verisini alır ve ekranda görüntüler.
Proje tamamlandığında, sıcaklık verileri Arduino üzerinden C# uygulamasına aktarılacak ve kullanıcıya anlık olarak gösterilecektir.
