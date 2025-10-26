⚙️ Yapılandırma (Configuration)
Kütüphaneyi kullanmaya başlamak için uygulamanızın giriş noktasında (örn: Program.cs veya Startup.cs) SetupLocalize metodunu çağırmanız yeterlidir.
<code> 
LocalizerSetup.SetupLocalize(*Globalization.json dosyası için path*);
</code>

Bu kod, belirtilen yolda (config/Globalization.json) bir JSON dosyası arar. Eğer dosya yoksa, otomatik olarak oluşturur.

📋 Globalization.json Dosya Yapısı
Kütüphane, çeviriler için aşağıdaki JSON yapısını bekler. Dosyayı manuel olarak düzenleyerek yeni diller ve anahtarlar (key) ekleyebilirsiniz.

<pre>
[
  {
    "Key": "exampleKey",
    "Values": [
      {
        "Lang": "es",
        "Value": "Valor de la muestra"
      },
      {
        "Lang": "en",
        "Value": "Example Value"
      },
      {
        "Lang": "tr",
        "Value": "Örnek Değer"
      }
    ]
  }
]
</pre>

Usage (Kullanım)
Kurulum tamamlandıktan sonra, herhangi bir string değeri üzerinde .Localize()/.Localize(*dil key'i*) extension metodunu kullanabilirsiniz.

1. Varsayılan Dili Kullanma
Bu kullanım, LanguageSettings.CurrentLanguage içinde tanımlı olan dili baz alır.

2. Belirli Bir Dil Belirterek Kullanma
Metodun parametresine bir dil kodu ("en", "es" vb.) vererek o dile ait çeviriyi zorunlu olarak alabilirsiniz.

3. Anahtar Bulunamazsa
Eğer Globalization.json içerisinde ilgili anahtar (Key) veya o anahtara ait dil çevirisi bulunamazsa, metot hata dönecektir.

🤝 Katkıda Bulunma
Katkıda bulunmak isterseniz, lütfen bir Pull Request (PR) açın veya "Issues" bölümünden bir konu başlığı oluşturun.

Projeyi forklayın.

Kendi özellik dalınızı oluşturun (git checkout -b ozellik/yeni-ozellik).

Değişikliklerinizi yapın ve commit'leyin (git commit -m 'Yeni özellik eklendi').

Dalınızı push'layın (git push origin ozellik/yeni-ozellik).

Bir Pull Request (PR) açın.
