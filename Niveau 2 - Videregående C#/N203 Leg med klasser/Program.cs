
using Dumpify;
using MCronberg.Kursus;

Spillekort s = new Spillekort();
s.Dump();
s.Vend();
s.Dump();
s.Vend();
s.Dump();

Spillekort s2 = new Spillekort(SpillekortKulør.Hjerter, SpillekortVærdi.Es);
s2.Dump();

SpillekortBunke b = new();
b.TilføjKort(s);
b.TilføjKort(s2);
b.Dump();
b.VendAlleKort();
b.Dump();

// Prøv også dette

//SpillekortBunke b2 = SpillekortBunke.OpretBunke();
//b2.Dump();