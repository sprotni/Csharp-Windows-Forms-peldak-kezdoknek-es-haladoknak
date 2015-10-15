///////////
using (var client = new WebClient())
            {
                client.DownloadFile("http://www.valami.hu/akarmi.zip", "Atneveztem.zip");
            }
//////////
Szükséges lehet:

using System.Net;
//////////
Leírás és magyarázat:

Ha ezt hozzárendeljük egy gomb click actionjéhez akkor az fog történni, hogy a WindowsForm ablakunkban elhelyezett gomb
a megnyomáskor letölti magamellé az adott linken található fájlt. A zárójelben található első rész a vesszőig a fájlhoz vezető út.
A második része a letöltött fájl neve lesz , itt figyelj oda, hogy ez nem feltétlen az ami a linken található. 
Ez a végtermék neve lesz. Tehát esetünkben az akarmi.zip letöltésre kerül és az lesz a neve, hogy Atneveztem.zip . 
Ez a módszer mindig felülírja és lecseréli a fájlt így további kivételeket nem kell megadni az automatikus működéshez.
