// casting implicito
//se il tipo di destinazione è piu capiente delll'iniziale non c'è perdita di precisione, per es.
//int -> double
double d = 130.78;
int a = 5 + (int)d;
Console.WriteLine($"implicito = {a}");

// casting esplicito
//qui dichiaro, la variabile in cui voglio che venga convertita. Bisogna stare accorti solo per un 
//problema di overflow.
//Non è possibile convertire un intero in una stringa
double dd = 130.78;
int aa = 5 + (int)d;
Console.WriteLine($"esplicito = {aa}");
