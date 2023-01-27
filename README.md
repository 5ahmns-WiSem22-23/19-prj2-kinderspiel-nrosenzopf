# 19-prj2-kinderspiel-nrosenzopf



## Tempo kleine Fische!
Spielinhalt und Verlauf, siehe Spielanleitung

![08](https://user-images.githubusercontent.com/72389468/215183903-a48faa15-65b9-4dd6-8f4b-9bbf6c942f54.JPG)
![dsfdsf](https://user-images.githubusercontent.com/72389468/215183911-abd589ac-6a04-442a-8104-120f395c9bd0.JPG)

#### Spielverlauf kurzform:
1. Gehörst du zu den Fisch-Freunden oder zu den Fischer-Fans? Entscheide dich!
2. Es wird gewürfelt: Blau/Orange/Gelb/Rosa = Fisch schwimmt weiter, Rot/Grün = Boot rückt nach vorne
3a. Ein Fisch erreicht das Meer = frei und kann nicht mehr gefangen werden, Farbe des Fisches wird noch einmal gewürfelt = beliebigen anderen Fisch darf sich vorwärts bewegen
3b. Ein Fisch wird gefangen = Fisch aufs Boot
4. Ende des Spiels = mehr Fische im Meer = Fisch-Freunde gewinnen, mehr als 2 Fische gefangen = Fischer-Fans gewinnen

## Funktionen
### Gefordert
- Auswahl ob Fisch-Freunde oder Fischer-Fans mittels Button (je nach Auswahl Spielverlauf/Spielende unterschiedlich)
- Würfel mit 6 verschiedenen Farben in Random reinfolge nach würfeln
- Blau/Orange/Gelb/Rosa = Fisch rutscht (wenn Farbe gewürfelt) anhand von Vektor nach vorne
- Rot/Grün = Boot rutscht (wenn Farbe gewürfelt) anhand von Vektor nach vorne
- Boot holt Fisch ein = Fisch wird auf das Boot gelegt
- Mehr als 2 Fische im Boot -> Angler Gewinnen das Spiel
- Fisch im Goal = Kann nicht mehr gefangen werden
- Mehr als 2 Fische im Goal = Fische gewinnen
- Wenn Farbe vom Fisch gewürfelt, welcher auf dem Boot ist = Boot rückt nach vorne
- Wenn Fisch schon im Ziel, Farbe aber trotzdem gewürfelt = Buttons erscheinen und Fische, welche noch im Rennen sind, dürfen je nach Auswahl um eines nach Vorne rutschen

### Zusatz
- Kameraschwenk
- Fischanimation
- MainThemeSound "Fünf kleine Fische" https://www.youtube.com/watch?v=6NAS7JxBu4E
- SpalshSound wenn Objekt voran fährt
- StartScreen mit Auswahl ob Team Angler oder Fische
- 4 verschiedene Endscreens (je nach Auswahl Team und Spielverlauf)
- Sonnenbrille und Bubbles (verschwinden nach Waiter von 2 Sekunden) werden im Goal aktivert
- Fische werden wirklich aufs Bod gelegt

## Audiodesign
- MainThemeSound "Fünf kleine Fische" https://www.youtube.com/watch?v=6NAS7JxBu4E
- SpalshSound wenn Boot voran fährt oder Fische weiter Schwimmen

## Grafikdesign und Assets
#### Eigene Grafiken
Cliparts in Illustrator umgewandelt in Vektorgrafiken und angepasst.

#### 3D Assets
Bubbles: https://assetstore.unity.com/packages/vfx/particles/environment/jiggly-bubble-free-61236

#### 2-jährige Kinder können noch nicht lesen. Daher symbolisches Design.
![Zeichenfläche 1](https://user-images.githubusercontent.com/72389468/215192047-933e2049-b042-4236-a293-94059bb6ad8d.png)



#### Entwicklungsplattformen
- Windows 10
- Unity 2020.3.18f1
- Visual Studio 2019
