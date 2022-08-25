
namespace SesliSessizApp.Services
{
    internal class StringIslemleriService
    {
        string[] _sesliler = new string[8]
        {
            "a", "e" , "ı", "i", "o", "ö", "u", "ü"
        };

        public string SesliSessizHarfBul(string kelime, bool sesliMi)
        {
            // 1.Basla
            // 2. Kullanıcıdan kelıme alınır
            // 3. Kullanıcıdan sesli / sessiz alınır
            // 4. kelime uzerinde dönülür
            // 5. sesli dizisi oluşturulur
            // 6. kelimenin döngüdeki karakteri sesliler içindeyse = sesliMi true ise
            // 7. sonuç string'ine sesli harf eklenir

            // ankara
            string sonuc = "";
            bool sesliHarfMi;
            if (sesliMi)
            {
                foreach (char kelimeHarf in kelime)
                {
                    foreach (string sesliHarf in _sesliler)
                    {
                        if (kelimeHarf.ToString().ToLower() == sesliHarf)
                        {
                            if (!sonuc.Contains(kelimeHarf.ToString()))
                              
                            sonuc = sonuc + kelimeHarf;
                            break;
                        }
                    }

                }
            }
            else
            {
                for (int i = 0; i < kelime.Length; i++)
                {
                    sesliHarfMi = false;
                    for (int j = 0; j < _sesliler.Length; j++)
                    {
                        if (kelime[i].ToString().ToLower() == _sesliler[j])
                        {
                            sesliHarfMi = true;
                            break;
                        }
                    }
                    if (!sesliHarfMi)
                    {
                        if (!sonuc.Contains(kelime[i].ToString()))
                            sonuc += kelime[i];
                    }
                }
            }

            return sonuc;
        }

        // çaGIL LEO AlsaÇ --> Çagıl Alsaç
        public string İlkHarfleriBuyult(string cumle)
        {
           
                string sonuc = "";
                if (string.IsNullOrWhiteSpace(cumle))
                {
                    sonuc = "Lütfen minimum bir kelime içeren cümle giriniz...";
                    return sonuc;
                    //return "Lütfen minimum bir kelime içeren cümle giriniz..."; boyle de yazabiliriz
                    // bu yontem daha kısa yol
                }

                string[] kelimeler = cumle.Split(' ');

                // for ile nasıl çözulur tamamlamadım daha
                //for (int i = 0; i < kelimeler.Length; i++)
                //{
                //    sonuc = kelimeler[i].Substring(0, 1).ToUpper(); 

                //}

                foreach (string kelime in kelimeler)
                {
                    sonuc += kelime.Substring(0, 1).ToUpper(); // Ç
                    sonuc += kelime.Substring(1).ToLower(); // Çagıl
                    sonuc += " ";
                }

                return sonuc.Trim();
            
        }
    }
}
