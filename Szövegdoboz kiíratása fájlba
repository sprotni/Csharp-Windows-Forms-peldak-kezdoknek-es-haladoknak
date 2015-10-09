///////////
        private void szovegdobozoktartalmanakkiiratasa_buttonclick(object sender, EventArgs e)
        {
            
            Directory.CreateDirectory("Letrehozokegymappat/abbaisegymappat");
            using (StreamWriter sw1 = new StreamWriter("Megadomahelyet.txt"))
            {
                sw1.WriteLine("hakellvalamikipotlasele" + szovegdoboz1.Text);
                sw1.WriteLine("hakellvalamikipotlasele" + szovegdoboz2.Text);
            }
        }
//////////
Szükséges lehet:

using System.IO;

//////////
Leírás és magyarázat:

Ha ezt hozzárendeljük egy gomb click actionjéhez akkor az fog történni, hogy a WindowsForm ablakunkban elhelyezett gomb
a megnyomáskor egy mappát létrehoz (elhagyható) további almappákkal együtt "Letrehozokegymappat/abbaisegymappat".
A következő sorban megtörténik a szöveg (.txt vagy .dat kiterjesztésű) fájl létrehozása.
Az ezt követő sorokban a kapcsos zárójelben megkell adni, hogy mit írjon bele a létrehozott fájlba.
Esetünkben ez úgy néz ki, hogy a fájlba a szövegdoboz előtt kell egy előtag tehát amikor kiírja azt a szövegdobozt beszúrja elé
a "" közé helyezett részt, (ez elhagyható), ha üresen hagyjuk (tehát csak "") akkor nem fog semmit eléhelyezni.
sw1.WriteLine rész 2 részre bontható sw1 a StreamWriter száma a Write rész lehet több fajta is a WriteLine az sortöréssel írja ki,
a Write pedig csak egymásután pakolja a szövegdoboz tartalmakat.
A + utáni rész a szovegdoboz1.Text rész 2 részre bontható szovegdoboz1 a formban elhelyezett dobozunk neve.
A Text pedig azt mutatja meg neki milyen típus az amit kiír ugye esetünkben szöveg.
