# Opgave

I denne opgave får du en række karakterer, de syv små dværge, som du skal få til at interagere med hinanden. 
Disse karakterer skal du få til at fortælle en ny historie, hver gang du kører dit program.

Du skal inkludere minimum 4 karakterer fra følgende liste:
- Brille (Doc): har briller, er deres leder, har det med at snakke bagvendt.
- Gnavpot (Grumpy): er hans navn, men han har dog et godt hjerte alligevel.
- Lystig (Happy): kraftig, glad og munter.
- Prosit (Sneezy): har allergi og nyser meget kraftigt.
- Flovmand (Bashful): rødmer let og gemmer sig i skægget, når det sker.
- Søvnig (Sleepy): hans navn passer til hans energiniveau, gaber højt.
- Dumpe (Dopey): kan ikke tale, kommer altid løbende langt efter de andre og er meget klodset.

Hver gang du kører dit program, skal det udvælge 2 karakterer tilfældigt. Du skal bestemme hvordan hver karakter, skal reagere på en anden karakter og dermed lave en lille historie i en "kædereaktion".

Fx kan du vælge at hvis A er sammen med B, så vil A begynde at skrige og C vil komme. Men hvis A er sammen med D, så vil A måske falde i søvn i stedet.

Hver gang der bliver tilføjet en ny karakter, bliver de tilføjet i slutningen af kædereaktionen og hver karakter kan kun være til stede &I gang i kædereaktionen. 

Det vil sige, at du kan have en liste af karakterer, der hedder:
- A, B, C, D Men ikke A, B, A

Reaktionerne kører kronologisk fra starten til slutningen af din kædereaktion, og hver karakter reagerer på den næste karakter i listen. 

Så hvis din kædereaktion er:
- A, B, C D,

Så vil A reagere på B, efterfølgende vil B reagere på C og C vil reagere på D. Hver karakter skal følgende reaktioner:
- en reaktion hvis de er den sidste på listen.
- en reaktion der tilkalder en anden karakter.
- en reaktion der får en karakter til at forsvinde, hvilket fjerne den fra listen.

Du bestemmer helt selv hvordan du vil fortælle din historie: du kan vise den frem ved brug af GUI, tekst, tegninger, emojier eller tekst i terminalen. Det er helt op til dig, vi skal bare kunne se, hvad der sker i historien.

# Resultatvideo

Du skal optage dit endelige program, hvor du kører det mindst tre gange med tre forskellige versioner af historien om de syv små dværge.

# Afleveringen

Upload din kode samt din resultatvideo til dit GitHub repository inden søndag d. 10. april kl. 12.
OBS. Hvis du ikke har linket til dit repository under tilmelding til arrangementet, så skal du sende det til tem©prosa.dk inden afleveringen.
Koden skal være under en fri licens hvis du vil deltage i konkurrencen (Du kan vælge GPLv3 eller en af de andre på listen).

# Løsningseksempel

Dette er et eksempel på hvordan en løsning kan se ud.
- Du starter programmet og de to tilfældige startkarakterer er Brille og Gnavpot.
- Fordi Brille er sammen med Gnavpot, så begynder de at skændes så højt, at de vækker Søvnig.
- Søvnig irriterer Gnavpot så meget, at han går væk.
- Søvnig falder i søvn igen.
