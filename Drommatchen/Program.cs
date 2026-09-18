// TODO: Skapa minst 2 spelare
Spelare spelare1 = new Spelare("Lionel Messi", 10, "HögerForvard", 93);
Spelare spelare2 = new Spelare("Luis Suarez", 9, "Anfallare", 89); 
Spelare spelare3 = new Spelare("Neymar Jr", 11, "Vänsterforvard", 86);

// TODO: Skapa 1 match
// Match match = new Match("Hemmalag", "Bortalag", "Datum");
Match match = new Match("FC Barcelona", "Real Madrid", "2014-10-15");
// TODO: Anropa match.Presentera()
match.Presentera();
// TODO: Anropa match.AnnounceraMålskytt() med båda spelarna
match.AnnounceraMålskytt(spelare1);
match.AnnounceraMålskytt(spelare2);
match.AnnounceraMålskytt(spelare3);

