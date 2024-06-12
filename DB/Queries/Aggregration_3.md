# Data aggregation

The following tables are given in a database:
1. kunde(<ins>id</ins>, name, vorname, **berater_id**)
2. produkt(<ins>id</ins>, name)
3. prod_kunde(<ins>id</ins>, **kunde_id**, **prod_id**)
4. berater(<ins>id</ins>, name, vorname)
5. zahlung(<ins>id</ins>, betrag, datum, **kunde_id**)

## Task: Express the following queries as SQL statements

a) Alle Kunden mit dem Namendes Beraters

``` SQL
SELECT k.name, k.vorname, b.name, b.vorname
FROM kunde k,
     berater b

WHERE k.berater_id = b.id
GROUP BY b.id;
```

b) Alle Zahlungen mit dem Namen des Kunden, sortiert nach Kunden und Datum

``` SQL
SELECT k.name, k.vorname, z.betrag, z.datum
FROM zahlung z,
     kunde k

WHERE z.kunde_id = k.id
GROUP BY k.id, k.datum;
```

c) Alle Kundennamen mit den Namen aller Produkte, die dieser Kunde einsetzt

``` SQL
SELECT k.name, k.vorname, p.name
FROM kunde k, 
     produkt p,
     produkt_kunde pk

WHERE k.id = pk.kunde_id AND 
      p.id = pk.produkt_id

GROUP BY k.id
```

d) Anzahl der Produkte, die jeder Kunde einsetzt (Attribute: Kundenname und Produktanzahl)

``` SQL
SELECT k.name, k.vorname, COUNT(p.id)
FROM kunde k, 
     produkt p,
     produkt_kunde pk

WHERE k.id = pk.kunde_id AND 
      p.id = pk.produkt_id

GROUP BY k.id
```

e) Summe und Durchschnitt der Zahlungen

``` SQL
SELECT SUM(betrag) as 'Gesamtbetrag', AVG(betrag) as 'Betragsdurchschnitt'
FROM zahlung
```

h) Summe der Einnahmen pro Berater

``` SQL 
SELECT SUM(z.betrag) as 'Betrag', b.name, b.vorname
FROM zahlung z,
     berater b,
     kunde k

WHERE z.kunde_id = k.id AND
      k.berater_id = b.id

GROUP BY b.id
```

i) Listen Sie die Produkte auf, die bei mindestens 5 Kunden des Beraters Gerd Schulze im Einsatz sind (Ausgabe: Produktname und Anzahl), absteigend sortiert nach der Anzahl

``` SQL 
SELECT p.name, COUNT(*) as Anzahl
FROM produkt p,
     prod_kunde pk,
     kunde k,
     berater b

WHERE p.id = pk.prod_id AND
      pk.kunde_id = k.id AND
      k.berater_id = b.id AND
      b.name = 'Schulze' AND b.vorname = 'Bernd'
HAVING Anzahl >= 5
ORDER BY DESC
```