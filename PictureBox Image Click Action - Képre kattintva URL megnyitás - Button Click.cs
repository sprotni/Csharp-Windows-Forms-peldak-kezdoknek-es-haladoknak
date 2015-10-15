//////////
private void paypaldonate_buttonclick(object sender, EventArgs e)
        {
                System.Diagnostics.Process.Start("https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=C4CSVJBD7EHRS");
        }
        
//////////

Szükséges lehet:

using System.Diagnostics;

//////////
Leírás és magyarázat:

Ha ezt hozzárendeljük egy gomb click action-jéhez akkor az fog történni, hogy a WindowsForm ablakunkban elhelyezett gomb
a megnyomáskor egy url-t nyit meg nekünk az alapértelmezett böngészőn keresztül ez felhasználható PictureBox click action-jéhez is
Nem csak gomb click action-el működik!
