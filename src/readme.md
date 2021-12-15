## Anforderungen Allgemein:
- Das ergebniss soll in Textueller Form Dargestelt werden in einer Sprache welche weitverbreitet ist. (Gewählt: English)
- Es müssen auch Komplexe Ergebnisse geliefert werden können
- a b und c müssen kommazahlen sein können
- Die Ergebnisse liefern 4 Nachkomma stellen
- j für imaginäre Zahlen verwenden
- es sollten die Länderspezifischen Komma Zeichen für GB und AT angezeigt werden können andere Länder sind nicht relevant.

#### Anforderungen Ergänzt 15.12.21 Real Root Only:
- Das ergebniss soll in Textueller Form Dargestelt werden in einer Sprache welche weitverbreitet ist. (Gewählt: English)
- a b und c müssen kommazahlen sein können
- es sollten die Länderspezifischen Komma Zeichen für GB und AT angezeigt werden können andere Länder sind nicht relevant.
- Für Imaginäre Lösungen sollte nur "Imaginary Solutions" zurück geliefert werden
- wenn a und (b oder c) == 0 dann sollte "a = 0" geliefert werden. 
- Rundungsfehler können vorerst ignoriert werden sollten aber im Code vermerkt werden

## Testfälle:
Die Testfälle wurden so gewählt das wir eine möglichst hohe Code Abdeckung erreicht haben und zumindest jeden Branch erreichen.
Die Funktionen System.Math.Sqrt, String.Format und  double.IsNaN werden als ausreichen getestet betrachtet da diese von sehr vielen Programmen benutzt werden.