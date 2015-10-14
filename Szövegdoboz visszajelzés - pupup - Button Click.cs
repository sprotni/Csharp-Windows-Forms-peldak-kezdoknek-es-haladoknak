///////////
private void megnyomtamegygombot_buttonclick(object sender, EventArgs e)
        {
MessageBox.Show("Sikeresen megnyomtad a gombot!",
                "Nagyon ügyes vagy!", //Cím//
                    MessageBoxButtons.OK, //A gomb feladata//
                    MessageBoxIcon.Information,//A benne megjelenő ikon típusa//
                    MessageBoxDefaultButton.Button1);//A szövegdobozban megjelenő gomb száma//
        }

//////////
Szükséges lehet:

using System.Windows.Forms;

//////////
Leírás és magyarázat:

Ha ezt hozzárendeljük egy gomb click action-jéhez akkor az fog történni, hogy a WindowsForm ablakunkban elhelyezett gomb
a megnyomáskor egy abalakot dob fel ami használható valamilyen tevékenység sikeres vagy sikertelen visszajelzésére is.
Nem csak gomb action-el működik!
